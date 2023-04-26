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
    /// Container for the parameters to the DescribeManagedRuleGroup operation.
    /// Provides high-level information for a managed rule group, including descriptions of
    /// the rules.
    /// </summary>
    public partial class DescribeManagedRuleGroupRequest : AmazonWAFV2Request
    {
        private string _name;
        private Scope _scope;
        private string _vendorName;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed rule group. You use this, along with the vendor name, to identify
        /// the rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether this is for an Amazon CloudFront distribution or for a regional
        /// application. A regional application can be an Application Load Balancer (ALB), an
        /// Amazon API Gateway REST API, an AppSync GraphQL API, an Amazon Cognito user pool,
        /// or an App Runner service. 
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <code>--scope=CLOUDFRONT
        /// --region=us-east-1</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// API and SDKs - For all calls, use the Region endpoint us-east-1. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property VendorName. 
        /// <para>
        /// The name of the managed rule group vendor. You use this, along with the rule group
        /// name, to identify the rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string VendorName
        {
            get { return this._vendorName; }
            set { this._vendorName = value; }
        }

        // Check to see if VendorName property is set
        internal bool IsSetVendorName()
        {
            return this._vendorName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The version of the rule group. You can only use a version that is not scheduled for
        /// expiration. If you don't provide this, WAF uses the vendor's default version. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}