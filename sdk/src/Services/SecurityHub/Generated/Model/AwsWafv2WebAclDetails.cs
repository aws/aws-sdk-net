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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an WAFv2 web Access Control List (ACL).
    /// </summary>
    public partial class AwsWafv2WebAclDetails
    {
        private string _arn;
        private long? _capacity;
        private AwsWafv2WebAclCaptchaConfigDetails _captchaConfig;
        private AwsWafv2WebAclActionDetails _defaultAction;
        private string _description;
        private string _id;
        private bool? _managedbyFirewallManager;
        private string _name;
        private List<AwsWafv2RulesDetails> _rules = new List<AwsWafv2RulesDetails>();
        private AwsWafv2VisibilityConfigDetails _visibilityConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the web ACL that you want to associate with the
        /// resource. 
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        ///  The web ACL capacity units (WCUs) currently being used by this web ACL. 
        /// </para>
        /// </summary>
        public long Capacity
        {
            get { return this._capacity.GetValueOrDefault(); }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaptchaConfig. 
        /// <para>
        ///  Specifies how WAF should handle CAPTCHA evaluations for rules that don't have their
        /// own <code>CaptchaConfig</code> settings. 
        /// </para>
        /// </summary>
        public AwsWafv2WebAclCaptchaConfigDetails CaptchaConfig
        {
            get { return this._captchaConfig; }
            set { this._captchaConfig = value; }
        }

        // Check to see if CaptchaConfig property is set
        internal bool IsSetCaptchaConfig()
        {
            return this._captchaConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        ///  The action to perform if none of the Rules contained in the web ACL match. 
        /// </para>
        /// </summary>
        public AwsWafv2WebAclActionDetails DefaultAction
        {
            get { return this._defaultAction; }
            set { this._defaultAction = value; }
        }

        // Check to see if DefaultAction property is set
        internal bool IsSetDefaultAction()
        {
            return this._defaultAction != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the web ACL that helps with identification. 
        /// </para>
        /// </summary>
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
        ///  A unique identifier for the web ACL. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ManagedbyFirewallManager. 
        /// <para>
        ///  Indicates whether this web ACL is managed by Firewall Manager. 
        /// </para>
        /// </summary>
        public bool ManagedbyFirewallManager
        {
            get { return this._managedbyFirewallManager.GetValueOrDefault(); }
            set { this._managedbyFirewallManager = value; }
        }

        // Check to see if ManagedbyFirewallManager property is set
        internal bool IsSetManagedbyFirewallManager()
        {
            return this._managedbyFirewallManager.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the web ACL. 
        /// </para>
        /// </summary>
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
        ///  The Rule statements used to identify the web requests that you want to allow, block,
        /// or count. Each rule includes one top-level statement that WAF uses to identify matching
        /// web requests, and parameters that govern how WAF handles them. 
        /// </para>
        /// </summary>
        public List<AwsWafv2RulesDetails> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        ///  Defines and enables Amazon CloudWatch metrics and web request sample collection.
        /// 
        /// </para>
        /// </summary>
        public AwsWafv2VisibilityConfigDetails VisibilityConfig
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