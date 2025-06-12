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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Specifies custom configurations for the associations between the web ACL and protected
    /// resources. 
    /// 
    ///  
    /// <para>
    /// Use this to customize the maximum size of the request body that your protected resources
    /// forward to WAF for inspection. You can customize this setting for CloudFront, API
    /// Gateway, Amazon Cognito, App Runner, or Verified Access resources. The default setting
    /// is 16 KB (16,384 bytes). 
    /// </para>
    ///  <note> 
    /// <para>
    /// You are charged additional fees when your protected resources forward body sizes that
    /// are larger than the default. For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF
    /// Pricing</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For Application Load Balancer and AppSync, the limit is fixed at 8 KB (8,192 bytes).
    /// </para>
    /// </summary>
    public partial class AssociationConfig
    {
        private Dictionary<string, RequestBodyAssociatedResourceTypeConfig> _requestBody = AWSConfigs.InitializeCollections ? new Dictionary<string, RequestBodyAssociatedResourceTypeConfig>() : null;

        /// <summary>
        /// Gets and sets the property RequestBody. 
        /// <para>
        /// Customizes the maximum size of the request body that your protected CloudFront, API
        /// Gateway, Amazon Cognito, App Runner, and Verified Access resources forward to WAF
        /// for inspection. The default size is 16 KB (16,384 bytes). You can change the setting
        /// for any of the available resource types. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You are charged additional fees when your protected resources forward body sizes that
        /// are larger than the default. For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF
        /// Pricing</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Example JSON: <c> { "API_GATEWAY": "KB_48", "APP_RUNNER_SERVICE": "KB_32" }</c> 
        /// </para>
        ///  
        /// <para>
        /// For Application Load Balancer and AppSync, the limit is fixed at 8 KB (8,192 bytes).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, RequestBodyAssociatedResourceTypeConfig> RequestBody
        {
            get { return this._requestBody; }
            set { this._requestBody = value; }
        }

        // Check to see if RequestBody property is set
        internal bool IsSetRequestBody()
        {
            return this._requestBody != null && (this._requestBody.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}