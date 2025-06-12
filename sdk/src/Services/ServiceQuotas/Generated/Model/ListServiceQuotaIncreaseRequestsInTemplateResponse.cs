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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
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
namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// This is the response object from the ListServiceQuotaIncreaseRequestsInTemplate operation.
    /// </summary>
    public partial class ListServiceQuotaIncreaseRequestsInTemplateResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServiceQuotaIncreaseRequestInTemplate> _serviceQuotaIncreaseRequestInTemplateList = AWSConfigs.InitializeCollections ? new List<ServiceQuotaIncreaseRequestInTemplate>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <c>NextToken</c> request parameter in a subsequent
        /// call to the operation to get the next part of the output. You should repeat this until
        /// the <c>NextToken</c> response element comes back as <c>null</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// Gets and sets the property ServiceQuotaIncreaseRequestInTemplateList. 
        /// <para>
        /// Information about the quota increase requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceQuotaIncreaseRequestInTemplate> ServiceQuotaIncreaseRequestInTemplateList
        {
            get { return this._serviceQuotaIncreaseRequestInTemplateList; }
            set { this._serviceQuotaIncreaseRequestInTemplateList = value; }
        }

        // Check to see if ServiceQuotaIncreaseRequestInTemplateList property is set
        internal bool IsSetServiceQuotaIncreaseRequestInTemplateList()
        {
            return this._serviceQuotaIncreaseRequestInTemplateList != null && (this._serviceQuotaIncreaseRequestInTemplateList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}