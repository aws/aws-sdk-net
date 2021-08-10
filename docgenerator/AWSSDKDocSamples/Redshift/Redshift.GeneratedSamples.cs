using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Redshift;
using Amazon.Redshift.Model;

namespace AWSSDKDocSamples.Amazon.Redshift.Generated
{
    class RedshiftSamples : ISample
    {
        public void RedshiftAuthorizeClusterSecurityGroupIngress()
        {
            #region authorizing-access-to-an-ec2-security-group-1481675923213

            var client = new AmazonRedshiftClient();
            var response = client.AuthorizeClusterSecurityGroupIngress(new AuthorizeClusterSecurityGroupIngressRequest 
            {
                ClusterSecurityGroupName = "mysecuritygroup",
                EC2SecurityGroupName = "myec2securitygroup",
                EC2SecurityGroupOwnerId = "123445677890"
            });


            #endregion
        }

        public void RedshiftAuthorizeSnapshotAccess()
        {
            #region to-authorize-an-aws-account-to-restore-from-snapshot-1482368189016

            var client = new AmazonRedshiftClient();
            var response = client.AuthorizeSnapshotAccess(new AuthorizeSnapshotAccessRequest 
            {
                AccountWithRestoreAccess = "444455556666",
                SnapshotIdentifier = "my-snapshot-id"
            });


            #endregion
        }

        public void RedshiftCopyClusterSnapshot()
        {
            #region to--creates-a-copy-of-a-snapshot-1482357194074

            var client = new AmazonRedshiftClient();
            var response = client.CopyClusterSnapshot(new CopyClusterSnapshotRequest 
            {
                SourceSnapshotIdentifier = "rs:mycluster-2016-12-21-20-40-51",
                TargetSnapshotIdentifier = "my-saved-snapshot-cop"
            });


            #endregion
        }

        public void RedshiftCreateCluster()
        {
            #region to-create-a-cluster-with-minimal-parameters-1481678090203

            var client = new AmazonRedshiftClient();
            var response = client.CreateCluster(new CreateClusterRequest 
            {
                ClusterIdentifier = "mycluster",
                MasterUserPassword = "TopSecret1",
                MasterUsername = "adminuser ",
                NodeType = "dw.hs1.xlarge"
            });


            #endregion
        }

        public void RedshiftCreateClusterParameterGroup()
        {
            #region to-create-a-cluster-snapshot-1481844657333

            var client = new AmazonRedshiftClient();
            var response = client.CreateClusterParameterGroup(new CreateClusterParameterGroupRequest 
            {
                Description = "My first cluster parameter group",
                ParameterGroupFamily = "redshift-1.0",
                ParameterGroupName = "myclusterparametergroup"
            });


            #endregion
        }

        public void RedshiftCreateClusterSecurityGroup()
        {
            #region to-create-a-new-cluster-security-group-1481844171608

            var client = new AmazonRedshiftClient();
            var response = client.CreateClusterSecurityGroup(new CreateClusterSecurityGroupRequest 
            {
                ClusterSecurityGroupName = "mysecuritygroup",
                Description = "This is my cluster security group"
            });


            #endregion
        }

        public void RedshiftCreateClusterSnapshot()
        {
            #region to-create-a-new-cluster-snapshot-1482180269983

            var client = new AmazonRedshiftClient();
            var response = client.CreateClusterSnapshot(new CreateClusterSnapshotRequest 
            {
                ClusterIdentifier = "mycluster",
                SnapshotIdentifier = "my-snapshot-id"
            });


            #endregion
        }

        public void RedshiftCreateClusterSubnetGroup()
        {
            #region to-create-a-new-cluster-subnet-group-1482357950701

            var client = new AmazonRedshiftClient();
            var response = client.CreateClusterSubnetGroup(new CreateClusterSubnetGroupRequest 
            {
                ClusterSubnetGroupName = "mysubnetgroup",
                Description = "My subnet group",
                SubnetIds = new List<string> {
                    "subnet-abc12345"
                }
            });


            #endregion
        }

        public void RedshiftCreateEventSubscription()
        {
            #region to-create-an-event-subscription-1483132129428

            var client = new AmazonRedshiftClient();
            var response = client.CreateEventSubscription(new CreateEventSubscriptionRequest 
            {
                SnsTopicArn = "arn:aws:sns:us-west-2:123456789101:my-sns-topic",
                SubscriptionName = "mysubscription"
            });


            #endregion
        }

        public void RedshiftCreateHsmClientCertificate()
        {
            #region to-create-a-new-hsm-certificate-1482359863292

            var client = new AmazonRedshiftClient();
            var response = client.CreateHsmClientCertificate(new CreateHsmClientCertificateRequest 
            {
                HsmClientCertificateIdentifier = "my-hsm"
            });


            #endregion
        }

        public void RedshiftCreateSnapshotCopyGrant()
        {
            #region to-create-a-snapshot-copy-grant-1482180728699

            var client = new AmazonRedshiftClient();
            var response = client.CreateSnapshotCopyGrant(new CreateSnapshotCopyGrantRequest 
            {
                SnapshotCopyGrantName = "mycopygrant"
            });


            #endregion
        }

        public void RedshiftCreateTags()
        {
            #region to-create-tags--1482440094007

            var client = new AmazonRedshiftClient();
            var response = client.CreateTags(new CreateTagsRequest 
            {
                ResourceName = "arn:aws:redshift:us-west-2:644653688104:cluster:mycluster",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "owner",
                        Value = "admin"
                    },
                    new Tag {
                        Key = "test",
                        Value = "environment"
                    }
                }
            });


            #endregion
        }

        public void RedshiftDeleteEventSubscription()
        {
            #region to-delete-an-event-subscription-1483134357677

            var client = new AmazonRedshiftClient();
            var response = client.DeleteEventSubscription(new DeleteEventSubscriptionRequest 
            {
                SubscriptionName = "mysubscription"
            });


            #endregion
        }

        public void RedshiftDescribeClusterParameterGroups()
        {
            #region to-get-a-description-of-cluster-parameter-groups-1482361865953

            var client = new AmazonRedshiftClient();
            var response = client.DescribeClusterParameterGroups(new DescribeClusterParameterGroupsRequest 
            {
                Marker = "",
                MaxRecords = 123,
                ParameterGroupName = "",
                TagKeys = new List<string> {
                    
                },
                TagValues = new List<string> {
                    
                }
            });

            List<ClusterParameterGroup> parameterGroups = response.ParameterGroups;

            #endregion
        }

        public void RedshiftDescribeClusterParameters()
        {
            #region to-get-the-parameters-for-a-parameter-group-1482362769122

            var client = new AmazonRedshiftClient();
            var response = client.DescribeClusterParameters(new DescribeClusterParametersRequest 
            {
                ParameterGroupName = "myclusterparametergroup"
            });

            List<Parameter> parameters = response.Parameters;

            #endregion
        }

        public void RedshiftDescribeClusters()
        {
            #region to-get-a-description-of-all-clusters-1475865512651

            var client = new AmazonRedshiftClient();
            var response = client.DescribeClusters(new DescribeClustersRequest 
            {
            });

            List<Cluster> clusters = response.Clusters;

            #endregion
        }

        public void RedshiftDescribeClusterSecurityGroups()
        {
            #region to-get-a-description-of-cluster-security-groups-for-the-account-1482363060704

            var client = new AmazonRedshiftClient();
            var response = client.DescribeClusterSecurityGroups(new DescribeClusterSecurityGroupsRequest 
            {
            });

            List<ClusterSecurityGroup> clusterSecurityGroups = response.ClusterSecurityGroups;

            #endregion
        }

        public void RedshiftDescribeClusterSnapshots()
        {
            #region to-get-a-description-of-all-cluster-snapshots-1482181325771

            var client = new AmazonRedshiftClient();
            var response = client.DescribeClusterSnapshots(new DescribeClusterSnapshotsRequest 
            {
            });

            List<Snapshot> snapshots = response.Snapshots;

            #endregion
        }

        public void RedshiftDescribeClusterSubnetGroups()
        {
            #region to-get-a-description-of-all-cluster-subnet-groups-1481847412769

            var client = new AmazonRedshiftClient();
            var response = client.DescribeClusterSubnetGroups(new DescribeClusterSubnetGroupsRequest 
            {
            });

            List<ClusterSubnetGroup> clusterSubnetGroups = response.ClusterSubnetGroups;

            #endregion
        }

        public void RedshiftDescribeClusterVersions()
        {
            #region to-get-a-description-of-cluster-versions-1482363389639

            var client = new AmazonRedshiftClient();
            var response = client.DescribeClusterVersions(new DescribeClusterVersionsRequest 
            {
            });

            List<ClusterVersion> clusterVersions = response.ClusterVersions;

            #endregion
        }

        public void RedshiftDescribeDefaultClusterParameters()
        {
            #region to-get-a-description-of-cluster-default-parameters-1482365915635

            var client = new AmazonRedshiftClient();
            var response = client.DescribeDefaultClusterParameters(new DescribeDefaultClusterParametersRequest 
            {
                ParameterGroupFamily = "redshift-1.0"
            });


            #endregion
        }

        public void RedshiftDescribeEventCategories()
        {
            #region to-get-a-description-of-event-categories-1482366442369

            var client = new AmazonRedshiftClient();
            var response = client.DescribeEventCategories(new DescribeEventCategoriesRequest 
            {
                SourceType = "cluster"
            });

            List<EventCategoriesMap> eventCategoriesMapList = response.EventCategoriesMapList;

            #endregion
        }

        public void RedshiftDescribeEvents()
        {
            #region to-get-a-description-of-events-1482367106459

            var client = new AmazonRedshiftClient();
            var response = client.DescribeEvents(new DescribeEventsRequest 
            {
                Duration = 600
            });

            List<Event> events = response.Events;

            #endregion
        }

        public void RedshiftDescribeEventSubscriptions()
        {
            #region to-describe-an-event-subscription-1483133239054

            var client = new AmazonRedshiftClient();
            var response = client.DescribeEventSubscriptions(new DescribeEventSubscriptionsRequest 
            {
                SubscriptionName = "mysubscription"
            });

            List<EventSubscription> eventSubscriptionsList = response.EventSubscriptionsList;

            #endregion
        }

        public void RedshiftDescribeHsmClientCertificates()
        {
            #region to-get-a-description-of-hsm-certificates-1482367536680

            var client = new AmazonRedshiftClient();
            var response = client.DescribeHsmClientCertificates(new DescribeHsmClientCertificatesRequest 
            {
            });

            List<HsmClientCertificate> hsmClientCertificates = response.HsmClientCertificates;

            #endregion
        }

        public void RedshiftDescribeLoggingStatus()
        {
            #region to-describe-logging-status-1483134803712

            var client = new AmazonRedshiftClient();
            var response = client.DescribeLoggingStatus(new DescribeLoggingStatusRequest 
            {
                ClusterIdentifier = "mycluster"
            });

            string bucketName = response.BucketName;
            DateTime lastSuccessfulDeliveryTime = response.LastSuccessfulDeliveryTime;
            bool loggingEnabled = response.LoggingEnabled;

            #endregion
        }

        public void RedshiftDescribeTags()
        {
            #region to-get-tags-for-a-resource-1482438593642

            var client = new AmazonRedshiftClient();
            var response = client.DescribeTags(new DescribeTagsRequest 
            {
            });

            List<TaggedResource> taggedResources = response.TaggedResources;

            #endregion
        }

        public void RedshiftDisableLogging()
        {
            #region to-disable-logging-1483135106459

            var client = new AmazonRedshiftClient();
            var response = client.DisableLogging(new DisableLoggingRequest 
            {
                ClusterIdentifier = "mycluster"
            });

            string bucketName = response.BucketName;
            DateTime lastSuccessfulDeliveryTime = response.LastSuccessfulDeliveryTime;
            bool loggingEnabled = response.LoggingEnabled;

            #endregion
        }

        public void RedshiftDisableSnapshotCopy()
        {
            #region to-disable-snapshot-copy-1482435501112

            var client = new AmazonRedshiftClient();
            var response = client.DisableSnapshotCopy(new DisableSnapshotCopyRequest 
            {
                ClusterIdentifier = "mycluster"
            });


            #endregion
        }

        public void RedshiftEnableLogging()
        {
            #region to-enable-logging-1482434657633

            var client = new AmazonRedshiftClient();
            var response = client.EnableLogging(new EnableLoggingRequest 
            {
                BucketName = "aws-logs-112233445566-us-west-2",
                ClusterIdentifier = "mycluster"
            });

            string bucketName = response.BucketName;
            bool loggingEnabled = response.LoggingEnabled;

            #endregion
        }

        public void RedshiftEnableSnapshotCopy()
        {
            #region to-enable-snapshot-copy-1482435074072

            var client = new AmazonRedshiftClient();
            var response = client.EnableSnapshotCopy(new EnableSnapshotCopyRequest 
            {
                ClusterIdentifier = "mycluster",
                DestinationRegion = "us-east-1"
            });


            #endregion
        }

        public void RedshiftModifyCluster()
        {
            #region to-modify-a-cluster-1482436093526

            var client = new AmazonRedshiftClient();
            var response = client.ModifyCluster(new ModifyClusterRequest 
            {
                ClusterIdentifier = "mycluster",
                ClusterSecurityGroups = new List<string> {
                    "mysecuritygroup"
                }
            });


            #endregion
        }

        public void RedshiftModifyClusterIamRoles()
        {
            #region to-modify-a-cluster-iam-roles-1482436895837

            var client = new AmazonRedshiftClient();
            var response = client.ModifyClusterIamRoles(new ModifyClusterIamRolesRequest 
            {
                AddIamRoles = new List<string> {
                    "arn:aws:iam::112233445566:role/myRedshiftRole"
                },
                ClusterIdentifier = "mycluster"
            });


            #endregion
        }

        public void RedshiftModifyClusterParameterGroup()
        {
            #region to-modify-a-paramter-group-1483130143433

            var client = new AmazonRedshiftClient();
            var response = client.ModifyClusterParameterGroup(new ModifyClusterParameterGroupRequest 
            {
                ParameterGroupName = "myclusterparametergroup",
                Parameters = new List<Parameter> {
                    new Parameter {
                        ApplyType = "dynamic",
                        ParameterName = "wlm_json_configuration",
                        ParameterValue = "[{\"query_group\":[\"report\"], \"query_group_wild_card\":1, \"query_concurrency\":4, \"max_execution_time\":20000, \"memory_percent_to_use\":25, \"rules\": [{\"rule_name\": \"rule_1\", \"predicate\": [{\"metric_name\": \"query_cpu_time\", \"operator\": \">\", \"value\": 1000000}, {\"metric_name\": \"query_blocks_read\", \"operator\": \">\", \"value\": 1000}], \"action\": \"log\"}] }, {\"user_group\":[\"admin\",\"dba\"], \"user_group_wild_card\":0, \"query_concurrency\":5, \"memory_percent_to_use\":40, \"rules\": [{\"rule_name\": \"rule_2\", \"predicate\": [{\"metric_name\": \"query_execution_time\", \"operator\": \">\", \"value\": 10000}, {\"metric_name\": \"scan_row_count\", \"operator\": \">\", \"value\": 1000000000}], \"action\": \"hop\"}] }, {\"query_concurrency\":5, \"memory_percent_to_use\":35 } ]"
                    }
                }
            });

            string parameterGroupName = response.ParameterGroupName;
            string parameterGroupStatus = response.ParameterGroupStatus;

            #endregion
        }

        public void RedshiftModifyClusterSubnetGroup()
        {
            #region to-modify-a-paramter-group-1483130143433

            var client = new AmazonRedshiftClient();
            var response = client.ModifyClusterSubnetGroup(new ModifyClusterSubnetGroupRequest 
            {
                ClusterSubnetGroupName = "mysubnetgroup",
                Description = "My subnet group",
                SubnetIds = new List<string> {
                    "subnet-4632f321",
                    "subnet-11312a67"
                }
            });


            #endregion
        }

        public void RedshiftModifyEventSubscription()
        {
            #region to-modify-an-event-subscription-1483132220470

            var client = new AmazonRedshiftClient();
            var response = client.ModifyEventSubscription(new ModifyEventSubscriptionRequest 
            {
                SourceType = "cluster",
                SubscriptionName = "mysubscription"
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