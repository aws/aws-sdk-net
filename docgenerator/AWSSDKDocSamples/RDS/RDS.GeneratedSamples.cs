using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.RDS;
using Amazon.RDS.Model;

namespace AWSSDKDocSamples.Amazon.RDS.Generated
{
    class RDSSamples : ISample
    {
        public void RDSAddRoleToDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.AddRoleToDBCluster(new AddRoleToDBClusterRequest 
            {
                DBClusterIdentifier = "mydbcluster",
                RoleArn = "arn:aws:iam::123456789012:role/RDSLoadFromS3"
            });


            #endregion
        }

        public void RDSAddRoleToDBInstance()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.AddRoleToDBInstance(new AddRoleToDBInstanceRequest 
            {
                DBInstanceIdentifier = "test-instance",
                FeatureName = "S3_INTEGRATION",
                RoleArn = "arn:aws:iam::111122223333:role/rds-s3-integration-role"
            });


            #endregion
        }

        public void RDSAddSourceIdentifierToSubscription()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.AddSourceIdentifierToSubscription(new AddSourceIdentifierToSubscriptionRequest 
            {
                SourceIdentifier = "test-instance-repl",
                SubscriptionName = "my-instance-events"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void RDSAddTagsToResource()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.AddTagsToResource(new AddTagsToResourceRequest 
            {
                ResourceName = "arn:aws:rds:us-east-1:992648334831:og:mymysqloptiongroup",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Staging",
                        Value = "LocationDB"
                    }
                }
            });


            #endregion
        }

        public void RDSApplyPendingMaintenanceAction()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ApplyPendingMaintenanceAction(new ApplyPendingMaintenanceActionRequest 
            {
                ApplyAction = "system-update",
                OptInType = "immediate",
                ResourceIdentifier = "arn:aws:rds:us-east-1:123456789012:cluster:my-db-cluster"
            });

            ResourcePendingMaintenanceActions resourcePendingMaintenanceActions = response.ResourcePendingMaintenanceActions;

            #endregion
        }

        public void RDSAuthorizeDBSecurityGroupIngress()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.AuthorizeDBSecurityGroupIngress(new AuthorizeDBSecurityGroupIngressRequest 
            {
                CIDRIP = "203.0.113.5/32",
                DBSecurityGroupName = "mydbsecuritygroup"
            });

            DBSecurityGroup dbSecurityGroup = response.DBSecurityGroup;

            #endregion
        }

        public void RDSCancelExportTask()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CancelExportTask(new CancelExportTaskRequest 
            {
                ExportTaskIdentifier = "my-s3-export-1"
            });

            string exportTaskIdentifier = response.ExportTaskIdentifier;
            string iamRoleArn = response.IamRoleArn;
            string kmsKeyId = response.KmsKeyId;
            int percentProgress = response.PercentProgress;
            string s3Bucket = response.S3Bucket;
            string s3Prefix = response.S3Prefix;
            DateTime snapshotTime = response.SnapshotTime;
            string sourceArn = response.SourceArn;
            string status = response.Status;
            int totalExtractedDataInGB = response.TotalExtractedDataInGB;

            #endregion
        }

        public void RDSCopyDBClusterParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CopyDBClusterParameterGroup(new CopyDBClusterParameterGroupRequest 
            {
                SourceDBClusterParameterGroupIdentifier = "mydbclusterparametergroup",
                TargetDBClusterParameterGroupDescription = "My DB cluster parameter group copy",
                TargetDBClusterParameterGroupIdentifier = "mydbclusterparametergroup-copy"
            });

            DBClusterParameterGroup dbClusterParameterGroup = response.DBClusterParameterGroup;

            #endregion
        }

        public void RDSCopyDBClusterSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CopyDBClusterSnapshot(new CopyDBClusterSnapshotRequest 
            {
                CopyTags = true,
                SourceDBClusterSnapshotIdentifier = "arn:aws:rds:us-east-1:123456789012:cluster-snapshot:rds:myaurora-2019-06-04-09-16",
                TargetDBClusterSnapshotIdentifier = "myclustersnapshotcopy"
            });

            DBClusterSnapshot dbClusterSnapshot = response.DBClusterSnapshot;

            #endregion
        }

        public void RDSCopyDBParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CopyDBParameterGroup(new CopyDBParameterGroupRequest 
            {
                SourceDBParameterGroupIdentifier = "mydbpg",
                TargetDBParameterGroupDescription = "Copy of mydbpg parameter group",
                TargetDBParameterGroupIdentifier = "mydbpgcopy"
            });

            DBParameterGroup dbParameterGroup = response.DBParameterGroup;

            #endregion
        }

        public void RDSCopyDBSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CopyDBSnapshot(new CopyDBSnapshotRequest 
            {
                SourceDBSnapshotIdentifier = "rds:database-mysql-2019-06-06-08-38",
                TargetDBSnapshotIdentifier = "mydbsnapshotcopy"
            });

            DBSnapshot dbSnapshot = response.DBSnapshot;

            #endregion
        }

        public void RDSCopyOptionGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CopyOptionGroup(new CopyOptionGroupRequest 
            {
                SourceOptionGroupIdentifier = "myoptiongroup",
                TargetOptionGroupDescription = "My option group copy",
                TargetOptionGroupIdentifier = "new-option-group"
            });

            OptionGroup optionGroup = response.OptionGroup;

            #endregion
        }

        public void RDSCreateBlueGreenDeployment()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateBlueGreenDeployment(new CreateBlueGreenDeploymentRequest 
            {
                BlueGreenDeploymentName = "bgd-test-instance",
                Source = "arn:aws:rds:us-east-1:123456789012:db:my-db-instance",
                TargetDBParameterGroupName = "mysql-80-group",
                TargetEngineVersion = "8.0"
            });

            BlueGreenDeployment blueGreenDeployment = response.BlueGreenDeployment;

            #endregion
        }

        public void RDSCreateBlueGreenDeployment()
        {
            #region example-2

            var client = new AmazonRDSClient();
            var response = client.CreateBlueGreenDeployment(new CreateBlueGreenDeploymentRequest 
            {
                BlueGreenDeploymentName = "my-blue-green-deployment",
                Source = "arn:aws:rds:us-east-1:123456789012:cluster:my-aurora-mysql-cluster",
                TargetDBClusterParameterGroupName = "mysql-80-cluster-group",
                TargetDBParameterGroupName = "ams-80-binlog-enabled",
                TargetEngineVersion = "8.0"
            });

            BlueGreenDeployment blueGreenDeployment = response.BlueGreenDeployment;

            #endregion
        }

        public void RDSCreateDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBCluster(new CreateDBClusterRequest 
            {
                DBClusterIdentifier = "sample-cluster",
                DBSubnetGroupName = "default",
                Engine = "aurora-mysql",
                EngineVersion = "5.7.12",
                MasterUserPassword = "mypassword",
                MasterUsername = "admin",
                VpcSecurityGroupIds = new List<string> {
                    "sg-0b91305example"
                }
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSCreateDBCluster()
        {
            #region example-2

            var client = new AmazonRDSClient();
            var response = client.CreateDBCluster(new CreateDBClusterRequest 
            {
                DBClusterIdentifier = "sample-pg-cluster",
                DBSubnetGroupName = "default",
                Engine = "aurora-postgresql",
                MasterUserPassword = "mypassword",
                MasterUsername = "admin",
                VpcSecurityGroupIds = new List<string> {
                    "sg-0b91305example"
                }
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSCreateDBClusterEndpoint()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBClusterEndpoint(new CreateDBClusterEndpointRequest 
            {
                DBClusterEndpointIdentifier = "mycustomendpoint",
                DBClusterIdentifier = "mydbcluster",
                EndpointType = "reader",
                StaticMembers = new List<string> {
                    "dbinstance1",
                    "dbinstance2"
                }
            });

            string customEndpointType = response.CustomEndpointType;
            string dbClusterEndpointArn = response.DBClusterEndpointArn;
            string dbClusterEndpointIdentifier = response.DBClusterEndpointIdentifier;
            string dbClusterEndpointResourceIdentifier = response.DBClusterEndpointResourceIdentifier;
            string dbClusterIdentifier = response.DBClusterIdentifier;
            string endpoint = response.Endpoint;
            string endpointType = response.EndpointType;
            List<string> excludedMembers = response.ExcludedMembers;
            List<string> staticMembers = response.StaticMembers;
            string status = response.Status;

            #endregion
        }

        public void RDSCreateDBClusterParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBClusterParameterGroup(new CreateDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup",
                DBParameterGroupFamily = "aurora5.6",
                Description = "My new cluster parameter group"
            });

            DBClusterParameterGroup dbClusterParameterGroup = response.DBClusterParameterGroup;

            #endregion
        }

        public void RDSCreateDBClusterSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBClusterSnapshot(new CreateDBClusterSnapshotRequest 
            {
                DBClusterIdentifier = "mydbclustersnapshot",
                DBClusterSnapshotIdentifier = "mydbcluster"
            });

            DBClusterSnapshot dbClusterSnapshot = response.DBClusterSnapshot;

            #endregion
        }

        public void RDSCreateDBInstance()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBInstance(new CreateDBInstanceRequest 
            {
                AllocatedStorage = 20,
                DBInstanceClass = "db.t3.micro",
                DBInstanceIdentifier = "test-mysql-instance",
                Engine = "mysql",
                MasterUserPassword = "secret99",
                MasterUsername = "admin"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSCreateDBInstanceReadReplica()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBInstanceReadReplica(new CreateDBInstanceReadReplicaRequest 
            {
                DBInstanceIdentifier = "test-instance-repl",
                SourceDBInstanceIdentifier = "test-instance"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSCreateDBParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBParameterGroup(new CreateDBParameterGroupRequest 
            {
                DBParameterGroupFamily = "MySQL8.0",
                DBParameterGroupName = "mydbparametergroup",
                Description = "My new parameter group"
            });

            DBParameterGroup dbParameterGroup = response.DBParameterGroup;

            #endregion
        }

        public void RDSCreateDBSecurityGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBSecurityGroup(new CreateDBSecurityGroupRequest 
            {
                DBSecurityGroupDescription = "My DB security group",
                DBSecurityGroupName = "mydbsecuritygroup"
            });

            DBSecurityGroup dbSecurityGroup = response.DBSecurityGroup;

            #endregion
        }

        public void RDSCreateDBSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBSnapshot(new CreateDBSnapshotRequest 
            {
                DBInstanceIdentifier = "mydbsnapshot",
                DBSnapshotIdentifier = "database-mysql"
            });

            DBSnapshot dbSnapshot = response.DBSnapshot;

            #endregion
        }

        public void RDSCreateDBSubnetGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateDBSubnetGroup(new CreateDBSubnetGroupRequest 
            {
                DBSubnetGroupDescription = "test DB subnet group",
                DBSubnetGroupName = "mysubnetgroup",
                SubnetIds = new List<string> {
                    "subnet-0a1dc4e1a6f123456",
                    "subnet-070dd7ecb3aaaaaaa",
                    "subnet-00f5b198bc0abcdef"
                }
            });

            DBSubnetGroup dbSubnetGroup = response.DBSubnetGroup;

            #endregion
        }

        public void RDSCreateEventSubscription()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateEventSubscription(new CreateEventSubscriptionRequest 
            {
                EventCategories = new List<string> {
                    "backup",
                    "recovery"
                },
                SnsTopicArn = "arn:aws:sns:us-east-1:123456789012:interesting-events",
                SourceType = "db-instance",
                SubscriptionName = "my-instance-events"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void RDSCreateGlobalCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateGlobalCluster(new CreateGlobalClusterRequest 
            {
                Engine = "aurora-mysql",
                GlobalClusterIdentifier = "myglobalcluster"
            });

            GlobalCluster globalCluster = response.GlobalCluster;

            #endregion
        }

        public void RDSCreateIntegration()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateIntegration(new CreateIntegrationRequest 
            {
                IntegrationName = "my-integration",
                SourceArn = "arn:aws:rds:us-east-1:123456789012:cluster:my-cluster",
                TargetArn = "arn:aws:redshift-serverless:us-east-1:123456789012:namespace/62c70612-0302-4db7-8414-b5e3e049f0d8"
            });

            DateTime createTime = response.CreateTime;
            string integrationArn = response.IntegrationArn;
            string integrationName = response.IntegrationName;
            string kmsKeyId = response.KMSKeyId;
            string sourceArn = response.SourceArn;
            string status = response.Status;
            List<Tag> tags = response.Tags;
            string targetArn = response.TargetArn;

            #endregion
        }

        public void RDSCreateOptionGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.CreateOptionGroup(new CreateOptionGroupRequest 
            {
                EngineName = "mysql",
                MajorEngineVersion = "8.0",
                OptionGroupDescription = "MySQL 8.0 option group",
                OptionGroupName = "MyOptionGroup"
            });

            OptionGroup optionGroup = response.OptionGroup;

            #endregion
        }

        public void RDSDeleteBlueGreenDeployment()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteBlueGreenDeployment(new DeleteBlueGreenDeploymentRequest 
            {
                BlueGreenDeploymentIdentifier = "bgd-v53303651eexfake",
                DeleteTarget = true
            });

            BlueGreenDeployment blueGreenDeployment = response.BlueGreenDeployment;

            #endregion
        }

        public void RDSDeleteBlueGreenDeployment()
        {
            #region example-2

            var client = new AmazonRDSClient();
            var response = client.DeleteBlueGreenDeployment(new DeleteBlueGreenDeploymentRequest 
            {
                BlueGreenDeploymentIdentifier = "bgd-wi89nwzglccsfake",
                DeleteTarget = true
            });

            BlueGreenDeployment blueGreenDeployment = response.BlueGreenDeployment;

            #endregion
        }

        public void RDSDeleteDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBCluster(new DeleteDBClusterRequest 
            {
                DBClusterIdentifier = "mycluster",
                FinalDBSnapshotIdentifier = "mycluster-final-snapshot",
                SkipFinalSnapshot = false
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSDeleteDBClusterEndpoint()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBClusterEndpoint(new DeleteDBClusterEndpointRequest 
            {
                DBClusterEndpointIdentifier = "mycustomendpoint"
            });

            string customEndpointType = response.CustomEndpointType;
            string dbClusterEndpointArn = response.DBClusterEndpointArn;
            string dbClusterEndpointIdentifier = response.DBClusterEndpointIdentifier;
            string dbClusterEndpointResourceIdentifier = response.DBClusterEndpointResourceIdentifier;
            string dbClusterIdentifier = response.DBClusterIdentifier;
            string endpoint = response.Endpoint;
            string endpointType = response.EndpointType;
            List<string> excludedMembers = response.ExcludedMembers;
            List<string> staticMembers = response.StaticMembers;
            string status = response.Status;

            #endregion
        }

        public void RDSDeleteDBClusterParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBClusterParameterGroup(new DeleteDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup"
            });


            #endregion
        }

        public void RDSDeleteDBClusterSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBClusterSnapshot(new DeleteDBClusterSnapshotRequest 
            {
                DBClusterSnapshotIdentifier = "mydbclustersnapshot"
            });

            DBClusterSnapshot dbClusterSnapshot = response.DBClusterSnapshot;

            #endregion
        }

        public void RDSDeleteDBInstance()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBInstance(new DeleteDBInstanceRequest 
            {
                DBInstanceIdentifier = "test-instance",
                FinalDBSnapshotIdentifier = "test-instance-final-snap",
                SkipFinalSnapshot = false
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSDeleteDBInstanceAutomatedBackup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBInstanceAutomatedBackup(new DeleteDBInstanceAutomatedBackupRequest 
            {
                DBInstanceAutomatedBackupsArn = "arn:aws:rds:us-west-2:123456789012:auto-backup:ab-jkib2gfq5rv7replzadausbrktni2bn4example"
            });

            DBInstanceAutomatedBackup dbInstanceAutomatedBackup = response.DBInstanceAutomatedBackup;

            #endregion
        }

        public void RDSDeleteDBParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBParameterGroup(new DeleteDBParameterGroupRequest 
            {
                DBParameterGroupName = "mydbparametergroup"
            });


            #endregion
        }

        public void RDSDeleteDBSecurityGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBSecurityGroup(new DeleteDBSecurityGroupRequest 
            {
                DBSecurityGroupName = "mysecgroup"
            });


            #endregion
        }

        public void RDSDeleteDBSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBSnapshot(new DeleteDBSnapshotRequest 
            {
                DBSnapshotIdentifier = "mydbsnapshot"
            });

            DBSnapshot dbSnapshot = response.DBSnapshot;

            #endregion
        }

        public void RDSDeleteDBSubnetGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteDBSubnetGroup(new DeleteDBSubnetGroupRequest 
            {
                DBSubnetGroupName = "mysubnetgroup"
            });


            #endregion
        }

        public void RDSDeleteEventSubscription()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteEventSubscription(new DeleteEventSubscriptionRequest 
            {
                SubscriptionName = "my-instance-events"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void RDSDeleteGlobalCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteGlobalCluster(new DeleteGlobalClusterRequest 
            {
                GlobalClusterIdentifier = "myglobalcluster"
            });

            GlobalCluster globalCluster = response.GlobalCluster;

            #endregion
        }

        public void RDSDeleteIntegration()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteIntegration(new DeleteIntegrationRequest 
            {
                IntegrationIdentifier = "5b9f3d79-7392-4a3e-896c-58eaa1b53231"
            });

            DateTime createTime = response.CreateTime;
            string integrationArn = response.IntegrationArn;
            string integrationName = response.IntegrationName;
            string kmsKeyId = response.KMSKeyId;
            string sourceArn = response.SourceArn;
            string status = response.Status;
            List<Tag> tags = response.Tags;
            string targetArn = response.TargetArn;

            #endregion
        }

        public void RDSDeleteOptionGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DeleteOptionGroup(new DeleteOptionGroupRequest 
            {
                OptionGroupName = "myoptiongroup"
            });


            #endregion
        }

        public void RDSDescribeAccountAttributes()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeAccountAttributes(new DescribeAccountAttributesRequest 
            {
            });

            List<AccountQuota> accountQuotas = response.AccountQuotas;

            #endregion
        }

        public void RDSDescribeBlueGreenDeployments()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeBlueGreenDeployments(new DescribeBlueGreenDeploymentsRequest 
            {
                BlueGreenDeploymentIdentifier = "bgd-v53303651eexfake"
            });

            List<BlueGreenDeployment> blueGreenDeployments = response.BlueGreenDeployments;

            #endregion
        }

        public void RDSDescribeBlueGreenDeployments()
        {
            #region example-2

            var client = new AmazonRDSClient();
            var response = client.DescribeBlueGreenDeployments(new DescribeBlueGreenDeploymentsRequest 
            {
                BlueGreenDeploymentIdentifier = "bgd-wi89nwzglccsfake"
            });

            List<BlueGreenDeployment> blueGreenDeployments = response.BlueGreenDeployments;

            #endregion
        }

        public void RDSDescribeBlueGreenDeployments()
        {
            #region example-3

            var client = new AmazonRDSClient();
            var response = client.DescribeBlueGreenDeployments(new DescribeBlueGreenDeploymentsRequest 
            {
                BlueGreenDeploymentIdentifier = "bgd-wi89nwzglccsfake"
            });

            List<BlueGreenDeployment> blueGreenDeployments = response.BlueGreenDeployments;

            #endregion
        }

        public void RDSDescribeCertificates()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeCertificates(new DescribeCertificatesRequest 
            {
            });

            List<Certificate> certificates = response.Certificates;

            #endregion
        }

        public void RDSDescribeDBClusterBacktracks()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusterBacktracks(new DescribeDBClusterBacktracksRequest 
            {
                DBClusterIdentifier = "mydbcluster"
            });

            List<DBClusterBacktrack> dbClusterBacktracks = response.DBClusterBacktracks;

            #endregion
        }

        public void RDSDescribeDBClusterEndpoints()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusterEndpoints(new DescribeDBClusterEndpointsRequest 
            {
            });

            List<DBClusterEndpoint> dbClusterEndpoints = response.DBClusterEndpoints;

            #endregion
        }

        public void RDSDescribeDBClusterEndpoints()
        {
            #region example-2

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusterEndpoints(new DescribeDBClusterEndpointsRequest 
            {
                DBClusterIdentifier = "serverless-cluster"
            });

            List<DBClusterEndpoint> dbClusterEndpoints = response.DBClusterEndpoints;

            #endregion
        }

        public void RDSDescribeDBClusterParameterGroups()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusterParameterGroups(new DescribeDBClusterParameterGroupsRequest 
            {
            });

            List<DBClusterParameterGroup> dbClusterParameterGroups = response.DBClusterParameterGroups;

            #endregion
        }

        public void RDSDescribeDBClusterParameters()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusterParameters(new DescribeDBClusterParametersRequest 
            {
                DBClusterParameterGroupName = "mydbclusterpg"
            });

            List<Parameter> parameters = response.Parameters;

            #endregion
        }

        public void RDSDescribeDBClusters()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusters(new DescribeDBClustersRequest 
            {
                DBClusterIdentifier = "mydbcluster"
            });

            List<DBCluster> dbClusters = response.DBClusters;

            #endregion
        }

        public void RDSDescribeDBClusterSnapshotAttributes()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusterSnapshotAttributes(new DescribeDBClusterSnapshotAttributesRequest 
            {
                DBClusterSnapshotIdentifier = "myclustersnapshot"
            });

            DBClusterSnapshotAttributesResult dbClusterSnapshotAttributesResult = response.DBClusterSnapshotAttributesResult;

            #endregion
        }

        public void RDSDescribeDBClusterSnapshots()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBClusterSnapshots(new DescribeDBClusterSnapshotsRequest 
            {
                DBClusterIdentifier = "mydbcluster"
            });

            List<DBClusterSnapshot> dbClusterSnapshots = response.DBClusterSnapshots;

            #endregion
        }

        public void RDSDescribeDBEngineVersions()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest 
            {
                Engine = "mysql"
            });

            List<DBEngineVersion> dbEngineVersions = response.DBEngineVersions;

            #endregion
        }

        public void RDSDescribeDBInstanceAutomatedBackups()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBInstanceAutomatedBackups(new DescribeDBInstanceAutomatedBackupsRequest 
            {
                DBInstanceIdentifier = "new-orcl-db"
            });

            List<DBInstanceAutomatedBackup> dbInstanceAutomatedBackups = response.DBInstanceAutomatedBackups;

            #endregion
        }

        public void RDSDescribeDBInstances()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBInstances(new DescribeDBInstancesRequest 
            {
                DBInstanceIdentifier = "mydbinstancecf"
            });

            List<DBInstance> dbInstances = response.DBInstances;

            #endregion
        }

        public void RDSDescribeDBLogFiles()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBLogFiles(new DescribeDBLogFilesRequest 
            {
                DBInstanceIdentifier = "test-instance"
            });

            List<DescribeDBLogFilesDetails> describeDBLogFiles = response.DescribeDBLogFiles;

            #endregion
        }

        public void RDSDescribeDBParameterGroups()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest 
            {
            });

            List<DBParameterGroup> dbParameterGroups = response.DBParameterGroups;

            #endregion
        }

        public void RDSDescribeDBParameters()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBParameters(new DescribeDBParametersRequest 
            {
                DBParameterGroupName = "mydbpg"
            });

            List<Parameter> parameters = response.Parameters;

            #endregion
        }

        public void RDSDescribeDBSecurityGroups()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBSecurityGroups(new DescribeDBSecurityGroupsRequest 
            {
                DBSecurityGroupName = "mydbsecuritygroup"
            });


            #endregion
        }

        public void RDSDescribeDBSnapshotAttributes()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBSnapshotAttributes(new DescribeDBSnapshotAttributesRequest 
            {
                DBSnapshotIdentifier = "mydbsnapshot"
            });

            DBSnapshotAttributesResult dbSnapshotAttributesResult = response.DBSnapshotAttributesResult;

            #endregion
        }

        public void RDSDescribeDBSnapshots()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBSnapshots(new DescribeDBSnapshotsRequest 
            {
                DBSnapshotIdentifier = "mydbsnapshot"
            });

            List<DBSnapshot> dbSnapshots = response.DBSnapshots;

            #endregion
        }

        public void RDSDescribeDBSubnetGroups()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest 
            {
            });

            List<DBSubnetGroup> dbSubnetGroups = response.DBSubnetGroups;

            #endregion
        }

        public void RDSDescribeEngineDefaultClusterParameters()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeEngineDefaultClusterParameters(new DescribeEngineDefaultClusterParametersRequest 
            {
                DBParameterGroupFamily = "aurora-mysql5.7"
            });

            EngineDefaults engineDefaults = response.EngineDefaults;

            #endregion
        }

        public void RDSDescribeEngineDefaultParameters()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeEngineDefaultParameters(new DescribeEngineDefaultParametersRequest 
            {
                DBParameterGroupFamily = "mysql5.7"
            });

            EngineDefaults engineDefaults = response.EngineDefaults;

            #endregion
        }

        public void RDSDescribeEventCategories()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeEventCategories(new DescribeEventCategoriesRequest 
            {
                Filters = new List<Filter> {
                    
                },
                SourceType = ""
            });

            List<EventCategoriesMap> eventCategoriesMapList = response.EventCategoriesMapList;

            #endregion
        }

        public void RDSDescribeEvents()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeEvents(new DescribeEventsRequest 
            {
                SourceIdentifier = "test-instance",
                SourceType = "db-instance"
            });

            List<Event> events = response.Events;

            #endregion
        }

        public void RDSDescribeEventSubscriptions()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest 
            {
            });

            List<EventSubscription> eventSubscriptionsList = response.EventSubscriptionsList;

            #endregion
        }

        public void RDSDescribeExportTasks()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeExportTasks(new DescribeExportTasksRequest 
            {
            });

            List<ExportTask> exportTasks = response.ExportTasks;

            #endregion
        }

        public void RDSDescribeGlobalClusters()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeGlobalClusters(new DescribeGlobalClustersRequest 
            {
            });

            List<GlobalCluster> globalClusters = response.GlobalClusters;

            #endregion
        }

        public void RDSDescribeIntegrations()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeIntegrations(new DescribeIntegrationsRequest 
            {
                IntegrationIdentifier = "5b9f3d79-7392-4a3e-896c-58eaa1b53231"
            });

            List<Integration> integrations = response.Integrations;

            #endregion
        }

        public void RDSDescribeOptionGroupOptions()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeOptionGroupOptions(new DescribeOptionGroupOptionsRequest 
            {
                EngineName = "mysql",
                MajorEngineVersion = "8.0"
            });

            List<OptionGroupOption> optionGroupOptions = response.OptionGroupOptions;

            #endregion
        }

        public void RDSDescribeOptionGroups()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeOptionGroups(new DescribeOptionGroupsRequest 
            {
                EngineName = "oracle-ee",
                MajorEngineVersion = "19"
            });

            List<OptionGroup> optionGroupsList = response.OptionGroupsList;

            #endregion
        }

        public void RDSDescribeOrderableDBInstanceOptions()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest 
            {
                Engine = "mysql"
            });

            List<OrderableDBInstanceOption> orderableDBInstanceOptions = response.OrderableDBInstanceOptions;

            #endregion
        }

        public void RDSDescribePendingMaintenanceActions()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribePendingMaintenanceActions(new DescribePendingMaintenanceActionsRequest 
            {
            });

            List<ResourcePendingMaintenanceActions> pendingMaintenanceActions = response.PendingMaintenanceActions;

            #endregion
        }

        public void RDSDescribeReservedDBInstances()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeReservedDBInstances(new DescribeReservedDBInstancesRequest 
            {
            });

            List<ReservedDBInstance> reservedDBInstances = response.ReservedDBInstances;

            #endregion
        }

        public void RDSDescribeReservedDBInstancesOfferings()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeReservedDBInstancesOfferings(new DescribeReservedDBInstancesOfferingsRequest 
            {
                ProductDescription = "oracle"
            });

            List<ReservedDBInstancesOffering> reservedDBInstancesOfferings = response.ReservedDBInstancesOfferings;

            #endregion
        }

        public void RDSDescribeSourceRegions()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeSourceRegions(new DescribeSourceRegionsRequest 
            {
                RegionName = "us-east-1"
            });

            List<SourceRegion> sourceRegions = response.SourceRegions;

            #endregion
        }

        public void RDSDescribeValidDBInstanceModifications()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DescribeValidDBInstanceModifications(new DescribeValidDBInstanceModificationsRequest 
            {
                DBInstanceIdentifier = "database-test1"
            });

            ValidDBInstanceModificationsMessage validDBInstanceModificationsMessage = response.ValidDBInstanceModificationsMessage;

            #endregion
        }

        public void RDSDownloadDBLogFilePortion()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.DownloadDBLogFilePortion(new DownloadDBLogFilePortionRequest 
            {
                DBInstanceIdentifier = "test-instance",
                LogFileName = "log.txt"
            });


            #endregion
        }

        public void RDSFailoverDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.FailoverDBCluster(new FailoverDBClusterRequest 
            {
                DBClusterIdentifier = "myaurorainstance-cluster",
                TargetDBInstanceIdentifier = "myaurorareplica"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSListTagsForResource()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceName = "arn:aws:rds:us-east-1:123456789012:db:orcl1"
            });

            List<Tag> tagList = response.TagList;

            #endregion
        }

        public void RDSModifyCertificates()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyCertificates(new ModifyCertificatesRequest 
            {
                CertificateIdentifier = "rds-ca-2019"
            });

            Certificate certificate = response.Certificate;

            #endregion
        }

        public void RDSModifyCurrentDBClusterCapacity()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyCurrentDBClusterCapacity(new ModifyCurrentDBClusterCapacityRequest 
            {
                Capacity = 8,
                DBClusterIdentifier = "mydbcluster"
            });

            int currentCapacity = response.CurrentCapacity;
            string dbClusterIdentifier = response.DBClusterIdentifier;
            int pendingCapacity = response.PendingCapacity;
            int secondsBeforeTimeout = response.SecondsBeforeTimeout;
            string timeoutAction = response.TimeoutAction;

            #endregion
        }

        public void RDSModifyDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBCluster(new ModifyDBClusterRequest 
            {
                ApplyImmediately = true,
                BackupRetentionPeriod = 14,
                DBClusterIdentifier = "cluster-2",
                MasterUserPassword = "newpassword99"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSModifyDBClusterEndpoint()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBClusterEndpoint(new ModifyDBClusterEndpointRequest 
            {
                DBClusterEndpointIdentifier = "mycustomendpoint",
                StaticMembers = new List<string> {
                    "dbinstance1",
                    "dbinstance2",
                    "dbinstance3"
                }
            });

            string customEndpointType = response.CustomEndpointType;
            string dbClusterEndpointArn = response.DBClusterEndpointArn;
            string dbClusterEndpointIdentifier = response.DBClusterEndpointIdentifier;
            string dbClusterEndpointResourceIdentifier = response.DBClusterEndpointResourceIdentifier;
            string dbClusterIdentifier = response.DBClusterIdentifier;
            string endpoint = response.Endpoint;
            string endpointType = response.EndpointType;
            List<string> excludedMembers = response.ExcludedMembers;
            List<string> staticMembers = response.StaticMembers;
            string status = response.Status;

            #endregion
        }

        public void RDSModifyDBClusterParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBClusterParameterGroup(new ModifyDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclusterpg",
                Parameters = new List<Parameter> {
                    new Parameter {
                        ApplyMethod = "immediate",
                        ParameterName = "server_audit_logging",
                        ParameterValue = "1"
                    },
                    new Parameter {
                        ApplyMethod = "immediate",
                        ParameterName = "server_audit_logs_upload",
                        ParameterValue = "1"
                    }
                }
            });

            string dbClusterParameterGroupName = response.DBClusterParameterGroupName;

            #endregion
        }

        public void RDSModifyDBClusterSnapshotAttribute()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBClusterSnapshotAttribute(new ModifyDBClusterSnapshotAttributeRequest 
            {
                AttributeName = "restore",
                DBClusterSnapshotIdentifier = "myclustersnapshot",
                ValuesToAdd = new List<string> {
                    "123456789012"
                }
            });

            DBClusterSnapshotAttributesResult dbClusterSnapshotAttributesResult = response.DBClusterSnapshotAttributesResult;

            #endregion
        }

        public void RDSModifyDBInstance()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBInstance(new ModifyDBInstanceRequest 
            {
                ApplyImmediately = true,
                DBInstanceIdentifier = "database-2",
                DBParameterGroupName = "test-sqlserver-se-2017",
                OptionGroupName = "test-se-2017"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSModifyDBParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBParameterGroup(new ModifyDBParameterGroupRequest 
            {
                DBParameterGroupName = "test-sqlserver-se-2017",
                Parameters = new List<Parameter> {
                    new Parameter {
                        ApplyMethod = "immediate",
                        ParameterName = "clr enabled",
                        ParameterValue = "1"
                    }
                }
            });

            string dbParameterGroupName = response.DBParameterGroupName;

            #endregion
        }

        public void RDSModifyDBSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBSnapshot(new ModifyDBSnapshotRequest 
            {
                DBSnapshotIdentifier = "db5-snapshot-upg-test",
                EngineVersion = "11.7"
            });

            DBSnapshot dbSnapshot = response.DBSnapshot;

            #endregion
        }

        public void RDSModifyDBSnapshotAttribute()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBSnapshotAttribute(new ModifyDBSnapshotAttributeRequest 
            {
                AttributeName = "restore",
                DBSnapshotIdentifier = "mydbsnapshot",
                ValuesToAdd = new List<string> {
                    "111122223333",
                    "444455556666"
                }
            });

            DBSnapshotAttributesResult dbSnapshotAttributesResult = response.DBSnapshotAttributesResult;

            #endregion
        }

        public void RDSModifyDBSnapshotAttribute()
        {
            #region example-2

            var client = new AmazonRDSClient();
            var response = client.ModifyDBSnapshotAttribute(new ModifyDBSnapshotAttributeRequest 
            {
                AttributeName = "restore",
                DBSnapshotIdentifier = "mydbsnapshot",
                ValuesToRemove = new List<string> {
                    "444455556666"
                }
            });

            DBSnapshotAttributesResult dbSnapshotAttributesResult = response.DBSnapshotAttributesResult;

            #endregion
        }

        public void RDSModifyDBSubnetGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyDBSubnetGroup(new ModifyDBSubnetGroupRequest 
            {
                DBSubnetGroupDescription = "",
                DBSubnetGroupName = "mysubnetgroup",
                SubnetIds = new List<string> {
                    "subnet-0a1dc4e1a6f123456",
                    "subnet-070dd7ecb3aaaaaaa",
                    "subnet-00f5b198bc0abcdef",
                    "subnet-08e41f9e230222222"
                }
            });

            DBSubnetGroup dbSubnetGroup = response.DBSubnetGroup;

            #endregion
        }

        public void RDSModifyEventSubscription()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyEventSubscription(new ModifyEventSubscriptionRequest 
            {
                Enabled = false,
                SubscriptionName = "my-instance-events"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void RDSModifyGlobalCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyGlobalCluster(new ModifyGlobalClusterRequest 
            {
                DeletionProtection = true,
                GlobalClusterIdentifier = "myglobalcluster"
            });

            GlobalCluster globalCluster = response.GlobalCluster;

            #endregion
        }

        public void RDSModifyIntegration()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyIntegration(new ModifyIntegrationRequest 
            {
                IntegrationIdentifier = "a1b2c3d4-5678-90ab-cdef-EXAMPLE11111",
                IntegrationName = "my-renamed-integration"
            });

            DateTime createTime = response.CreateTime;
            string dataFilter = response.DataFilter;
            string integrationArn = response.IntegrationArn;
            string integrationName = response.IntegrationName;
            string kmsKeyId = response.KMSKeyId;
            string sourceArn = response.SourceArn;
            string status = response.Status;
            List<Tag> tags = response.Tags;
            string targetArn = response.TargetArn;

            #endregion
        }

        public void RDSModifyOptionGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ModifyOptionGroup(new ModifyOptionGroupRequest 
            {
                ApplyImmediately = true,
                OptionGroupName = "myawsuser-og02",
                OptionsToInclude = new List<OptionConfiguration> {
                    new OptionConfiguration {
                        DBSecurityGroupMemberships = new List<string> {
                            "default"
                        },
                        OptionName = "MEMCACHED"
                    }
                }
            });

            OptionGroup optionGroup = response.OptionGroup;

            #endregion
        }

        public void RDSPromoteReadReplica()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.PromoteReadReplica(new PromoteReadReplicaRequest 
            {
                DBInstanceIdentifier = "test-instance-repl"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSPurchaseReservedDBInstancesOffering()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.PurchaseReservedDBInstancesOffering(new PurchaseReservedDBInstancesOfferingRequest 
            {
                ReservedDBInstanceId = "8ba30be1-b9ec-447f-8f23-6114e3f4c7b4",
                ReservedDBInstancesOfferingId = ""
            });

            ReservedDBInstance reservedDBInstance = response.ReservedDBInstance;

            #endregion
        }

        public void RDSRebootDBInstance()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RebootDBInstance(new RebootDBInstanceRequest 
            {
                DBInstanceIdentifier = "test-mysql-instance"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSRemoveFromGlobalCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RemoveFromGlobalCluster(new RemoveFromGlobalClusterRequest 
            {
                DbClusterIdentifier = "arn:aws:rds:us-west-2:123456789012:cluster:DB-1",
                GlobalClusterIdentifier = "myglobalcluster"
            });

            GlobalCluster globalCluster = response.GlobalCluster;

            #endregion
        }

        public void RDSRemoveRoleFromDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RemoveRoleFromDBCluster(new RemoveRoleFromDBClusterRequest 
            {
                DBClusterIdentifier = "mydbcluster",
                RoleArn = "arn:aws:iam::123456789012:role/RDSLoadFromS3"
            });


            #endregion
        }

        public void RDSRemoveSourceIdentifierFromSubscription()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RemoveSourceIdentifierFromSubscription(new RemoveSourceIdentifierFromSubscriptionRequest 
            {
                SourceIdentifier = "test-instance-repl",
                SubscriptionName = "my-instance-events"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void RDSRemoveTagsFromResource()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RemoveTagsFromResource(new RemoveTagsFromResourceRequest 
            {
                ResourceName = "arn:aws:rds:us-east-1:123456789012:db:mydbinstance",
                TagKeys = new List<string> {
                    "Name",
                    "Environment"
                }
            });


            #endregion
        }

        public void RDSResetDBClusterParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ResetDBClusterParameterGroup(new ResetDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclpg",
                ResetAllParameters = true
            });

            string dbClusterParameterGroupName = response.DBClusterParameterGroupName;

            #endregion
        }

        public void RDSResetDBParameterGroup()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.ResetDBParameterGroup(new ResetDBParameterGroupRequest 
            {
                DBParameterGroupName = "mypg",
                ResetAllParameters = true
            });

            string dbParameterGroupName = response.DBParameterGroupName;

            #endregion
        }

        public void RDSRestoreDBClusterFromS3()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RestoreDBClusterFromS3(new RestoreDBClusterFromS3Request 
            {
                DBClusterIdentifier = "cluster-s3-restore",
                Engine = "aurora-mysql",
                MasterUserPassword = "mypassword",
                MasterUsername = "admin",
                S3BucketName = "mybucket",
                S3IngestionRoleArn = "arn:aws:iam::123456789012:role/service-role/TestBackup",
                S3Prefix = "test-backup",
                SourceEngine = "mysql",
                SourceEngineVersion = "5.7.28"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSRestoreDBClusterFromSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RestoreDBClusterFromSnapshot(new RestoreDBClusterFromSnapshotRequest 
            {
                DBClusterIdentifier = "newdbcluster",
                Engine = "aurora-postgresql",
                EngineVersion = "10.7",
                SnapshotIdentifier = "test-instance-snapshot"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSRestoreDBClusterToPointInTime()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RestoreDBClusterToPointInTime(new RestoreDBClusterToPointInTimeRequest 
            {
                DBClusterIdentifier = "sample-cluster-clone",
                RestoreType = "copy-on-write",
                SourceDBClusterIdentifier = "database-4",
                UseLatestRestorableTime = true
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSRestoreDBInstanceFromDBSnapshot()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RestoreDBInstanceFromDBSnapshot(new RestoreDBInstanceFromDBSnapshotRequest 
            {
                DBInstanceClass = "db.t3.small",
                DBInstanceIdentifier = "db7-new-instance",
                DBSnapshotIdentifier = "db7-test-snapshot"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSRestoreDBInstanceToPointInTime()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RestoreDBInstanceToPointInTime(new RestoreDBInstanceToPointInTimeRequest 
            {
                RestoreTimeUtc = new DateTime(2018, 7, 30, 11, 45, 0, DateTimeKind.Utc),
                SourceDBInstanceIdentifier = "test-instance",
                TargetDBInstanceIdentifier = "restored-test-instance"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSRevokeDBSecurityGroupIngress()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.RevokeDBSecurityGroupIngress(new RevokeDBSecurityGroupIngressRequest 
            {
                CIDRIP = "203.0.113.5/32",
                DBSecurityGroupName = "mydbsecuritygroup"
            });

            DBSecurityGroup dbSecurityGroup = response.DBSecurityGroup;

            #endregion
        }

        public void RDSStartActivityStream()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StartActivityStream(new StartActivityStreamRequest 
            {
                ApplyImmediately = true,
                KmsKeyId = "arn:aws:kms:us-east-1:1234567890123:key/a12c345d-6ef7-890g-h123-456i789jk0l1",
                Mode = "async",
                ResourceArn = "arn:aws:rds:us-east-1:1234567890123:cluster:my-pg-cluster"
            });

            bool applyImmediately = response.ApplyImmediately;
            string kinesisStreamName = response.KinesisStreamName;
            string kmsKeyId = response.KmsKeyId;
            string mode = response.Mode;
            string status = response.Status;

            #endregion
        }

        public void RDSStartDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StartDBCluster(new StartDBClusterRequest 
            {
                DBClusterIdentifier = "mydbcluster"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSStartDBInstance()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StartDBInstance(new StartDBInstanceRequest 
            {
                DBInstanceIdentifier = "test-instance"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSStartDBInstanceAutomatedBackupsReplication()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StartDBInstanceAutomatedBackupsReplication(new StartDBInstanceAutomatedBackupsReplicationRequest 
            {
                BackupRetentionPeriod = 14,
                SourceDBInstanceArn = "arn:aws:rds:us-east-1:123456789012:db:new-orcl-db"
            });

            DBInstanceAutomatedBackup dbInstanceAutomatedBackup = response.DBInstanceAutomatedBackup;

            #endregion
        }

        public void RDSStartExportTask()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StartExportTask(new StartExportTaskRequest 
            {
                ExportTaskIdentifier = "my-s3-export",
                IamRoleArn = "arn:aws:iam::123456789012:role/service-role/ExportRole",
                KmsKeyId = "arn:aws:kms:us-west-2:123456789012:key/abcd0000-7fca-4128-82f2-aabbccddeeff",
                S3BucketName = "mybucket",
                SourceArn = "arn:aws:rds:us-west-2:123456789012:snapshot:db5-snapshot-test"
            });

            string exportTaskIdentifier = response.ExportTaskIdentifier;
            string iamRoleArn = response.IamRoleArn;
            string kmsKeyId = response.KmsKeyId;
            int percentProgress = response.PercentProgress;
            string s3Bucket = response.S3Bucket;
            DateTime snapshotTime = response.SnapshotTime;
            string sourceArn = response.SourceArn;
            string status = response.Status;
            int totalExtractedDataInGB = response.TotalExtractedDataInGB;

            #endregion
        }

        public void RDSStopActivityStream()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StopActivityStream(new StopActivityStreamRequest 
            {
                ApplyImmediately = true,
                ResourceArn = "arn:aws:rds:us-east-1:1234567890123:cluster:my-pg-cluster"
            });

            string kinesisStreamName = response.KinesisStreamName;
            string kmsKeyId = response.KmsKeyId;
            string status = response.Status;

            #endregion
        }

        public void RDSStopDBCluster()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StopDBCluster(new StopDBClusterRequest 
            {
                DBClusterIdentifier = "mydbcluster"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void RDSStopDBInstance()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StopDBInstance(new StopDBInstanceRequest 
            {
                DBInstanceIdentifier = "test-instance"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void RDSStopDBInstanceAutomatedBackupsReplication()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.StopDBInstanceAutomatedBackupsReplication(new StopDBInstanceAutomatedBackupsReplicationRequest 
            {
                SourceDBInstanceArn = "arn:aws:rds:us-east-1:123456789012:db:new-orcl-db"
            });

            DBInstanceAutomatedBackup dbInstanceAutomatedBackup = response.DBInstanceAutomatedBackup;

            #endregion
        }

        public void RDSSwitchoverBlueGreenDeployment()
        {
            #region example-1

            var client = new AmazonRDSClient();
            var response = client.SwitchoverBlueGreenDeployment(new SwitchoverBlueGreenDeploymentRequest 
            {
                BlueGreenDeploymentIdentifier = "bgd-wi89nwzglccsfake",
                SwitchoverTimeout = 300
            });

            BlueGreenDeployment blueGreenDeployment = response.BlueGreenDeployment;

            #endregion
        }

        public void RDSSwitchoverBlueGreenDeployment()
        {
            #region example-2

            var client = new AmazonRDSClient();
            var response = client.SwitchoverBlueGreenDeployment(new SwitchoverBlueGreenDeploymentRequest 
            {
                BlueGreenDeploymentIdentifier = "bgd-wi89nwzglccsfake",
                SwitchoverTimeout = 300
            });

            BlueGreenDeployment blueGreenDeployment = response.BlueGreenDeployment;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}