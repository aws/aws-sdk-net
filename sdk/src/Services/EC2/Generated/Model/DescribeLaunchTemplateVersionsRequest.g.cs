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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLaunchTemplateVersions operation. Describes
    /// one or more versions of a specified launch template. You can describe all versions,
    /// individual versions, or a range of versions. You can also describe all the latest
    /// versions or all the default versions of all the launch templates in your account.
    /// </summary>
    public partial class DescribeLaunchTemplateVersionsRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>create-time</c> - The time the launch template version was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ebs-optimized</c> - A boolean that indicates whether the instance is optimized
        /// for Amazon EBS I/O.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>http-endpoint</c> - Indicates whether the HTTP metadata endpoint on your instances
        /// is enabled (<c>enabled</c> | <c>disabled</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>http-protocol-ipv4</c> - Indicates whether the IPv4 endpoint for the instance
        /// metadata service is enabled (<c>enabled</c> | <c>disabled</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>host-resource-group-arn</c> - The ARN of the host resource group in which to launch
        /// the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>http-tokens</c> - The state of token usage for your instance metadata requests
        /// (<c>optional</c> | <c>required</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>iam-instance-profile</c> - The ARN of the IAM instance profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>image-id</c> - The ID of the AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>instance-type</c> - The instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>is-default-version</c> - A boolean that indicates whether the launch template
        /// version is the default version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kernel-id</c> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>license-configuration-arn</c> - The ARN of the license configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>network-card-index</c> - The index of the network card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ram-disk-id</c> - The RAM disk ID.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IncludeManagedResources. 
        /// <para>
        /// Indicates whether to include managed resources in the output. If this parameter is
        /// set to <c>true</c>, the output includes resources that are managed by Amazon Web Services
        /// services, even if managed resource visibility is set to hidden.
        /// </para>
        /// </summary>
        public bool? IncludeManagedResources { get; set; }

        /// <summary>
        /// Checks to see if the IncludeManagedResources property is set.
        /// </summary>
        internal bool IsSetIncludeManagedResources() => this.IncludeManagedResources.HasValue;

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
        /// </para>
        ///  
        /// <para>
        /// To describe one or more versions of a specified launch template, you must specify
        /// either the launch template ID or the launch template name, but not both.
        /// </para>
        ///  
        /// <para>
        /// To describe all the latest or default launch template versions in your account, you
        /// must omit this parameter.
        /// </para>
        /// </summary>
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateId property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateId() => this.LaunchTemplateId != null;

        /// <summary>
        /// Gets and sets the property LaunchTemplateName. 
        /// <para>
        /// The name of the launch template.
        /// </para>
        ///  
        /// <para>
        /// To describe one or more versions of a specified launch template, you must specify
        /// either the launch template name or the launch template ID, but not both.
        /// </para>
        ///  
        /// <para>
        /// To describe all the latest or default launch template versions in your account, you
        /// must omit this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 128)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchTemplateName property is set.
        /// </summary>
        internal bool IsSetLaunchTemplateName() => this.LaunchTemplateName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <c>NextToken</c> value. This value can
        /// be between 1 and 200.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MaxVersion. 
        /// <para>
        /// The version number up to which to describe launch template versions.
        /// </para>
        /// </summary>
        public string MaxVersion { get; set; }

        /// <summary>
        /// Checks to see if the MaxVersion property is set.
        /// </summary>
        internal bool IsSetMaxVersion() => this.MaxVersion != null;

        /// <summary>
        /// Gets and sets the property MinVersion. 
        /// <para>
        /// The version number after which to describe launch template versions.
        /// </para>
        /// </summary>
        public string MinVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinVersion property is set.
        /// </summary>
        internal bool IsSetMinVersion() => this.MinVersion != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResolveAlias. 
        /// <para>
        /// If <c>true</c>, and if a Systems Manager parameter is specified for <c>ImageId</c>,
        /// the AMI ID is displayed in the response for <c>imageId</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>false</c>, and if a Systems Manager parameter is specified for <c>ImageId</c>,
        /// the parameter is displayed in the response for <c>imageId</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-launch-template.html#use-an-ssm-parameter-instead-of-an-ami-id">Use
        /// a Systems Manager parameter instead of an AMI ID</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? ResolveAlias { get; set; }

        /// <summary>
        /// Checks to see if the ResolveAlias property is set.
        /// </summary>
        internal bool IsSetResolveAlias() => this.ResolveAlias.HasValue;

        /// <summary>
        /// Gets and sets the property Versions. 
        /// <para>
        /// One or more versions of the launch template. Valid values depend on whether you are
        /// describing a specified launch template (by ID or name) or all launch templates in
        /// your account.
        /// </para>
        ///  
        /// <para>
        /// To describe one or more versions of a specified launch template, valid values are
        /// <c>$Latest</c>, <c>$Default</c>, and numbers.
        /// </para>
        ///  
        /// <para>
        /// To describe all launch templates in your account that are defined as the latest version,
        /// the valid value is <c>$Latest</c>. To describe all launch templates in your account
        /// that are defined as the default version, the valid value is <c>$Default</c>. You can
        /// specify <c>$Latest</c> and <c>$Default</c> in the same request. You cannot specify
        /// numbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Versions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Versions property is set.
        /// </summary>
        internal bool IsSetVersions() => this.Versions != null && (this.Versions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
