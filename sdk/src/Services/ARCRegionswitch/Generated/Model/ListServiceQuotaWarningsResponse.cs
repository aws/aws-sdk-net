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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// This is the response object from the ListServiceQuotaWarnings operation.
    /// </summary>
    public partial class ListServiceQuotaWarningsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServiceQuotaWarningSummary> _serviceQuotaWarningSummaries = AWSConfigs.InitializeCollections ? new List<ServiceQuotaWarningSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token. A response may contain no results while still including a <c>nextToken</c>.
        /// Continue paginating until <c>nextToken</c> is null to retrieve all results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property ServiceQuotaWarningSummaries. 
        /// <para>
        /// The service quota warnings for the plans that you can access.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ServiceQuotaWarningSummary> ServiceQuotaWarningSummaries
        {
            get { return this._serviceQuotaWarningSummaries; }
            set { this._serviceQuotaWarningSummaries = value; }
        }

        // Check to see if ServiceQuotaWarningSummaries property is set
        internal bool IsSetServiceQuotaWarningSummaries()
        {
            return this._serviceQuotaWarningSummaries != null && (this._serviceQuotaWarningSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}