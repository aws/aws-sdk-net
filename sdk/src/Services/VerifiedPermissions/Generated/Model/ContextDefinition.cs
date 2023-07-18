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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains additional details about the context of the request. Verified Permissions
    /// evaluates this information in an authorization request as part of the <code>when</code>
    /// and <code>unless</code> clauses in a policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorized.html">IsAuthorized</a>
    /// and <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// operations.
    /// </para>
    ///  
    /// <para>
    /// Example: <code>"context":{"Context":{"&lt;KeyName1&gt;":{"boolean":true},"&lt;KeyName2&gt;":{"long":1234}}}</code>
    /// 
    /// </para>
    /// </summary>
    public partial class ContextDefinition
    {
        private Dictionary<string, AttributeValue> _contextMap = new Dictionary<string, AttributeValue>();

        /// <summary>
        /// Gets and sets the property ContextMap. 
        /// <para>
        /// An list of attributes that are needed to successfully evaluate an authorization request.
        /// Each attribute in this array must include a map of a data type and its value.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>"Context":{"&lt;KeyName1&gt;":{"boolean":true},"&lt;KeyName2&gt;":{"long":1234}}</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public Dictionary<string, AttributeValue> ContextMap
        {
            get { return this._contextMap; }
            set { this._contextMap = value; }
        }

        // Check to see if ContextMap property is set
        internal bool IsSetContextMap()
        {
            return this._contextMap != null && this._contextMap.Count > 0; 
        }

    }
}