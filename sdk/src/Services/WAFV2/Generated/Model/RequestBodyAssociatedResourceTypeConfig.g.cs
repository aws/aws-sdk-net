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
    /// Customizes the maximum size of the request body that your protected Application Load
    /// Balancer, CloudFront, API Gateway, Amazon Cognito, App Runner, Verified Access, and
    /// Elastic Load Balancing for Envoy resources forward to WAF for inspection. The default
    /// size is 8 KB (8,192 bytes) for Application Load Balancer and 16 KB (16,384 bytes)
    /// for the other resource types. You can change the setting for any of the available
    /// resource types. 
    /// 
    ///  <note> 
    /// <para>
    /// You are charged additional fees when your protected resources forward body sizes that
    /// are larger than the default. For more information, see <a href="http://aws.amazon.com/waf/pricing/">WAF
    /// Pricing</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Example JSON: <c> { "API_GATEWAY": "KB_48", "APP_RUNNER_SERVICE": "KB_32", "APPLICATION_LOAD_BALANCER":
    /// "KB_16" }</c> 
    /// </para>
    ///  
    /// <para>
    /// For AppSync, the limit is fixed at 8 KB (8,192 bytes).
    /// </para>
    ///  
    /// <para>
    /// This is used in the <c>AssociationConfig</c> of the web ACL. 
    /// </para>
    /// </summary>
    public partial class RequestBodyAssociatedResourceTypeConfig
    {
        /// <summary>
        /// Gets and sets the property DefaultSizeInspectionLimit. 
        /// <para>
        /// Specifies the maximum size of the web request body component that an associated Application
        /// Load Balancer, CloudFront, API Gateway, Amazon Cognito, App Runner, Verified Access,
        /// or Elastic Load Balancing for Envoy resource should send to WAF for inspection. This
        /// applies to statements in the web ACL that inspect the body or JSON body. 
        /// </para>
        ///  
        /// <para>
        /// You can specify <c>KB_8</c> only for Application Load Balancer, with the <c>APPLICATION_LOAD_BALANCER</c>
        /// resource type. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>8 KB (8,192 bytes)</c> for Application Load Balancer and <c>16 KB (16,384
        /// bytes)</c> for the other resource types
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SizeInspectionLimit DefaultSizeInspectionLimit { get; set; }

        /// <summary>
        /// Checks to see if the DefaultSizeInspectionLimit property is set.
        /// </summary>
        internal bool IsSetDefaultSizeInspectionLimit() => this.DefaultSizeInspectionLimit != null;
    }
}
