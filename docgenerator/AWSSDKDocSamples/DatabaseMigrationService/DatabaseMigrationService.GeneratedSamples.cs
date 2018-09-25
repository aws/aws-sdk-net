using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DatabaseMigrationService;
using Amazon.DatabaseMigrationService.Model;

namespace AWSSDKDocSamples.Amazon.DatabaseMigrationService.Generated
{
    class DatabaseMigrationServiceSamples : ISample
    {
        static IAmazonDatabaseMigrationService client = new AmazonDatabaseMigrationServiceClient();
        public void DatabaseMigrationServiceAddTagsToResource()
        {
            #region add-tags-to-resource-1481744141435

            var response = client.AddTagsToResource(new AddTagsToResourceRequest 
            {
                ResourceArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E", // Required. Use the ARN of the resource you want to tag.
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "1633456"
                    }
                } // Required. Use the Key/Value pair format.
            });


            #endregion
        }

        public void DatabaseMigrationServiceCreateEndpoint()
        {
            #region create-endpoint-1481746254348

            var response = client.CreateEndpoint(new CreateEndpointRequest 
            {
                CertificateArn = "",
                DatabaseName = "testdb",
                EndpointIdentifier = "test-endpoint-1",
                EndpointType = "source",
                EngineName = "mysql",
                ExtraConnectionAttributes = "",
                KmsKeyId = "arn:aws:kms:us-east-1:123456789012:key/4c1731d6-5435-ed4d-be13-d53411a7cfbd",
                Password = "pasword",
                Port = 3306,
                ServerName = "mydb.cx1llnox7iyx.us-west-2.rds.amazonaws.com",
                SslMode = "require",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "143327655"
                    }
                },
                Username = "username"
            });

            Endpoint endpoint = response.Endpoint;

            #endregion
        }

        public void DatabaseMigrationServiceCreateReplicationInstance()
        {
            #region create-replication-instance-1481746705295

            var response = client.CreateReplicationInstance(new CreateReplicationInstanceRequest 
            {
                AllocatedStorage = 123,
                AutoMinorVersionUpgrade = true,
                AvailabilityZone = "",
                EngineVersion = "",
                KmsKeyId = "",
                MultiAZ = true,
                PreferredMaintenanceWindow = "",
                PubliclyAccessible = true,
                ReplicationInstanceClass = "",
                ReplicationInstanceIdentifier = "",
                ReplicationSubnetGroupIdentifier = "",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "string",
                        Value = "string"
                    }
                },
                VpcSecurityGroupIds = new List<string> {
                    
                }
            });

            ReplicationInstance replicationInstance = response.ReplicationInstance;

            #endregion
        }

        public void DatabaseMigrationServiceCreateReplicationSubnetGroup()
        {
            #region create-replication-subnet-group-1481747297930

            var response = client.CreateReplicationSubnetGroup(new CreateReplicationSubnetGroupRequest 
            {
                ReplicationSubnetGroupDescription = "US West subnet group",
                ReplicationSubnetGroupIdentifier = "us-west-2ab-vpc-215ds366",
                SubnetIds = new List<string> {
                    "subnet-e145356n",
                    "subnet-58f79200"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "145235"
                    }
                }
            });

            ReplicationSubnetGroup replicationSubnetGroup = response.ReplicationSubnetGroup;

            #endregion
        }

        public void DatabaseMigrationServiceCreateReplicationTask()
        {
            #region create-replication-task-1481747646288

            var response = client.CreateReplicationTask(new CreateReplicationTaskRequest 
            {
                CdcStartTime = new DateTime(2016, 12, 14, 10, 25, 43, DateTimeKind.Utc),
                MigrationType = "full-load",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ",
                ReplicationTaskIdentifier = "task1",
                ReplicationTaskSettings = "",
                SourceEndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ZW5UAN6P4E77EC7YWHK4RZZ3BE",
                TableMappings = "file://mappingfile.json",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Acount",
                        Value = "24352226"
                    }
                },
                TargetEndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteCertificate()
        {
            #region delete-certificate-1481751957981

            var response = client.DeleteCertificate(new DeleteCertificateRequest 
            {
                CertificateArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUSM457DE6XFJCJQ"
            });

            Certificate certificate = response.Certificate;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteEndpoint()
        {
            #region delete-endpoint-1481752425530

            var response = client.DeleteEndpoint(new DeleteEndpointRequest 
            {
                EndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:RAAR3R22XSH46S3PWLC3NJAWKM"
            });

            Endpoint endpoint = response.Endpoint;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationInstance()
        {
            #region delete-replication-instance-1481752552839

            var response = client.DeleteReplicationInstance(new DeleteReplicationInstanceRequest 
            {
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            ReplicationInstance replicationInstance = response.ReplicationInstance;

            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationSubnetGroup()
        {
            #region delete-replication-subnet-group-1481752728597

            var response = client.DeleteReplicationSubnetGroup(new DeleteReplicationSubnetGroupRequest 
            {
                ReplicationSubnetGroupIdentifier = "us-west-2ab-vpc-215ds366"
            });


            #endregion
        }

        public void DatabaseMigrationServiceDeleteReplicationTask()
        {
            #region delete-replication-task-1481752903506

            var response = client.DeleteReplicationTask(new DeleteReplicationTaskRequest 
            {
                ReplicationTaskArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeAccountAttributes()
        {
            #region describe-acount-attributes-1481753085663

            var response = client.DescribeAccountAttributes(new DescribeAccountAttributesRequest 
            {
            });

            List<AccountQuota> accountQuotas = response.AccountQuotas;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeCertificates()
        {
            #region describe-certificates-1481753186244

            var response = client.DescribeCertificates(new DescribeCertificatesRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            List<Certificate> certificates = response.Certificates;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeConnections()
        {
            #region describe-connections-1481754477953

            var response = client.DescribeConnections(new DescribeConnectionsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            List<Connection> connections = response.Connections;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeEndpoints()
        {
            #region describe-endpoints-1481754926060

            var response = client.DescribeEndpoints(new DescribeEndpointsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            List<Endpoint> endpoints = response.Endpoints;
            string marker = response.Marker;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeEndpointTypes()
        {
            #region describe-endpoint-types-1481754742591

            var response = client.DescribeEndpointTypes(new DescribeEndpointTypesRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<SupportedEndpointType> supportedEndpointTypes = response.SupportedEndpointTypes;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeOrderableReplicationInstances()
        {
            #region describe-orderable-replication-instances-1481755123669

            var response = client.DescribeOrderableReplicationInstances(new DescribeOrderableReplicationInstancesRequest 
            {
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<OrderableReplicationInstance> orderableReplicationInstances = response.OrderableReplicationInstances;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeRefreshSchemasStatus()
        {
            #region describe-refresh-schema-status-1481755303497

            var response = client.DescribeRefreshSchemasStatus(new DescribeRefreshSchemasStatusRequest 
            {
                EndpointArn = ""
            });

            RefreshSchemasStatus refreshSchemasStatus = response.RefreshSchemasStatus;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeReplicationInstances()
        {
            #region describe-replication-instances-1481755443952

            var response = client.DescribeReplicationInstances(new DescribeReplicationInstancesRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<ReplicationInstance> replicationInstances = response.ReplicationInstances;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeReplicationSubnetGroups()
        {
            #region describe-replication-subnet-groups-1481755621284

            var response = client.DescribeReplicationSubnetGroups(new DescribeReplicationSubnetGroupsRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<ReplicationSubnetGroup> replicationSubnetGroups = response.ReplicationSubnetGroups;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeReplicationTasks()
        {
            #region describe-replication-tasks-1481755777563

            var response = client.DescribeReplicationTasks(new DescribeReplicationTasksRequest 
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "string",
                        Values = new List<string> {
                            "string",
                            "string"
                        }
                    }
                },
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<ReplicationTask> replicationTasks = response.ReplicationTasks;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeSchemas()
        {
            #region describe-schemas-1481755933924

            var response = client.DescribeSchemas(new DescribeSchemasRequest 
            {
                EndpointArn = "",
                Marker = "",
                MaxRecords = 123
            });

            string marker = response.Marker;
            List<string> schemas = response.Schemas;

            #endregion
        }

        public void DatabaseMigrationServiceDescribeTableStatistics()
        {
            #region describe-table-statistics-1481756071890

            var response = client.DescribeTableStatistics(new DescribeTableStatisticsRequest 
            {
                Marker = "",
                MaxRecords = 123,
                ReplicationTaskArn = ""
            });

            string marker = response.Marker;
            string replicationTaskArn = response.ReplicationTaskArn;
            List<TableStatistics> tableStatistics = response.TableStatistics;

            #endregion
        }

        public void DatabaseMigrationServiceImportCertificate()
        {
            #region import-certificate-1481756197206

            var response = client.ImportCertificate(new ImportCertificateRequest 
            {
                CertificateIdentifier = "",
                CertificatePem = ""
            });

            Certificate certificate = response.Certificate;

            #endregion
        }

        public void DatabaseMigrationServiceListTagsForResource()
        {
            #region list-tags-for-resource-1481761095501

            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceArn = ""
            });

            List<Tag> tagList = response.TagList;

            #endregion
        }

        public void DatabaseMigrationServiceModifyEndpoint()
        {
            #region modify-endpoint-1481761649937

            var response = client.ModifyEndpoint(new ModifyEndpointRequest 
            {
                CertificateArn = "",
                DatabaseName = "",
                EndpointArn = "",
                EndpointIdentifier = "",
                EndpointType = "source",
                EngineName = "",
                ExtraConnectionAttributes = "",
                Password = "",
                Port = 123,
                ServerName = "",
                SslMode = "require",
                Username = ""
            });

            Endpoint endpoint = response.Endpoint;

            #endregion
        }

        public void DatabaseMigrationServiceModifyReplicationInstance()
        {
            #region modify-replication-instance-1481761784746

            var response = client.ModifyReplicationInstance(new ModifyReplicationInstanceRequest 
            {
                AllocatedStorage = 123,
                AllowMajorVersionUpgrade = true,
                ApplyImmediately = true,
                AutoMinorVersionUpgrade = true,
                EngineVersion = "1.5.0",
                MultiAZ = true,
                PreferredMaintenanceWindow = "sun:06:00-sun:14:00",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ",
                ReplicationInstanceClass = "dms.t2.micro",
                ReplicationInstanceIdentifier = "test-rep-1",
                VpcSecurityGroupIds = new List<string> {
                    
                }
            });

            ReplicationInstance replicationInstance = response.ReplicationInstance;

            #endregion
        }

        public void DatabaseMigrationServiceModifyReplicationSubnetGroup()
        {
            #region modify-replication-subnet-group-1481762275392

            var response = client.ModifyReplicationSubnetGroup(new ModifyReplicationSubnetGroupRequest 
            {
                ReplicationSubnetGroupDescription = "",
                ReplicationSubnetGroupIdentifier = "",
                SubnetIds = new List<string> {
                    
                }
            });

            ReplicationSubnetGroup replicationSubnetGroup = response.ReplicationSubnetGroup;

            #endregion
        }

        public void DatabaseMigrationServiceRefreshSchemas()
        {
            #region refresh-schema-1481762399111

            var response = client.RefreshSchemas(new RefreshSchemasRequest 
            {
                EndpointArn = "",
                ReplicationInstanceArn = ""
            });

            RefreshSchemasStatus refreshSchemasStatus = response.RefreshSchemasStatus;

            #endregion
        }

        public void DatabaseMigrationServiceRemoveTagsFromResource()
        {
            #region remove-tags-from-resource-1481762571330

            var response = client.RemoveTagsFromResource(new RemoveTagsFromResourceRequest 
            {
                ResourceArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E",
                TagKeys = new List<string> {
                    
                }
            });


            #endregion
        }

        public void DatabaseMigrationServiceStartReplicationTask()
        {
            #region start-replication-task-1481762706778

            var response = client.StartReplicationTask(new StartReplicationTaskRequest 
            {
                CdcStartTime = new DateTime(2016, 12, 14, 5, 33, 20, DateTimeKind.Utc),
                ReplicationTaskArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ",
                StartReplicationTaskType = "start-replication"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceStopReplicationTask()
        {
            #region stop-replication-task-1481762924947

            var response = client.StopReplicationTask(new StopReplicationTaskRequest 
            {
                ReplicationTaskArn = "arn:aws:dms:us-east-1:123456789012:endpoint:ASXWXJZLNWNT5HTWCGV2BUJQ7E"
            });

            ReplicationTask replicationTask = response.ReplicationTask;

            #endregion
        }

        public void DatabaseMigrationServiceTestConnection()
        {
            #region test-conection-1481763017636

            var response = client.TestConnection(new TestConnectionRequest 
            {
                EndpointArn = "arn:aws:dms:us-east-1:123456789012:endpoint:RAAR3R22XSH46S3PWLC3NJAWKM",
                ReplicationInstanceArn = "arn:aws:dms:us-east-1:123456789012:rep:6UTDJGBOUS3VI3SUWA66XFJCJQ"
            });

            Connection connection = response.Connection;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}