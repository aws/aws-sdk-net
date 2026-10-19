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
    /// Container for the parameters to the UpdateManagedRuleSetVersionExpiryDate operation.
    /// Updates the expiration information for your managed rule set. Use this to initiate
    /// the expiration of a managed rule group version. After you initiate expiration for
    /// a version, WAF excludes it from the response to <a>ListAvailableManagedRuleGroupVersions</a>
    /// for the managed rule group. <note> <para> This is intended for use only by vendors
    /// of managed rule sets. Vendors are Amazon Web Services and Amazon Web Services Marketplace
    /// sellers. </para> <para> Vendors, you can use the managed rule set APIs to provide
    /// controlled rollout of your versioned managed rule group offerings for your customers.
    /// The APIs are <c>ListManagedRuleSets</c>, <c>GetManagedRuleSet</c>, <c>PutManagedRuleSetVersions</c>,
    /// and <c>UpdateManagedRuleSetVersionExpiryDate</c>. </para> </note>
    /// </summary>
    public partial class UpdateManagedRuleSetVersionExpiryDateRequest : AmazonWAFV2Request
    {
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
        [AWSProperty(Required = true)]
        public DateTime? ExpiryTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTimestamp property is set.
        /// </summary>
        internal bool IsSetExpiryTimestamp() => this.ExpiryTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the managed rule set. The ID is returned in the responses
        /// to commands like <c>list</c>. You provide it to operations like <c>get</c> and <c>update</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LockToken. 
        /// <para>
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 36)]
        public string LockToken { get; set; }

        /// <summary>
        /// Checks to see if the LockToken property is set.
        /// </summary>
        internal bool IsSetLockToken() => this.LockToken != null;

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
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property VersionToExpire. 
        /// <para>
        /// The version that you want to remove from your list of offerings for the named managed
        /// rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string VersionToExpire { get; set; }

        /// <summary>
        /// Checks to see if the VersionToExpire property is set.
        /// </summary>
        internal bool IsSetVersionToExpire() => this.VersionToExpire != null;
    }
}
