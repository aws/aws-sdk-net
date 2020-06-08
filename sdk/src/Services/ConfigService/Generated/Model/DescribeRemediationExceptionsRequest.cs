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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRemediationExceptions operation.
    /// Returns the details of one or more remediation exceptions. A detailed view of a remediation
    /// exception for a set of resources that includes an explanation of an exception and
    /// the time when the exception will be deleted. When you specify the limit and the next
    /// token, you receive a paginated response. 
    /// 
    ///  <note> 
    /// <para>
    /// When you specify the limit and the next token, you receive a paginated response. 
    /// </para>
    ///  
    /// <para>
    /// Limit and next token are not applicable if you request resources in batch. It is only
    /// applicable, when you request all resources.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeRemediationExceptionsRequest : AmazonConfigServiceRequest
    {
        private string _configRuleName;
        private int? _limit;
        private string _nextToken;
        private List<RemediationExceptionResourceKey> _resourceKeys = new List<RemediationExceptionResourceKey>();

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the AWS Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of RemediationExceptionResourceKey returned on each page. The default
        /// is 25. If you specify 0, AWS Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned in a previous request that you use to request
        /// the next page of results in a paginated response.
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
        /// Gets and sets the property ResourceKeys. 
        /// <para>
        /// An exception list of resource exception keys to be processed with the current request.
        /// AWS Config adds exception for each resource key. For example, AWS Config adds 3 exceptions
        /// for 3 resource keys. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<RemediationExceptionResourceKey> ResourceKeys
        {
            get { return this._resourceKeys; }
            set { this._resourceKeys = value; }
        }

        // Check to see if ResourceKeys property is set
        internal bool IsSetResourceKeys()
        {
            return this._resourceKeys != null && this._resourceKeys.Count > 0; 
        }

    }
}