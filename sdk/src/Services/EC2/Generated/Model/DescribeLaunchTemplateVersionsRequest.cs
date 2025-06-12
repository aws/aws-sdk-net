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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the DescribeLaunchTemplateVersions operation.
    /// Describes one or more versions of a specified launch template. You can describe all
    /// versions, individual versions, or a range of versions. You can also describe all the
    /// latest versions or all the default versions of all the launch templates in your account.
    /// </summary>
    public partial class DescribeLaunchTemplateVersionsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private string _launchTemplateId;
        private string _launchTemplateName;
        private int? _maxResults;
        private string _maxVersion;
        private string _minVersion;
        private string _nextToken;
        private bool? _resolveAlias;
        private List<string> _versions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        public string LaunchTemplateId
        {
            get { return this._launchTemplateId; }
            set { this._launchTemplateId = value; }
        }

        // Check to see if LaunchTemplateId property is set
        internal bool IsSetLaunchTemplateId()
        {
            return this._launchTemplateId != null;
        }

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
        [AWSProperty(Min=3, Max=128)]
        public string LaunchTemplateName
        {
            get { return this._launchTemplateName; }
            set { this._launchTemplateName = value; }
        }

        // Check to see if LaunchTemplateName property is set
        internal bool IsSetLaunchTemplateName()
        {
            return this._launchTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <c>NextToken</c> value. This value can
        /// be between 1 and 200.
        /// </para>
        /// </summary>
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxVersion. 
        /// <para>
        /// The version number up to which to describe launch template versions.
        /// </para>
        /// </summary>
        public string MaxVersion
        {
            get { return this._maxVersion; }
            set { this._maxVersion = value; }
        }

        // Check to see if MaxVersion property is set
        internal bool IsSetMaxVersion()
        {
            return this._maxVersion != null;
        }

        /// <summary>
        /// Gets and sets the property MinVersion. 
        /// <para>
        /// The version number after which to describe launch template versions.
        /// </para>
        /// </summary>
        public string MinVersion
        {
            get { return this._minVersion; }
            set { this._minVersion = value; }
        }

        // Check to see if MinVersion property is set
        internal bool IsSetMinVersion()
        {
            return this._minVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to request the next page of results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

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
        public bool? ResolveAlias
        {
            get { return this._resolveAlias; }
            set { this._resolveAlias = value; }
        }

        // Check to see if ResolveAlias property is set
        internal bool IsSetResolveAlias()
        {
            return this._resolveAlias.HasValue; 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && (this._versions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}