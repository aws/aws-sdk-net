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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
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
namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeProtectConfigurations operation.
    /// Retrieves the protect configurations that match any of filters. If a filter isn’t
    /// provided then all protect configurations are returned.
    /// </summary>
    public partial class DescribeProtectConfigurationsRequest : AmazonPinpointSMSVoiceV2Request
    {
        private List<ProtectConfigurationFilter> _filters = AWSConfigs.InitializeCollections ? new List<ProtectConfigurationFilter>() : null;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _protectConfigurationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// An array of ProtectConfigurationFilter objects to filter the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<ProtectConfigurationFilter> Filters
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results. You don't need to supply
        /// a value for this field in the initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ProtectConfigurationIds. 
        /// <para>
        /// An array of protect configuration identifiers to search for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> ProtectConfigurationIds
        {
            get { return this._protectConfigurationIds; }
            set { this._protectConfigurationIds = value; }
        }

        // Check to see if ProtectConfigurationIds property is set
        internal bool IsSetProtectConfigurationIds()
        {
            return this._protectConfigurationIds != null && (this._protectConfigurationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}