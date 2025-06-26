using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.IoTManagedIntegrations;
using Amazon.IoTManagedIntegrations.Model;

namespace AWSSDKDocSamples.Amazon.IoTManagedIntegrations.Generated
{
    class IoTManagedIntegrationsSamples : ISample
    {
        public void IoTManagedIntegrationsCreateCloudConnector()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.CreateCloudConnector(new CreateCloudConnectorRequest 
            {
                ClientToken = "1234567890",
                EndpointConfig = new EndpointConfig { Lambda = new LambdaConfig { Arn = "arn:aws:lambda:us-east-1:111122223333:function:my-function:myVersion" } },
                EndpointType = "LAMBDA",
                Name = "Connector for TP Link Cloud"
            });

            string id = response.Id;

            #endregion
        }

        public void IoTManagedIntegrationsCreateCloudConnector()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.CreateCloudConnector(new CreateCloudConnectorRequest 
            {
                ClientToken = "12312321",
                EndpointConfig = new EndpointConfig { Lambda = new LambdaConfig { Arn = "arn:aws:lambda:us-east-1:111122223333:function:my-function:myVersion" } },
                EndpointType = "LAMBDA",
                Name = "Connector for Ring Cloud"
            });

            string id = response.Id;

            #endregion
        }

        public void IoTManagedIntegrationsCreateCloudConnector()
        {
            #region example-3

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.CreateCloudConnector(new CreateCloudConnectorRequest 
            {
                ClientToken = "1213123123",
                EndpointConfig = new EndpointConfig { Lambda = new LambdaConfig { Arn = "arn:aws:lambda:us-east-1:111122223333:function:my-function:myVersion2" } },
                EndpointType = "LAMBDA",
                Name = "Connector for Ring Cloud"
            });


            #endregion
        }

        public void IoTManagedIntegrationsGetCloudConnector()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetCloudConnector(new GetCloudConnectorRequest 
            {
                Identifier = "123456789012"
            });

            EndpointConfig endpointConfig = response.EndpointConfig;
            string endpointType = response.EndpointType;
            string id = response.Id;
            string name = response.Name;

            #endregion
        }

        public void IoTManagedIntegrationsGetCloudConnector()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetCloudConnector(new GetCloudConnectorRequest 
            {
                Identifier = "123456789012"
            });

            EndpointConfig endpointConfig = response.EndpointConfig;
            string name = response.Name;

            #endregion
        }

        public void IoTManagedIntegrationsGetCloudConnector()
        {
            #region example-3

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetCloudConnector(new GetCloudConnectorRequest 
            {
                Identifier = "123456789012"
            });


            #endregion
        }

        public void IoTManagedIntegrationsGetSchemaVersion()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetSchemaVersion(new GetSchemaVersionRequest 
            {
                SchemaVersionedId = "matter.ColorControl@1.4",
                Type = "capability"
            });

            string description = response.Description;
            string awsNamespace = response.Namespace;
            SchemaVersionSchema schema = response.Schema;
            string schemaId = response.SchemaId;
            string semanticVersion = response.SemanticVersion;
            string type = response.Type;

            #endregion
        }

        public void IoTManagedIntegrationsGetSchemaVersion()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetSchemaVersion(new GetSchemaVersionRequest 
            {
                Format = "ZCL",
                SchemaVersionedId = "matter.ColorControl@1.4",
                Type = "capability"
            });

            string description = response.Description;
            string awsNamespace = response.Namespace;
            SchemaVersionSchema schema = response.Schema;
            string schemaId = response.SchemaId;
            string semanticVersion = response.SemanticVersion;
            string type = response.Type;

            #endregion
        }

        public void IoTManagedIntegrationsGetSchemaVersion()
        {
            #region example-3

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.GetSchemaVersion(new GetSchemaVersionRequest 
            {
                SchemaVersionedId = "matter.ColorControl@$latest",
                Type = "capability"
            });


            #endregion
        }

        public void IoTManagedIntegrationsListCloudConnectors()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListCloudConnectors(new ListCloudConnectorsRequest 
            {
                MaxResults = 5
            });

            List<ConnectorItem> items = response.Items;

            #endregion
        }

        public void IoTManagedIntegrationsListCloudConnectors()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListCloudConnectors(new ListCloudConnectorsRequest 
            {
                MaxResults = 5
            });


            #endregion
        }

        public void IoTManagedIntegrationsListSchemaVersions()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListSchemaVersions(new ListSchemaVersionsRequest 
            {
                SchemaId = "example.ColorControl",
                Type = "capability"
            });

            List<SchemaVersionListItem> items = response.Items;

            #endregion
        }

        public void IoTManagedIntegrationsListSchemaVersions()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListSchemaVersions(new ListSchemaVersionsRequest 
            {
                SemanticVersion = "34.56",
                Type = "capability"
            });

            List<SchemaVersionListItem> items = response.Items;

            #endregion
        }

        public void IoTManagedIntegrationsListSchemaVersions()
        {
            #region example-3

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.ListSchemaVersions(new ListSchemaVersionsRequest 
            {
                Namespace = "matter",
                SchemaId = "example.ColorControl",
                Type = "capability"
            });


            #endregion
        }

        public void IoTManagedIntegrationsSendConnectorEvent()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.SendConnectorEvent(new SendConnectorEventRequest 
            {
                ConnectorId = "MockConnectorId",
                DeviceDiscoveryId = "358275hbk3qr",
                Devices = new List<Device> {
                    new Device {
                        CapabilityReport = new MatterCapabilityReport {
                            Version = "1.0.0",
                            Endpoints = new List<MatterCapabilityReportEndpoint> {
                                new MatterCapabilityReportEndpoint {
                                    Clusters = new List<MatterCapabilityReportCluster> {
                                        new MatterCapabilityReportCluster {
                                            Attributes = new List<MatterCapabilityReportAttribute> {
                                                new MatterCapabilityReportAttribute {
                                                    Value = <data>,
                                                    Id = "0x0000"
                                                },
                                                new MatterCapabilityReportAttribute { Id = "0x0001" },
                                                new MatterCapabilityReportAttribute { Id = "0x0002" }
                                            },
                                            Commands = new List<string> {
                                                "0x00",
                                                "0x01"
                                            },
                                            Events = new List<string> {
                                                
                                            },
                                            Id = "0x0201",
                                            Revision = 1
                                        }
                                    },
                                    DeviceTypes = new List<string> {
                                        "Refrigerator"
                                    },
                                    Id = "EP1"
                                }
                            },
                            NodeId = "1"
                        },
                        ConnectorDeviceId = "Mock-Connector-DeviceId-1",
                        ConnectorDeviceName = "Sample-User-device-1"
                    }
                },
                Message = "Sample ConnectorEventMessage",
                Operation = "DEVICE_DISCOVERY",
                OperationVersion = "1.0",
                StatusCode = 200,
                UserId = "MockThirdPartyUserId"
            });

            string connectorId = response.ConnectorId;

            #endregion
        }

        public void IoTManagedIntegrationsSendConnectorEvent()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.SendConnectorEvent(new SendConnectorEventRequest 
            {
                ConnectorId = "MockConnectorId",
                MatterEndpoint = new MatterEndpoint {
                    Clusters = new List<MatterCluster> {
                        new MatterCluster {
                            Attributes = new MatterAttributes {
                                
                            },
                            Commands = new Dictionary<string, MatterFields> {
                                { "0x03", new MatterFields {  } }
                            },
                            Id = "0x1003"
                        }
                    },
                    Id = "1"
                },
                Message = "Sample ConnectorEventMessage",
                Operation = "DEVICE_COMMAND_RESPONSE",
                OperationVersion = "1.0",
                StatusCode = 200,
                TraceId = "9b75f3839b6140f=_1",
                UserId = "MockThirdPartyUserId"
            });

            string connectorId = response.ConnectorId;

            #endregion
        }

        public void IoTManagedIntegrationsSendConnectorEvent()
        {
            #region example-3

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.SendConnectorEvent(new SendConnectorEventRequest 
            {
                ConnectorId = "MockConnectorId",
                MatterEndpoint = new MatterEndpoint {
                    Clusters = new List<MatterCluster> {
                        new MatterCluster {
                            Attributes = new MatterAttributes {  },
                            Id = "0x1003"
                        }
                    },
                    Id = "1"
                },
                Message = "Sample ConnectorEventMessage",
                Operation = "DEVICE_EVENT",
                OperationVersion = "1.0",
                StatusCode = 200,
                TraceId = "TraceId-Sample",
                UserId = "MockThirdPartyUserId"
            });

            string connectorId = response.ConnectorId;

            #endregion
        }

        public void IoTManagedIntegrationsUpdateCloudConnector()
        {
            #region example-1

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.UpdateCloudConnector(new UpdateCloudConnectorRequest 
            {
                Identifier = "123456789012",
                Name = "Connector for TP Link Cloud V2"
            });


            #endregion
        }

        public void IoTManagedIntegrationsUpdateCloudConnector()
        {
            #region example-2

            var client = new AmazonIoTManagedIntegrationsClient();
            var response = client.UpdateCloudConnector(new UpdateCloudConnectorRequest 
            {
                Identifier = "123456789012",
                Name = "Connector for Ring Cloud"
            });


            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}