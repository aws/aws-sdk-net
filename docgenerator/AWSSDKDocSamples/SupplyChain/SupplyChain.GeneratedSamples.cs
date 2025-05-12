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

        public void SupplyChainCreateDataIntegrationFlow()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.CreateDataIntegrationFlow(new CreateDataIntegrationFlowRequest 
            {
                Name = "testStagingFlow",
                InstanceId = "8850c54e-e187-4fa7-89d4-6370f165174d",
                Sources = new List<DataIntegrationFlowSource> {
                    new DataIntegrationFlowSource {
                        S3Source = new DataIntegrationFlowS3SourceConfiguration {
                            BucketName = "aws-supply-chain-data-b8c7bb28-a576-4334-b481-6d6e8e47371f",
                            Prefix = "example-prefix"
                        },
                        SourceName = "testSourceName",
                        SourceType = "S3"
                    }
                },
                Tags = new Dictionary<string, string> {
                    { "tagKey1", "tagValue1" }
                },
                Target = new DataIntegrationFlowTarget {
                    DatasetTarget = new DataIntegrationFlowDatasetTargetConfiguration { DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/default/datasets/my_staging_dataset" },
                    TargetType = "DATASET"
                },
                Transformation = new DataIntegrationFlowTransformation {
                    SqlTransformation = new DataIntegrationFlowSQLTransformationConfiguration { Query = "SELECT * FROM testSourceName" },
                    TransformationType = "SQL"
                }
            });

            string name = response.Name;
            string instanceId = response.InstanceId;

            #endregion
        }

        public void SupplyChainCreateDataIntegrationFlow()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.CreateDataIntegrationFlow(new CreateDataIntegrationFlowRequest 
            {
                Name = "trading-partner",
                InstanceId = "8850c54e-e187-4fa7-89d4-6370f165174d",
                Sources = new List<DataIntegrationFlowSource> {
                    new DataIntegrationFlowSource {
                        DatasetSource = new DataIntegrationFlowDatasetSourceConfiguration { DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/default/datasets/my_staging_dataset1" },
                        SourceName = "testSourceName1",
                        SourceType = "DATASET"
                    },
                    new DataIntegrationFlowSource {
                        DatasetSource = new DataIntegrationFlowDatasetSourceConfiguration { DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/default/datasets/my_staging_dataset2" },
                        SourceName = "testSourceName2",
                        SourceType = "DATASET"
                    }
                },
                Tags = new Dictionary<string, string> {
                    { "tagKey1", "tagValue1" }
                },
                Target = new DataIntegrationFlowTarget {
                    DatasetTarget = new DataIntegrationFlowDatasetTargetConfiguration {
                        DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/asc/datasets/trading_partner",
                        Options = new DataIntegrationFlowDatasetOptions {
                            DedupeRecords = true,
                            DedupeStrategy = new DataIntegrationFlowDedupeStrategy {
                                Type = "FIELD_PRIORITY",
                                FieldPriority = new DataIntegrationFlowFieldPriorityDedupeStrategyConfiguration { Fields = new List<DataIntegrationFlowFieldPriorityDedupeField> {
                                    new DataIntegrationFlowFieldPriorityDedupeField {
                                        Name = "eff_start_date",
                                        SortOrder = "DESC"
                                    }
                                } }
                            },
                            LoadType = "REPLACE"
                        }
                    },
                    TargetType = "DATASET"
                },
                Transformation = new DataIntegrationFlowTransformation {
                    SqlTransformation = new DataIntegrationFlowSQLTransformationConfiguration { Query = "SELECT S1.id AS id, S1.poc_org_unit_description AS description, S1.company_id AS company_id, S1.tpartner_type AS tpartner_type, S1.geo_id AS geo_id, S1.eff_start_date AS eff_start_date, S1.eff_end_date AS eff_end_date FROM testSourceName1 AS S1 LEFT JOIN testSourceName2 as S2 ON S1.id=S2.id" },
                    TransformationType = "SQL"
                }
            });

            string name = response.Name;
            string instanceId = response.InstanceId;

            #endregion
        }

        public void SupplyChainCreateDataLakeDataset()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.CreateDataLakeDataset(new CreateDataLakeDatasetRequest 
            {
                Name = "inbound_order",
                Description = "This is an AWS Supply Chain inbound order dataset",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "asc",
                Tags = new Dictionary<string, string> {
                    { "tagKey1", "tagValue1" },
                    { "tagKey2", "tagValue2" }
                }
            });

            DataLakeDataset dataset = response.Dataset;

            #endregion
        }

        public void SupplyChainCreateDataLakeDataset()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.CreateDataLakeDataset(new CreateDataLakeDatasetRequest 
            {
                Name = "my_dataset",
                Description = "This is a custom dataset",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "default",
                PartitionSpec = new DataLakeDatasetPartitionSpec { Fields = new List<DataLakeDatasetPartitionField> {
                    new DataLakeDatasetPartitionField {
                        Name = "creation_time",
                        Transform = new DataLakeDatasetPartitionFieldTransform { Type = "DAY" }
                    },
                    new DataLakeDatasetPartitionField {
                        Name = "description",
                        Transform = new DataLakeDatasetPartitionFieldTransform { Type = "IDENTITY" }
                    }
                } },
                Schema = new DataLakeDatasetSchema {
                    Name = "MyDataset",
                    Fields = new List<DataLakeDatasetSchemaField> {
                        new DataLakeDatasetSchemaField {
                            Name = "id",
                            Type = "INT",
                            IsRequired = true
                        },
                        new DataLakeDatasetSchemaField {
                            Name = "description",
                            Type = "STRING",
                            IsRequired = true
                        },
                        new DataLakeDatasetSchemaField {
                            Name = "price",
                            Type = "DOUBLE",
                            IsRequired = false
                        },
                        new DataLakeDatasetSchemaField {
                            Name = "creation_time",
                            Type = "TIMESTAMP",
                            IsRequired = false
                        },
                        new DataLakeDatasetSchemaField {
                            Name = "quantity",
                            Type = "LONG",
                            IsRequired = false
                        }
                    },
                    PrimaryKeys = new List<DataLakeDatasetPrimaryKeyField> {
                        new DataLakeDatasetPrimaryKeyField { Name = "id" }
                    }
                },
                Tags = new Dictionary<string, string> {
                    { "tagKey1", "tagValue1" },
                    { "tagKey2", "tagValue2" }
                }
            });

            DataLakeDataset dataset = response.Dataset;

            #endregion
        }

        public void SupplyChainCreateDataLakeNamespace()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.CreateDataLakeNamespace(new CreateDataLakeNamespaceRequest 
            {
                Name = "my_namespace",
                Description = "This is my AWS Supply Chain namespace",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Tags = new Dictionary<string, string> {
                    { "tagKey1", "tagValue1" },
                    { "tagKey2", "tagValue2" }
                }
            });

            DataLakeNamespace awsNamespace = response.Namespace;

            #endregion
        }

        public void SupplyChainCreateInstance()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.CreateInstance(new CreateInstanceRequest 
            {
                InstanceDescription = "example instance description",
                InstanceName = "example instance name",
                KmsKeyArn = "arn:aws:kms:us-west-2:123456789012:key/b14ffc39-b7d4-45ab-991a-6257a7f0d24d",
                Tags = new Dictionary<string, string> {
                    { "tagKey1", "tagValue1" }
                }
            });

            Instance instance = response.Instance;

            #endregion
        }

        public void SupplyChainCreateInstance()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.CreateInstance(new CreateInstanceRequest 
            {
            });

            Instance instance = response.Instance;

            #endregion
        }

        public void SupplyChainDeleteDataIntegrationFlow()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.DeleteDataIntegrationFlow(new DeleteDataIntegrationFlowRequest 
            {
                Name = "testStagingFlow",
                InstanceId = "8850c54e-e187-4fa7-89d4-6370f165174d"
            });

            string name = response.Name;
            string instanceId = response.InstanceId;

            #endregion
        }

        public void SupplyChainDeleteDataLakeDataset()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.DeleteDataLakeDataset(new DeleteDataLakeDatasetRequest 
            {
                Name = "inbound_order",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "asc"
            });

            string name = response.Name;
            string instanceId = response.InstanceId;
            string awsNamespace = response.Namespace;

            #endregion
        }

        public void SupplyChainDeleteDataLakeDataset()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.DeleteDataLakeDataset(new DeleteDataLakeDatasetRequest 
            {
                Name = "my_dataset",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "default"
            });

            string name = response.Name;
            string instanceId = response.InstanceId;
            string awsNamespace = response.Namespace;

            #endregion
        }

        public void SupplyChainDeleteDataLakeNamespace()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.DeleteDataLakeNamespace(new DeleteDataLakeNamespaceRequest 
            {
                Name = "my_namespace",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5"
            });

            string name = response.Name;
            string instanceId = response.InstanceId;

            #endregion
        }

        public void SupplyChainDeleteInstance()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.DeleteInstance(new DeleteInstanceRequest 
            {
                InstanceId = "9e193580-7cc5-45f7-9609-c43ba0ada793"
            });

            Instance instance = response.Instance;

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

        public void SupplyChainGetDataIntegrationEvent()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataIntegrationEvent(new GetDataIntegrationEventRequest 
            {
                EventId = "19739c8e-cd2e-4cbc-a2f7-0dc43239f042",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            DataIntegrationEvent event = response.Event;

            #endregion
        }

        public void SupplyChainGetDataIntegrationFlow()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataIntegrationFlow(new GetDataIntegrationFlowRequest 
            {
                Name = "testStagingFlow",
                InstanceId = "8850c54e-e187-4fa7-89d4-6370f165174d"
            });

            DataIntegrationFlow flow = response.Flow;

            #endregion
        }

        public void SupplyChainGetDataIntegrationFlowExecution()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataIntegrationFlowExecution(new GetDataIntegrationFlowExecutionRequest 
            {
                ExecutionId = "edbbdd3f-c0f9-49d9-ab01-f64542f803b7",
                FlowName = "source-product",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            DataIntegrationFlowExecution flowExecution = response.FlowExecution;

            #endregion
        }

        public void SupplyChainGetDataIntegrationFlowExecution()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataIntegrationFlowExecution(new GetDataIntegrationFlowExecutionRequest 
            {
                ExecutionId = "9daf6071-d12c-4eef-864c-73cea2557825",
                FlowName = "target-product",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            DataIntegrationFlowExecution flowExecution = response.FlowExecution;

            #endregion
        }

        public void SupplyChainGetDataLakeDataset()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataLakeDataset(new GetDataLakeDatasetRequest 
            {
                Name = "inbound_order",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "asc"
            });

            DataLakeDataset dataset = response.Dataset;

            #endregion
        }

        public void SupplyChainGetDataLakeDataset()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataLakeDataset(new GetDataLakeDatasetRequest 
            {
                Name = "my_dataset",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "default"
            });

            DataLakeDataset dataset = response.Dataset;

            #endregion
        }

        public void SupplyChainGetDataLakeNamespace()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataLakeNamespace(new GetDataLakeNamespaceRequest 
            {
                Name = "my_namespace",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5"
            });

            DataLakeNamespace awsNamespace = response.Namespace;

            #endregion
        }

        public void SupplyChainGetDataLakeNamespace()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.GetDataLakeNamespace(new GetDataLakeNamespaceRequest 
            {
                Name = "asc",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5"
            });

            DataLakeNamespace awsNamespace = response.Namespace;

            #endregion
        }

        public void SupplyChainGetInstance()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.GetInstance(new GetInstanceRequest 
            {
                InstanceId = "9e193580-7cc5-45f7-9609-c43ba0ada793"
            });

            Instance instance = response.Instance;

            #endregion
        }

        public void SupplyChainGetInstance()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.GetInstance(new GetInstanceRequest 
            {
                InstanceId = "9e193580-7cc5-45f7-9609-c43ba0ada793"
            });

            Instance instance = response.Instance;

            #endregion
        }

        public void SupplyChainListDataIntegrationEvents()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.ListDataIntegrationEvents(new ListDataIntegrationEventsRequest 
            {
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            List<DataIntegrationEvent> events = response.Events;

            #endregion
        }

        public void SupplyChainListDataIntegrationFlowExecutions()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.ListDataIntegrationFlowExecutions(new ListDataIntegrationFlowExecutionsRequest 
            {
                FlowName = "source-product",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            List<DataIntegrationFlowExecution> flowExecutions = response.FlowExecutions;

            #endregion
        }

        public void SupplyChainListDataIntegrationFlows()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.ListDataIntegrationFlows(new ListDataIntegrationFlowsRequest 
            {
                InstanceId = "8850c54e-e187-4fa7-89d4-6370f165174d"
            });

            List<DataIntegrationFlow> flows = response.Flows;

            #endregion
        }

        public void SupplyChainListDataLakeDatasets()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.ListDataLakeDatasets(new ListDataLakeDatasetsRequest 
            {
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "asc"
            });

            List<DataLakeDataset> datasets = response.Datasets;

            #endregion
        }

        public void SupplyChainListDataLakeDatasets()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.ListDataLakeDatasets(new ListDataLakeDatasetsRequest 
            {
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                MaxResults = 2,
                Namespace = "default",
                NextToken = "next_token_returned_from_previous_list_request"
            });

            List<DataLakeDataset> datasets = response.Datasets;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SupplyChainListDataLakeNamespaces()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.ListDataLakeNamespaces(new ListDataLakeNamespacesRequest 
            {
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5"
            });

            List<DataLakeNamespace> namespaces = response.Namespaces;

            #endregion
        }

        public void SupplyChainListDataLakeNamespaces()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.ListDataLakeNamespaces(new ListDataLakeNamespacesRequest 
            {
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                MaxResults = 1,
                NextToken = "next_token_returned_from_previous_list_request"
            });

            List<DataLakeNamespace> namespaces = response.Namespaces;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SupplyChainListInstances()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.ListInstances(new ListInstancesRequest 
            {
            });

            List<Instance> instances = response.Instances;

            #endregion
        }

        public void SupplyChainListInstances()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.ListInstances(new ListInstancesRequest 
            {
                InstanceNameFilter = new List<string> {
                    "example instance name"
                },
                InstanceStateFilter = new List<string> {
                    "Active"
                }
            });

            List<Instance> instances = response.Instances;

            #endregion
        }

        public void SupplyChainListInstances()
        {
            #region example-3

            var client = new AmazonSupplyChainClient();
            var response = client.ListInstances(new ListInstancesRequest 
            {
                MaxResults = 1
            });

            List<Instance> instances = response.Instances;
            string nextToken = response.NextToken;

            #endregion
        }

        public void SupplyChainListInstances()
        {
            #region example-4

            var client = new AmazonSupplyChainClient();
            var response = client.ListInstances(new ListInstancesRequest 
            {
                MaxResults = 1,
                NextToken = "AAQA-EFRSURBSGhtcng0c0dxbENwUHdnckVIbkFYNU1QVjRTZWN2ak5iMFVicC8zemlHOVF3SEpjSC9WTWJVVXBMV2Z1N3ZvZlQ0WEFBQUFmakI4QmdrcWhraUc5dzBCQndhZ2J6QnRBZ0VBTUdnR0NTcUdTSWIzRFFFSEFUQWVCZ2xnaGtnQlpRTUVBUzR3RVFRTTJibW9LemgrSWZTY0RaZEdBZ0VRZ0R2dDhsQnVGbGJ0dnFTZityWmNSWEVPbG93emJoSjhxOGNMbGQ1UGMvY0VRbWlTR3pQUFd4N2RraXY5Y0ovcS9vSmFYZVBGdWVHaU0zWmd0dz09n-rC1ejA5--7ltJxpDT2xP_i8xGqDPMOZfjpp8q6l5NuP9_bnBURvwwYhdqDriMK5_f96LuPEnPbuML-ItfgEiCcUy0p2tApvpZkZqOG5fbqP-4C5aDYPTffHLyq-MMqvfrGVJzL1nvkpZcnTkVR9VJsu5b8I0qqDW0H8EMKGgTo78U9lr4sj3Usi9VMwZxgKCBmr03HhFLYXOW--XMbIx0CTZF0fYIcRxmA_sVS6J7gpaB9yMcnzs5VUKokoA5JTcAPY5d1Y1VyE8KKxv51cfPgXw8OYCDbFQncw8mZPmE-VqxjFbksmk_FmghpPn9j2Ppoe-zr0LQ%3D"
            });

            List<Instance> instances = response.Instances;

            #endregion
        }

        public void SupplyChainListTagsForResource()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/data-integration-flows/my_flow1"
            });

            Dictionary<string, string> tags = response.Tags;

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

        public void SupplyChainSendDataIntegrationEvent()
        {
            #region example-16

            var client = new AmazonSupplyChainClient();
            var response = client.SendDataIntegrationEvent(new SendDataIntegrationEventRequest 
            {
                Data = "{\"dataset_id\": \"datset-id-test-123\" }",
                DatasetTarget = new DataIntegrationEventDatasetTargetConfiguration {
                    DatasetIdentifier = "arn:aws:scn:us-west-2:135808960812:instance/8928ae12-15e5-4441-825d-ec2184f0a43a/namespaces/asc/datasets/product",
                    OperationType = "APPEND"
                },
                EventGroupId = "datasetId",
                EventTimestamp = DateTime.UtcNow,
                EventType = "scn.data.dataset",
                InstanceId = "8928ae12-15e5-4441-825d-ec2184f0a43a"
            });

            string eventId = response.EventId;

            #endregion
        }

        public void SupplyChainTagResource()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.TagResource(new TagResourceRequest 
            {
                ResourceArn = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/data-integration-flows/my_flow1",
                Tags = new Dictionary<string, string> {
                    { "tagKey1", "tagValue1" }
                }
            });


            #endregion
        }

        public void SupplyChainUntagResource()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.UntagResource(new UntagResourceRequest 
            {
                ResourceArn = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/data-integration-flows/my_flow1",
                TagKeys = new List<string> {
                    "tagKey1"
                }
            });


            #endregion
        }

        public void SupplyChainUpdateDataIntegrationFlow()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.UpdateDataIntegrationFlow(new UpdateDataIntegrationFlowRequest 
            {
                Name = "testStagingFlow",
                InstanceId = "8850c54e-e187-4fa7-89d4-6370f165174d",
                Sources = new List<DataIntegrationFlowSource> {
                    new DataIntegrationFlowSource {
                        S3Source = new DataIntegrationFlowS3SourceConfiguration {
                            BucketName = "aws-supply-chain-data-b8c7bb28-a576-4334-b481-6d6e8e47371f",
                            Prefix = "example-prefix"
                        },
                        SourceName = "testSourceName",
                        SourceType = "S3"
                    }
                },
                Target = new DataIntegrationFlowTarget {
                    DatasetTarget = new DataIntegrationFlowDatasetTargetConfiguration { DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/default/datasets/my_staging_dataset" },
                    TargetType = "DATASET"
                },
                Transformation = new DataIntegrationFlowTransformation {
                    SqlTransformation = new DataIntegrationFlowSQLTransformationConfiguration { Query = "SELECT connection_id, bukrs AS id, txtmd AS description FROM testSourceName WHERE langu = 'E'" },
                    TransformationType = "SQL"
                }
            });

            DataIntegrationFlow flow = response.Flow;

            #endregion
        }

        public void SupplyChainUpdateDataIntegrationFlow()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.UpdateDataIntegrationFlow(new UpdateDataIntegrationFlowRequest 
            {
                Name = "trading-partner",
                InstanceId = "8850c54e-e187-4fa7-89d4-6370f165174d",
                Sources = new List<DataIntegrationFlowSource> {
                    new DataIntegrationFlowSource {
                        DatasetSource = new DataIntegrationFlowDatasetSourceConfiguration { DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/default/datasets/my_staging_dataset1" },
                        SourceName = "testSourceName1",
                        SourceType = "DATASET"
                    },
                    new DataIntegrationFlowSource {
                        DatasetSource = new DataIntegrationFlowDatasetSourceConfiguration { DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/default/datasets/my_staging_dataset2_updated" },
                        SourceName = "testSourceName2",
                        SourceType = "DATASET"
                    }
                },
                Target = new DataIntegrationFlowTarget {
                    DatasetTarget = new DataIntegrationFlowDatasetTargetConfiguration {
                        DatasetIdentifier = "arn:aws:scn:us-east-1:123456789012:instance/8850c54e-e187-4fa7-89d4-6370f165174d/namespaces/asc/datasets/trading_partner",
                        Options = new DataIntegrationFlowDatasetOptions {
                            DedupeRecords = true,
                            DedupeStrategy = new DataIntegrationFlowDedupeStrategy {
                                Type = "FIELD_PRIORITY",
                                FieldPriority = new DataIntegrationFlowFieldPriorityDedupeStrategyConfiguration { Fields = new List<DataIntegrationFlowFieldPriorityDedupeField> {
                                    new DataIntegrationFlowFieldPriorityDedupeField {
                                        Name = "eff_start_date",
                                        SortOrder = "ASC"
                                    }
                                } }
                            },
                            LoadType = "REPLACE"
                        }
                    },
                    TargetType = "DATASET"
                },
                Transformation = new DataIntegrationFlowTransformation {
                    SqlTransformation = new DataIntegrationFlowSQLTransformationConfiguration { Query = "SELECT S1.id AS id, S1.poc_org_unit_description AS description, S1.company_id AS company_id, S1.tpartner_type AS tpartner_type, S1.geo_id AS geo_id, S1.eff_start_date AS eff_start_date, S1.eff_end_date AS eff_end_date FROM testSourceName1 AS S1 LEFT JOIN testSourceName2 as S2 ON S1.id=S2.id" },
                    TransformationType = "SQL"
                }
            });

            DataIntegrationFlow flow = response.Flow;

            #endregion
        }

        public void SupplyChainUpdateDataLakeDataset()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.UpdateDataLakeDataset(new UpdateDataLakeDatasetRequest 
            {
                Name = "inbound_order",
                Description = "This is an updated AWS Supply Chain inbound order dataset",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "asc"
            });

            DataLakeDataset dataset = response.Dataset;

            #endregion
        }

        public void SupplyChainUpdateDataLakeDataset()
        {
            #region example-2

            var client = new AmazonSupplyChainClient();
            var response = client.UpdateDataLakeDataset(new UpdateDataLakeDatasetRequest 
            {
                Name = "my_dataset",
                Description = "This is an updated custom dataset",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5",
                Namespace = "default"
            });

            DataLakeDataset dataset = response.Dataset;

            #endregion
        }

        public void SupplyChainUpdateDataLakeNamespace()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.UpdateDataLakeNamespace(new UpdateDataLakeNamespaceRequest 
            {
                Name = "my_namespace",
                Description = "This is an updated AWS Supply Chain namespace",
                InstanceId = "1877dd20-dee9-4639-8e99-cb67acf21fe5"
            });

            DataLakeNamespace awsNamespace = response.Namespace;

            #endregion
        }

        public void SupplyChainUpdateInstance()
        {
            #region example-1

            var client = new AmazonSupplyChainClient();
            var response = client.UpdateInstance(new UpdateInstanceRequest 
            {
                InstanceDescription = "updated example instance description",
                InstanceId = "9e193580-7cc5-45f7-9609-c43ba0ada793",
                InstanceName = "updated example instance name"
            });

            Instance instance = response.Instance;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}