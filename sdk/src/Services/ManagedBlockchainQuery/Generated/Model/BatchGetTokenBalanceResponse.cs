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
 * Do not modify this file. This file is generated from the managedblockchain-query-2023-05-04.normal.json service model.
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
namespace Amazon.ManagedBlockchainQuery.Model
{
    /// <summary>
    /// This is the response object from the BatchGetTokenBalance operation.
    /// </summary>
    public partial class BatchGetTokenBalanceResponse : AmazonWebServiceResponse
    {
        private List<BatchGetTokenBalanceErrorItem> _errors = AWSConfigs.InitializeCollections ? new List<BatchGetTokenBalanceErrorItem>() : null;
        private List<BatchGetTokenBalanceOutputItem> _tokenBalances = AWSConfigs.InitializeCollections ? new List<BatchGetTokenBalanceOutputItem>() : null;

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// An array of <c>BatchGetTokenBalanceErrorItem</c> objects returned from the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<BatchGetTokenBalanceErrorItem> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TokenBalances. 
        /// <para>
        /// An array of <c>BatchGetTokenBalanceOutputItem</c> objects returned by the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<BatchGetTokenBalanceOutputItem> TokenBalances
        {
            get { return this._tokenBalances; }
            set { this._tokenBalances = value; }
        }

        // Check to see if TokenBalances property is set
        internal bool IsSetTokenBalances()
        {
            return this._tokenBalances != null && (this._tokenBalances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}