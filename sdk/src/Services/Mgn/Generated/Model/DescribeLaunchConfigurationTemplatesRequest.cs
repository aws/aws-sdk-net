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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeLaunchConfigurationTemplates operation.
    /// Lists all Launch Configuration Templates, filtered by Launch Configuration Template
    /// IDs
    /// </summary>
    public partial class DescribeLaunchConfigurationTemplatesRequest : AmazonMgnRequest
    {
        private List<string> _launchConfigurationTemplateIDs = new List<string>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationTemplateIDs. 
        /// <para>
        /// Request to filter Launch Configuration Templates list by Launch Configuration Template
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> LaunchConfigurationTemplateIDs
        {
            get { return this._launchConfigurationTemplateIDs; }
            set { this._launchConfigurationTemplateIDs = value; }
        }

        // Check to see if LaunchConfigurationTemplateIDs property is set
        internal bool IsSetLaunchConfigurationTemplateIDs()
        {
            return this._launchConfigurationTemplateIDs != null && this._launchConfigurationTemplateIDs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum results to be returned in DescribeLaunchConfigurationTemplates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// Next pagination token returned from DescribeLaunchConfigurationTemplates.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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