/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The collection of computing resources from which an endpoint is created.
    /// </summary>
    public partial class Workgroup
    {
        /// <summary>
        /// Gets and sets the property BaseCapacity. 
        /// <para>
        /// The base data warehouse capacity of the workgroup in Redshift Processing Units (RPUs).
        /// </para>
        /// </summary>
        public int? BaseCapacity { get; set; }

        /// <summary>
        /// Checks to see if the BaseCapacity property is set.
        /// </summary>
        internal bool IsSetBaseCapacity() => this.BaseCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property ConfigParameters. 
        /// <para>
        /// An array of parameters to set for advanced control over a database. The options are
        /// <c>auto_mv</c>, <c>datestyle</c>, <c>enable_case_sensitive_identifier</c>, <c>enable_user_activity_logging</c>,
        /// <c>query_group</c>, <c>search_path</c>, <c>require_ssl</c>, <c>use_fips_ssl</c>, and
        /// either <c>wlm_json_configuration</c> or query monitoring metrics that let you define
        /// performance boundaries. You can either specify individual query monitoring metrics
        /// (such as <c>max_scan_row_count</c>, <c>max_query_execution_time</c>) or use <c>wlm_json_configuration</c>
        /// to define query queues with rules, but not both. If you're using <c>wlm_json_configuration</c>,
        /// the maximum size of <c>parameterValue</c> is 8000 characters. For more information
        /// about query monitoring rules and available metrics, see <a href="https://docs.aws.amazon.com/redshift/latest/dg/cm-c-wlm-query-monitoring-rules.html#cm-c-wlm-query-monitoring-metrics-serverless">
        /// Query monitoring metrics for Amazon Redshift Serverless</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigParameter> ConfigParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<ConfigParameter>() : null;

        /// <summary>
        /// Checks to see if the ConfigParameters property is set.
        /// </summary>
        internal bool IsSetConfigParameters() => this.ConfigParameters != null && (this.ConfigParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the workgroup.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property CrossAccountVpcs. 
        /// <para>
        /// A list of VPCs. Each entry is the unique identifier of a virtual private cloud with
        /// access to Amazon Redshift Serverless. If all of the VPCs for the grantee are allowed,
        /// it shows an asterisk.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CrossAccountVpcs { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CrossAccountVpcs property is set.
        /// </summary>
        internal bool IsSetCrossAccountVpcs() => this.CrossAccountVpcs != null && (this.CrossAccountVpcs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The custom domain name’s certificate Amazon resource name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string CustomDomainCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainCertificateArn property is set.
        /// </summary>
        internal bool IsSetCustomDomainCertificateArn() => this.CustomDomainCertificateArn != null;

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateExpiryTime. 
        /// <para>
        /// The expiration time for the certificate.
        /// </para>
        /// </summary>
        public DateTime? CustomDomainCertificateExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainCertificateExpiryTime property is set.
        /// </summary>
        internal bool IsSetCustomDomainCertificateExpiryTime() => this.CustomDomainCertificateExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name associated with the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string CustomDomainName { get; set; }

        /// <summary>
        /// Checks to see if the CustomDomainName property is set.
        /// </summary>
        internal bool IsSetCustomDomainName() => this.CustomDomainName != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint that is created from the workgroup.
        /// </para>
        /// </summary>
        public Endpoint Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// The value that specifies whether to enable enhanced virtual private cloud (VPC) routing,
        /// which forces Amazon Redshift Serverless to route traffic through your VPC.
        /// </para>
        /// </summary>
        public bool? EnhancedVpcRouting { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedVpcRouting property is set.
        /// </summary>
        internal bool IsSetEnhancedVpcRouting() => this.EnhancedVpcRouting.HasValue;

        /// <summary>
        /// Gets and sets the property ExtraComputeForAutomaticOptimization. 
        /// <para>
        /// A boolean value that, if <c>true</c>, indicates that the workgroup allocates additional
        /// compute resources to run automatic optimization operations.
        /// </para>
        ///  
        /// <para>
        /// Default: false
        /// </para>
        /// </summary>
        public bool? ExtraComputeForAutomaticOptimization { get; set; }

        /// <summary>
        /// Checks to see if the ExtraComputeForAutomaticOptimization property is set.
        /// </summary>
        internal bool IsSetExtraComputeForAutomaticOptimization() => this.ExtraComputeForAutomaticOptimization.HasValue;

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type that the workgroup supports. Possible values are <c>ipv4</c> and
        /// <c>dualstack</c>.
        /// </para>
        /// </summary>
        public string IpAddressType { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressType property is set.
        /// </summary>
        internal bool IsSetIpAddressType() => this.IpAddressType != null;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum data-warehouse capacity Amazon Redshift Serverless uses to serve queries.
        /// The max capacity is specified in RPUs.
        /// </para>
        /// </summary>
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The namespace the workgroup is associated with.
        /// </para>
        /// </summary>
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;

        /// <summary>
        /// Gets and sets the property PatchVersion. 
        /// <para>
        /// The patch version of your Amazon Redshift Serverless workgroup. For more information
        /// about patch versions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/cluster-versions.html">Cluster
        /// versions for Amazon Redshift</a>.
        /// </para>
        /// </summary>
        public string PatchVersion { get; set; }

        /// <summary>
        /// Checks to see if the PatchVersion property is set.
        /// </summary>
        internal bool IsSetPatchVersion() => this.PatchVersion != null;

        /// <summary>
        /// Gets and sets the property PendingTrackName. 
        /// <para>
        /// The name for the track that you want to assign to the workgroup. When the track changes,
        /// the workgroup is switched to the latest workgroup release available for the track.
        /// At this point, the track name is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string PendingTrackName { get; set; }

        /// <summary>
        /// Checks to see if the PendingTrackName property is set.
        /// </summary>
        internal bool IsSetPendingTrackName() => this.PendingTrackName != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The custom port to use when connecting to a workgroup. Valid port ranges are 5431-5455
        /// and 8191-8215. The default is 5439.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property PricePerformanceTarget. 
        /// <para>
        /// An object that represents the price performance target settings for the workgroup.
        /// </para>
        /// </summary>
        public PerformanceTarget PricePerformanceTarget { get; set; }

        /// <summary>
        /// Checks to see if the PricePerformanceTarget property is set.
        /// </summary>
        internal bool IsSetPricePerformanceTarget() => this.PricePerformanceTarget != null;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// A value that specifies whether the workgroup can be accessible from a public network.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// An array of security group IDs to associate with the workgroup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the workgroup.
        /// </para>
        /// </summary>
        public WorkgroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// An array of subnet IDs the workgroup is associated with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrackName. 
        /// <para>
        /// The name of the track for the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TrackName { get; set; }

        /// <summary>
        /// Checks to see if the TrackName property is set.
        /// </summary>
        internal bool IsSetTrackName() => this.TrackName != null;

        /// <summary>
        /// Gets and sets the property WorkgroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that links to the workgroup.
        /// </para>
        /// </summary>
        public string WorkgroupArn { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupArn property is set.
        /// </summary>
        internal bool IsSetWorkgroupArn() => this.WorkgroupArn != null;

        /// <summary>
        /// Gets and sets the property WorkgroupId. 
        /// <para>
        /// The unique identifier of the workgroup.
        /// </para>
        /// </summary>
        public string WorkgroupId { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupId property is set.
        /// </summary>
        internal bool IsSetWorkgroupId() => this.WorkgroupId != null;

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string WorkgroupName { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupName property is set.
        /// </summary>
        internal bool IsSetWorkgroupName() => this.WorkgroupName != null;

        /// <summary>
        /// Gets and sets the property WorkgroupVersion. 
        /// <para>
        /// The Amazon Redshift Serverless version of your workgroup. For more information about
        /// Amazon Redshift Serverless versions, see<a href="https://docs.aws.amazon.com/redshift/latest/mgmt/cluster-versions.html">Cluster
        /// versions for Amazon Redshift</a>.
        /// </para>
        /// </summary>
        public string WorkgroupVersion { get; set; }

        /// <summary>
        /// Checks to see if the WorkgroupVersion property is set.
        /// </summary>
        internal bool IsSetWorkgroupVersion() => this.WorkgroupVersion != null;
    }
}
