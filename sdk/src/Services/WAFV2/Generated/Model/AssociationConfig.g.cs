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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    ///  
    /// <para>
    /// You can also use this to have your CloudFront distributions insert the WAF challenge
    /// JavaScript SDK into the HTML responses that they return. For more information, see
    /// the <c>ChallengeJavascriptSdkInjection</c> setting. 
    /// </para>
    /// </summary>
    public partial class AssociationConfig
    {
        /// <summary>
        /// Gets and sets the property ChallengeJavascriptSdkInjection. 
        /// <para>
        /// Specifies the CloudFront distributions that insert the WAF challenge JavaScript SDK
        /// into the HTML responses that they return. When you enable this setting for a distribution,
        /// you do not add the SDK to your web pages yourself. 
        /// </para>
        ///  
        /// <para>
        /// You can configure this setting only for CloudFront distributions, using the <c>CLOUDFRONT</c>
        /// map key. WAF rejects any other resource type, and the setting is not available for
        /// regional resources. To configure it, use the CloudFront scope. 
        /// </para>
        ///  
        /// <para>
        /// Your web ACL must also contain at least one of the following qualifying managed rule
        /// groups. WAF Bot Control qualifies only at the <c>TARGETED</c> inspection level, not
        /// at <c>COMMON</c>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The WAF Bot Control managed rule group <c>AWSManagedRulesBotControlRuleSet</c>, with
        /// the inspection level set to <c>TARGETED</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The WAF Fraud Control account takeover prevention (ATP) managed rule group <c>AWSManagedRulesATPRuleSet</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The WAF Fraud Control account creation fraud prevention (ACFP) managed rule group
        /// <c>AWSManagedRulesACFPRuleSet</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you remove the last qualifying managed rule group from the web ACL, or lower the
        /// WAF Bot Control inspection level from <c>TARGETED</c> to <c>COMMON</c>, you must remove
        /// this setting in the same update. Otherwise, WAF rejects the update. 
        /// </para>
        ///  
        /// <para>
        /// Example JSON: <c> { "CLOUDFRONT": {} }</c> 
        /// </para>
        ///  
        /// <para>
        /// If you omit this setting, CloudFront does not insert the SDK. When you omit it from
        /// a web ACL that previously used it, cached HTML that already contains the SDK is still
        /// served until it expires, or until you invalidate the cache for that distribution.
        /// For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-challenge-javascript-sdk-injection.html">Automatic
        /// SDK integration for CloudFront distributions</a> in the <i>WAF Developer Guide</i>.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public Dictionary<string, ChallengeJavascriptSdkInjectionConfig> ChallengeJavascriptSdkInjection { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ChallengeJavascriptSdkInjectionConfig>() : null;

        /// <summary>
        /// Checks to see if the ChallengeJavascriptSdkInjection property is set.
        /// </summary>
        internal bool IsSetChallengeJavascriptSdkInjection() => this.ChallengeJavascriptSdkInjection != null && (this.ChallengeJavascriptSdkInjection.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, RequestBodyAssociatedResourceTypeConfig> RequestBody { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, RequestBodyAssociatedResourceTypeConfig>() : null;

        /// <summary>
        /// Checks to see if the RequestBody property is set.
        /// </summary>
        internal bool IsSetRequestBody() => this.RequestBody != null && (this.RequestBody.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
