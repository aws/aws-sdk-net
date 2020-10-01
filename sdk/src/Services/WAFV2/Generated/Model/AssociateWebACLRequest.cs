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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateWebACL operation.
    /// <note> 
    /// <para>
    /// This is the latest version of <b>AWS WAF</b>, named AWS WAFV2, released in November,
    /// 2019. For information, including how to migrate your AWS WAF resources from the prior
    /// release, see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-chapter.html">AWS
    /// WAF Developer Guide</a>. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Associates a Web ACL with a regional application resource, to protect the resource.
    /// A regional application can be an Application Load Balancer (ALB), an API Gateway REST
    /// API, or an AppSync GraphQL API. 
    /// </para>
    ///  
    /// <para>
    /// For AWS CloudFront, don't use this call. Instead, use your CloudFront distribution
    /// configuration. To associate a Web ACL, in the CloudFront call <code>UpdateDistribution</code>,
    /// set the web ACL ID to the Amazon Resource Name (ARN) of the Web ACL. For information,
    /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>.
    /// </para>
    /// </summary>
    public partial class AssociateWebACLRequest : AmazonWAFV2Request
    {
        private string _resourceArn;
        private string _webACLArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource to associate with the web ACL. 
        /// </para>
        ///  
        /// <para>
        /// The ARN must be in one of the following formats:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For an Application Load Balancer: <code>arn:aws:elasticloadbalancing:<i>region</i>:<i>account-id</i>:loadbalancer/app/<i>load-balancer-name</i>/<i>load-balancer-id</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an API Gateway REST API: <code>arn:aws:apigateway:<i>region</i>::/restapis/<i>api-id</i>/stages/<i>stage-name</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an AppSync GraphQL API: <code>arn:aws:appsync:<i>region</i>:<i>account-id</i>:apis/<i>GraphQLApiId</i>
        /// </code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property WebACLArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Web ACL that you want to associate with the
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string WebACLArn
        {
            get { return this._webACLArn; }
            set { this._webACLArn = value; }
        }

        // Check to see if WebACLArn property is set
        internal bool IsSetWebACLArn()
        {
            return this._webACLArn != null;
        }

    }
}