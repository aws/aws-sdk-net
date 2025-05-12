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
    /// Container for the parameters to the GetWebACLForResource operation.
    /// Retrieves the <a>WebACL</a> for the specified resource. 
    /// 
    ///  
    /// <para>
    /// This call uses <c>GetWebACL</c>, to verify that your account has permission to access
    /// the retrieved web ACL. If you get an error that indicates that your account isn't
    /// authorized to perform <c>wafv2:GetWebACL</c> on the resource, that error won't be
    /// included in your CloudTrail event history. 
    /// </para>
    ///  
    /// <para>
    /// For Amazon CloudFront, don't use this call. Instead, call the CloudFront action <c>GetDistributionConfig</c>.
    /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_GetDistributionConfig.html">GetDistributionConfig</a>
    /// in the <i>Amazon CloudFront API Reference</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions for customer-managed IAM policies</b> 
    /// </para>
    ///  
    /// <para>
    /// This call requires permissions that are specific to the protected resource type. For
    /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-GetWebACLForResource">Permissions
    /// for GetWebACLForResource</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetWebACLForResourceRequest : AmazonWAFV2Request
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource whose web ACL you want to retrieve.
        /// 
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

    }
}