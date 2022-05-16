using System;
using System.Collections.Generic;
using EntityToDB;
using TSDataModel;
namespace TSDataDatabase
{
	public class TSDataDbHandle : DbHandle
	{
		public TSDataDbHandle(string connectiongString): base(connectiongString)
		{
		}
		protected override void OnDbConfig()
		{
			base.OnDbConfig();
			AddPrimaryKeyConfig(typeof(tBillableReason).Name, "BillableReasonID");
			AddPrimaryKeyConfig(typeof(tBillingBatch).Name, "BillingBatchID");
			AddPrimaryKeyConfig(typeof(tBillingGroup).Name, "BillingGroupID");
			AddPrimaryKeyConfig(typeof(tBillingGroupUser).Name, "BillingGroupID, UserID");
			AddPrimaryKeyConfig(typeof(tBranch).Name, "BranchID");
			AddPrimaryKeyConfig(typeof(tCallBlockAccount).Name, "CallBlockAccountID");
			AddPrimaryKeyConfig(typeof(tCallBlockTxn).Name, "CallBlockTxnID");
			AddPrimaryKeyConfig(typeof(tCarrier).Name, "CarrierID");
			AddPrimaryKeyConfig(typeof(tCategory).Name, "CategoryID");
			AddPrimaryKeyConfig(typeof(tCompany).Name, "CompanyKey");
			AddPrimaryKeyConfig(typeof(tContract).Name, "ContractID");
			AddPrimaryKeyConfig(typeof(tContractDetail).Name, "ContractID, LineNumber");
			AddPrimaryKeyConfig(typeof(tContractTax).Name, "ContractID, TaxID");
			AddPrimaryKeyConfig(typeof(tContractType).Name, "ContractTypeID");
			AddPrimaryKeyConfig(typeof(tCustomer).Name, "CustomerID");
			AddPrimaryKeyConfig(typeof(tCustomerGroup).Name, "GroupID");
			AddPrimaryKeyConfig(typeof(tCustomerService).Name, "CustomerID, ServiceItemID");
			AddPrimaryKeyConfig(typeof(tCustomerSite).Name, "SiteID");
			AddPrimaryKeyConfig(typeof(tDefectiveRecord).Name, "DefectiveRecordID");
			AddPrimaryKeyConfig(typeof(tID).Name, "IDName");
			AddPrimaryKeyConfig(typeof(tInventory).Name, "WarehouseID, ItemID");
			AddPrimaryKeyConfig(typeof(tInventoryDetail).Name, "WarehouseID, ItemID, SerialNumber");
			AddPrimaryKeyConfig(typeof(tInventoryTxn).Name, "InventoryTxnID");
			AddPrimaryKeyConfig(typeof(tItem).Name, "ItemID");
			AddPrimaryKeyConfig(typeof(tLock).Name, "LockID");
			AddPrimaryKeyConfig(typeof(tNotificationSetting).Name, "NotificationSettingID");
			AddPrimaryKeyConfig(typeof(tPage).Name, "PageID");
			AddPrimaryKeyConfig(typeof(tPermission).Name, "FunctionID, UserID");
			AddPrimaryKeyConfig(typeof(tProblem).Name, "ProblemID");
			AddPrimaryKeyConfig(typeof(tProblemGroup).Name, "ProblemGroupID");
			AddPrimaryKeyConfig(typeof(tPurchaseOrder).Name, "PurchaseOrderID");
			AddPrimaryKeyConfig(typeof(tPurchaseOrderDetail).Name, "PurchaseOrderID, LineNumber");
			AddPrimaryKeyConfig(typeof(tPurchaseOrderTax).Name, "PurchaseOrderID, TaxID");
			AddPrimaryKeyConfig(typeof(tReceiving).Name, "ReceivingID");
			AddPrimaryKeyConfig(typeof(tReceivingDetail).Name, "ReceivingID, LineNumber");
			AddPrimaryKeyConfig(typeof(tReturnShipment).Name, "ReturnShipmentID");
			AddPrimaryKeyConfig(typeof(tSchedule).Name, "ScheduleID");
			AddPrimaryKeyConfig(typeof(tScheduleDetail).Name, "ScheduleDetailID");
			AddPrimaryKeyConfig(typeof(tServiceBillngRate).Name, "BillingRateID");
			AddPrimaryKeyConfig(typeof(tServiceHour).Name, "ServiceHourID");
			AddPrimaryKeyConfig(typeof(tServiceHourDetail).Name, "ServiceHourID, DayOfWeek");
			AddPrimaryKeyConfig(typeof(tSetting).Name, "SettingID");
			AddPrimaryKeyConfig(typeof(tSla).Name, "SlaID");
			AddPrimaryKeyConfig(typeof(tSlaDetail).Name, "SlaID, ZoneNumber, ServiceItemID, Severity");
			AddPrimaryKeyConfig(typeof(tSolution).Name, "SolutionID");
			AddPrimaryKeyConfig(typeof(tStockMovement).Name, "StockMovementID");
			AddPrimaryKeyConfig(typeof(tStockShipment).Name, "ShipmentID");
			AddPrimaryKeyConfig(typeof(tTax).Name, "TaxID");
			AddPrimaryKeyConfig(typeof(tTaxCode).Name, "TaxCodeID");
			AddPrimaryKeyConfig(typeof(tTaxCodeDetail).Name, "TaxRegionID, TaxCodeID, TaxID");
			AddPrimaryKeyConfig(typeof(tTeam).Name, "TeamID");
			AddPrimaryKeyConfig(typeof(tTeamMember).Name, "TeamID");
			AddPrimaryKeyConfig(typeof(tTeamTerritory).Name, "TeamID, TerritoryID");
			AddPrimaryKeyConfig(typeof(tUser).Name, "UserID");
			AddPrimaryKeyConfig(typeof(tUserService).Name, "UserID, ServiceItemID");
			AddPrimaryKeyConfig(typeof(tUserTerritory).Name, "UserID, TerritoryID");
			AddPrimaryKeyConfig(typeof(tWarehouse).Name, "WarehouseID");
			AddPrimaryKeyConfig(typeof(tWorkOrder).Name, "WorkOrderID");
			AddPrimaryKeyConfig(typeof(tWorkOrderCharge).Name, "WorkOrderID, LineNumber");
			AddPrimaryKeyConfig(typeof(tWorkOrderNotification).Name, "WorkOrderID, LineNumber");
			AddPrimaryKeyConfig(typeof(tWorkOrderParts).Name, "WorkOrderID, LineNumber");
			AddPrimaryKeyConfig(typeof(tWorkOrderRemark).Name, "WorkOrderRemarkID");
			AddPrimaryKeyConfig(typeof(tWorkOrderService).Name, "WorkOrderID, LineNumber");
			AddPrimaryKeyConfig(typeof(tWorkOrderTax).Name, "WorkOrderID, TaxID");
		}
	}
}
