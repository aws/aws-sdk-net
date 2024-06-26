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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains additional details about the context of the request. Verified Permissions
    /// evaluates this information in an authorization request as part of the <c>when</c>
    /// and <c>unless</c> clauses in a policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as a request parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorized.html">IsAuthorized</a>,
    /// <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_BatchIsAuthorized.html">BatchIsAuthorized</a>,
    /// and <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_IsAuthorizedWithToken.html">IsAuthorizedWithToken</a>
    /// operations.
    /// </para>
    ///  
    /// <para>
    /// Example: <c>"context":{"contextMap":{"&lt;KeyName1&gt;":{"boolean":true},"&lt;KeyName2&gt;":{"long":1234}}}</c>
    /// 
    /// </para>
    /// </summary>
    public partial class ContextDefinition
    {
        private Dictionary<string, AttributeValue> _contextMap = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Gets and sets the property ContextMap. 
        /// <para>
        /// An list of attributes that are needed to successfully evaluate an authorization request.
        /// Each attribute in this array must include a map of a data type and its value.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>"contextMap":{"&lt;KeyName1&gt;":{"boolean":true},"&lt;KeyName2&gt;":{"long":1234}}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, AttributeValue> ContextMap
        {
            get { return this._contextMap; }
            set { this._contextMap = value; }
        }

        // Check to see if ContextMap property is set
        internal bool IsSetContextMap()
        {
            return this._contextMap != null && (this._contextMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}