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
    /// Container for the parameters to the UpdateRuleGroup operation.
    /// Updates the specified <a>RuleGroup</a>.
    /// 
    ///  <note> 
    /// <para>
    /// This operation completely replaces the mutable specifications that you already have
    /// for the rule group with the ones that you provide to this call. 
    /// </para>
    ///  
    /// <para>
    /// To modify a rule group, do the following: 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Retrieve it by calling <a>GetRuleGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update its settings as needed
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provide the complete rule group specification to this call
    /// </para>
    ///  </li> </ol> </note> 
    /// <para>
    ///  A rule group defines a collection of rules to inspect and control web requests that
    /// you can use in a <a>WebACL</a>. When you create a rule group, you define an immutable
    /// capacity limit. If you update a rule group, you must stay within the capacity. This
    /// allows others to reuse the rule group with confidence in its capacity requirements.
    /// 
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
    public partial class UpdateRuleGroupRequest : AmazonWAFV2Request
    {
        private Dictionary<string, CustomResponseBody> _customResponseBodies = AWSConfigs.InitializeCollections ? new Dictionary<string, CustomResponseBody>() : null;
        private string _description;
        private string _id;
        private string _lockToken;
        private string _name;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;
        private Scope _scope;
        private VisibilityConfig _visibilityConfig;

        /// <summary>
        /// Gets and sets the property CustomResponseBodies. 
        /// <para>
        /// A map of custom response keys and content bodies. When you create a rule with a block
        /// action, you can send a custom response to the web request. You define these for the
        /// rule group, and then use them in the rules that you define in the rule group. 
        /// </para>
        ///  
        /// <para>
        /// For information about customizing web requests and responses, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/waf-custom-request-response.html">Customizing
        /// web requests and responses in WAF</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// For information about the limits on count and size for custom request and response
        /// settings, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/limits.html">WAF
        /// quotas</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public Dictionary<string, CustomResponseBody> CustomResponseBodies
        {
            get { return this._customResponseBodies; }
            set { this._customResponseBodies = value; }
        }

        // Check to see if CustomResponseBodies property is set
        internal bool IsSetCustomResponseBodies()
        {
            return this._customResponseBodies != null && (this._customResponseBodies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule group that helps with identification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the rule group. This ID is returned in the responses to create
        /// and list commands. You provide it to operations like update and delete.
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
        /// A token used for optimistic locking. WAF returns a token to your <c>get</c> and <c>list</c>
        /// requests, to mark the state of the entity at the time of the request. To make changes
        /// to the entity associated with the token, you provide the token to operations like
        /// <c>update</c> and <c>delete</c>. WAF uses the token to ensure that no changes have
        /// been made to the entity since you last retrieved it. If a change has been made, the
        /// update fails with a <c>WAFOptimisticLockException</c>. If this happens, perform another
        /// <c>get</c>, and use the new token returned by that operation. 
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
        /// The name of the rule group. You cannot change the name of a rule group after you create
        /// it.
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
        /// Gets and sets the property Rules. 
        /// <para>
        /// The <a>Rule</a> statements used to identify the web requests that you want to manage.
        /// Each rule includes one top-level statement that WAF uses to identify matching web
        /// requests, and parameters that govern how WAF handles them. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
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

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VisibilityConfig VisibilityConfig
        {
            get { return this._visibilityConfig; }
            set { this._visibilityConfig = value; }
        }

        // Check to see if VisibilityConfig property is set
        internal bool IsSetVisibilityConfig()
        {
            return this._visibilityConfig != null;
        }

    }
}