/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLaunchTemplateVersions operation.
    /// Describes one or more versions of a specified launch template. You can describe all
    /// versions, individual versions, or a range of versions.
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
        /// The ID of the launch template. You must specify either the launch template ID or launch
        /// template name in the request.
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
        /// The name of the launch template. You must specify either the launch template ID or
        /// launch template name in the request.
        /// </para>
        /// </summary>
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
        /// can be between 5 and 1000.
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
        /// Gets and sets the property Versions. 
        /// <para>
        /// One or more versions of the launch template.
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