using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Text;

namespace CommonLibrary
{
	public static class HttpUtil
	{
		public static StreamContent CreateStreamContent(string text)
		{
			MemoryStream memStream = new MemoryStream();
			using (GZipStream compressStream = new GZipStream(memStream, CompressionMode.Compress, true))
			{
				byte[] data = Encoding.UTF8.GetBytes(text);
				compressStream.Write(data, 0, data.Length);
			}
			memStream.Position = 0;
			StreamContent streamContent = new StreamContent(memStream);
			return streamContent;
		}
		public static Stream CreateStream(string text)
		{
			MemoryStream memStream = new MemoryStream();
			using (GZipStream compressStream = new GZipStream(memStream, CompressionMode.Compress, true))
			{
				byte[] data = Encoding.UTF8.GetBytes(text);
				compressStream.Write(data, 0, data.Length);
			}
			memStream.Position = 0;
			return memStream;
		}
		public static string ExtractText(Stream contentStream)
		{
			MemoryStream memStream = new MemoryStream();
			using (GZipStream decompressStream = new GZipStream(contentStream, CompressionMode.Decompress))
			{
				decompressStream.CopyTo(memStream);
			}
			byte[] data = memStream.ToArray();
			string text = Encoding.UTF8.GetString(data);
			return text;
		}
		public static HttpResponseMessage CreateResponse(string rsp)
		{
			StreamContent streamContent = CreateStreamContent(rsp);
			HttpResponseMessage rspMsg = new HttpResponseMessage();
			rspMsg.Content = streamContent;
			rspMsg.StatusCode = System.Net.HttpStatusCode.OK;
			return rspMsg;
		}
		public static string ExtractRequest(HttpRequestMessage reqMsg)
		{
			Stream compressedReqStream = (Stream)reqMsg.Content.ReadAsStreamAsync().Result;
			string req = ExtractText(compressedReqStream);
			return req;
		}
		public static string ExtractResponse(HttpResponseMessage rspMsg)
		{
			Stream compressedRspStream = rspMsg.Content.ReadAsStreamAsync().Result;
			string rsp = ExtractText(compressedRspStream);
			return rsp;
		}
		/*
		public static void ThrowHttpResponseException(string msg)
		{
			HttpResponseMessage rsp = new HttpResponseMessage(HttpStatusCode.BadRequest)
			{
				Content = new StringContent(msg),
				ReasonPhrase = msg
			};
			throw new HttpResponseException(rsp);
		}
		*/
	}
}
