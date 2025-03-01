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
    /// Container for the parameters to the ListResourcesForWebACL operation.
    /// Retrieves an array of the Amazon Resource Names (ARNs) for the resources that are
    /// associated with the specified web ACL. 
    /// 
    ///  
    /// <para>
    /// For Amazon CloudFront, don't use this call. Instead, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
    /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
    /// in the <i>Amazon CloudFront API Reference</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions for customer-managed IAM policies</b> 
    /// </para>
    ///  
    /// <para>
    /// This call requires permissions that are specific to the protected resource type. For
    /// details, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/security_iam_service-with-iam.html#security_iam_action-ListResourcesForWebACL">Permissions
    /// for ListResourcesForWebACL</a> in the <i>WAF Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListResourcesForWebACLRequest : AmazonWAFV2Request
    {
        private ResourceType _resourceType;
        private string _webACLArn;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Retrieves the web ACLs that are used by the specified resource type. 
        /// </para>
        ///  
        /// <para>
        /// For Amazon CloudFront, don't use this call. Instead, use the CloudFront call <c>ListDistributionsByWebACLId</c>.
        /// For information, see <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_ListDistributionsByWebACLId.html">ListDistributionsByWebACLId</a>
        /// in the <i>Amazon CloudFront API Reference</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you don't provide a resource type, the call uses the resource type <c>APPLICATION_LOAD_BALANCER</c>.
        /// 
        /// </para>
        ///  </note> 
        /// <para>
        /// Default: <c>APPLICATION_LOAD_BALANCER</c> 
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property WebACLArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL.
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