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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceQuotas.Model
{
    /// <summary>
    /// Container for the parameters to the ListAWSDefaultServiceQuotas operation.
    /// Lists all default service quotas for the specified AWS service or all AWS services.
    /// ListAWSDefaultServiceQuotas is similar to <a>ListServiceQuotas</a> except for the
    /// Value object. The Value object returned by <code>ListAWSDefaultServiceQuotas</code>
    /// is the default value assigned by AWS. This request returns a list of all service quotas
    /// for the specified service. The listing of each you'll see the default values are the
    /// values that AWS provides for the quotas. 
    /// 
    ///  <note> 
    /// <para>
    /// Always check the <code>NextToken</code> response parameter when calling any of the
    /// <code>List*</code> operations. These operations can return an unexpected list of results,
    /// even when there are more results available. When this happens, the <code>NextToken</code>
    /// response parameter contains a value to pass the next call to the same API to request
    /// the next part of the list.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListAWSDefaultServiceQuotasRequest : AmazonServiceQuotasRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _serviceCode;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// (Optional) Limits the number of results that you want to include in the response.
        /// If you don't include this parameter, the response defaults to a value that's specific
        /// to the operation. If additional items exist beyond the specified maximum, the <code>NextToken</code>
        /// element is present and has a value (isn't null). Include that value as the <code>NextToken</code>
        /// request parameter in the call to the operation to get the next part of the results.
        /// You should check <code>NextToken</code> after every operation to ensure that you receive
        /// all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// (Optional) Use this parameter in a request if you receive a <code>NextToken</code>
        /// response in a previous request that indicates that there's more output available.
        /// In a subsequent call, set it to the value of the previous call's <code>NextToken</code>
        /// response to indicate where the output should continue from. If additional items exist
        /// beyond the specified maximum, the <code>NextToken</code> element is present and has
        /// a value (isn't null). Include that value as the <code>NextToken</code> request parameter
        /// in the call to the operation to get the next part of the results. You should check
        /// <code>NextToken</code> after every operation to ensure that you receive all of the
        /// results.
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
        /// Gets and sets the property ServiceCode. 
        /// <para>
        /// Specifies the service that you want to use.
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