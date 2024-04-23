using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SupplyChain;
using Amazon.SupplyChain.Model;

namespace AWSSDKDocSamples.Amazon.SupplyChain.Generated
{
    class SupplyChainSamples : ISample
    {
        public void SupplyChainCreateBillOfMaterialsImportJob()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.CreateBillOfMaterialsImportJob(new CreateBillOfMaterialsImportJobRequest 
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                InstanceId = "60f82bbd-71f7-4fcd-a941-472f574c5243",
                S3uri = "s3://mybucketname/pathelemene/file.csv"
            });

            string jobId = response.JobId;

            #endregion
        }

        public void SupplyChainGetBillOfMaterialsImportJob()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.GetBillOfMaterialsImportJob(new GetBillOfMaterialsImportJobRequest 
            {
                InstanceId = "60f82bbd-71f7-4fcd-a941-472f574c5243",
                JobId = "f79b359b-1515-4436-a3bf-bae7b33e47b4"
            });

            BillOfMaterialsImportJob job = response.Job;

            #endregion
        }

        public void SupplyChainGetBillOfMaterialsImportJob()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.GetBillOfMaterialsImportJob(new GetBillOfMaterialsImportJobRequest 
            {
                InstanceId = "60f82bbd-71f7-4fcd-a941-472f574c5243",
                JobId = "f79b359b-1515-4436-a3bf-bae7b33e47b4"
            });

            BillOfMaterialsImportJob job = response.Job;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"id\": \"inbound-order-id-test-123\", \"tpartner_id\": \"partner-id-test-123\" }",
                EventGroupId = "inboundOrderId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.inboundorder",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"id\": \"inbound-order-line-id-test-123\", \"order_id\": \"order-id-test-123\", \"tpartner_id\": \"partner-id-test-123\", \"product_id\": \"product-id-test-123\", \"quantity_submitted\": \"100.0\" }",
                EventGroupId = "inboundOrderLineId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.inboundorderline",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-3

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"id\": \"inbound-order-line-schedule-id-test-123\", \"order_id\": \"order-id-test-123\", \"order_line_id\": \"order-line-id-test-123\", \"product_id\": \"product-id-test-123\"}",
                EventGroupId = "inboundOrderLineScheduleId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.inboundorderlineschedule",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-4

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"snapshot_date\": \"1672470400000\", \"product_id\": \"product-id-test-123\", \"site_id\": \"site-id-test-123\", \"region_id\": \"region-id-test-123\", \"product_group_id\": \"product-group-id-test-123\", \"forecast_start_dttm\": \"1672470400000\", \"forecast_end_dttm\": \"1672470400000\" }",
                EventGroupId = "forecastId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.forecast",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-5

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"snapshot_date\": \"1672470400000\", \"site_id\": \"site-id-test-123\", \"product_id\": \"product-id-test-123\", \"on_hand_inventory\": \"100.0\", \"inv_condition\": \"good\", \"lot_number\": \"lot-number-test-123\"}",
                EventGroupId = "inventoryLevelId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.inventorylevel",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-6

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"id\": \"outbound-orderline-id-test-123\", \"cust_order_id\": \"cust-order-id-test-123\", \"product_id\": \"product-id-test-123\" }",
                EventGroupId = "outboundOrderLineId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.outboundorderline",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-7

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"id\": \"outbound-shipment-id-test-123\", \"cust_order_id\": \"cust-order-id-test-123\", \"cust_order_line_id\": \"cust-order-line-id-test-123\", \"product_id\": \"product-id-test-123\" }",
                EventGroupId = "outboundShipmentId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.outboundshipment",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-8

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"process_id\": \"process-id-test-123\" }",
                EventGroupId = "processHeaderId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.processheader",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-9

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"process_operation_id\": \"process-operation-id-test-123\", \"process_id\": \"process-id-test-123\" }",
                EventGroupId = "processOperationId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.processoperation",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-10

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"process_product_id\": \"process-product-id-test-123\", \"process_id\": \"process-id-test-123\" }",
                EventGroupId = "processProductId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.processproduct",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-11

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"reservation_id\": \"reservation-id-test-123\", \"reservation_detail_id\": \"reservation-detail-id-test-123\" }",
                EventGroupId = "reservationId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.reservation",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-12

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"id\": \"shipment-id-test-123\", \"supplier_tpartner_id\": \"supplier-tpartner-id-test-123\", \"product_id\": \"product-id-test-123\", \"order_id\": \"order-id-test-123\", \"order_line_id\": \"order-line-id-test-123\", \"package_id\": \"package-id-test-123\" }",
                EventGroupId = "shipmentId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.shipment",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-13

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"shipment_stop_id\": \"shipment-stop-id-test-123\", \"shipment_id\": \"shipment-id-test-123\" }",
                EventGroupId = "shipmentStopId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.shipmentstop",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-14

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"shipment_stop_order_id\": \"shipment-stop-order-id-test-123\", \"shipment_stop_id\": \"shipment-stop-id-test-123\", \"shipment_id\": \"shipment-id-test-123\" }",
                EventGroupId = "shipmentStopOrderId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.shipmentstoporder",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-15

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"supply_plan_id\": \"supply-plan-id-test-123\" }",
                EventGroupId = "supplyPlanId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.supplyplan",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}