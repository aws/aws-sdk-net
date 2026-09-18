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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an WAFv2 web Access Control List (ACL).
    /// </summary>
    public partial class AwsWafv2WebAclDetails
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the web ACL that you want to associate with the
        /// resource. 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        ///  The web ACL capacity units (WCUs) currently being used by this web ACL. 
        /// </para>
        /// </summary>
        public long? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property CaptchaConfig. 
        /// <para>
        ///  Specifies how WAF should handle CAPTCHA evaluations for rules that don't have their
        /// own <c>CaptchaConfig</c> settings. 
        /// </para>
        /// </summary>
        public AwsWafv2WebAclCaptchaConfigDetails CaptchaConfig { get; set; }

        /// <summary>
        /// Checks to see if the CaptchaConfig property is set.
        /// </summary>
        internal bool IsSetCaptchaConfig() => this.CaptchaConfig != null;

        /// <summary>
        /// Gets and sets the property DefaultAction. 
        /// <para>
        ///  The action to perform if none of the Rules contained in the web ACL match. 
        /// </para>
        /// </summary>
        public AwsWafv2WebAclActionDetails DefaultAction { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAction property is set.
        /// </summary>
        internal bool IsSetDefaultAction() => this.DefaultAction != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the web ACL that helps with identification. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  A unique identifier for the web ACL. 
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ManagedbyFirewallManager. 
        /// <para>
        ///  Indicates whether this web ACL is managed by Firewall Manager. 
        /// </para>
        /// </summary>
        public bool? ManagedbyFirewallManager { get; set; }

        /// <summary>
        /// Checks to see if the ManagedbyFirewallManager property is set.
        /// </summary>
        internal bool IsSetManagedbyFirewallManager() => this.ManagedbyFirewallManager.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the web ACL. 
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        ///  The Rule statements used to identify the web requests that you want to allow, block,
        /// or count. Each rule includes one top-level statement that WAF uses to identify matching
        /// web requests, and parameters that govern how WAF handles them. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsWafv2RulesDetails> Rules { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsWafv2RulesDetails>() : null;

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null && (this.Rules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        ///  Defines and enables Amazon CloudWatch metrics and web request sample collection.
        /// 
        /// </para>
        /// </summary>
        public AwsWafv2VisibilityConfigDetails VisibilityConfig { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityConfig property is set.
        /// </summary>
        internal bool IsSetVisibilityConfig() => this.VisibilityConfig != null;
    }
}
