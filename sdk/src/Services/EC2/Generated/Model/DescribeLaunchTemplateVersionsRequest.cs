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
        private List<Filter> _filters = new List<Filter>();
        private string _launchTemplateId;
        private string _launchTemplateName;
        private int? _maxResults;
        private string _maxVersion;
        private string _minVersion;
        private string _nextToken;
        private bool? _resolveAlias;
        private List<string> _versions = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>create-time</code> - The time the launch template version was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ebs-optimized</code> - A boolean that indicates whether the instance is optimized
        /// for Amazon EBS I/O.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>http-endpoint</code> - Indicates whether the HTTP metadata endpoint on your
        /// instances is enabled (<code>enabled</code> | <code>disabled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>http-protocol-ipv4</code> - Indicates whether the IPv4 endpoint for the instance
        /// metadata service is enabled (<code>enabled</code> | <code>disabled</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>host-resource-group-arn</code> - The ARN of the host resource group in which
        /// to launch the instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>http-tokens</code> - The state of token usage for your instance metadata requests
        /// (<code>optional</code> | <code>required</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>iam-instance-profile</code> - The ARN of the IAM instance profile.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>image-id</code> - The ID of the AMI.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>instance-type</code> - The instance type.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>is-default-version</code> - A boolean that indicates whether the launch template
        /// version is the default version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kernel-id</code> - The kernel ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>license-configuration-arn</code> - The ARN of the license configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>network-card-index</code> - The index of the network card.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ram-disk-id</code> - The RAM disk ID.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateId. 
        /// <para>
        /// The ID of the launch template.
        /// </para>
        ///  
        /// <para>
        /// To describe one or more versions of a specified launch template, you must specify
        /// either the <code>LaunchTemplateId</code> or the <code>LaunchTemplateName</code>, but
        /// not both.
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
        /// either the <code>LaunchTemplateName</code> or the <code>LaunchTemplateId</code>, but
        /// not both.
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
        /// results, make another call with the returned <code>NextToken</code> value. This value
        /// can be between 1 and 200.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
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
        /// If <code>true</code>, and if a Systems Manager parameter is specified for <code>ImageId</code>,
        /// the AMI ID is displayed in the response for <code>imageId</code>.
        /// </para>
        ///  
        /// <para>
        /// If <code>false</code>, and if a Systems Manager parameter is specified for <code>ImageId</code>,
        /// the parameter is displayed in the response for <code>imageId</code>.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html#use-an-ssm-parameter-instead-of-an-ami-id">Use
        /// a Systems Manager parameter instead of an AMI ID</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool ResolveAlias
        {
            get { return this._resolveAlias.GetValueOrDefault(); }
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
        /// <code>$Latest</code>, <code>$Default</code>, and numbers.
        /// </para>
        ///  
        /// <para>
        /// To describe all launch templates in your account that are defined as the latest version,
        /// the valid value is <code>$Latest</code>. To describe all launch templates in your
        /// account that are defined as the default version, the valid value is <code>$Default</code>.
        /// You can specify <code>$Latest</code> and <code>$Default</code> in the same request.
        /// You cannot specify numbers.
        /// </para>
        /// </summary>
        public List<string> Versions
        {
            get { return this._versions; }
            set { this._versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this._versions != null && this._versions.Count > 0; 
        }

    }
}