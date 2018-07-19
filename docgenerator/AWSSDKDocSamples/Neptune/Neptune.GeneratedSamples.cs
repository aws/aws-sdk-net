using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Neptune;
using Amazon.Neptune.Model;

namespace AWSSDKDocSamples.Amazon.Neptune.Generated
{
    class NeptuneSamples : ISample
    {
        static IAmazonNeptune client = new AmazonNeptuneClient();
        public void NeptuneAddSourceIdentifierToSubscription()
        {
            #region add-source-identifier-to-subscription-93fb6a15-0a59-4577-a7b5-e12db9752c14

            var response = client.AddSourceIdentifierToSubscription(new AddSourceIdentifierToSubscriptionRequest 
            {
                SourceIdentifier = "mymysqlinstance",
                SubscriptionName = "mymysqleventsubscription"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void NeptuneAddTagsToResource()
        {
            #region add-tags-to-resource-fa99ef50-228b-449d-b893-ca4d4e9768ab

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

        public void NeptuneApplyPendingMaintenanceAction()
        {
            #region apply-pending-maintenance-action-2a026047-8bbb-47fc-b695-abad9f308c24

            var response = client.ApplyPendingMaintenanceAction(new ApplyPendingMaintenanceActionRequest 
            {
                ApplyAction = "system-update",
                OptInType = "immediate",
                ResourceIdentifier = "arn:aws:rds:us-east-1:992648334831:db:mymysqlinstance"
            });

            ResourcePendingMaintenanceActions resourcePendingMaintenanceActions = response.ResourcePendingMaintenanceActions;

            #endregion
        }

        public void NeptuneCopyDBClusterParameterGroup()
        {
            #region copy-db-cluster-parameter-group-6fefaffe-cde9-4dba-9f0b-d3f593572fe4

            var response = client.CopyDBClusterParameterGroup(new CopyDBClusterParameterGroupRequest 
            {
                SourceDBClusterParameterGroupIdentifier = "mydbclusterparametergroup",
                TargetDBClusterParameterGroupDescription = "My DB cluster parameter group copy",
                TargetDBClusterParameterGroupIdentifier = "mydbclusterparametergroup-copy"
            });

            DBClusterParameterGroup dbClusterParameterGroup = response.DBClusterParameterGroup;

            #endregion
        }

        public void NeptuneCopyDBClusterSnapshot()
        {
            #region to-copy-a-db-cluster-snapshot-1473879770564

            var response = client.CopyDBClusterSnapshot(new CopyDBClusterSnapshotRequest 
            {
                SourceDBClusterSnapshotIdentifier = "rds:sample-cluster-2016-09-14-10-38",
                TargetDBClusterSnapshotIdentifier = "cluster-snapshot-copy-1"
            });

            DBClusterSnapshot dbClusterSnapshot = response.DBClusterSnapshot;

            #endregion
        }

        public void NeptuneCopyDBParameterGroup()
        {
            #region copy-db-parameter-group-610d4dba-2c87-467f-ae5d-edd7f8e47349

            var response = client.CopyDBParameterGroup(new CopyDBParameterGroupRequest 
            {
                SourceDBParameterGroupIdentifier = "mymysqlparametergroup",
                TargetDBParameterGroupDescription = "My MySQL parameter group copy",
                TargetDBParameterGroupIdentifier = "mymysqlparametergroup-copy"
            });

            DBParameterGroup dbParameterGroup = response.DBParameterGroup;

            #endregion
        }

        public void NeptuneCreateDBCluster()
        {
            #region create-db-cluster-423b998d-eba9-40dd-8e19-96c5b6e5f31d

            var response = client.CreateDBCluster(new CreateDBClusterRequest 
            {
                AvailabilityZones = new List<string> {
                    "us-east-1a"
                },
                BackupRetentionPeriod = 1,
                DBClusterIdentifier = "mydbcluster",
                DBClusterParameterGroupName = "mydbclusterparametergroup",
                DatabaseName = "myauroradb",
                Engine = "aurora",
                EngineVersion = "5.6.10a",
                MasterUserPassword = "mypassword",
                MasterUsername = "myuser",
                Port = 3306,
                StorageEncrypted = true
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void NeptuneCreateDBClusterParameterGroup()
        {
            #region create-db-cluster-parameter-group-8eb1c3ae-1965-4262-afe3-ee134c4430b1

            var response = client.CreateDBClusterParameterGroup(new CreateDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup",
                DBParameterGroupFamily = "aurora5.6",
                Description = "My DB cluster parameter group"
            });

            DBClusterParameterGroup dbClusterParameterGroup = response.DBClusterParameterGroup;

            #endregion
        }

        public void NeptuneCreateDBClusterSnapshot()
        {
            #region create-db-cluster-snapshot-

            var response = client.CreateDBClusterSnapshot(new CreateDBClusterSnapshotRequest 
            {
                DBClusterIdentifier = "mydbcluster",
                DBClusterSnapshotIdentifier = "mydbclustersnapshot"
            });

            DBClusterSnapshot dbClusterSnapshot = response.DBClusterSnapshot;

            #endregion
        }

        public void NeptuneCreateDBInstance()
        {
            #region create-db-instance-57eb5d16-8bf8-4c84-9709-1700322b37b9

            var response = client.CreateDBInstance(new CreateDBInstanceRequest 
            {
                AllocatedStorage = 5,
                DBInstanceClass = "db.t2.micro",
                DBInstanceIdentifier = "mymysqlinstance",
                Engine = "MySQL",
                MasterUserPassword = "MyPassword",
                MasterUsername = "MyUser"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void NeptuneCreateDBParameterGroup()
        {
            #region create-db-parameter-group-42afcc37-12e9-4b6a-a55c-b8a141246e87

            var response = client.CreateDBParameterGroup(new CreateDBParameterGroupRequest 
            {
                DBParameterGroupFamily = "mysql5.6",
                DBParameterGroupName = "mymysqlparametergroup",
                Description = "My MySQL parameter group"
            });

            DBParameterGroup dbParameterGroup = response.DBParameterGroup;

            #endregion
        }

        public void NeptuneCreateDBSubnetGroup()
        {
            #region create-db-subnet-group-c3d162c2-0ec4-4955-ba89-18967615fdb8

            var response = client.CreateDBSubnetGroup(new CreateDBSubnetGroupRequest 
            {
                DBSubnetGroupDescription = "My DB subnet group",
                DBSubnetGroupName = "mydbsubnetgroup",
                SubnetIds = new List<string> {
                    "subnet-1fab8a69",
                    "subnet-d43a468c"
                }
            });

            DBSubnetGroup dbSubnetGroup = response.DBSubnetGroup;

            #endregion
        }

        public void NeptuneCreateEventSubscription()
        {
            #region create-event-subscription-00dd0ee6-0e0f-4a38-ae83-e5f2ded5f69a

            var response = client.CreateEventSubscription(new CreateEventSubscriptionRequest 
            {
                Enabled = true,
                EventCategories = new List<string> {
                    "availability"
                },
                SnsTopicArn = "arn:aws:sns:us-east-1:992648334831:MyDemoSNSTopic",
                SourceIds = new List<string> {
                    "mymysqlinstance"
                },
                SourceType = "db-instance",
                SubscriptionName = "mymysqleventsubscription"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void NeptuneDeleteDBCluster()
        {
            #region delete-db-cluster-927fc2c8-6c67-4075-b1ba-75490be0f7d6

            var response = client.DeleteDBCluster(new DeleteDBClusterRequest 
            {
                DBClusterIdentifier = "mydbcluster",
                SkipFinalSnapshot = true
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void NeptuneDeleteDBClusterParameterGroup()
        {
            #region delete-db-cluster-parameter-group-364f5555-ba0a-4cc8-979c-e769098924fc

            var response = client.DeleteDBClusterParameterGroup(new DeleteDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup"
            });


            #endregion
        }

        public void NeptuneDeleteDBClusterSnapshot()
        {
            #region delete-db-cluster-snapshot-c67e0d95-670e-4fb5-af90-6d9a70a91b07

            var response = client.DeleteDBClusterSnapshot(new DeleteDBClusterSnapshotRequest 
            {
                DBClusterSnapshotIdentifier = "mydbclustersnapshot"
            });

            DBClusterSnapshot dbClusterSnapshot = response.DBClusterSnapshot;

            #endregion
        }

        public void NeptuneDeleteDBInstance()
        {
            #region delete-db-instance-4412e650-949c-488a-b32a-7d3038ebccc4

            var response = client.DeleteDBInstance(new DeleteDBInstanceRequest 
            {
                DBInstanceIdentifier = "mymysqlinstance",
                SkipFinalSnapshot = true
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void NeptuneDeleteDBParameterGroup()
        {
            #region to-delete-a-db-parameter-group-1473888796509

            var response = client.DeleteDBParameterGroup(new DeleteDBParameterGroupRequest 
            {
                DBParameterGroupName = "mydbparamgroup3"
            });


            #endregion
        }

        public void NeptuneDeleteDBSubnetGroup()
        {
            #region delete-db-subnet-group-4ae00375-511e-443d-a01d-4b9f552244aa

            var response = client.DeleteDBSubnetGroup(new DeleteDBSubnetGroupRequest 
            {
                DBSubnetGroupName = "mydbsubnetgroup"
            });


            #endregion
        }

        public void NeptuneDeleteEventSubscription()
        {
            #region delete-db-event-subscription-d33567e3-1d5d-48ff-873f-0270453f4a75

            var response = client.DeleteEventSubscription(new DeleteEventSubscriptionRequest 
            {
                SubscriptionName = "myeventsubscription"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void NeptuneDescribeDBClusterParameterGroups()
        {
            #region describe-db-cluster-parameter-groups-cf9c6e66-664e-4f57-8e29-a9080abfc013

            var response = client.DescribeDBClusterParameterGroups(new DescribeDBClusterParameterGroupsRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup"
            });


            #endregion
        }

        public void NeptuneDescribeDBClusterParameters()
        {
            #region describe-db-cluster-parameters-98043c28-e489-41a7-b118-bfd96dc779a1

            var response = client.DescribeDBClusterParameters(new DescribeDBClusterParametersRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup",
                Source = "system"
            });


            #endregion
        }

        public void NeptuneDescribeDBClusters()
        {
            #region describe-db-clusters-7aae8861-cb95-4b3b-9042-f62df7698635

            var response = client.DescribeDBClusters(new DescribeDBClustersRequest 
            {
                DBClusterIdentifier = "mynewdbcluster"
            });


            #endregion
        }

        public void NeptuneDescribeDBClusterSnapshotAttributes()
        {
            #region describe-db-cluster-snapshot-attributes-6752ade3-0c7b-4b06-a8e4-b76bf4e2d3571

            var response = client.DescribeDBClusterSnapshotAttributes(new DescribeDBClusterSnapshotAttributesRequest 
            {
                DBClusterSnapshotIdentifier = "mydbclustersnapshot"
            });

            DBClusterSnapshotAttributesResult dbClusterSnapshotAttributesResult = response.DBClusterSnapshotAttributesResult;

            #endregion
        }

        public void NeptuneDescribeDBClusterSnapshots()
        {
            #region describe-db-cluster-snapshots-52f38af1-3431-4a51-9a6a-e6bb8c961b32

            var response = client.DescribeDBClusterSnapshots(new DescribeDBClusterSnapshotsRequest 
            {
                DBClusterSnapshotIdentifier = "mydbclustersnapshot",
                SnapshotType = "manual"
            });


            #endregion
        }

        public void NeptuneDescribeDBEngineVersions()
        {
            #region describe-db-engine-versions-8e698cf2-2162-425a-a854-111cdaceb52b

            var response = client.DescribeDBEngineVersions(new DescribeDBEngineVersionsRequest 
            {
                DBParameterGroupFamily = "mysql5.6",
                DefaultOnly = true,
                Engine = "mysql",
                EngineVersion = "5.6",
                ListSupportedCharacterSets = true
            });


            #endregion
        }

        public void NeptuneDescribeDBInstances()
        {
            #region describe-db-instances-0e11a8c5-4ec3-4463-8cbf-f7254d04c4fc

            var response = client.DescribeDBInstances(new DescribeDBInstancesRequest 
            {
                DBInstanceIdentifier = "mymysqlinstance"
            });


            #endregion
        }

        public void NeptuneDescribeDBParameterGroups()
        {
            #region describe-db-parameter-groups-

            var response = client.DescribeDBParameterGroups(new DescribeDBParameterGroupsRequest 
            {
                DBParameterGroupName = "mymysqlparametergroup"
            });


            #endregion
        }

        public void NeptuneDescribeDBParameters()
        {
            #region describe-db-parameters-09db4201-ef4f-4d97-a4b5-d71c0715b901

            var response = client.DescribeDBParameters(new DescribeDBParametersRequest 
            {
                DBParameterGroupName = "mymysqlparametergroup",
                MaxRecords = 20,
                Source = "system"
            });


            #endregion
        }

        public void NeptuneDescribeDBSubnetGroups()
        {
            #region describe-db-subnet-groups-1d97b340-682f-4dd6-9653-8ed72a8d1221

            var response = client.DescribeDBSubnetGroups(new DescribeDBSubnetGroupsRequest 
            {
                DBSubnetGroupName = "mydbsubnetgroup"
            });


            #endregion
        }

        public void NeptuneDescribeEngineDefaultClusterParameters()
        {
            #region describe-engine-default-cluster-parameters-f130374a-7bee-434b-b51d-da20b6e000e0

            var response = client.DescribeEngineDefaultClusterParameters(new DescribeEngineDefaultClusterParametersRequest 
            {
                DBParameterGroupFamily = "aurora5.6"
            });

            EngineDefaults engineDefaults = response.EngineDefaults;

            #endregion
        }

        public void NeptuneDescribeEngineDefaultParameters()
        {
            #region describe-engine-default-parameters-35d5108e-1d44-4fac-8aeb-04b8fdfface1

            var response = client.DescribeEngineDefaultParameters(new DescribeEngineDefaultParametersRequest 
            {
                DBParameterGroupFamily = "mysql5.6"
            });

            EngineDefaults engineDefaults = response.EngineDefaults;

            #endregion
        }

        public void NeptuneDescribeEventCategories()
        {
            #region describe-event-categories-97bd4c77-12da-4be6-b42f-edf77771428b

            var response = client.DescribeEventCategories(new DescribeEventCategoriesRequest 
            {
                SourceType = "db-instance"
            });


            #endregion
        }

        public void NeptuneDescribeEvents()
        {
            #region describe-events-3836e5ed-3913-4f76-8452-c77fcad5016b

            var response = client.DescribeEvents(new DescribeEventsRequest 
            {
                Duration = 10080,
                EventCategories = new List<string> {
                    "backup"
                },
                SourceIdentifier = "mymysqlinstance",
                SourceType = "db-instance"
            });


            #endregion
        }

        public void NeptuneDescribeEventSubscriptions()
        {
            #region describe-event-subscriptions-11184a82-e58a-4d0c-b558-f3a7489e0850

            var response = client.DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest 
            {
                SubscriptionName = "mymysqleventsubscription"
            });


            #endregion
        }

        public void NeptuneDescribeOrderableDBInstanceOptions()
        {
            #region describe-orderable-db-instance-options-7444d3ed-82eb-42b9-9ed9-896b8c27a782

            var response = client.DescribeOrderableDBInstanceOptions(new DescribeOrderableDBInstanceOptionsRequest 
            {
                DBInstanceClass = "db.t2.micro",
                Engine = "mysql",
                EngineVersion = "5.6.27",
                LicenseModel = "general-public-license",
                Vpc = true
            });


            #endregion
        }

        public void NeptuneDescribePendingMaintenanceActions()
        {
            #region describe-pending-maintenance-actions-e6021f7e-58ae-49cc-b874-11996176835c

            var response = client.DescribePendingMaintenanceActions(new DescribePendingMaintenanceActionsRequest 
            {
                ResourceIdentifier = "arn:aws:rds:us-east-1:992648334831:db:mymysqlinstance"
            });


            #endregion
        }

        public void NeptuneFailoverDBCluster()
        {
            #region failover-db-cluster-9e7f2f93-d98c-42c7-bb0e-d6c485c096d6

            var response = client.FailoverDBCluster(new FailoverDBClusterRequest 
            {
                DBClusterIdentifier = "myaurorainstance-cluster",
                TargetDBInstanceIdentifier = "myaurorareplica"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void NeptuneListTagsForResource()
        {
            #region list-tags-for-resource-8401f3c2-77cd-4f90-bfd5-b523f0adcc2f

            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceName = "arn:aws:rds:us-east-1:992648334831:og:mymysqloptiongroup"
            });


            #endregion
        }

        public void NeptuneModifyDBCluster()
        {
            #region modify-db-cluster-a370ee1b-768d-450a-853b-707cb1ab663d

            var response = client.ModifyDBCluster(new ModifyDBClusterRequest 
            {
                ApplyImmediately = true,
                DBClusterIdentifier = "mydbcluster",
                MasterUserPassword = "mynewpassword",
                NewDBClusterIdentifier = "mynewdbcluster",
                PreferredBackupWindow = "04:00-04:30",
                PreferredMaintenanceWindow = "Tue:05:00-Tue:05:30"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void NeptuneModifyDBClusterParameterGroup()
        {
            #region modify-db-cluster-parameter-group-f9156bc9-082a-442e-8d12-239542c1a113

            var response = client.ModifyDBClusterParameterGroup(new ModifyDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup",
                Parameters = new List<Parameter> {
                    new Parameter {
                        ApplyMethod = "immediate",
                        ParameterName = "time_zone",
                        ParameterValue = "America/Phoenix"
                    }
                }
            });


            #endregion
        }

        public void NeptuneModifyDBClusterSnapshotAttribute()
        {
            #region to-add-or-remove-access-to-a-manual-db-cluster-snapshot-1473889426431

            var response = client.ModifyDBClusterSnapshotAttribute(new ModifyDBClusterSnapshotAttributeRequest 
            {
                AttributeName = "restore",
                DBClusterSnapshotIdentifier = "manual-cluster-snapshot1",
                ValuesToAdd = new List<string> {
                    "123451234512",
                    "123456789012"
                },
                ValuesToRemove = new List<string> {
                    "all"
                }
            });

            DBClusterSnapshotAttributesResult dbClusterSnapshotAttributesResult = response.DBClusterSnapshotAttributesResult;

            #endregion
        }

        public void NeptuneModifyDBInstance()
        {
            #region modify-db-instance-6979a368-6254-467b-8a8d-61103f4fcde9

            var response = client.ModifyDBInstance(new ModifyDBInstanceRequest 
            {
                AllocatedStorage = 10,
                ApplyImmediately = true,
                BackupRetentionPeriod = 1,
                DBInstanceClass = "db.t2.small",
                DBInstanceIdentifier = "mymysqlinstance",
                MasterUserPassword = "mynewpassword",
                PreferredBackupWindow = "04:00-04:30",
                PreferredMaintenanceWindow = "Tue:05:00-Tue:05:30"
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void NeptuneModifyDBParameterGroup()
        {
            #region modify-db-parameter-group-f3a4e52a-68e4-4b88-b559-f912d34c457a

            var response = client.ModifyDBParameterGroup(new ModifyDBParameterGroupRequest 
            {
                DBParameterGroupName = "mymysqlparametergroup",
                Parameters = new List<Parameter> {
                    new Parameter {
                        ApplyMethod = "immediate",
                        ParameterName = "time_zone",
                        ParameterValue = "America/Phoenix"
                    }
                }
            });


            #endregion
        }

        public void NeptuneModifyDBSubnetGroup()
        {
            #region modify-db-subnet-group-e34a97d9-8fe6-4239-a4ed-ad6e73a956b0

            var response = client.ModifyDBSubnetGroup(new ModifyDBSubnetGroupRequest 
            {
                DBSubnetGroupName = "mydbsubnetgroup",
                SubnetIds = new List<string> {
                    "subnet-70e1975a",
                    "subnet-747a5c49"
                }
            });

            DBSubnetGroup dbSubnetGroup = response.DBSubnetGroup;

            #endregion
        }

        public void NeptuneModifyEventSubscription()
        {
            #region modify-event-subscription-405ac869-1f02-42cd-b8f4-6950a435f30e

            var response = client.ModifyEventSubscription(new ModifyEventSubscriptionRequest 
            {
                Enabled = true,
                EventCategories = new List<string> {
                    "deletion",
                    "low storage"
                },
                SourceType = "db-instance",
                SubscriptionName = "mymysqleventsubscription"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void NeptuneRebootDBInstance()
        {
            #region reboot-db-instance-b9ce8a0a-2920-451d-a1f3-01d288aa7366

            var response = client.RebootDBInstance(new RebootDBInstanceRequest 
            {
                DBInstanceIdentifier = "mymysqlinstance",
                ForceFailover = false
            });

            DBInstance dbInstance = response.DBInstance;

            #endregion
        }

        public void NeptuneRemoveSourceIdentifierFromSubscription()
        {
            #region remove-source-identifier-from-subscription-30d25493-c19d-4cf7-b4e5-68371d0d8770

            var response = client.RemoveSourceIdentifierFromSubscription(new RemoveSourceIdentifierFromSubscriptionRequest 
            {
                SourceIdentifier = "mymysqlinstance",
                SubscriptionName = "myeventsubscription"
            });

            EventSubscription eventSubscription = response.EventSubscription;

            #endregion
        }

        public void NeptuneRemoveTagsFromResource()
        {
            #region remove-tags-from-resource-49f00574-38f6-4d01-ac89-d3c668449ce3

            var response = client.RemoveTagsFromResource(new RemoveTagsFromResourceRequest 
            {
                ResourceName = "arn:aws:rds:us-east-1:992648334831:og:mydboptiongroup",
                TagKeys = new List<string> {
                    "MyKey"
                }
            });


            #endregion
        }

        public void NeptuneResetDBClusterParameterGroup()
        {
            #region reset-db-cluster-parameter-group-b04aeaf7-7f73-49e1-9bb4-857573ea3ee4

            var response = client.ResetDBClusterParameterGroup(new ResetDBClusterParameterGroupRequest 
            {
                DBClusterParameterGroupName = "mydbclusterparametergroup",
                ResetAllParameters = true
            });


            #endregion
        }

        public void NeptuneResetDBParameterGroup()
        {
            #region reset-db-parameter-group-ed2ed723-de0d-4824-8af5-3c65fa130abf

            var response = client.ResetDBParameterGroup(new ResetDBParameterGroupRequest 
            {
                DBParameterGroupName = "mydbparametergroup",
                ResetAllParameters = true
            });


            #endregion
        }

        public void NeptuneRestoreDBClusterFromSnapshot()
        {
            #region to-restore-an-amazon-aurora-db-cluster-from-a-db-cluster-snapshot-1473958144325

            var response = client.RestoreDBClusterFromSnapshot(new RestoreDBClusterFromSnapshotRequest 
            {
                DBClusterIdentifier = "restored-cluster1",
                Engine = "aurora",
                SnapshotIdentifier = "sample-cluster-snapshot1"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        public void NeptuneRestoreDBClusterToPointInTime()
        {
            #region to-restore-a-db-cluster-to-a-point-in-time-1473962082214

            var response = client.RestoreDBClusterToPointInTime(new RestoreDBClusterToPointInTimeRequest 
            {
                DBClusterIdentifier = "sample-restored-cluster1",
                RestoreToTime = new DateTime(2016, 9, 13, 11, 45, 0),
                SourceDBClusterIdentifier = "sample-cluster1"
            });

            DBCluster dbCluster = response.DBCluster;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}