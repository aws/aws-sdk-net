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
    /// Associates a web ACL with a regional application resource, to protect the resource.
    /// A regional application can be an Application Load Balancer (ALB), an Amazon API Gateway
    /// REST API, an AppSync GraphQL API, an Amazon Cognito user pool, or an App Runner service.
    /// 
    /// 
    ///  
    /// <para>
    /// For Amazon CloudFront, don't use this call. Instead, use your CloudFront distribution
    /// configuration. To associate a web ACL, in the CloudFront call <code>UpdateDistribution</code>,
    /// set the web ACL ID to the Amazon Resource Name (ARN) of the web ACL. For information,
    /// see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
    /// in the <i>Amazon CloudFront Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// When you make changes to web ACLs or web ACL components, like rules and rule groups,
    /// WAF propagates the changes everywhere that the web ACL and its components are stored
    /// and used. Your changes are applied within seconds, but there might be a brief period
    /// of inconsistency when the changes have arrived in some places and not in others. So,
    /// for example, if you change a rule action setting, the action might be the old action
    /// in one area and the new action in another area. Or if you add an IP address to an
    /// IP set used in a blocking rule, the new address might briefly be blocked in one area
    /// while still allowed in another. This temporary inconsistency can occur when you first
    /// associate a web ACL with an Amazon Web Services resource and when you change a web
    /// ACL that is already associated with a resource. Generally, any inconsistencies of
    /// this type last only a few seconds.
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
        /// For an Application Load Balancer: <code>arn:<i>partition</i>:elasticloadbalancing:<i>region</i>:<i>account-id</i>:loadbalancer/app/<i>load-balancer-name</i>/<i>load-balancer-id</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon API Gateway REST API: <code>arn:<i>partition</i>:apigateway:<i>region</i>::/restapis/<i>api-id</i>/stages/<i>stage-name</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an AppSync GraphQL API: <code>arn:<i>partition</i>:appsync:<i>region</i>:<i>account-id</i>:apis/<i>GraphQLApiId</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon Cognito user pool: <code>arn:<i>partition</i>:cognito-idp:<i>region</i>:<i>account-id</i>:userpool/<i>user-pool-id</i>
        /// </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an App Runner service: <code>arn:<i>partition</i>:apprunner:<i>region</i>:<i>account-id</i>:service/<i>apprunner-service-name</i>/<i>apprunner-service-id</i>
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
        /// The Amazon Resource Name (ARN) of the web ACL that you want to associate with the
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