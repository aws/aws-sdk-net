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
    /// Container for the parameters to the UpdateManagedRuleSetVersionExpiryDate operation.
    /// Updates the expiration information for your managed rule set. Use this to initiate
    /// the expiration of a managed rule group version. After you initiate expiration for
    /// a version, WAF excludes it from the response to <a>ListAvailableManagedRuleGroupVersions</a>
    /// for the managed rule group. 
    /// 
    ///  <note> 
    /// <para>
    /// This is intended for use only by vendors of managed rule sets. Vendors are Amazon
    /// Web Services and Amazon Web Services Marketplace sellers. 
    /// </para>
    ///  
    /// <para>
    /// Vendors, you can use the managed rule set APIs to provide controlled rollout of your
    /// versioned managed rule group offerings for your customers. The APIs are <code>ListManagedRuleSets</code>,
    /// <code>GetManagedRuleSet</code>, <code>PutManagedRuleSetVersions</code>, and <code>UpdateManagedRuleSetVersionExpiryDate</code>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateManagedRuleSetVersionExpiryDateRequest : AmazonWAFV2Request
    {
        private DateTime? _expiryTimestamp;
        private string _id;
        private string _lockToken;
        private string _name;
        private Scope _scope;
        private string _versionToExpire;

        /// <summary>
        /// Gets and sets the property ExpiryTimestamp. 
        /// <para>
        /// The time that you want the version to expire.
        /// </para>
        ///  
        /// <para>
        /// Times are in Coordinated Universal Time (UTC) format. UTC format includes the special
        /// designator, Z. For example, "2016-09-27T14:50Z". 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ExpiryTimestamp
        {
            get { return this._expiryTimestamp.GetValueOrDefault(); }
            set { this._expiryTimestamp = value; }
        }

        // Check to see if ExpiryTimestamp property is set
        internal bool IsSetExpiryTimestamp()
        {
            return this._expiryTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the managed rule set. The ID is returned in the responses
        /// to commands like <code>list</code>. You provide it to operations like <code>get</code>
        /// and <code>update</code>.
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
        /// Gets and sets the property LockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <code>get</code>
        /// and <code>list</code> requests, to mark the state of the entity at the time of the
        /// request. To make changes to the entity associated with the token, you provide the
        /// token to operations like <code>update</code> and <code>delete</code>. WAF uses the
        /// token to ensure that no changes have been made to the entity since you last retrieved
        /// it. If a change has been made, the update fails with a <code>WAFOptimisticLockException</code>.
        /// If this happens, perform another <code>get</code>, and use the new token returned
        /// by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string LockToken
        {
            get { return this._lockToken; }
            set { this._lockToken = value; }
        }

        // Check to see if LockToken property is set
        internal bool IsSetLockToken()
        {
            return this._lockToken != null;
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
        /// Gets and sets the property VersionToExpire. 
        /// <para>
        /// The version that you want to remove from your list of offerings for the named managed
        /// rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string VersionToExpire
        {
            get { return this._versionToExpire; }
            set { this._versionToExpire = value; }
        }

        // Check to see if VersionToExpire property is set
        internal bool IsSetVersionToExpire()
        {
            return this._versionToExpire != null;
        }

    }
}