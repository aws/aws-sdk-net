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
    /// Container for the parameters to the DescribeLaunchTemplates operation.
    /// Describes one or more launch templates.
    /// </summary>
    public partial class DescribeLaunchTemplatesRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _launchTemplateIds = new List<string>();
        private List<string> _launchTemplateNames = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>create-time</code> - The time the launch template was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>launch-template-name</code> - The name of the launch template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
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
        /// Gets and sets the property LaunchTemplateIds. 
        /// <para>
        /// One or more launch template IDs.
        /// </para>
        /// </summary>
        public List<string> LaunchTemplateIds
        {
            get { return this._launchTemplateIds; }
            set { this._launchTemplateIds = value; }
        }

        // Check to see if LaunchTemplateIds property is set
        internal bool IsSetLaunchTemplateIds()
        {
            return this._launchTemplateIds != null && this._launchTemplateIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateNames. 
        /// <para>
        /// One or more launch template names.
        /// </para>
        /// </summary>
        public List<string> LaunchTemplateNames
        {
            get { return this._launchTemplateNames; }
            set { this._launchTemplateNames = value; }
        }

        // Check to see if LaunchTemplateNames property is set
        internal bool IsSetLaunchTemplateNames()
        {
            return this._launchTemplateNames != null && this._launchTemplateNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. To retrieve the remaining
        /// results, make another call with the returned <code>NextToken</code> value. This value
        /// can be between 1 and 200.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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

    }
}