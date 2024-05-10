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
    /// Container for the parameters to the ListServiceQuotas operation.
    /// Lists the applied quota values for the specified Amazon Web Service. For some quotas,
    /// only the default values are available. If the applied quota value is not available
    /// for a quota, the quota is not retrieved.
    /// </summary>
    public partial class ListServiceQuotasRequest : AmazonServiceQuotasRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private AppliedLevelEnum _quotaAppliedAtLevel;
        private string _quotaCode;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the maximum number of results that you want included on each page of the
        /// response. If you do not include this parameter, it defaults to a value appropriate
        /// to the operation. If additional items exist beyond those included in the current response,
        /// the <c>NextToken</c> response element is present and has a value (is not null). Include
        /// that value as the <c>NextToken</c> request parameter in the next call to the operation
        /// to get the next part of the results.
        /// </para>
        ///  <note> 
        /// <para>
        /// An API operation can return fewer results than the maximum even when there are more
        /// results available. You should check <c>NextToken</c> after every operation to ensure
        /// that you receive all of the results.
        /// </para>
        ///  </note>
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
        /// Specifies a value for receiving additional results after you receive a <c>NextToken</c>
        /// response in a previous request. A <c>NextToken</c> response indicates that more output
        /// is available. Set this parameter to the value of the previous call's <c>NextToken</c>
        /// response to indicate where the output should continue from.
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
        /// Gets and sets the property QuotaAppliedAtLevel. 
        /// <para>
        /// Specifies at which level of granularity that the quota value is applied.
        /// </para>
        /// </summary>
        public AppliedLevelEnum QuotaAppliedAtLevel
        {
            get { return this._quotaAppliedAtLevel; }
            set { this._quotaAppliedAtLevel = value; }
        }

        // Check to see if QuotaAppliedAtLevel property is set
        internal bool IsSetQuotaAppliedAtLevel()
        {
            return this._quotaAppliedAtLevel != null;
        }

        /// <summary>
        /// Gets and sets the property QuotaCode. 
        /// <para>
        /// Specifies the quota identifier. To find the quota code for a specific quota, use the
        /// <a>ListServiceQuotas</a> operation, and look for the <c>QuotaCode</c> response in
        /// the output for the quota you want.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string QuotaCode
        {
            get { return this._quotaCode; }
            set { this._quotaCode = value; }
        }

        // Check to see if QuotaCode property is set
        internal bool IsSetQuotaCode()
        {
            return this._quotaCode != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Specifies the service identifier. To find the service code value for an Amazon Web
        /// Services service, use the <a>ListServices</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ServiceCode
        {
            get { return this._serviceCode; }
            set { this._serviceCode = value; }
        }

        // Check to see if ServiceCode property is set
        internal bool IsSetServiceCode()
        {
            return this._serviceCode != null;
        }

    }
}