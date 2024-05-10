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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// This is the response object from the ListAPIKeys operation.
    /// </summary>
    public partial class ListAPIKeysResponse : AmazonWebServiceResponse
    {
        private List<APIKeySummary> _apiKeySummaries = AWSConfigs.InitializeCollections ? new List<APIKeySummary>() : null;
        private string _applicationIntegrationURL;
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property APIKeySummaries. 
        /// <para>
        /// The array of key summaries. If you specified a <c>Limit</c> in your request, this
        /// might not be the full list. 
        /// </para>
        /// </summary>
        public List<APIKeySummary> APIKeySummaries
        {
            get { return this._apiKeySummaries; }
            set { this._apiKeySummaries = value; }
        }

        // Check to see if APIKeySummaries property is set
        internal bool IsSetAPIKeySummaries()
        {
            return this._apiKeySummaries != null && (this._apiKeySummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApplicationIntegrationURL. 
        /// <para>
        /// The CAPTCHA application integration URL, for use in your JavaScript implementation.
        /// 
        /// </para>
        /// </summary>
        public string ApplicationIntegrationURL
        {
            get { return this._applicationIntegrationURL; }
            set { this._applicationIntegrationURL = value; }
        }

        // Check to see if ApplicationIntegrationURL property is set
        internal bool IsSetApplicationIntegrationURL()
        {
            return this._applicationIntegrationURL != null;
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <c>Limit</c> setting, if the number of objects
        /// that are still available for retrieval exceeds the limit, WAF returns a <c>NextMarker</c>
        /// value in the response. To retrieve the next batch of objects, provide the marker from
        /// the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}