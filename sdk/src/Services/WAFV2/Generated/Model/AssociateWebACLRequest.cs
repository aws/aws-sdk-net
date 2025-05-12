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
    /// Container for the parameters to the AssociateWebACL operation.
    /// Associates a web ACL with a resource, to protect the resource. 
    /// 
    ///  
    /// <para>
    /// Use this for all resource types except for Amazon CloudFront distributions. For Amazon
    /// CloudFront, call <c>UpdateDistribution</c> for the distribution and provide the Amazon
    /// Resource Name (ARN) of the web ACL in the web ACL ID. For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_UpdateDistribution.html">UpdateDistribution</a>
    /// in the <i>Amazon CloudFront Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions for customer-managed IAM policies</b> 
    /// </para>
    ///  
    /// <para>
    /// This call requires permissions that are specific to the protected resource type. For
    /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-AssociateWebACL">Permissions
    /// for AssociateWebACL</a> in the <i>WAF Developer Guide</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Temporary inconsistencies during updates</b> 
    /// </para>
    ///  
    /// <para>
    /// When you create or change a web ACL or other WAF resources, the changes take a small
    /// amount of time to propagate to all areas where the resources are stored. The propagation
    /// time can be from a few seconds to a number of minutes. 
    /// </para>
    ///  
    /// <para>
    /// The following are examples of the temporary inconsistencies that you might notice
    /// during change propagation: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// After you create a web ACL, if you try to associate it with a resource, you might
    /// get an exception indicating that the web ACL is unavailable. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you add a rule group to a web ACL, the new rule group rules might be in effect
    /// in one area where the web ACL is used and not in another.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you change a rule action setting, you might see the old action in some places
    /// and the new action in others. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After you add an IP address to an IP set that is in use in a blocking rule, the new
    /// address might be blocked in one area while still allowed in another.
    /// </para>
    ///  </li> </ul>
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
        /// For an Application Load Balancer: <c>arn:<i>partition</i>:elasticloadbalancing:<i>region</i>:<i>account-id</i>:loadbalancer/app/<i>load-balancer-name</i>/<i>load-balancer-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon API Gateway REST API: <c>arn:<i>partition</i>:apigateway:<i>region</i>::/restapis/<i>api-id</i>/stages/<i>stage-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an AppSync GraphQL API: <c>arn:<i>partition</i>:appsync:<i>region</i>:<i>account-id</i>:apis/<i>GraphQLApiId</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon Cognito user pool: <c>arn:<i>partition</i>:cognito-idp:<i>region</i>:<i>account-id</i>:userpool/<i>user-pool-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an App Runner service: <c>arn:<i>partition</i>:apprunner:<i>region</i>:<i>account-id</i>:service/<i>apprunner-service-name</i>/<i>apprunner-service-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amazon Web Services Verified Access instance: <c>arn:<i>partition</i>:ec2:<i>region</i>:<i>account-id</i>:verified-access-instance/<i>instance-id</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For an Amplify application: <c>arn:<i>partition</i>:amplify:<i>region</i>:<i>account-id</i>:apps/<i>app-id</i>
        /// </c> 
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