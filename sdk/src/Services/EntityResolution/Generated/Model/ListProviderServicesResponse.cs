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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// This is the response object from the ListProviderServices operation.
    /// </summary>
    public partial class ListProviderServicesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProviderServiceSummary> _providerServiceSummaries = AWSConfigs.InitializeCollections ? new List<ProviderServiceSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token from the previous API call.
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
        /// Gets and sets the property ProviderServiceSummaries. 
        /// <para>
        /// A list of <c>ProviderServices</c> objects.
        /// </para>
        /// </summary>
        public List<ProviderServiceSummary> ProviderServiceSummaries
        {
            get { return this._providerServiceSummaries; }
            set { this._providerServiceSummaries = value; }
        }

        // Check to see if ProviderServiceSummaries property is set
        internal bool IsSetProviderServiceSummaries()
        {
            return this._providerServiceSummaries != null && (this._providerServiceSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}