using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace TSDataModel
{
	public partial class tBillableReason : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_BillableReasonID;
		public int BillableReasonID { get=>m_BillableReasonID; set { m_BillableReasonID = value; NotifyPropertyChanged(); }}
		private string m_BillableReason = "";
		public string BillableReason { get=>m_BillableReason; set { m_BillableReason = value; NotifyPropertyChanged(); }}
		public tBillableReason()
		{
		}
	}
	public partial class tBillingBatch : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_BillingBatchID;
		public int BillingBatchID { get=>m_BillingBatchID; set { m_BillingBatchID = value; NotifyPropertyChanged(); }}
		private int m_BillingGroupID;
		public int BillingGroupID { get=>m_BillingGroupID; set { m_BillingGroupID = value; NotifyPropertyChanged(); }}
		private string m_BatchDesc = "";
		public string BatchDesc { get=>m_BatchDesc; set { m_BatchDesc = value; NotifyPropertyChanged(); }}
		private DateTime? m_CutOffDate;
		public DateTime? CutOffDate { get=>m_CutOffDate; set { m_CutOffDate = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTime;
		public DateTime? CreatedTime { get=>m_CreatedTime; set { m_CreatedTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_ClosedTime;
		public DateTime? ClosedTime { get=>m_ClosedTime; set { m_ClosedTime = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		private int m_NumberOfWorkOrders;
		public int NumberOfWorkOrders { get=>m_NumberOfWorkOrders; set { m_NumberOfWorkOrders = value; NotifyPropertyChanged(); }}
		private decimal m_BillingTotal;
		public decimal BillingTotal { get=>m_BillingTotal; set { m_BillingTotal = value; NotifyPropertyChanged(); }}
		public tBillingBatch()
		{
		}
	}
	public partial class tBillingGroup : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_BillingGroupID;
		public int BillingGroupID { get=>m_BillingGroupID; set { m_BillingGroupID = value; NotifyPropertyChanged(); }}
		private string m_BillingGroupDesc = "";
		public string BillingGroupDesc { get=>m_BillingGroupDesc; set { m_BillingGroupDesc = value; NotifyPropertyChanged(); }}
		private string m_GroupType = "";
		public string GroupType { get=>m_GroupType; set { m_GroupType = value; NotifyPropertyChanged(); }}
		public tBillingGroup()
		{
		}
	}
	public partial class tBillingGroupUser : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_BillingGroupID;
		public int BillingGroupID { get=>m_BillingGroupID; set { m_BillingGroupID = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		public tBillingGroupUser()
		{
		}
	}
	public partial class tBranch : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_BranchID;
		public int BranchID { get=>m_BranchID; set { m_BranchID = value; NotifyPropertyChanged(); }}
		private string m_BranchName = "";
		public string BranchName { get=>m_BranchName; set { m_BranchName = value; NotifyPropertyChanged(); }}
		private string m_Address = "";
		public string Address { get=>m_Address; set { m_Address = value; NotifyPropertyChanged(); }}
		private string m_City = "";
		public string City { get=>m_City; set { m_City = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private string m_PostalCode = "";
		public string PostalCode { get=>m_PostalCode; set { m_PostalCode = value; NotifyPropertyChanged(); }}
		private string m_Country = "";
		public string Country { get=>m_Country; set { m_Country = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private string m_TimeZone = "";
		public string TimeZone { get=>m_TimeZone; set { m_TimeZone = value; NotifyPropertyChanged(); }}
		public tBranch()
		{
		}
	}
	public partial class tCallBlockAccount : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_CallBlockAccountID;
		public int CallBlockAccountID { get=>m_CallBlockAccountID; set { m_CallBlockAccountID = value; NotifyPropertyChanged(); }}
		private string m_AccountName = "";
		public string AccountName { get=>m_AccountName; set { m_AccountName = value; NotifyPropertyChanged(); }}
		private string m_Contact = "";
		public string Contact { get=>m_Contact; set { m_Contact = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTime;
		public DateTime? CreatedTime { get=>m_CreatedTime; set { m_CreatedTime = value; NotifyPropertyChanged(); }}
		private int m_CreatedByUserID;
		public int CreatedByUserID { get=>m_CreatedByUserID; set { m_CreatedByUserID = value; NotifyPropertyChanged(); }}
		private decimal m_Balance;
		public decimal Balance { get=>m_Balance; set { m_Balance = value; NotifyPropertyChanged(); }}
		public tCallBlockAccount()
		{
		}
	}
	public partial class tCallBlockTxn : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_CallBlockTxnID;
		public int CallBlockTxnID { get=>m_CallBlockTxnID; set { m_CallBlockTxnID = value; NotifyPropertyChanged(); }}
		private int m_AccountID;
		public int AccountID { get=>m_AccountID; set { m_AccountID = value; NotifyPropertyChanged(); }}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private string m_TxnType = "";
		public string TxnType { get=>m_TxnType; set { m_TxnType = value; NotifyPropertyChanged(); }}
		private int m_Qty;
		public int Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private DateTime? m_TxnTime;
		public DateTime? TxnTime { get=>m_TxnTime; set { m_TxnTime = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private string m_Note = "";
		public string Note { get=>m_Note; set { m_Note = value; NotifyPropertyChanged(); }}
		public tCallBlockTxn()
		{
		}
	}
	public partial class tCarrier : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_CarrierID;
		public int CarrierID { get=>m_CarrierID; set { m_CarrierID = value; NotifyPropertyChanged(); }}
		private string m_CarrierName = "";
		public string CarrierName { get=>m_CarrierName; set { m_CarrierName = value; NotifyPropertyChanged(); }}
		public tCarrier()
		{
		}
	}
	public partial class tCategory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_CategoryID;
		public int CategoryID { get=>m_CategoryID; set { m_CategoryID = value; NotifyPropertyChanged(); }}
		private string m_CategoryDesc = "";
		public string CategoryDesc { get=>m_CategoryDesc; set { m_CategoryDesc = value; NotifyPropertyChanged(); }}
		public tCategory()
		{
		}
	}
	public partial class tCompany : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private string m_CompanyKey = "";
		public string CompanyKey { get=>m_CompanyKey; set { m_CompanyKey = value; NotifyPropertyChanged(); }}
		private string m_CompanyName = "";
		public string CompanyName { get=>m_CompanyName; set { m_CompanyName = value; NotifyPropertyChanged(); }}
		private string m_Address = "";
		public string Address { get=>m_Address; set { m_Address = value; NotifyPropertyChanged(); }}
		private string m_City = "";
		public string City { get=>m_City; set { m_City = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private string m_PostalCode = "";
		public string PostalCode { get=>m_PostalCode; set { m_PostalCode = value; NotifyPropertyChanged(); }}
		private string m_Country = "";
		public string Country { get=>m_Country; set { m_Country = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private string m_Website = "";
		public string Website { get=>m_Website; set { m_Website = value; NotifyPropertyChanged(); }}
		private string m_TimeZone = "";
		public string TimeZone { get=>m_TimeZone; set { m_TimeZone = value; NotifyPropertyChanged(); }}
		public tCompany()
		{
		}
	}
	public partial class tContract : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ContractID;
		public int ContractID { get=>m_ContractID; set { m_ContractID = value; NotifyPropertyChanged(); }}
		private int m_ContractTypeID;
		public int ContractTypeID { get=>m_ContractTypeID; set { m_ContractTypeID = value; NotifyPropertyChanged(); }}
		private int m_RenewedFormID;
		public int RenewedFormID { get=>m_RenewedFormID; set { m_RenewedFormID = value; NotifyPropertyChanged(); }}
		private int m_CustomerID;
		public int CustomerID { get=>m_CustomerID; set { m_CustomerID = value; NotifyPropertyChanged(); }}
		private int m_TaxRegionID;
		public int TaxRegionID { get=>m_TaxRegionID; set { m_TaxRegionID = value; NotifyPropertyChanged(); }}
		private decimal m_Subtotal;
		public decimal Subtotal { get=>m_Subtotal; set { m_Subtotal = value; NotifyPropertyChanged(); }}
		private decimal m_TaxTotal;
		public decimal TaxTotal { get=>m_TaxTotal; set { m_TaxTotal = value; NotifyPropertyChanged(); }}
		private string m_Total = "";
		public string Total { get=>m_Total; set { m_Total = value; NotifyPropertyChanged(); }}
		private string m_BillingScheduleID = "";
		public string BillingScheduleID { get=>m_BillingScheduleID; set { m_BillingScheduleID = value; NotifyPropertyChanged(); }}
		private string m_PaymentMethod = "";
		public string PaymentMethod { get=>m_PaymentMethod; set { m_PaymentMethod = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedDate;
		public DateTime? CreatedDate { get=>m_CreatedDate; set { m_CreatedDate = value; NotifyPropertyChanged(); }}
		private int m_CreatedByUserID;
		public int CreatedByUserID { get=>m_CreatedByUserID; set { m_CreatedByUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_ContractStartDate;
		public DateTime? ContractStartDate { get=>m_ContractStartDate; set { m_ContractStartDate = value; NotifyPropertyChanged(); }}
		private DateTime? m_ContractEndDate;
		public DateTime? ContractEndDate { get=>m_ContractEndDate; set { m_ContractEndDate = value; NotifyPropertyChanged(); }}
		private string m_Term = "";
		public string Term { get=>m_Term; set { m_Term = value; NotifyPropertyChanged(); }}
		private string m_Notes = "";
		public string Notes { get=>m_Notes; set { m_Notes = value; NotifyPropertyChanged(); }}
		public tContract()
		{
		}
	}
	public partial class tContractDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ContractID;
		public int ContractID { get=>m_ContractID; set { m_ContractID = value; NotifyPropertyChanged(); }}
		private int m_LineNumber;
		public int LineNumber { get=>m_LineNumber; set { m_LineNumber = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private decimal m_UnitPrice;
		public decimal UnitPrice { get=>m_UnitPrice; set { m_UnitPrice = value; NotifyPropertyChanged(); }}
		private decimal m_Qty;
		public decimal Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private decimal m_Amount;
		public decimal Amount { get=>m_Amount; set { m_Amount = value; NotifyPropertyChanged(); }}
		private int m_CoveredItemID;
		public int CoveredItemID { get=>m_CoveredItemID; set { m_CoveredItemID = value; NotifyPropertyChanged(); }}
		private int m_CoveredQty;
		public int CoveredQty { get=>m_CoveredQty; set { m_CoveredQty = value; NotifyPropertyChanged(); }}
		private string m_SerialNumbers = "";
		public string SerialNumbers { get=>m_SerialNumbers; set { m_SerialNumbers = value; NotifyPropertyChanged(); }}
		private DateTime? m_StartDate;
		public DateTime? StartDate { get=>m_StartDate; set { m_StartDate = value; NotifyPropertyChanged(); }}
		private DateTime? m_EndDate;
		public DateTime? EndDate { get=>m_EndDate; set { m_EndDate = value; NotifyPropertyChanged(); }}
		private int m_ServiceHourID;
		public int ServiceHourID { get=>m_ServiceHourID; set { m_ServiceHourID = value; NotifyPropertyChanged(); }}
		private int m_BillingRateID;
		public int BillingRateID { get=>m_BillingRateID; set { m_BillingRateID = value; NotifyPropertyChanged(); }}
		public tContractDetail()
		{
		}
	}
	public partial class tContractTax : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ContractID;
		public int ContractID { get=>m_ContractID; set { m_ContractID = value; NotifyPropertyChanged(); }}
		private int m_TaxID;
		public int TaxID { get=>m_TaxID; set { m_TaxID = value; NotifyPropertyChanged(); }}
		private decimal m_Tax;
		public decimal Tax { get=>m_Tax; set { m_Tax = value; NotifyPropertyChanged(); }}
		public tContractTax()
		{
		}
	}
	public partial class tContractType : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ContractTypeID;
		public int ContractTypeID { get=>m_ContractTypeID; set { m_ContractTypeID = value; NotifyPropertyChanged(); }}
		private string m_ContractTypeDesc = "";
		public string ContractTypeDesc { get=>m_ContractTypeDesc; set { m_ContractTypeDesc = value; NotifyPropertyChanged(); }}
		public tContractType()
		{
		}
	}
	public partial class tCustomer : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_CustomerID;
		public int CustomerID { get=>m_CustomerID; set { m_CustomerID = value; NotifyPropertyChanged(); }}
		private string m_CustomerName = "";
		public string CustomerName { get=>m_CustomerName; set { m_CustomerName = value; NotifyPropertyChanged(); }}
		private string m_Address = "";
		public string Address { get=>m_Address; set { m_Address = value; NotifyPropertyChanged(); }}
		private string m_City = "";
		public string City { get=>m_City; set { m_City = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private string m_PostalCode = "";
		public string PostalCode { get=>m_PostalCode; set { m_PostalCode = value; NotifyPropertyChanged(); }}
		private string m_Country = "";
		public string Country { get=>m_Country; set { m_Country = value; NotifyPropertyChanged(); }}
		private string m_Contact = "";
		public string Contact { get=>m_Contact; set { m_Contact = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_MobilePhone = "";
		public string MobilePhone { get=>m_MobilePhone; set { m_MobilePhone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private int m_SalesRepUserID;
		public int SalesRepUserID { get=>m_SalesRepUserID; set { m_SalesRepUserID = value; NotifyPropertyChanged(); }}
		private int m_BranchID;
		public int BranchID { get=>m_BranchID; set { m_BranchID = value; NotifyPropertyChanged(); }}
		private int m_GroupID;
		public int GroupID { get=>m_GroupID; set { m_GroupID = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		private string m_TimeZone = "";
		public string TimeZone { get=>m_TimeZone; set { m_TimeZone = value; NotifyPropertyChanged(); }}
		private decimal m_CreditLimit;
		public decimal CreditLimit { get=>m_CreditLimit; set { m_CreditLimit = value; NotifyPropertyChanged(); }}
		private int m_Term;
		public int Term { get=>m_Term; set { m_Term = value; NotifyPropertyChanged(); }}
		private int m_DiscountDays;
		public int DiscountDays { get=>m_DiscountDays; set { m_DiscountDays = value; NotifyPropertyChanged(); }}
		private double m_DiscountRate;
		public double DiscountRate { get=>m_DiscountRate; set { m_DiscountRate = value; NotifyPropertyChanged(); }}
		private int m_CallBlockAccountID;
		public int CallBlockAccountID { get=>m_CallBlockAccountID; set { m_CallBlockAccountID = value; NotifyPropertyChanged(); }}
		private int m_BillingGroupID;
		public int BillingGroupID { get=>m_BillingGroupID; set { m_BillingGroupID = value; NotifyPropertyChanged(); }}
		private int m_SlaID;
		public int SlaID { get=>m_SlaID; set { m_SlaID = value; NotifyPropertyChanged(); }}
		private int m_TaxRegionID;
		public int TaxRegionID { get=>m_TaxRegionID; set { m_TaxRegionID = value; NotifyPropertyChanged(); }}
		private int m_BillingRateID;
		public int BillingRateID { get=>m_BillingRateID; set { m_BillingRateID = value; NotifyPropertyChanged(); }}
		private string m_Notes = "";
		public string Notes { get=>m_Notes; set { m_Notes = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreationDate;
		public DateTime? CreationDate { get=>m_CreationDate; set { m_CreationDate = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastUpdate;
		public DateTime? LastUpdate { get=>m_LastUpdate; set { m_LastUpdate = value; NotifyPropertyChanged(); }}
		private int m_LastUpdateID;
		public int LastUpdateID { get=>m_LastUpdateID; set { m_LastUpdateID = value; NotifyPropertyChanged(); }}
		public tCustomer()
		{
		}
	}
	public partial class tCustomerGroup : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_GroupID;
		public int GroupID { get=>m_GroupID; set { m_GroupID = value; NotifyPropertyChanged(); }}
		private string m_GroupName = "";
		public string GroupName { get=>m_GroupName; set { m_GroupName = value; NotifyPropertyChanged(); }}
		public tCustomerGroup()
		{
		}
	}
	public partial class tCustomerService : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_CustomerID;
		public int CustomerID { get=>m_CustomerID; set { m_CustomerID = value; NotifyPropertyChanged(); }}
		private int m_ServiceItemID;
		public int ServiceItemID { get=>m_ServiceItemID; set { m_ServiceItemID = value; NotifyPropertyChanged(); }}
		public tCustomerService()
		{
		}
	}
	public partial class tCustomerSite : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_SiteID;
		public int SiteID { get=>m_SiteID; set { m_SiteID = value; NotifyPropertyChanged(); }}
		private int m_CustomerID;
		public int CustomerID { get=>m_CustomerID; set { m_CustomerID = value; NotifyPropertyChanged(); }}
		private string m_SiteName = "";
		public string SiteName { get=>m_SiteName; set { m_SiteName = value; NotifyPropertyChanged(); }}
		private string m_Address = "";
		public string Address { get=>m_Address; set { m_Address = value; NotifyPropertyChanged(); }}
		private string m_City = "";
		public string City { get=>m_City; set { m_City = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private string m_PostalCode = "";
		public string PostalCode { get=>m_PostalCode; set { m_PostalCode = value; NotifyPropertyChanged(); }}
		private string m_Country = "";
		public string Country { get=>m_Country; set { m_Country = value; NotifyPropertyChanged(); }}
		private string m_Contact = "";
		public string Contact { get=>m_Contact; set { m_Contact = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_MobilePhone = "";
		public string MobilePhone { get=>m_MobilePhone; set { m_MobilePhone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private string m_TimeZone = "";
		public string TimeZone { get=>m_TimeZone; set { m_TimeZone = value; NotifyPropertyChanged(); }}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		private int m_SlaZoneID;
		public int SlaZoneID { get=>m_SlaZoneID; set { m_SlaZoneID = value; NotifyPropertyChanged(); }}
		public tCustomerSite()
		{
		}
	}
	public partial class tDefectiveRecord : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_DefectiveRecordID;
		public int DefectiveRecordID { get=>m_DefectiveRecordID; set { m_DefectiveRecordID = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private int m_SerialNumber;
		public int SerialNumber { get=>m_SerialNumber; set { m_SerialNumber = value; NotifyPropertyChanged(); }}
		private string m_Defect = "";
		public string Defect { get=>m_Defect; set { m_Defect = value; NotifyPropertyChanged(); }}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private DateTime? m_EnterTime;
		public DateTime? EnterTime { get=>m_EnterTime; set { m_EnterTime = value; NotifyPropertyChanged(); }}
		private int m_ReturnUserID;
		public int ReturnUserID { get=>m_ReturnUserID; set { m_ReturnUserID = value; NotifyPropertyChanged(); }}
		private int m_ReturnFromWarehosueID;
		public int ReturnFromWarehosueID { get=>m_ReturnFromWarehosueID; set { m_ReturnFromWarehosueID = value; NotifyPropertyChanged(); }}
		private int m_ReturnShipmentID;
		public int ReturnShipmentID { get=>m_ReturnShipmentID; set { m_ReturnShipmentID = value; NotifyPropertyChanged(); }}
		private int m_ReparingWarehouseID;
		public int ReparingWarehouseID { get=>m_ReparingWarehouseID; set { m_ReparingWarehouseID = value; NotifyPropertyChanged(); }}
		private int m_RepairTime;
		public int RepairTime { get=>m_RepairTime; set { m_RepairTime = value; NotifyPropertyChanged(); }}
		private int m_RepairUserID;
		public int RepairUserID { get=>m_RepairUserID; set { m_RepairUserID = value; NotifyPropertyChanged(); }}
		private string m_RepairNotes = "";
		public string RepairNotes { get=>m_RepairNotes; set { m_RepairNotes = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		public tDefectiveRecord()
		{
		}
	}
	public partial class tID : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private string m_IDName = "";
		public string IDName { get=>m_IDName; set { m_IDName = value; NotifyPropertyChanged(); }}
		private int m_CurrentID;
		public int CurrentID { get=>m_CurrentID; set { m_CurrentID = value; NotifyPropertyChanged(); }}
		public tID()
		{
		}
	}
	public partial class tInventory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WarehouseID;
		public int WarehouseID { get=>m_WarehouseID; set { m_WarehouseID = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private int m_Qty;
		public int Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private decimal m_TotalCost;
		public decimal TotalCost { get=>m_TotalCost; set { m_TotalCost = value; NotifyPropertyChanged(); }}
		private decimal m_AveCost;
		public decimal AveCost { get=>m_AveCost; set { m_AveCost = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastUpdate;
		public DateTime? LastUpdate { get=>m_LastUpdate; set { m_LastUpdate = value; NotifyPropertyChanged(); }}
		public tInventory()
		{
		}
	}
	public partial class tInventoryDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WarehouseID;
		public int WarehouseID { get=>m_WarehouseID; set { m_WarehouseID = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private string m_SerialNumber = "";
		public string SerialNumber { get=>m_SerialNumber; set { m_SerialNumber = value; NotifyPropertyChanged(); }}
		public tInventoryDetail()
		{
		}
	}
	public partial class tInventoryTxn : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_InventoryTxnID;
		public int InventoryTxnID { get=>m_InventoryTxnID; set { m_InventoryTxnID = value; NotifyPropertyChanged(); }}
		private int m_WarehouseID;
		public int WarehouseID { get=>m_WarehouseID; set { m_WarehouseID = value; NotifyPropertyChanged(); }}
		private DateTime? m_TxnTime;
		public DateTime? TxnTime { get=>m_TxnTime; set { m_TxnTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_TxnTimeUtc;
		public DateTime? TxnTimeUtc { get=>m_TxnTimeUtc; set { m_TxnTimeUtc = value; NotifyPropertyChanged(); }}
		private string m_TxnType = "";
		public string TxnType { get=>m_TxnType; set { m_TxnType = value; NotifyPropertyChanged(); }}
		private bool m_IsReversal;
		public bool IsReversal { get=>m_IsReversal; set { m_IsReversal = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private string m_SerialNumber = "";
		public string SerialNumber { get=>m_SerialNumber; set { m_SerialNumber = value; NotifyPropertyChanged(); }}
		private int m_Qty;
		public int Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private decimal m_Cost;
		public decimal Cost { get=>m_Cost; set { m_Cost = value; NotifyPropertyChanged(); }}
		private int m_EndQty;
		public int EndQty { get=>m_EndQty; set { m_EndQty = value; NotifyPropertyChanged(); }}
		private decimal m_EndCost;
		public decimal EndCost { get=>m_EndCost; set { m_EndCost = value; NotifyPropertyChanged(); }}
		private int m_ReferenceID;
		public int ReferenceID { get=>m_ReferenceID; set { m_ReferenceID = value; NotifyPropertyChanged(); }}
		private string m_Notes = "";
		public string Notes { get=>m_Notes; set { m_Notes = value; NotifyPropertyChanged(); }}
		public tInventoryTxn()
		{
		}
	}
	public partial class tItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private int m_CategoryID;
		public int CategoryID { get=>m_CategoryID; set { m_CategoryID = value; NotifyPropertyChanged(); }}
		private string m_ItemDesc = "";
		public string ItemDesc { get=>m_ItemDesc; set { m_ItemDesc = value; NotifyPropertyChanged(); }}
		private string m_ItemNumber = "";
		public string ItemNumber { get=>m_ItemNumber; set { m_ItemNumber = value; NotifyPropertyChanged(); }}
		private string m_Barcode = "";
		public string Barcode { get=>m_Barcode; set { m_Barcode = value; NotifyPropertyChanged(); }}
		private string m_ItemType = "";
		public string ItemType { get=>m_ItemType; set { m_ItemType = value; NotifyPropertyChanged(); }}
		private string m_ItemStatus = "";
		public string ItemStatus { get=>m_ItemStatus; set { m_ItemStatus = value; NotifyPropertyChanged(); }}
		private string m_Uom = "";
		public string Uom { get=>m_Uom; set { m_Uom = value; NotifyPropertyChanged(); }}
		private int m_TaxCodeID;
		public int TaxCodeID { get=>m_TaxCodeID; set { m_TaxCodeID = value; NotifyPropertyChanged(); }}
		private decimal m_Price;
		public decimal Price { get=>m_Price; set { m_Price = value; NotifyPropertyChanged(); }}
		private decimal m_UnitCost;
		public decimal UnitCost { get=>m_UnitCost; set { m_UnitCost = value; NotifyPropertyChanged(); }}
		private decimal m_PriceUsd;
		public decimal PriceUsd { get=>m_PriceUsd; set { m_PriceUsd = value; NotifyPropertyChanged(); }}
		private decimal m_UnitCostUsd;
		public decimal UnitCostUsd { get=>m_UnitCostUsd; set { m_UnitCostUsd = value; NotifyPropertyChanged(); }}
		private bool m_TrackSerialNo;
		public bool TrackSerialNo { get=>m_TrackSerialNo; set { m_TrackSerialNo = value; NotifyPropertyChanged(); }}
		private bool m_TrackInventory;
		public bool TrackInventory { get=>m_TrackInventory; set { m_TrackInventory = value; NotifyPropertyChanged(); }}
		private bool m_Returnable;
		public bool Returnable { get=>m_Returnable; set { m_Returnable = value; NotifyPropertyChanged(); }}
		private int m_BillingRateID;
		public int BillingRateID { get=>m_BillingRateID; set { m_BillingRateID = value; NotifyPropertyChanged(); }}
		private string m_Manufacture = "";
		public string Manufacture { get=>m_Manufacture; set { m_Manufacture = value; NotifyPropertyChanged(); }}
		private int m_PrimaryVendorID;
		public int PrimaryVendorID { get=>m_PrimaryVendorID; set { m_PrimaryVendorID = value; NotifyPropertyChanged(); }}
		private double m_MinStockLevel;
		public double MinStockLevel { get=>m_MinStockLevel; set { m_MinStockLevel = value; NotifyPropertyChanged(); }}
		private double m_MaxStockLevel;
		public double MaxStockLevel { get=>m_MaxStockLevel; set { m_MaxStockLevel = value; NotifyPropertyChanged(); }}
		private string m_Location = "";
		public string Location { get=>m_Location; set { m_Location = value; NotifyPropertyChanged(); }}
		private int m_ProblemGroupID;
		public int ProblemGroupID { get=>m_ProblemGroupID; set { m_ProblemGroupID = value; NotifyPropertyChanged(); }}
		private int m_SolutionGroupID;
		public int SolutionGroupID { get=>m_SolutionGroupID; set { m_SolutionGroupID = value; NotifyPropertyChanged(); }}
		private string m_Notes = "";
		public string Notes { get=>m_Notes; set { m_Notes = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTime;
		public DateTime? CreatedTime { get=>m_CreatedTime; set { m_CreatedTime = value; NotifyPropertyChanged(); }}
		public tItem()
		{
		}
	}
	public partial class tLock : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private string m_LockID = "";
		public string LockID { get=>m_LockID; set { m_LockID = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private string m_LockType = "";
		public string LockType { get=>m_LockType; set { m_LockType = value; NotifyPropertyChanged(); }}
		private DateTime? m_LockTime;
		public DateTime? LockTime { get=>m_LockTime; set { m_LockTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_ExpiryTime;
		public DateTime? ExpiryTime { get=>m_ExpiryTime; set { m_ExpiryTime = value; NotifyPropertyChanged(); }}
		public tLock()
		{
		}
	}
	public partial class tNotificationSetting : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_NotificationSettingID;
		public int NotificationSettingID { get=>m_NotificationSettingID; set { m_NotificationSettingID = value; NotifyPropertyChanged(); }}
		private string m_NotificationSettingDesc = "";
		public string NotificationSettingDesc { get=>m_NotificationSettingDesc; set { m_NotificationSettingDesc = value; NotifyPropertyChanged(); }}
		private string m_CustomerList = "";
		public string CustomerList { get=>m_CustomerList; set { m_CustomerList = value; NotifyPropertyChanged(); }}
		private string m_SiteList = "";
		public string SiteList { get=>m_SiteList; set { m_SiteList = value; NotifyPropertyChanged(); }}
		private string m_WorkOrderList = "";
		public string WorkOrderList { get=>m_WorkOrderList; set { m_WorkOrderList = value; NotifyPropertyChanged(); }}
		private string m_TriggerList = "";
		public string TriggerList { get=>m_TriggerList; set { m_TriggerList = value; NotifyPropertyChanged(); }}
		private string m_EmailList = "";
		public string EmailList { get=>m_EmailList; set { m_EmailList = value; NotifyPropertyChanged(); }}
		private string m_EmailCCList = "";
		public string EmailCCList { get=>m_EmailCCList; set { m_EmailCCList = value; NotifyPropertyChanged(); }}
		private string m_NotificationType = "";
		public string NotificationType { get=>m_NotificationType; set { m_NotificationType = value; NotifyPropertyChanged(); }}
		private string m_SubjectPrefix = "";
		public string SubjectPrefix { get=>m_SubjectPrefix; set { m_SubjectPrefix = value; NotifyPropertyChanged(); }}
		private DateTime? m_ExpiryDate;
		public DateTime? ExpiryDate { get=>m_ExpiryDate; set { m_ExpiryDate = value; NotifyPropertyChanged(); }}
		public tNotificationSetting()
		{
		}
	}
	public partial class tPage : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_PageID;
		public int PageID { get=>m_PageID; set { m_PageID = value; NotifyPropertyChanged(); }}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_SendFromUserID;
		public int SendFromUserID { get=>m_SendFromUserID; set { m_SendFromUserID = value; NotifyPropertyChanged(); }}
		private int m_SendToUserID;
		public int SendToUserID { get=>m_SendToUserID; set { m_SendToUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_SubmitTimeUtc;
		public DateTime? SubmitTimeUtc { get=>m_SubmitTimeUtc; set { m_SubmitTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_StartPagingTimeUtc;
		public DateTime? StartPagingTimeUtc { get=>m_StartPagingTimeUtc; set { m_StartPagingTimeUtc = value; NotifyPropertyChanged(); }}
		private string m_PhoneNumber = "";
		public string PhoneNumber { get=>m_PhoneNumber; set { m_PhoneNumber = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private string m_Subject = "";
		public string Subject { get=>m_Subject; set { m_Subject = value; NotifyPropertyChanged(); }}
		private string m_Message = "";
		public string Message { get=>m_Message; set { m_Message = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		private int m_MaxRetry;
		public int MaxRetry { get=>m_MaxRetry; set { m_MaxRetry = value; NotifyPropertyChanged(); }}
		private int m_PageCount;
		public int PageCount { get=>m_PageCount; set { m_PageCount = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastPageTimeUtc;
		public DateTime? LastPageTimeUtc { get=>m_LastPageTimeUtc; set { m_LastPageTimeUtc = value; NotifyPropertyChanged(); }}
		private string m_Result = "";
		public string Result { get=>m_Result; set { m_Result = value; NotifyPropertyChanged(); }}
		private DateTime? m_AcknowledgedTimeUtc;
		public DateTime? AcknowledgedTimeUtc { get=>m_AcknowledgedTimeUtc; set { m_AcknowledgedTimeUtc = value; NotifyPropertyChanged(); }}
		public tPage()
		{
		}
	}
	public partial class tPermission : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private string m_FunctionID = "";
		public string FunctionID { get=>m_FunctionID; set { m_FunctionID = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		public tPermission()
		{
		}
	}
	public partial class tProblem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ProblemID;
		public int ProblemID { get=>m_ProblemID; set { m_ProblemID = value; NotifyPropertyChanged(); }}
		private string m_ProblemDesc = "";
		public string ProblemDesc { get=>m_ProblemDesc; set { m_ProblemDesc = value; NotifyPropertyChanged(); }}
		public tProblem()
		{
		}
	}
	public partial class tProblemGroup : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ProblemGroupID;
		public int ProblemGroupID { get=>m_ProblemGroupID; set { m_ProblemGroupID = value; NotifyPropertyChanged(); }}
		private string m_PoblemGroupDesc = "";
		public string PoblemGroupDesc { get=>m_PoblemGroupDesc; set { m_PoblemGroupDesc = value; NotifyPropertyChanged(); }}
		public tProblemGroup()
		{
		}
	}
	public partial class tPurchaseOrder : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_PurchaseOrderID;
		public int PurchaseOrderID { get=>m_PurchaseOrderID; set { m_PurchaseOrderID = value; NotifyPropertyChanged(); }}
		private int m_VendorID;
		public int VendorID { get=>m_VendorID; set { m_VendorID = value; NotifyPropertyChanged(); }}
		private DateTime? m_OrderDate;
		public DateTime? OrderDate { get=>m_OrderDate; set { m_OrderDate = value; NotifyPropertyChanged(); }}
		private int m_BillToBranchID;
		public int BillToBranchID { get=>m_BillToBranchID; set { m_BillToBranchID = value; NotifyPropertyChanged(); }}
		private string m_ShipToAddress = "";
		public string ShipToAddress { get=>m_ShipToAddress; set { m_ShipToAddress = value; NotifyPropertyChanged(); }}
		private string m_ShipToCity = "";
		public string ShipToCity { get=>m_ShipToCity; set { m_ShipToCity = value; NotifyPropertyChanged(); }}
		private string m_ShipToProvince = "";
		public string ShipToProvince { get=>m_ShipToProvince; set { m_ShipToProvince = value; NotifyPropertyChanged(); }}
		private string m_ShipToPostalCode = "";
		public string ShipToPostalCode { get=>m_ShipToPostalCode; set { m_ShipToPostalCode = value; NotifyPropertyChanged(); }}
		private string m_ShipToContact = "";
		public string ShipToContact { get=>m_ShipToContact; set { m_ShipToContact = value; NotifyPropertyChanged(); }}
		private string m_ShipToPhone = "";
		public string ShipToPhone { get=>m_ShipToPhone; set { m_ShipToPhone = value; NotifyPropertyChanged(); }}
		private int m_TaxRegionID;
		public int TaxRegionID { get=>m_TaxRegionID; set { m_TaxRegionID = value; NotifyPropertyChanged(); }}
		private decimal m_Subtotal;
		public decimal Subtotal { get=>m_Subtotal; set { m_Subtotal = value; NotifyPropertyChanged(); }}
		private decimal m_TaxTotal;
		public decimal TaxTotal { get=>m_TaxTotal; set { m_TaxTotal = value; NotifyPropertyChanged(); }}
		private decimal m_Total;
		public decimal Total { get=>m_Total; set { m_Total = value; NotifyPropertyChanged(); }}
		private int m_PurchaserUserID;
		public int PurchaserUserID { get=>m_PurchaserUserID; set { m_PurchaserUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_ApprovedTime;
		public DateTime? ApprovedTime { get=>m_ApprovedTime; set { m_ApprovedTime = value; NotifyPropertyChanged(); }}
		private int m_ApprovedByUserID;
		public int ApprovedByUserID { get=>m_ApprovedByUserID; set { m_ApprovedByUserID = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		public tPurchaseOrder()
		{
		}
	}
	public partial class tPurchaseOrderDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_PurchaseOrderID;
		public int PurchaseOrderID { get=>m_PurchaseOrderID; set { m_PurchaseOrderID = value; NotifyPropertyChanged(); }}
		private int m_LineNumber;
		public int LineNumber { get=>m_LineNumber; set { m_LineNumber = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private int m_Qty;
		public int Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private decimal m_UnitCost;
		public decimal UnitCost { get=>m_UnitCost; set { m_UnitCost = value; NotifyPropertyChanged(); }}
		private decimal m_ExtendCost;
		public decimal ExtendCost { get=>m_ExtendCost; set { m_ExtendCost = value; NotifyPropertyChanged(); }}
		private int m_ReceivedQty;
		public int ReceivedQty { get=>m_ReceivedQty; set { m_ReceivedQty = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastReceivingTime;
		public DateTime? LastReceivingTime { get=>m_LastReceivingTime; set { m_LastReceivingTime = value; NotifyPropertyChanged(); }}
		public tPurchaseOrderDetail()
		{
		}
	}
	public partial class tPurchaseOrderTax : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_PurchaseOrderID;
		public int PurchaseOrderID { get=>m_PurchaseOrderID; set { m_PurchaseOrderID = value; NotifyPropertyChanged(); }}
		private int m_TaxID;
		public int TaxID { get=>m_TaxID; set { m_TaxID = value; NotifyPropertyChanged(); }}
		private decimal m_TaxableAmount;
		public decimal TaxableAmount { get=>m_TaxableAmount; set { m_TaxableAmount = value; NotifyPropertyChanged(); }}
		private decimal m_Tax;
		public decimal Tax { get=>m_Tax; set { m_Tax = value; NotifyPropertyChanged(); }}
		public tPurchaseOrderTax()
		{
		}
	}
	public partial class tReceiving : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ReceivingID;
		public int ReceivingID { get=>m_ReceivingID; set { m_ReceivingID = value; NotifyPropertyChanged(); }}
		private int m_WarehouseID;
		public int WarehouseID { get=>m_WarehouseID; set { m_WarehouseID = value; NotifyPropertyChanged(); }}
		private int m_VendorID;
		public int VendorID { get=>m_VendorID; set { m_VendorID = value; NotifyPropertyChanged(); }}
		private DateTime? m_RecevingTime;
		public DateTime? RecevingTime { get=>m_RecevingTime; set { m_RecevingTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_ReceivedByUserID;
		public DateTime? ReceivedByUserID { get=>m_ReceivedByUserID; set { m_ReceivedByUserID = value; NotifyPropertyChanged(); }}
		private string m_InvoiceNumber = "";
		public string InvoiceNumber { get=>m_InvoiceNumber; set { m_InvoiceNumber = value; NotifyPropertyChanged(); }}
		private int m_PurchaseOrderID;
		public int PurchaseOrderID { get=>m_PurchaseOrderID; set { m_PurchaseOrderID = value; NotifyPropertyChanged(); }}
		private decimal m_Subtotal;
		public decimal Subtotal { get=>m_Subtotal; set { m_Subtotal = value; NotifyPropertyChanged(); }}
		private decimal m_TaxTotal;
		public decimal TaxTotal { get=>m_TaxTotal; set { m_TaxTotal = value; NotifyPropertyChanged(); }}
		private decimal m_ExpenseTotal;
		public decimal ExpenseTotal { get=>m_ExpenseTotal; set { m_ExpenseTotal = value; NotifyPropertyChanged(); }}
		private decimal m_Total;
		public decimal Total { get=>m_Total; set { m_Total = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		public tReceiving()
		{
		}
	}
	public partial class tReceivingDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ReceivingID;
		public int ReceivingID { get=>m_ReceivingID; set { m_ReceivingID = value; NotifyPropertyChanged(); }}
		private int m_LineNumber;
		public int LineNumber { get=>m_LineNumber; set { m_LineNumber = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private string m_SerialNumber = "";
		public string SerialNumber { get=>m_SerialNumber; set { m_SerialNumber = value; NotifyPropertyChanged(); }}
		private int m_Qty;
		public int Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private decimal m_UnitCost;
		public decimal UnitCost { get=>m_UnitCost; set { m_UnitCost = value; NotifyPropertyChanged(); }}
		private decimal m_ExtendedCost;
		public decimal ExtendedCost { get=>m_ExtendedCost; set { m_ExtendedCost = value; NotifyPropertyChanged(); }}
		private int m_POLineNumber;
		public int POLineNumber { get=>m_POLineNumber; set { m_POLineNumber = value; NotifyPropertyChanged(); }}
		public tReceivingDetail()
		{
		}
	}
	public partial class tReturnShipment : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ReturnShipmentID;
		public int ReturnShipmentID { get=>m_ReturnShipmentID; set { m_ReturnShipmentID = value; NotifyPropertyChanged(); }}
		private int m_ToWarehouseID;
		public int ToWarehouseID { get=>m_ToWarehouseID; set { m_ToWarehouseID = value; NotifyPropertyChanged(); }}
		private int m_FromWarehouseID;
		public int FromWarehouseID { get=>m_FromWarehouseID; set { m_FromWarehouseID = value; NotifyPropertyChanged(); }}
		private int m_CarrierID;
		public int CarrierID { get=>m_CarrierID; set { m_CarrierID = value; NotifyPropertyChanged(); }}
		private string m_WaybillNumber = "";
		public string WaybillNumber { get=>m_WaybillNumber; set { m_WaybillNumber = value; NotifyPropertyChanged(); }}
		private DateTime? m_ShippedTime;
		public DateTime? ShippedTime { get=>m_ShippedTime; set { m_ShippedTime = value; NotifyPropertyChanged(); }}
		private int m_ShippingUserID;
		public int ShippingUserID { get=>m_ShippingUserID; set { m_ShippingUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_ReceivedTime;
		public DateTime? ReceivedTime { get=>m_ReceivedTime; set { m_ReceivedTime = value; NotifyPropertyChanged(); }}
		private int m_ReceivedUserID;
		public int ReceivedUserID { get=>m_ReceivedUserID; set { m_ReceivedUserID = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		public tReturnShipment()
		{
		}
	}
	public partial class tSchedule : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ScheduleID;
		public int ScheduleID { get=>m_ScheduleID; set { m_ScheduleID = value; NotifyPropertyChanged(); }}
		private string m_ScheduleDesc = "";
		public string ScheduleDesc { get=>m_ScheduleDesc; set { m_ScheduleDesc = value; NotifyPropertyChanged(); }}
		private DateTime? m_StartDate;
		public DateTime? StartDate { get=>m_StartDate; set { m_StartDate = value; NotifyPropertyChanged(); }}
		private DateTime? m_EndDate;
		public DateTime? EndDate { get=>m_EndDate; set { m_EndDate = value; NotifyPropertyChanged(); }}
		private int m_CreatedByUserID;
		public int CreatedByUserID { get=>m_CreatedByUserID; set { m_CreatedByUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTime;
		public DateTime? CreatedTime { get=>m_CreatedTime; set { m_CreatedTime = value; NotifyPropertyChanged(); }}
		private int m_ModifiedByUserID;
		public int ModifiedByUserID { get=>m_ModifiedByUserID; set { m_ModifiedByUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_ModifiedTime;
		public DateTime? ModifiedTime { get=>m_ModifiedTime; set { m_ModifiedTime = value; NotifyPropertyChanged(); }}
		public tSchedule()
		{
		}
	}
	public partial class tScheduleDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ScheduleDetailID;
		public int ScheduleDetailID { get=>m_ScheduleDetailID; set { m_ScheduleDetailID = value; NotifyPropertyChanged(); }}
		private int m_ScheduleID;
		public int ScheduleID { get=>m_ScheduleID; set { m_ScheduleID = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private int m_ServiceItemID;
		public int ServiceItemID { get=>m_ServiceItemID; set { m_ServiceItemID = value; NotifyPropertyChanged(); }}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		private DateTime? m_StartTime;
		public DateTime? StartTime { get=>m_StartTime; set { m_StartTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_EndTime;
		public DateTime? EndTime { get=>m_EndTime; set { m_EndTime = value; NotifyPropertyChanged(); }}
		public tScheduleDetail()
		{
		}
	}
	public partial class tServiceBillngRate : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_BillingRateID;
		public int BillingRateID { get=>m_BillingRateID; set { m_BillingRateID = value; NotifyPropertyChanged(); }}
		private string m_BillingRateDesc = "";
		public string BillingRateDesc { get=>m_BillingRateDesc; set { m_BillingRateDesc = value; NotifyPropertyChanged(); }}
		private int m_LaborItemID;
		public int LaborItemID { get=>m_LaborItemID; set { m_LaborItemID = value; NotifyPropertyChanged(); }}
		private int m_TravelItemID;
		public int TravelItemID { get=>m_TravelItemID; set { m_TravelItemID = value; NotifyPropertyChanged(); }}
		private decimal m_LaborRegularPrice;
		public decimal LaborRegularPrice { get=>m_LaborRegularPrice; set { m_LaborRegularPrice = value; NotifyPropertyChanged(); }}
		private decimal m_LaborAfterHourPrice;
		public decimal LaborAfterHourPrice { get=>m_LaborAfterHourPrice; set { m_LaborAfterHourPrice = value; NotifyPropertyChanged(); }}
		private int m_LaborMinMinutes;
		public int LaborMinMinutes { get=>m_LaborMinMinutes; set { m_LaborMinMinutes = value; NotifyPropertyChanged(); }}
		private int m_LaborRoundingMinutes;
		public int LaborRoundingMinutes { get=>m_LaborRoundingMinutes; set { m_LaborRoundingMinutes = value; NotifyPropertyChanged(); }}
		private decimal m_TravelRegularPrice;
		public decimal TravelRegularPrice { get=>m_TravelRegularPrice; set { m_TravelRegularPrice = value; NotifyPropertyChanged(); }}
		private decimal m_TravelAfterHourPrice;
		public decimal TravelAfterHourPrice { get=>m_TravelAfterHourPrice; set { m_TravelAfterHourPrice = value; NotifyPropertyChanged(); }}
		private int m_TravelMinMinutes;
		public int TravelMinMinutes { get=>m_TravelMinMinutes; set { m_TravelMinMinutes = value; NotifyPropertyChanged(); }}
		private int m_TravelRoundingMinutes;
		public int TravelRoundingMinutes { get=>m_TravelRoundingMinutes; set { m_TravelRoundingMinutes = value; NotifyPropertyChanged(); }}
		public tServiceBillngRate()
		{
		}
	}
	public partial class tServiceHour : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ServiceHourID;
		public int ServiceHourID { get=>m_ServiceHourID; set { m_ServiceHourID = value; NotifyPropertyChanged(); }}
		private string m_ServiceHourDesc = "";
		public string ServiceHourDesc { get=>m_ServiceHourDesc; set { m_ServiceHourDesc = value; NotifyPropertyChanged(); }}
		public tServiceHour()
		{
		}
	}
	public partial class tServiceHourDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ServiceHourID;
		public int ServiceHourID { get=>m_ServiceHourID; set { m_ServiceHourID = value; NotifyPropertyChanged(); }}
		private int m_DayOfWeek;
		public int DayOfWeek { get=>m_DayOfWeek; set { m_DayOfWeek = value; NotifyPropertyChanged(); }}
		private TimeSpan m_StartingTime;
		public TimeSpan StartingTime { get=>m_StartingTime; set { m_StartingTime = value; NotifyPropertyChanged(); }}
		private TimeSpan m_EndTime;
		public TimeSpan EndTime { get=>m_EndTime; set { m_EndTime = value; NotifyPropertyChanged(); }}
		public tServiceHourDetail()
		{
		}
	}
	public partial class tSetting : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private string m_SettingID = "";
		public string SettingID { get=>m_SettingID; set { m_SettingID = value; NotifyPropertyChanged(); }}
		private string m_SettingDesc = "";
		public string SettingDesc { get=>m_SettingDesc; set { m_SettingDesc = value; NotifyPropertyChanged(); }}
		private string m_SettingValue = "";
		public string SettingValue { get=>m_SettingValue; set { m_SettingValue = value; NotifyPropertyChanged(); }}
		public tSetting()
		{
		}
	}
	public partial class tSla : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_SlaID;
		public int SlaID { get=>m_SlaID; set { m_SlaID = value; NotifyPropertyChanged(); }}
		private string m_SlaDesc = "";
		public string SlaDesc { get=>m_SlaDesc; set { m_SlaDesc = value; NotifyPropertyChanged(); }}
		public tSla()
		{
		}
	}
	public partial class tSlaDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_SlaID;
		public int SlaID { get=>m_SlaID; set { m_SlaID = value; NotifyPropertyChanged(); }}
		private int m_ZoneNumber;
		public int ZoneNumber { get=>m_ZoneNumber; set { m_ZoneNumber = value; NotifyPropertyChanged(); }}
		private int m_ServiceItemID;
		public int ServiceItemID { get=>m_ServiceItemID; set { m_ServiceItemID = value; NotifyPropertyChanged(); }}
		private int m_Severity;
		public int Severity { get=>m_Severity; set { m_Severity = value; NotifyPropertyChanged(); }}
		private int m_ResponseTime;
		public int ResponseTime { get=>m_ResponseTime; set { m_ResponseTime = value; NotifyPropertyChanged(); }}
		private int m_SolutionTime;
		public int SolutionTime { get=>m_SolutionTime; set { m_SolutionTime = value; NotifyPropertyChanged(); }}
		public tSlaDetail()
		{
		}
	}
	public partial class tSlaZone : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_SlaID;
		public int SlaID { get=>m_SlaID; set { m_SlaID = value; NotifyPropertyChanged(); }}
		private int m_ZoneNumber;
		public int ZoneNumber { get=>m_ZoneNumber; set { m_ZoneNumber = value; NotifyPropertyChanged(); }}
		private string m_ZoneDesc = "";
		public string ZoneDesc { get=>m_ZoneDesc; set { m_ZoneDesc = value; NotifyPropertyChanged(); }}
		public tSlaZone()
		{
		}
	}
	public partial class tSolution : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_SolutionID;
		public int SolutionID { get=>m_SolutionID; set { m_SolutionID = value; NotifyPropertyChanged(); }}
		private int m_SolutionGroupID;
		public int SolutionGroupID { get=>m_SolutionGroupID; set { m_SolutionGroupID = value; NotifyPropertyChanged(); }}
		private string m_SolutionDesc = "";
		public string SolutionDesc { get=>m_SolutionDesc; set { m_SolutionDesc = value; NotifyPropertyChanged(); }}
		public tSolution()
		{
		}
	}
	public partial class tSolutionGroup : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_SolutionGroupID;
		public int SolutionGroupID { get=>m_SolutionGroupID; set { m_SolutionGroupID = value; NotifyPropertyChanged(); }}
		private string m_SolutionGroupDesc = "";
		public string SolutionGroupDesc { get=>m_SolutionGroupDesc; set { m_SolutionGroupDesc = value; NotifyPropertyChanged(); }}
		public tSolutionGroup()
		{
		}
	}
	public partial class tStockMovement : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_StockMovementID;
		public int StockMovementID { get=>m_StockMovementID; set { m_StockMovementID = value; NotifyPropertyChanged(); }}
		private int m_FromWarehouseID;
		public int FromWarehouseID { get=>m_FromWarehouseID; set { m_FromWarehouseID = value; NotifyPropertyChanged(); }}
		private int m_ToWarehouseID;
		public int ToWarehouseID { get=>m_ToWarehouseID; set { m_ToWarehouseID = value; NotifyPropertyChanged(); }}
		private string m_MovementType = "";
		public string MovementType { get=>m_MovementType; set { m_MovementType = value; NotifyPropertyChanged(); }}
		private DateTime? m_MovementTime;
		public DateTime? MovementTime { get=>m_MovementTime; set { m_MovementTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_MovementTimeUtc;
		public DateTime? MovementTimeUtc { get=>m_MovementTimeUtc; set { m_MovementTimeUtc = value; NotifyPropertyChanged(); }}
		private string m_UserID = "";
		public string UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private string m_SerialNumber = "";
		public string SerialNumber { get=>m_SerialNumber; set { m_SerialNumber = value; NotifyPropertyChanged(); }}
		private int m_Qty;
		public int Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private bool m_ShipToCustomerSite;
		public bool ShipToCustomerSite { get=>m_ShipToCustomerSite; set { m_ShipToCustomerSite = value; NotifyPropertyChanged(); }}
		private bool m_IsWriteOff;
		public bool IsWriteOff { get=>m_IsWriteOff; set { m_IsWriteOff = value; NotifyPropertyChanged(); }}
		private string m_Noes = "";
		public string Noes { get=>m_Noes; set { m_Noes = value; NotifyPropertyChanged(); }}
		private int m_ShipmentID;
		public int ShipmentID { get=>m_ShipmentID; set { m_ShipmentID = value; NotifyPropertyChanged(); }}
		public tStockMovement()
		{
		}
	}
	public partial class tStockShipment : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ShipmentID;
		public int ShipmentID { get=>m_ShipmentID; set { m_ShipmentID = value; NotifyPropertyChanged(); }}
		private string m_DestinationType = "";
		public string DestinationType { get=>m_DestinationType; set { m_DestinationType = value; NotifyPropertyChanged(); }}
		private int m_FromWarehouseID;
		public int FromWarehouseID { get=>m_FromWarehouseID; set { m_FromWarehouseID = value; NotifyPropertyChanged(); }}
		private int m_ToWarehouseID;
		public int ToWarehouseID { get=>m_ToWarehouseID; set { m_ToWarehouseID = value; NotifyPropertyChanged(); }}
		private int m_ToSiteID;
		public int ToSiteID { get=>m_ToSiteID; set { m_ToSiteID = value; NotifyPropertyChanged(); }}
		private int m_CarrierID;
		public int CarrierID { get=>m_CarrierID; set { m_CarrierID = value; NotifyPropertyChanged(); }}
		private string m_WaybillNumber = "";
		public string WaybillNumber { get=>m_WaybillNumber; set { m_WaybillNumber = value; NotifyPropertyChanged(); }}
		private DateTime? m_ShippedTime;
		public DateTime? ShippedTime { get=>m_ShippedTime; set { m_ShippedTime = value; NotifyPropertyChanged(); }}
		private int m_ShippingUserID;
		public int ShippingUserID { get=>m_ShippingUserID; set { m_ShippingUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_ReceivedTime;
		public DateTime? ReceivedTime { get=>m_ReceivedTime; set { m_ReceivedTime = value; NotifyPropertyChanged(); }}
		private int m_ReceivedUserID;
		public int ReceivedUserID { get=>m_ReceivedUserID; set { m_ReceivedUserID = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		public tStockShipment()
		{
		}
	}
	public partial class tTax : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TaxID;
		public int TaxID { get=>m_TaxID; set { m_TaxID = value; NotifyPropertyChanged(); }}
		private string m_TaxDesc = "";
		public string TaxDesc { get=>m_TaxDesc; set { m_TaxDesc = value; NotifyPropertyChanged(); }}
		private string m_Symbol = "";
		public string Symbol { get=>m_Symbol; set { m_Symbol = value; NotifyPropertyChanged(); }}
		private double m_Rate;
		public double Rate { get=>m_Rate; set { m_Rate = value; NotifyPropertyChanged(); }}
		public tTax()
		{
		}
	}
	public partial class tTaxCode : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TaxCodeID;
		public int TaxCodeID { get=>m_TaxCodeID; set { m_TaxCodeID = value; NotifyPropertyChanged(); }}
		private string m_TaxCodeDesc = "";
		public string TaxCodeDesc { get=>m_TaxCodeDesc; set { m_TaxCodeDesc = value; NotifyPropertyChanged(); }}
		public tTaxCode()
		{
		}
	}
	public partial class tTaxCodeDetail : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TaxRegionID;
		public int TaxRegionID { get=>m_TaxRegionID; set { m_TaxRegionID = value; NotifyPropertyChanged(); }}
		private int m_TaxCodeID;
		public int TaxCodeID { get=>m_TaxCodeID; set { m_TaxCodeID = value; NotifyPropertyChanged(); }}
		private int m_TaxID;
		public int TaxID { get=>m_TaxID; set { m_TaxID = value; NotifyPropertyChanged(); }}
		public tTaxCodeDetail()
		{
		}
	}
	public partial class tTaxRegion : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TaxRegionID;
		public int TaxRegionID { get=>m_TaxRegionID; set { m_TaxRegionID = value; NotifyPropertyChanged(); }}
		private string m_TaxRegion = "";
		public string TaxRegion { get=>m_TaxRegion; set { m_TaxRegion = value; NotifyPropertyChanged(); }}
		public tTaxRegion()
		{
		}
	}
	public partial class tTeam : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TeamID;
		public int TeamID { get=>m_TeamID; set { m_TeamID = value; NotifyPropertyChanged(); }}
		private string m_TeamDesc = "";
		public string TeamDesc { get=>m_TeamDesc; set { m_TeamDesc = value; NotifyPropertyChanged(); }}
		public tTeam()
		{
		}
	}
	public partial class tTeamMember : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TeamID;
		public int TeamID { get=>m_TeamID; set { m_TeamID = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		public tTeamMember()
		{
		}
	}
	public partial class tTeamTerritory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TeamID;
		public int TeamID { get=>m_TeamID; set { m_TeamID = value; NotifyPropertyChanged(); }}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		public tTeamTerritory()
		{
		}
	}
	public partial class tTerritory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		private string m_TerritoryDesc = "";
		public string TerritoryDesc { get=>m_TerritoryDesc; set { m_TerritoryDesc = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		public tTerritory()
		{
		}
	}
	public partial class tUser : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private string m_Name = "";
		public string Name { get=>m_Name; set { m_Name = value; NotifyPropertyChanged(); }}
		private int m_BranchID;
		public int BranchID { get=>m_BranchID; set { m_BranchID = value; NotifyPropertyChanged(); }}
		private string m_UserName = "";
		public string UserName { get=>m_UserName; set { m_UserName = value; NotifyPropertyChanged(); }}
		private string m_Password = "";
		public string Password { get=>m_Password; set { m_Password = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_CellPhone = "";
		public string CellPhone { get=>m_CellPhone; set { m_CellPhone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		public tUser()
		{
		}
	}
	public partial class tUserService : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private int m_ServiceItemID;
		public int ServiceItemID { get=>m_ServiceItemID; set { m_ServiceItemID = value; NotifyPropertyChanged(); }}
		public tUserService()
		{
		}
	}
	public partial class tUserTerritory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		public tUserTerritory()
		{
		}
	}
	public partial class tWarehouse : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WarehouseID;
		public int WarehouseID { get=>m_WarehouseID; set { m_WarehouseID = value; NotifyPropertyChanged(); }}
		private string m_WarehouseName = "";
		public string WarehouseName { get=>m_WarehouseName; set { m_WarehouseName = value; NotifyPropertyChanged(); }}
		private string m_Address = "";
		public string Address { get=>m_Address; set { m_Address = value; NotifyPropertyChanged(); }}
		private string m_City = "";
		public string City { get=>m_City; set { m_City = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private string m_PostalCode = "";
		public string PostalCode { get=>m_PostalCode; set { m_PostalCode = value; NotifyPropertyChanged(); }}
		private string m_Country = "";
		public string Country { get=>m_Country; set { m_Country = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private string m_Contact = "";
		public string Contact { get=>m_Contact; set { m_Contact = value; NotifyPropertyChanged(); }}
		private string m_TimeZone = "";
		public string TimeZone { get=>m_TimeZone; set { m_TimeZone = value; NotifyPropertyChanged(); }}
		private bool m_IsReparingWarehouse;
		public bool IsReparingWarehouse { get=>m_IsReparingWarehouse; set { m_IsReparingWarehouse = value; NotifyPropertyChanged(); }}
		public tWarehouse()
		{
		}
	}
	public partial class tWorkOrder : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_SiteID;
		public int SiteID { get=>m_SiteID; set { m_SiteID = value; NotifyPropertyChanged(); }}
		private string m_SiteName = "";
		public string SiteName { get=>m_SiteName; set { m_SiteName = value; NotifyPropertyChanged(); }}
		private string m_Address1 = "";
		public string Address1 { get=>m_Address1; set { m_Address1 = value; NotifyPropertyChanged(); }}
		private string m_Address2 = "";
		public string Address2 { get=>m_Address2; set { m_Address2 = value; NotifyPropertyChanged(); }}
		private string m_City = "";
		public string City { get=>m_City; set { m_City = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private string m_PostalCode = "";
		public string PostalCode { get=>m_PostalCode; set { m_PostalCode = value; NotifyPropertyChanged(); }}
		private string m_Country = "";
		public string Country { get=>m_Country; set { m_Country = value; NotifyPropertyChanged(); }}
		private string m_Contact = "";
		public string Contact { get=>m_Contact; set { m_Contact = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_Phone2 = "";
		public string Phone2 { get=>m_Phone2; set { m_Phone2 = value; NotifyPropertyChanged(); }}
		private string m_Contact2 = "";
		public string Contact2 { get=>m_Contact2; set { m_Contact2 = value; NotifyPropertyChanged(); }}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		private string m_TimeZone = "";
		public string TimeZone { get=>m_TimeZone; set { m_TimeZone = value; NotifyPropertyChanged(); }}
		private string m_Subject = "";
		public string Subject { get=>m_Subject; set { m_Subject = value; NotifyPropertyChanged(); }}
		private int m_InitialSeverity;
		public int InitialSeverity { get=>m_InitialSeverity; set { m_InitialSeverity = value; NotifyPropertyChanged(); }}
		private int m_Severity;
		public int Severity { get=>m_Severity; set { m_Severity = value; NotifyPropertyChanged(); }}
		private string m_Status = "";
		public string Status { get=>m_Status; set { m_Status = value; NotifyPropertyChanged(); }}
		private string m_ReferenceNumber1 = "";
		public string ReferenceNumber1 { get=>m_ReferenceNumber1; set { m_ReferenceNumber1 = value; NotifyPropertyChanged(); }}
		private string m_ReferenceNumber2 = "";
		public string ReferenceNumber2 { get=>m_ReferenceNumber2; set { m_ReferenceNumber2 = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTime;
		public DateTime? CreatedTime { get=>m_CreatedTime; set { m_CreatedTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTimeUtc;
		public DateTime? CreatedTimeUtc { get=>m_CreatedTimeUtc; set { m_CreatedTimeUtc = value; NotifyPropertyChanged(); }}
		private int m_CreatingUserID;
		public int CreatingUserID { get=>m_CreatingUserID; set { m_CreatingUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_Eta;
		public DateTime? Eta { get=>m_Eta; set { m_Eta = value; NotifyPropertyChanged(); }}
		private DateTime? m_EtaUtc;
		public DateTime? EtaUtc { get=>m_EtaUtc; set { m_EtaUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_FirstResponseTime;
		public DateTime? FirstResponseTime { get=>m_FirstResponseTime; set { m_FirstResponseTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_FirstResponseTimeUtc;
		public DateTime? FirstResponseTimeUtc { get=>m_FirstResponseTimeUtc; set { m_FirstResponseTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastDispatchTime;
		public DateTime? LastDispatchTime { get=>m_LastDispatchTime; set { m_LastDispatchTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastDispatchTimeUtc;
		public DateTime? LastDispatchTimeUtc { get=>m_LastDispatchTimeUtc; set { m_LastDispatchTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastArrivalTime;
		public DateTime? LastArrivalTime { get=>m_LastArrivalTime; set { m_LastArrivalTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastArrivalTimeUtc;
		public DateTime? LastArrivalTimeUtc { get=>m_LastArrivalTimeUtc; set { m_LastArrivalTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastCompleteTime;
		public DateTime? LastCompleteTime { get=>m_LastCompleteTime; set { m_LastCompleteTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_LastCompleteTimeUtc;
		public DateTime? LastCompleteTimeUtc { get=>m_LastCompleteTimeUtc; set { m_LastCompleteTimeUtc = value; NotifyPropertyChanged(); }}
		private int m_LastTechnicianID;
		public int LastTechnicianID { get=>m_LastTechnicianID; set { m_LastTechnicianID = value; NotifyPropertyChanged(); }}
		private DateTime? m_ClosedTime;
		public DateTime? ClosedTime { get=>m_ClosedTime; set { m_ClosedTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_ClosedTimeUtc;
		public DateTime? ClosedTimeUtc { get=>m_ClosedTimeUtc; set { m_ClosedTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_CancelledTime;
		public DateTime? CancelledTime { get=>m_CancelledTime; set { m_CancelledTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_CancelledTimeUtc;
		public DateTime? CancelledTimeUtc { get=>m_CancelledTimeUtc; set { m_CancelledTimeUtc = value; NotifyPropertyChanged(); }}
		private int m_CancelledUserID;
		public int CancelledUserID { get=>m_CancelledUserID; set { m_CancelledUserID = value; NotifyPropertyChanged(); }}
		private bool m_IsSlaWorkOrder;
		public bool IsSlaWorkOrder { get=>m_IsSlaWorkOrder; set { m_IsSlaWorkOrder = value; NotifyPropertyChanged(); }}
		private bool m_NeedReview;
		public bool NeedReview { get=>m_NeedReview; set { m_NeedReview = value; NotifyPropertyChanged(); }}
		private int m_WorkOrderTypeID;
		public int WorkOrderTypeID { get=>m_WorkOrderTypeID; set { m_WorkOrderTypeID = value; NotifyPropertyChanged(); }}
		private int m_BillingBatchID;
		public int BillingBatchID { get=>m_BillingBatchID; set { m_BillingBatchID = value; NotifyPropertyChanged(); }}
		private int m_BillingUserID;
		public int BillingUserID { get=>m_BillingUserID; set { m_BillingUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_BilledTime;
		public DateTime? BilledTime { get=>m_BilledTime; set { m_BilledTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_BilledTimeUtc;
		public DateTime? BilledTimeUtc { get=>m_BilledTimeUtc; set { m_BilledTimeUtc = value; NotifyPropertyChanged(); }}
		private string m_PaymentType = "";
		public string PaymentType { get=>m_PaymentType; set { m_PaymentType = value; NotifyPropertyChanged(); }}
		private int m_TaxRegionID;
		public int TaxRegionID { get=>m_TaxRegionID; set { m_TaxRegionID = value; NotifyPropertyChanged(); }}
		private decimal m_Subtotal;
		public decimal Subtotal { get=>m_Subtotal; set { m_Subtotal = value; NotifyPropertyChanged(); }}
		private decimal m_TaxTotal;
		public decimal TaxTotal { get=>m_TaxTotal; set { m_TaxTotal = value; NotifyPropertyChanged(); }}
		private decimal m_Total;
		public decimal Total { get=>m_Total; set { m_Total = value; NotifyPropertyChanged(); }}
		public tWorkOrder()
		{
		}
	}
	public partial class tWorkOrderCharge : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_LineNumber;
		public int LineNumber { get=>m_LineNumber; set { m_LineNumber = value; NotifyPropertyChanged(); }}
		private int m_ChargeItemID;
		public int ChargeItemID { get=>m_ChargeItemID; set { m_ChargeItemID = value; NotifyPropertyChanged(); }}
		private string m_SerialNumber = "";
		public string SerialNumber { get=>m_SerialNumber; set { m_SerialNumber = value; NotifyPropertyChanged(); }}
		private double m_Qty;
		public double Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private decimal m_Price;
		public decimal Price { get=>m_Price; set { m_Price = value; NotifyPropertyChanged(); }}
		private decimal m_Amount;
		public decimal Amount { get=>m_Amount; set { m_Amount = value; NotifyPropertyChanged(); }}
		private string m_Notes = "";
		public string Notes { get=>m_Notes; set { m_Notes = value; NotifyPropertyChanged(); }}
		private int m_ServiceLineNumber;
		public int ServiceLineNumber { get=>m_ServiceLineNumber; set { m_ServiceLineNumber = value; NotifyPropertyChanged(); }}
		private int m_PartsLineNumber;
		public int PartsLineNumber { get=>m_PartsLineNumber; set { m_PartsLineNumber = value; NotifyPropertyChanged(); }}
		private int m_ContractID;
		public int ContractID { get=>m_ContractID; set { m_ContractID = value; NotifyPropertyChanged(); }}
		private int m_ContractLineNumber;
		public int ContractLineNumber { get=>m_ContractLineNumber; set { m_ContractLineNumber = value; NotifyPropertyChanged(); }}
		public tWorkOrderCharge()
		{
		}
	}
	public partial class tWorkOrderExtraData : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_ServiceLineNumber;
		public int ServiceLineNumber { get=>m_ServiceLineNumber; set { m_ServiceLineNumber = value; NotifyPropertyChanged(); }}
		private string m_ExtraData = "";
		public string ExtraData { get=>m_ExtraData; set { m_ExtraData = value; NotifyPropertyChanged(); }}
		private string m_RequestFromThirdParty = "";
		public string RequestFromThirdParty { get=>m_RequestFromThirdParty; set { m_RequestFromThirdParty = value; NotifyPropertyChanged(); }}
		private string m_ResponseToThirdParty = "";
		public string ResponseToThirdParty { get=>m_ResponseToThirdParty; set { m_ResponseToThirdParty = value; NotifyPropertyChanged(); }}
		public tWorkOrderExtraData()
		{
		}
	}
	public partial class tWorkOrderNotification : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_LineNumber;
		public int LineNumber { get=>m_LineNumber; set { m_LineNumber = value; NotifyPropertyChanged(); }}
		private string m_Action = "";
		public string Action { get=>m_Action; set { m_Action = value; NotifyPropertyChanged(); }}
		private string m_Message = "";
		public string Message { get=>m_Message; set { m_Message = value; NotifyPropertyChanged(); }}
		public tWorkOrderNotification()
		{
		}
	}
	public partial class tWorkOrderParts : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_LineNumber;
		public int LineNumber { get=>m_LineNumber; set { m_LineNumber = value; NotifyPropertyChanged(); }}
		private int m_PartsItemID;
		public int PartsItemID { get=>m_PartsItemID; set { m_PartsItemID = value; NotifyPropertyChanged(); }}
		private string m_SerialNunber = "";
		public string SerialNunber { get=>m_SerialNunber; set { m_SerialNunber = value; NotifyPropertyChanged(); }}
		private int m_Qty;
		public int Qty { get=>m_Qty; set { m_Qty = value; NotifyPropertyChanged(); }}
		private bool m_IsReplacement;
		public bool IsReplacement { get=>m_IsReplacement; set { m_IsReplacement = value; NotifyPropertyChanged(); }}
		private int m_WarehouseID;
		public int WarehouseID { get=>m_WarehouseID; set { m_WarehouseID = value; NotifyPropertyChanged(); }}
		private int m_ConsumingUserID;
		public int ConsumingUserID { get=>m_ConsumingUserID; set { m_ConsumingUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_ConsumedTime;
		public DateTime? ConsumedTime { get=>m_ConsumedTime; set { m_ConsumedTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_ConsumedTimeUtc;
		public DateTime? ConsumedTimeUtc { get=>m_ConsumedTimeUtc; set { m_ConsumedTimeUtc = value; NotifyPropertyChanged(); }}
		public tWorkOrderParts()
		{
		}
	}
	public partial class tWorkOrderRemark : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderRemarkID;
		public int WorkOrderRemarkID { get=>m_WorkOrderRemarkID; set { m_WorkOrderRemarkID = value; NotifyPropertyChanged(); }}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private string m_Remark = "";
		public string Remark { get=>m_Remark; set { m_Remark = value; NotifyPropertyChanged(); }}
		private DateTime? m_EnterTime;
		public DateTime? EnterTime { get=>m_EnterTime; set { m_EnterTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_EnterTimeUtc;
		public DateTime? EnterTimeUtc { get=>m_EnterTimeUtc; set { m_EnterTimeUtc = value; NotifyPropertyChanged(); }}
		private string m_AttachmentFileName = "";
		public string AttachmentFileName { get=>m_AttachmentFileName; set { m_AttachmentFileName = value; NotifyPropertyChanged(); }}
		private bool m_IsInternal;
		public bool IsInternal { get=>m_IsInternal; set { m_IsInternal = value; NotifyPropertyChanged(); }}
		private bool m_NeedReview;
		public bool NeedReview { get=>m_NeedReview; set { m_NeedReview = value; NotifyPropertyChanged(); }}
		private bool m_IsClosingRemark;
		public bool IsClosingRemark { get=>m_IsClosingRemark; set { m_IsClosingRemark = value; NotifyPropertyChanged(); }}
		public tWorkOrderRemark()
		{
		}
	}
	public partial class tWorkOrderService : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_LineNumber;
		public int LineNumber { get=>m_LineNumber; set { m_LineNumber = value; NotifyPropertyChanged(); }}
		private int m_ServiceItemID;
		public int ServiceItemID { get=>m_ServiceItemID; set { m_ServiceItemID = value; NotifyPropertyChanged(); }}
		private string m_ProgressStatus = "";
		public string ProgressStatus { get=>m_ProgressStatus; set { m_ProgressStatus = value; NotifyPropertyChanged(); }}
		private int m_TechnicianID;
		public int TechnicianID { get=>m_TechnicianID; set { m_TechnicianID = value; NotifyPropertyChanged(); }}
		private int m_ContractID;
		public int ContractID { get=>m_ContractID; set { m_ContractID = value; NotifyPropertyChanged(); }}
		private int m_ContractLineNumber;
		public int ContractLineNumber { get=>m_ContractLineNumber; set { m_ContractLineNumber = value; NotifyPropertyChanged(); }}
		private int m_CreatingUserID;
		public int CreatingUserID { get=>m_CreatingUserID; set { m_CreatingUserID = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTime;
		public DateTime? CreatedTime { get=>m_CreatedTime; set { m_CreatedTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_CreatedTimeUtc;
		public DateTime? CreatedTimeUtc { get=>m_CreatedTimeUtc; set { m_CreatedTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_AssignTime;
		public DateTime? AssignTime { get=>m_AssignTime; set { m_AssignTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_AssignTimeUtc;
		public DateTime? AssignTimeUtc { get=>m_AssignTimeUtc; set { m_AssignTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_DispatchTime;
		public DateTime? DispatchTime { get=>m_DispatchTime; set { m_DispatchTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_DispatchTimeUtc;
		public DateTime? DispatchTimeUtc { get=>m_DispatchTimeUtc; set { m_DispatchTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_ArrivalTime;
		public DateTime? ArrivalTime { get=>m_ArrivalTime; set { m_ArrivalTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_ArrivalTimeUtc;
		public DateTime? ArrivalTimeUtc { get=>m_ArrivalTimeUtc; set { m_ArrivalTimeUtc = value; NotifyPropertyChanged(); }}
		private DateTime? m_CompeleteTime;
		public DateTime? CompeleteTime { get=>m_CompeleteTime; set { m_CompeleteTime = value; NotifyPropertyChanged(); }}
		private DateTime? m_CompleteTimeUtc;
		public DateTime? CompleteTimeUtc { get=>m_CompleteTimeUtc; set { m_CompleteTimeUtc = value; NotifyPropertyChanged(); }}
		private int m_TravelTime;
		public int TravelTime { get=>m_TravelTime; set { m_TravelTime = value; NotifyPropertyChanged(); }}
		private int m_OnSiteTime;
		public int OnSiteTime { get=>m_OnSiteTime; set { m_OnSiteTime = value; NotifyPropertyChanged(); }}
		private int m_ReturnTravelTime;
		public int ReturnTravelTime { get=>m_ReturnTravelTime; set { m_ReturnTravelTime = value; NotifyPropertyChanged(); }}
		private int m_ProblemID;
		public int ProblemID { get=>m_ProblemID; set { m_ProblemID = value; NotifyPropertyChanged(); }}
		private int m_SolutionID;
		public int SolutionID { get=>m_SolutionID; set { m_SolutionID = value; NotifyPropertyChanged(); }}
		private string m_SuspensionReason = "";
		public string SuspensionReason { get=>m_SuspensionReason; set { m_SuspensionReason = value; NotifyPropertyChanged(); }}
		private int m_BillingRateID;
		public int BillingRateID { get=>m_BillingRateID; set { m_BillingRateID = value; NotifyPropertyChanged(); }}
		private string m_BillableReason = "";
		public string BillableReason { get=>m_BillableReason; set { m_BillableReason = value; NotifyPropertyChanged(); }}
		public tWorkOrderService()
		{
		}
	}
	public partial class tWorkOrderTax : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_WorkOrderID;
		public int WorkOrderID { get=>m_WorkOrderID; set { m_WorkOrderID = value; NotifyPropertyChanged(); }}
		private int m_TaxID;
		public int TaxID { get=>m_TaxID; set { m_TaxID = value; NotifyPropertyChanged(); }}
		private decimal m_TaxableAmount;
		public decimal TaxableAmount { get=>m_TaxableAmount; set { m_TaxableAmount = value; NotifyPropertyChanged(); }}
		private decimal m_Tax;
		public decimal Tax { get=>m_Tax; set { m_Tax = value; NotifyPropertyChanged(); }}
		public tWorkOrderTax()
		{
		}
	}
	public partial class vCustomerSite : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_SiteID;
		public int SiteID { get=>m_SiteID; set { m_SiteID = value; NotifyPropertyChanged(); }}
		private int m_CustomerID;
		public int CustomerID { get=>m_CustomerID; set { m_CustomerID = value; NotifyPropertyChanged(); }}
		private string m_SiteName = "";
		public string SiteName { get=>m_SiteName; set { m_SiteName = value; NotifyPropertyChanged(); }}
		private string m_Address = "";
		public string Address { get=>m_Address; set { m_Address = value; NotifyPropertyChanged(); }}
		private string m_City = "";
		public string City { get=>m_City; set { m_City = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private string m_PostalCode = "";
		public string PostalCode { get=>m_PostalCode; set { m_PostalCode = value; NotifyPropertyChanged(); }}
		private string m_Country = "";
		public string Country { get=>m_Country; set { m_Country = value; NotifyPropertyChanged(); }}
		private string m_Contact = "";
		public string Contact { get=>m_Contact; set { m_Contact = value; NotifyPropertyChanged(); }}
		private string m_Phone = "";
		public string Phone { get=>m_Phone; set { m_Phone = value; NotifyPropertyChanged(); }}
		private string m_MobilePhone = "";
		public string MobilePhone { get=>m_MobilePhone; set { m_MobilePhone = value; NotifyPropertyChanged(); }}
		private string m_Email = "";
		public string Email { get=>m_Email; set { m_Email = value; NotifyPropertyChanged(); }}
		private string m_TimeZone = "";
		public string TimeZone { get=>m_TimeZone; set { m_TimeZone = value; NotifyPropertyChanged(); }}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		private int m_SlaZoneID;
		public int SlaZoneID { get=>m_SlaZoneID; set { m_SlaZoneID = value; NotifyPropertyChanged(); }}
		private string m_CustomerName = "";
		public string CustomerName { get=>m_CustomerName; set { m_CustomerName = value; NotifyPropertyChanged(); }}
		public vCustomerSite()
		{
		}
	}
	public partial class vItemInfo : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_ItemID;
		public int ItemID { get=>m_ItemID; set { m_ItemID = value; NotifyPropertyChanged(); }}
		private int m_CategoryID;
		public int CategoryID { get=>m_CategoryID; set { m_CategoryID = value; NotifyPropertyChanged(); }}
		private string m_ItemDesc = "";
		public string ItemDesc { get=>m_ItemDesc; set { m_ItemDesc = value; NotifyPropertyChanged(); }}
		private string m_ItemNumber = "";
		public string ItemNumber { get=>m_ItemNumber; set { m_ItemNumber = value; NotifyPropertyChanged(); }}
		private string m_ItemType = "";
		public string ItemType { get=>m_ItemType; set { m_ItemType = value; NotifyPropertyChanged(); }}
		private string m_ItemStatus = "";
		public string ItemStatus { get=>m_ItemStatus; set { m_ItemStatus = value; NotifyPropertyChanged(); }}
		private decimal m_Price;
		public decimal Price { get=>m_Price; set { m_Price = value; NotifyPropertyChanged(); }}
		private decimal m_UnitCost;
		public decimal UnitCost { get=>m_UnitCost; set { m_UnitCost = value; NotifyPropertyChanged(); }}
		private bool m_Selected;
		public bool Selected { get=>m_Selected; set { m_Selected = value; NotifyPropertyChanged(); }}
		public vItemInfo()
		{
		}
	}
	public partial class vTerritoryInfo : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		private string m_TerritoryDesc = "";
		public string TerritoryDesc { get=>m_TerritoryDesc; set { m_TerritoryDesc = value; NotifyPropertyChanged(); }}
		private string m_Province = "";
		public string Province { get=>m_Province; set { m_Province = value; NotifyPropertyChanged(); }}
		private bool m_Selected;
		public bool Selected { get=>m_Selected; set { m_Selected = value; NotifyPropertyChanged(); }}
		public vTerritoryInfo()
		{
		}
	}
	public partial class vUserService : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private int m_ServiceItemID;
		public int ServiceItemID { get=>m_ServiceItemID; set { m_ServiceItemID = value; NotifyPropertyChanged(); }}
		private string m_ItemDesc = "";
		public string ItemDesc { get=>m_ItemDesc; set { m_ItemDesc = value; NotifyPropertyChanged(); }}
		public vUserService()
		{
		}
	}
	public partial class vUserTerritory : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void NotifyPropertyChanged([CallerMemberName] string name = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}
		private int m_UserID;
		public int UserID { get=>m_UserID; set { m_UserID = value; NotifyPropertyChanged(); }}
		private int m_TerritoryID;
		public int TerritoryID { get=>m_TerritoryID; set { m_TerritoryID = value; NotifyPropertyChanged(); }}
		private string m_TerritoryDesc = "";
		public string TerritoryDesc { get=>m_TerritoryDesc; set { m_TerritoryDesc = value; NotifyPropertyChanged(); }}
		public vUserTerritory()
		{
		}
	}
}
