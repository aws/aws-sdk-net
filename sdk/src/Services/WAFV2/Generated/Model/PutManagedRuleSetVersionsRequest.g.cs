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
    /// Container for the parameters to the PutManagedRuleSetVersions operation. Defines the
    /// versions of your managed rule set that you are offering to the customers. Customers
    /// see your offerings as managed rule groups with versioning. <note> <para> This is intended
    /// for use only by vendors of managed rule sets. Vendors are Amazon Web Services and
    /// Amazon Web Services Marketplace sellers. </para> <para> Vendors, you can use the managed
    /// rule set APIs to provide controlled rollout of your versioned managed rule group offerings
    /// for your customers. The APIs are <c>ListManagedRuleSets</c>, <c>GetManagedRuleSet</c>,
    /// <c>PutManagedRuleSetVersions</c>, and <c>UpdateManagedRuleSetVersionExpiryDate</c>.
    /// </para> </note> <para> Customers retrieve their managed rule group list by calling
    /// <a>ListAvailableManagedRuleGroups</a>. The name that you provide here for your managed
    /// rule set is the name the customer sees for the corresponding managed rule group. Customers
    /// can retrieve the available versions for a managed rule group by calling <a>ListAvailableManagedRuleGroupVersions</a>.
    /// You provide a rule group specification for each version. For each managed rule set,
    /// you must specify a version that you recommend using. </para> <para> To initiate the
    /// expiration of a managed rule group version, use <a>UpdateManagedRuleSetVersionExpiryDate</a>.
    /// </para>
    /// </summary>
    public partial class PutManagedRuleSetVersionsRequest : AmazonWAFV2Request
    {
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
        /// Gets and sets the property RecommendedVersion. 
        /// <para>
        /// The version of the named managed rule group that you'd like your customers to choose,
        /// from among your version offerings. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string RecommendedVersion { get; set; }

        /// <summary>
        /// Checks to see if the RecommendedVersion property is set.
        /// </summary>
        internal bool IsSetRecommendedVersion() => this.RecommendedVersion != null;

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
        /// Gets and sets the property VersionsToPublish. 
        /// <para>
        /// The versions of the named managed rule group that you want to offer to your customers.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, VersionToPublish> VersionsToPublish { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, VersionToPublish>() : null;

        /// <summary>
        /// Checks to see if the VersionsToPublish property is set.
        /// </summary>
        internal bool IsSetVersionsToPublish() => this.VersionsToPublish != null && (this.VersionsToPublish.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
