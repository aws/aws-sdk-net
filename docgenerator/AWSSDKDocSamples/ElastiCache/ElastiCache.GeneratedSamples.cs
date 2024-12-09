using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ElastiCache;
using Amazon.ElastiCache.Model;

namespace AWSSDKDocSamples.Amazon.ElastiCache.Generated
{
    class ElastiCacheSamples : ISample
    {
        public void ElastiCacheAddTagsToResource()
        {
            #region addtagstoresource-1482430264385

            var client = new AmazonElastiCacheClient();
            var response = client.AddTagsToResource(new AddTagsToResourceRequest 
            {
                ResourceName = "arn:aws:elasticache:us-east-1:1234567890:cluster:my-mem-cluster",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "APIVersion",
                        Value = "20150202"
                    },
                    new Tag {
                        Key = "Service",
                        Value = "ElastiCache"
                    }
                }
            });

            List<Tag> tagList = response.TagList;

            #endregion
        }

        public void ElastiCacheAuthorizeCacheSecurityGroupIngress()
        {
            #region authorizecachecachesecuritygroupingress-1483046446206

            var client = new AmazonElastiCacheClient();
            var response = client.AuthorizeCacheSecurityGroupIngress(new AuthorizeCacheSecurityGroupIngressRequest 
            {
                CacheSecurityGroupName = "my-sec-grp",
                EC2SecurityGroupName = "my-ec2-sec-grp",
                EC2SecurityGroupOwnerId = "1234567890"
            });


            #endregion
        }

        public void ElastiCacheCopySnapshot()
        {
            #region copysnapshot-1482961393820

            var client = new AmazonElastiCacheClient();
            var response = client.CopySnapshot(new CopySnapshotRequest 
            {
                SourceSnapshotName = "my-snapshot",
                TargetBucket = "",
                TargetSnapshotName = "my-snapshot-copy"
            });

            Snapshot snapshot = response.Snapshot;

            #endregion
        }

        public void ElastiCacheCreateCacheCluster()
        {
            #region createcachecluster-1474994727381

            var client = new AmazonElastiCacheClient();
            var response = client.CreateCacheCluster(new CreateCacheClusterRequest 
            {
                AZMode = "cross-az",
                CacheClusterId = "my-memcached-cluster",
                CacheNodeType = "cache.r3.large",
                CacheSubnetGroupName = "default",
                Engine = "memcached",
                EngineVersion = "1.4.24",
                NumCacheNodes = 2,
                Port = 11211
            });

            CacheCluster cacheCluster = response.CacheCluster;

            #endregion
        }

        public void ElastiCacheCreateCacheCluster()
        {
            #region createcachecluster-1474994727381

            var client = new AmazonElastiCacheClient();
            var response = client.CreateCacheCluster(new CreateCacheClusterRequest 
            {
                AutoMinorVersionUpgrade = true,
                CacheClusterId = "my-redis",
                CacheNodeType = "cache.r3.larage",
                CacheSubnetGroupName = "default",
                Engine = "redis",
                EngineVersion = "3.2.4",
                NumCacheNodes = 1,
                Port = 6379,
                PreferredAvailabilityZone = "us-east-1c",
                SnapshotRetentionLimit = 7
            });

            CacheCluster cacheCluster = response.CacheCluster;

            #endregion
        }

        public void ElastiCacheCreateCacheParameterGroup()
        {
            #region createcacheparametergroup-1474997699362

            var client = new AmazonElastiCacheClient();
            var response = client.CreateCacheParameterGroup(new CreateCacheParameterGroupRequest 
            {
                CacheParameterGroupFamily = "redis2.8",
                CacheParameterGroupName = "custom-redis2-8",
                Description = "Custom Redis 2.8 parameter group."
            });

            CacheParameterGroup cacheParameterGroup = response.CacheParameterGroup;

            #endregion
        }

        public void ElastiCacheCreateCacheSecurityGroup()
        {
            #region createcachesecuritygroup-1483041506604

            var client = new AmazonElastiCacheClient();
            var response = client.CreateCacheSecurityGroup(new CreateCacheSecurityGroupRequest 
            {
                CacheSecurityGroupName = "my-cache-sec-grp",
                Description = "Example ElastiCache security group."
            });


            #endregion
        }

        public void ElastiCacheCreateCacheSubnetGroup()
        {
            #region createcachesubnet-1483042274558

            var client = new AmazonElastiCacheClient();
            var response = client.CreateCacheSubnetGroup(new CreateCacheSubnetGroupRequest 
            {
                CacheSubnetGroupDescription = "Sample subnet group",
                CacheSubnetGroupName = "my-sn-grp2",
                SubnetIds = new List<string> {
                    "subnet-6f28c982",
                    "subnet-bcd382f3",
                    "subnet-845b3e7c0"
                }
            });

            CacheSubnetGroup cacheSubnetGroup = response.CacheSubnetGroup;

            #endregion
        }

        public void ElastiCacheCreateReplicationGroup()
        {
            #region createcachereplicationgroup-1474998730655

            var client = new AmazonElastiCacheClient();
            var response = client.CreateReplicationGroup(new CreateReplicationGroupRequest 
            {
                AutomaticFailoverEnabled = true,
                CacheNodeType = "cache.m3.medium",
                Engine = "redis",
                EngineVersion = "2.8.24",
                NumCacheClusters = 3,
                ReplicationGroupDescription = "A Redis replication group.",
                ReplicationGroupId = "my-redis-rg",
                SnapshotRetentionLimit = 30
            });

            ReplicationGroup replicationGroup = response.ReplicationGroup;

            #endregion
        }

        public void ElastiCacheCreateReplicationGroup()
        {
            #region createreplicationgroup-1483657035585

            var client = new AmazonElastiCacheClient();
            var response = client.CreateReplicationGroup(new CreateReplicationGroupRequest 
            {
                AutoMinorVersionUpgrade = true,
                CacheNodeType = "cache.m3.medium",
                CacheParameterGroupName = "default.redis3.2.cluster.on",
                Engine = "redis",
                EngineVersion = "3.2.4",
                NodeGroupConfiguration = new List<NodeGroupConfiguration> {
                    new NodeGroupConfiguration {
                        PrimaryAvailabilityZone = "us-east-1c",
                        ReplicaAvailabilityZones = new List<string> {
                            "us-east-1b"
                        },
                        ReplicaCount = 1,
                        Slots = "0-8999"
                    },
                    new NodeGroupConfiguration {
                        PrimaryAvailabilityZone = "us-east-1a",
                        ReplicaAvailabilityZones = new List<string> {
                            "us-east-1a",
                            "us-east-1c"
                        },
                        ReplicaCount = 2,
                        Slots = "9000-16383"
                    }
                },
                NumNodeGroups = 2,
                ReplicationGroupDescription = "A multi-sharded replication group",
                ReplicationGroupId = "clustered-redis-rg",
                SnapshotRetentionLimit = 8
            });

            ReplicationGroup replicationGroup = response.ReplicationGroup;

            #endregion
        }

        public void ElastiCacheCreateSnapshot()
        {
            #region createsnapshot-1474999681024

            var client = new AmazonElastiCacheClient();
            var response = client.CreateSnapshot(new CreateSnapshotRequest 
            {
                CacheClusterId = "onenoderedis",
                SnapshotName = "snapshot-1"
            });

            Snapshot snapshot = response.Snapshot;

            #endregion
        }

        public void ElastiCacheCreateSnapshot()
        {
            #region createsnapshot-1474999681024

            var client = new AmazonElastiCacheClient();
            var response = client.CreateSnapshot(new CreateSnapshotRequest 
            {
                CacheClusterId = "threenoderedis-001",
                SnapshotName = "snapshot-2"
            });

            Snapshot snapshot = response.Snapshot;

            #endregion
        }

        public void ElastiCacheCreateSnapshot()
        {
            #region createsnapshot-clustered-redis-1486144841758

            var client = new AmazonElastiCacheClient();
            var response = client.CreateSnapshot(new CreateSnapshotRequest 
            {
                ReplicationGroupId = "clusteredredis",
                SnapshotName = "snapshot-2x5"
            });

            Snapshot snapshot = response.Snapshot;

            #endregion
        }

        public void ElastiCacheDeleteCacheCluster()
        {
            #region deletecachecluster-1475010605291

            var client = new AmazonElastiCacheClient();
            var response = client.DeleteCacheCluster(new DeleteCacheClusterRequest 
            {
                CacheClusterId = "my-memcached"
            });

            CacheCluster cacheCluster = response.CacheCluster;

            #endregion
        }

        public void ElastiCacheDeleteCacheParameterGroup()
        {
            #region deletecacheparametergroup-1475010933957

            var client = new AmazonElastiCacheClient();
            var response = client.DeleteCacheParameterGroup(new DeleteCacheParameterGroupRequest 
            {
                CacheParameterGroupName = "custom-mem1-4"
            });


            #endregion
        }

        public void ElastiCacheDeleteCacheSecurityGroup()
        {
            #region deletecachesecuritygroup-1483046967507

            var client = new AmazonElastiCacheClient();
            var response = client.DeleteCacheSecurityGroup(new DeleteCacheSecurityGroupRequest 
            {
                CacheSecurityGroupName = "my-sec-group"
            });


            #endregion
        }

        public void ElastiCacheDeleteCacheSubnetGroup()
        {
            #region deletecachesubnetgroup-1475011431325

            var client = new AmazonElastiCacheClient();
            var response = client.DeleteCacheSubnetGroup(new DeleteCacheSubnetGroupRequest 
            {
                CacheSubnetGroupName = "my-subnet-group"
            });


            #endregion
        }

        public void ElastiCacheDeleteReplicationGroup()
        {
            #region deletereplicationgroup-1475011641804

            var client = new AmazonElastiCacheClient();
            var response = client.DeleteReplicationGroup(new DeleteReplicationGroupRequest 
            {
                ReplicationGroupId = "my-redis-rg",
                RetainPrimaryCluster = false
            });

            ReplicationGroup replicationGroup = response.ReplicationGroup;

            #endregion
        }

        public void ElastiCacheDeleteSnapshot()
        {
            #region deletesnapshot-1475011945779

            var client = new AmazonElastiCacheClient();
            var response = client.DeleteSnapshot(new DeleteSnapshotRequest 
            {
                SnapshotName = "snapshot-20161212"
            });

            Snapshot snapshot = response.Snapshot;

            #endregion
        }

        public void ElastiCacheDescribeCacheClusters()
        {
            #region describecacheclusters-1475012269754

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheClusters(new DescribeCacheClustersRequest 
            {
                CacheClusterId = "my-mem-cluster"
            });

            List<CacheCluster> cacheClusters = response.CacheClusters;

            #endregion
        }

        public void ElastiCacheDescribeCacheClusters()
        {
            #region describecacheclusters-1475012269754

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheClusters(new DescribeCacheClustersRequest 
            {
                CacheClusterId = "my-mem-cluster",
                ShowCacheNodeInfo = true
            });

            List<CacheCluster> cacheClusters = response.CacheClusters;

            #endregion
        }

        public void ElastiCacheDescribeCacheEngineVersions()
        {
            #region describecacheengineversions-1475012638790

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheEngineVersions(new DescribeCacheEngineVersionsRequest 
            {
            });

            List<CacheEngineVersion> cacheEngineVersions = response.CacheEngineVersions;

            #endregion
        }

        public void ElastiCacheDescribeCacheEngineVersions()
        {
            #region describecacheengineversions-1475012638790

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheEngineVersions(new DescribeCacheEngineVersionsRequest 
            {
                DefaultOnly = false,
                Engine = "redis",
                MaxRecords = 50
            });

            List<CacheEngineVersion> cacheEngineVersions = response.CacheEngineVersions;
            string marker = response.Marker;

            #endregion
        }

        public void ElastiCacheDescribeCacheParameterGroups()
        {
            #region describecacheparametergroups-1483045457557

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheParameterGroups(new DescribeCacheParameterGroupsRequest 
            {
                CacheParameterGroupName = "custom-mem1-4"
            });

            List<CacheParameterGroup> cacheParameterGroups = response.CacheParameterGroups;

            #endregion
        }

        public void ElastiCacheDescribeCacheParameters()
        {
            #region describecacheparameters-1475013576900

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheParameters(new DescribeCacheParametersRequest 
            {
                CacheParameterGroupName = "custom-redis2-8",
                MaxRecords = 100,
                Source = "user"
            });

            string marker = response.Marker;
            List<Parameter> parameters = response.Parameters;

            #endregion
        }

        public void ElastiCacheDescribeCacheSecurityGroups()
        {
            #region describecachesecuritygroups-1483047200801

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheSecurityGroups(new DescribeCacheSecurityGroupsRequest 
            {
                CacheSecurityGroupName = "my-sec-group"
            });


            #endregion
        }

        public void ElastiCacheDescribeCacheSubnetGroups()
        {
            #region describecachesubnetgroups-1482439214064

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeCacheSubnetGroups(new DescribeCacheSubnetGroupsRequest 
            {
                MaxRecords = 25
            });

            List<CacheSubnetGroup> cacheSubnetGroups = response.CacheSubnetGroups;
            string marker = response.Marker;

            #endregion
        }

        public void ElastiCacheDescribeEngineDefaultParameters()
        {
            #region describeenginedefaultparameters-1481738057686

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeEngineDefaultParameters(new DescribeEngineDefaultParametersRequest 
            {
                CacheParameterGroupFamily = "redis2.8",
                MaxRecords = 25
            });

            EngineDefaults engineDefaults = response.EngineDefaults;

            #endregion
        }

        public void ElastiCacheDescribeEvents()
        {
            #region describeevents-1481843894757

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeEvents(new DescribeEventsRequest 
            {
                Duration = 360,
                SourceType = "cache-cluster"
            });

            List<Event> events = response.Events;
            string marker = response.Marker;

            #endregion
        }

        public void ElastiCacheDescribeEvents()
        {
            #region describeevents-1481843894757

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeEvents(new DescribeEventsRequest 
            {
                StartTime = new DateTime(2016, 12, 22, 3, 0, 0, DateTimeKind.Utc)
            });

            List<Event> events = response.Events;
            string marker = response.Marker;

            #endregion
        }

        public void ElastiCacheDescribeReplicationGroups()
        {
            #region describereplicationgroups-1481742639427

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeReplicationGroups(new DescribeReplicationGroupsRequest 
            {
            });

            string marker = response.Marker;
            List<ReplicationGroup> replicationGroups = response.ReplicationGroups;

            #endregion
        }

        public void ElastiCacheDescribeReservedCacheNodes()
        {
            #region describereservedcachenodes-1481742348045

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeReservedCacheNodes(new DescribeReservedCacheNodesRequest 
            {
                MaxRecords = 25
            });


            #endregion
        }

        public void ElastiCacheDescribeReservedCacheNodesOfferings()
        {
            #region describereseredcachenodeofferings-1481742869998

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeReservedCacheNodesOfferings(new DescribeReservedCacheNodesOfferingsRequest 
            {
                MaxRecords = 20
            });

            string marker = response.Marker;
            List<ReservedCacheNodesOffering> reservedCacheNodesOfferings = response.ReservedCacheNodesOfferings;

            #endregion
        }

        public void ElastiCacheDescribeReservedCacheNodesOfferings()
        {
            #region describereseredcachenodeofferings-1481742869998

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeReservedCacheNodesOfferings(new DescribeReservedCacheNodesOfferingsRequest 
            {
                CacheNodeType = "cache.r3.large",
                Duration = "3",
                MaxRecords = 25,
                OfferingType = "Light Utilization",
                ReservedCacheNodesOfferingId = ""
            });

            string marker = response.Marker;
            List<ReservedCacheNodesOffering> reservedCacheNodesOfferings = response.ReservedCacheNodesOfferings;

            #endregion
        }

        public void ElastiCacheDescribeReservedCacheNodesOfferings()
        {
            #region describereseredcachenodeofferings-1481742869998

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeReservedCacheNodesOfferings(new DescribeReservedCacheNodesOfferingsRequest 
            {
                CacheNodeType = "",
                Duration = "",
                Marker = "",
                MaxRecords = 25,
                OfferingType = "",
                ProductDescription = "",
                ReservedCacheNodesOfferingId = "438012d3-4052-4cc7-b2e3-8d3372e0e706"
            });

            string marker = response.Marker;
            List<ReservedCacheNodesOffering> reservedCacheNodesOfferings = response.ReservedCacheNodesOfferings;

            #endregion
        }

        public void ElastiCacheDescribeSnapshots()
        {
            #region describesnapshots-1481743399584

            var client = new AmazonElastiCacheClient();
            var response = client.DescribeSnapshots(new DescribeSnapshotsRequest 
            {
                SnapshotName = "snapshot-20161212"
            });

            string marker = response.Marker;
            List<Snapshot> snapshots = response.Snapshots;

            #endregion
        }

        public void ElastiCacheListAllowedNodeTypeModifications()
        {
            #region listallowednodetypemodifications-1481748494872

            var client = new AmazonElastiCacheClient();
            var response = client.ListAllowedNodeTypeModifications(new ListAllowedNodeTypeModificationsRequest 
            {
                ReplicationGroupId = "myreplgroup"
            });

            List<string> scaleUpModifications = response.ScaleUpModifications;

            #endregion
        }

        public void ElastiCacheListAllowedNodeTypeModifications()
        {
            #region listallowednodetypemodifications-1481748494872

            var client = new AmazonElastiCacheClient();
            var response = client.ListAllowedNodeTypeModifications(new ListAllowedNodeTypeModificationsRequest 
            {
                CacheClusterId = "mycluster"
            });

            List<string> scaleUpModifications = response.ScaleUpModifications;

            #endregion
        }

        public void ElastiCacheListTagsForResource()
        {
            #region listtagsforresource-1481748784584

            var client = new AmazonElastiCacheClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest 
            {
                ResourceName = "arn:aws:elasticache:us-west-2:<my-account-id>:cluster:mycluster"
            });

            List<Tag> tagList = response.TagList;

            #endregion
        }

        public void ElastiCacheModifyCacheCluster()
        {
            #region modifycachecluster-1482962725919

            var client = new AmazonElastiCacheClient();
            var response = client.ModifyCacheCluster(new ModifyCacheClusterRequest 
            {
                ApplyImmediately = true,
                CacheClusterId = "redis-cluster",
                SnapshotRetentionLimit = 14
            });

            CacheCluster cacheCluster = response.CacheCluster;

            #endregion
        }

        public void ElastiCacheModifyCacheParameterGroup()
        {
            #region modifycacheparametergroup-1482966746787

            var client = new AmazonElastiCacheClient();
            var response = client.ModifyCacheParameterGroup(new ModifyCacheParameterGroupRequest 
            {
                CacheParameterGroupName = "custom-mem1-4",
                ParameterNameValues = new List<ParameterNameValue> {
                    new ParameterNameValue {
                        ParameterName = "binding_protocol",
                        ParameterValue = "ascii"
                    },
                    new ParameterNameValue {
                        ParameterName = "chunk_size",
                        ParameterValue = "96"
                    }
                }
            });

            string cacheParameterGroupName = response.CacheParameterGroupName;

            #endregion
        }

        public void ElastiCacheModifyCacheSubnetGroup()
        {
            #region modifycachesubnetgroup-1483043446226

            var client = new AmazonElastiCacheClient();
            var response = client.ModifyCacheSubnetGroup(new ModifyCacheSubnetGroupRequest 
            {
                CacheSubnetGroupName = "my-sn-grp",
                SubnetIds = new List<string> {
                    "subnet-bcde2345"
                }
            });

            CacheSubnetGroup cacheSubnetGroup = response.CacheSubnetGroup;

            #endregion
        }

        public void ElastiCacheModifyReplicationGroup()
        {
            #region modifyreplicationgroup-1483039689581

            var client = new AmazonElastiCacheClient();
            var response = client.ModifyReplicationGroup(new ModifyReplicationGroupRequest 
            {
                ApplyImmediately = true,
                ReplicationGroupDescription = "Modified replication group",
                ReplicationGroupId = "my-redis-rg",
                SnapshotRetentionLimit = 30,
                SnapshottingClusterId = "my-redis-rg-001"
            });

            ReplicationGroup replicationGroup = response.ReplicationGroup;

            #endregion
        }

        public void ElastiCachePurchaseReservedCacheNodesOffering()
        {
            #region purchasereservedcachenodesofferings-1483040798484

            var client = new AmazonElastiCacheClient();
            var response = client.PurchaseReservedCacheNodesOffering(new PurchaseReservedCacheNodesOfferingRequest 
            {
                ReservedCacheNodesOfferingId = "1ef01f5b-94ff-433f-a530-61a56bfc8e7a"
            });


            #endregion
        }

        public void ElastiCacheRebootCacheCluster()
        {
            #region rebootcachecluster-1482969019505

            var client = new AmazonElastiCacheClient();
            var response = client.RebootCacheCluster(new RebootCacheClusterRequest 
            {
                CacheClusterId = "custom-mem1-4  ",
                CacheNodeIdsToReboot = new List<string> {
                    "0001",
                    "0002"
                }
            });

            CacheCluster cacheCluster = response.CacheCluster;

            #endregion
        }

        public void ElastiCacheRemoveTagsFromResource()
        {
            #region removetagsfromresource-1483037920947

            var client = new AmazonElastiCacheClient();
            var response = client.RemoveTagsFromResource(new RemoveTagsFromResourceRequest 
            {
                ResourceName = "arn:aws:elasticache:us-east-1:1234567890:cluster:my-mem-cluster",
                TagKeys = new List<string> {
                    "A",
                    "C",
                    "E"
                }
            });

            List<Tag> tagList = response.TagList;

            #endregion
        }

        public void ElastiCacheResetCacheParameterGroup()
        {
            #region resetcacheparametergroup-1483038334014

            var client = new AmazonElastiCacheClient();
            var response = client.ResetCacheParameterGroup(new ResetCacheParameterGroupRequest 
            {
                CacheParameterGroupName = "custom-mem1-4",
                ResetAllParameters = true
            });

            string cacheParameterGroupName = response.CacheParameterGroupName;

            #endregion
        }

        public void ElastiCacheRevokeCacheSecurityGroupIngress()
        {
            #region describecachesecuritygroups-1483047200801

            var client = new AmazonElastiCacheClient();
            var response = client.RevokeCacheSecurityGroupIngress(new RevokeCacheSecurityGroupIngressRequest 
            {
                CacheSecurityGroupName = "my-sec-grp",
                EC2SecurityGroupName = "my-ec2-sec-grp",
                EC2SecurityGroupOwnerId = "1234567890"
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