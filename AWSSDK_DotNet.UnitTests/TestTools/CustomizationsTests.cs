using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.CloudFront.Model;
using Amazon.CloudFront;


namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class CustomizationsTests
    {	
        [TestMethod][TestCategory("UnitTest")]
        public void EnsureAutoScalingCustomizationsExists()
        {
            NoopCall(() => new Amazon.AutoScaling.Model.AdjustmentType().Type);

            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeAccountLimits");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeAdjustmentTypes");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeAutoScalingGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeAutoScalingInstances");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeAutoScalingNotificationTypes");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeLaunchConfigurations");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeMetricCollectionTypes");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeNotificationConfigurations");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribePolicies");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeScalingActivities");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeScalingProcessTypes");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeScheduledActions");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeTags");
            EnsureParameterlessMethodExists(typeof(Amazon.AutoScaling.AmazonAutoScalingClient), "DescribeTerminationPolicyTypes");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureCloudFrontCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "ListDistributions");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "ListCloudFrontOriginAccessIdentities");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "DeleteCloudFrontOriginAccessIdentity");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "DeleteDistribution");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "DeleteStreamingDistribution");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "GetCloudFrontOriginAccessIdentity");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "GetCloudFrontOriginAccessIdentityConfig");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "GetDistribution");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "GetDistributionConfig");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "GetStreamingDistribution");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "GetStreamingDistributionConfig");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudFront.AmazonCloudFrontClient), "ListStreamingDistributions");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureCloudTrailCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.CloudTrail.AmazonCloudTrailClient), "DescribeTrails");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureCloudWatchCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.CloudWatch.AmazonCloudWatchClient), "DescribeAlarmHistory");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudWatch.AmazonCloudWatchClient), "DescribeAlarms");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudWatch.AmazonCloudWatchClient), "ListMetrics");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureDataPipelineCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.DataPipeline.AmazonDataPipelineClient), "ListPipelines");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureDirectConnectCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.DirectConnect.AmazonDirectConnectClient), "DescribeConnections");
            EnsureParameterlessMethodExists(typeof(Amazon.DirectConnect.AmazonDirectConnectClient), "DescribeInterconnects");
            EnsureParameterlessMethodExists(typeof(Amazon.DirectConnect.AmazonDirectConnectClient), "DescribeLocations");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureDynamoDBCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.DynamoDBv2.AmazonDynamoDBClient), "ListTables");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureEC2CustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "AllocateAddress");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "CreateInternetGateway");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DeleteSpotDatafeedSubscription");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeAccountAttributes");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeAddresses");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeAvailabilityZones");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeBundleTasks");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeConversionTasks");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeCustomerGateways");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeDhcpOptions");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeExportTasks");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeImages");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeInstanceStatus");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeInstances");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeInternetGateways");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeKeyPairs");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeNetworkAcls");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeNetworkInterfaces");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribePlacementGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeRegions");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeReservedInstances");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeReservedInstancesListings");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeReservedInstancesModifications");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeReservedInstancesOfferings");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeRouteTables");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeSecurityGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeSnapshots");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeSpotDatafeedSubscription");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeSpotInstanceRequests");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeSpotPriceHistory");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeSubnets");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeTags");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeVolumeStatus");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeVolumes");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeVpcs");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeVpnConnections");
            EnsureParameterlessMethodExists(typeof(Amazon.EC2.AmazonEC2Client), "DescribeVpnGateways");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureElastiCacheCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeCacheClusters");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeCacheEngineVersions");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeCacheParameterGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeCacheSecurityGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeCacheSubnetGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeEvents");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeReplicationGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeReservedCacheNodes");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeReservedCacheNodesOfferings");
            EnsureParameterlessMethodExists(typeof(Amazon.ElastiCache.AmazonElastiCacheClient), "DescribeSnapshots");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureElasticBeanstalkCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticBeanstalk.AmazonElasticBeanstalkClient), "CreateStorageLocation");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticBeanstalk.AmazonElasticBeanstalkClient), "DescribeApplicationVersions");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticBeanstalk.AmazonElasticBeanstalkClient), "DescribeApplications");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticBeanstalk.AmazonElasticBeanstalkClient), "DescribeConfigurationOptions");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticBeanstalk.AmazonElasticBeanstalkClient), "DescribeEnvironments");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticBeanstalk.AmazonElasticBeanstalkClient), "DescribeEvents");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticBeanstalk.AmazonElasticBeanstalkClient), "ListAvailableSolutionStacks");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureElasticLoadBalancingCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancingClient), "DescribeLoadBalancerPolicies");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancingClient), "DescribeLoadBalancerPolicyTypes");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticLoadBalancing.AmazonElasticLoadBalancingClient), "DescribeLoadBalancers");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureElasticMapReduceCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "DescribeCluster");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "DescribeJobFlows");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "DescribeStep");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "ListBootstrapActions");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "ListClusters");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "ListInstanceGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "ListInstances");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticMapReduce.AmazonElasticMapReduceClient), "ListSteps");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureElasticTranscoderCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticTranscoder.AmazonElasticTranscoderClient), "ListPresets");
            EnsureParameterlessMethodExists(typeof(Amazon.ElasticTranscoder.AmazonElasticTranscoderClient), "ListPipelines");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureSimpleEmailCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "GetSendQuota");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "GetSendStatistics");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "ListIdentities");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "ListVerifiedEmailAddresses");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureIdentityManagementCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListUsers");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "UpdateAccountPasswordPolicy");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListRoles");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListInstanceProfiles");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListAccessKeys");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetAccountPasswordPolicy");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "DeleteAccountPasswordPolicy");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListSAMLProviders");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListAccountAliases");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListMFADevices");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListSigningCertificates");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListVirtualMFADevices");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetAccountSummary");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "CreateAccessKey");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "GetUser");
            EnsureParameterlessMethodExists(typeof(Amazon.IdentityManagement.AmazonIdentityManagementServiceClient), "ListServerCertificates");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureImportExportCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.ImportExport.AmazonImportExportClient), "ListJobs");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureKinesisCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.Kinesis.AmazonKinesisClient), "ListStreams");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureLogsCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.CloudWatchLogs.AmazonCloudWatchLogsClient), "DescribeLogGroups");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureMonitoringCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.CloudWatch.AmazonCloudWatchClient), "DescribeAlarmHistory");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudWatch.AmazonCloudWatchClient), "DescribeAlarms");
            EnsureParameterlessMethodExists(typeof(Amazon.CloudWatch.AmazonCloudWatchClient), "ListMetrics");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureOpsWorksCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.OpsWorks.AmazonOpsWorksClient), "DescribeElasticLoadBalancers");
            EnsureParameterlessMethodExists(typeof(Amazon.OpsWorks.AmazonOpsWorksClient), "DescribeMyUserProfile");
            EnsureParameterlessMethodExists(typeof(Amazon.OpsWorks.AmazonOpsWorksClient), "DescribeUserProfiles");
            EnsureParameterlessMethodExists(typeof(Amazon.OpsWorks.AmazonOpsWorksClient), "DescribeServiceErrors");
            EnsureParameterlessMethodExists(typeof(Amazon.OpsWorks.AmazonOpsWorksClient), "DescribeStacks");
            EnsureParameterlessMethodExists(typeof(Amazon.OpsWorks.AmazonOpsWorksClient), "UpdateMyUserProfile");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureRDSCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeDBEngineVersions");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeDBInstances");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeDBParameterGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeDBSecurityGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeDBSnapshots");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeDBSubnetGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeEventCategories");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeEventSubscriptions");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeEvents");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeOptionGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeReservedDBInstances");
            EnsureParameterlessMethodExists(typeof(Amazon.RDS.AmazonRDSClient), "DescribeReservedDBInstancesOfferings");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureRedshiftCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeClusterParameterGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeClusterSecurityGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeClusterSnapshots");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeClusterSubnetGroups");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeClusterVersions");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeClusters");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeEventCategories");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeEventSubscriptions");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeEvents");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeHsmClientCertificates");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeHsmConfigurations");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeOrderableClusterOptions");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeReservedNodeOfferings");
            EnsureParameterlessMethodExists(typeof(Amazon.Redshift.AmazonRedshiftClient), "DescribeReservedNodes");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureRoute53CustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.Route53.AmazonRoute53Client), "ListHealthChecks");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureSESCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "GetSendQuota");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "GetSendStatistics");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "ListIdentities");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleEmail.AmazonSimpleEmailServiceClient), "ListVerifiedEmailAddresses");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureSimpleDBCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleDB.AmazonSimpleDBClient), "ListDomains");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureSimpleNotificationServiceCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ListPlatformApplications");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ListSubscriptions");
            EnsureParameterlessMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "ListTopics");

            EnsureSimpleMethodExists(typeof(Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient), "AddPermission", new Type[] { typeof(string), typeof(string), typeof(List<string>), typeof(List<string>) });
        }
        
        [TestMethod][TestCategory("UnitTest")]
        public void EnsureStorageGatewayCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.StorageGateway.AmazonStorageGatewayClient), "ListGateways");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureSTSCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.SecurityToken.AmazonSecurityTokenServiceClient), "GetSessionToken");
        }

        [TestMethod][TestCategory("UnitTest")]
        public void EnsureSupportCustomizationsExists()
        {
            EnsureParameterlessMethodExists(typeof(Amazon.AWSSupport.AmazonAWSSupportClient), "DescribeServices");
            EnsureParameterlessMethodExists(typeof(Amazon.AWSSupport.AmazonAWSSupportClient), "DescribeSeverityLevels");
        }

        void NoopCall(Func<object> action)
        {
        }

        void EnsureParameterlessMethodExists(Type type, string methodName)
        {
            Assert.IsNotNull(type.GetMethod(methodName, new Type[] { }), "Failed to find parameterless method " + methodName);
        }

        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}
