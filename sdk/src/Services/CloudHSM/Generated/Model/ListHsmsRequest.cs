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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the ListHsms operation.
    /// Retrieves the identifiers of all of the HSMs provisioned for the current customer.
    /// 
    ///  
    /// <para>
    /// This operation supports pagination with the use of the <code>NextToken</code> member.
    /// If more results are available, the <code>NextToken</code> member of the response contains
    /// a token that you pass in the next call to <code>ListHsms</code> to retrieve the next
    /// set of items.
    /// </para>
    /// </summary>
    public partial class ListHsmsRequest : AmazonCloudHSMRequest
    {
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>NextToken</code> value from a previous call to <code>ListHsms</code>. Pass
        /// null if this is the first call.
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

    }
}