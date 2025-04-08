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
    /// Container for the parameters to the GetManagedRuleSet operation.
    /// Retrieves the specified managed rule set. 
    /// 
    ///  <note> 
    /// <para>
    /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
    /// Web Services and Amazon Web Services Marketplace sellers. 
    /// </para>
    ///  
    /// <para>
    /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
    /// versioned managed rule group offerings for your customers. The APIs are <c>ListManagedRuleSets</c>,
    /// <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetManagedRuleSetRequest : AmazonWAFV2Request
    {
        private string _id;
        private string _name;
        private Scope _scope;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the managed rule set. The ID is returned in the responses
        /// to commands like <c>list</c>. You provide it to operations like <c>get</c> and <c>update</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the managed rule set. You use this, along with the rule set ID, to identify
        /// the rule set.
        /// </para>
        ///  
        /// <para>
        /// This name is assigned to the corresponding managed rule group, which your customers
        /// can access and use. 
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
        /// Specifies whether this is for a global resource type, such as a Amazon CloudFront
        /// distribution. For an Amplify application, use <c>CLOUDFRONT</c>.
        /// </para>
        ///  
        /// <para>
        /// To work with CloudFront, you must also specify the Region US East (N. Virginia) as
        /// follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CLI - Specify the Region when you use the CloudFront scope: <c>--scope=CLOUDFRONT
        /// --region=us-east-1</c>. 
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

    }
}