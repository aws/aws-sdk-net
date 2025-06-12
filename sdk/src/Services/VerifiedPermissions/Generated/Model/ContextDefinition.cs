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
    /// If you're passing context as part of the request, exactly one instance of <c>context</c>
    /// must be passed. If you don't want to pass context, omit the <c>context</c> parameter
    /// from your request rather than sending <c>context {}</c>.
    /// </para>
    ///  
    /// <para>
    /// Example: <c>"context":{"contextMap":{"&lt;KeyName1&gt;":{"boolean":true},"&lt;KeyName2&gt;":{"long":1234}}}</c>
    /// 
    /// </para>
    /// </summary>
    public partial class ContextDefinition
    {
        private string _cedarJson;
        private Dictionary<string, AttributeValue> _contextMap = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;

        /// <summary>
        /// Gets and sets the property CedarJson. 
        /// <para>
        /// A Cedar JSON string representation of the context needed to successfully evaluate
        /// an authorization request.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>{"cedarJson":"{\"&lt;KeyName1&gt;\": true, \"&lt;KeyName2&gt;\": 1234}"
        /// }</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CedarJson
        {
            get { return this._cedarJson; }
            set { this._cedarJson = value; }
        }

        // Check to see if CedarJson property is set
        internal bool IsSetCedarJson()
        {
            return this._cedarJson != null;
        }

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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