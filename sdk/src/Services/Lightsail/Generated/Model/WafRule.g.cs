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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a Web Application Firewall (WAF) rule group for a Lightsail distribution.
    /// A WAF rule group is a set of rules managed by AWS. The rules inspect viewer requests
    /// and block requests that match them.
    /// </summary>
    public partial class WafRule
    {
        /// <summary>
        /// Gets and sets the property AcfpConfig. 
        /// <para>
        /// An object that describes the configuration of the account creation fraud prevention
        /// rule group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define this parameter only when the <c>name</c> is <c>AWSManagedRulesACFPRuleSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter is required when the <c>name</c> is <c>AWSManagedRulesACFPRuleSet</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WafAcfpConfig AcfpConfig { get; set; }

        /// <summary>
        /// Checks to see if the AcfpConfig property is set.
        /// </summary>
        internal bool IsSetAcfpConfig() => this.AcfpConfig != null;

        /// <summary>
        /// Gets and sets the property AtpConfig. 
        /// <para>
        /// An object that describes the configuration of the account takeover prevention rule
        /// group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define this parameter only when the <c>name</c> is <c>AWSManagedRulesATPRuleSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter is required when the <c>name</c> is <c>AWSManagedRulesATPRuleSet</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WafAtpConfig AtpConfig { get; set; }

        /// <summary>
        /// Checks to see if the AtpConfig property is set.
        /// </summary>
        internal bool IsSetAtpConfig() => this.AtpConfig != null;

        /// <summary>
        /// Gets and sets the property BotControlConfig. 
        /// <para>
        /// An object that describes the configuration of the bot control rule group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define this parameter only when the <c>name</c> is <c>AWSManagedRulesBotControlRuleSet</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This parameter is required when the <c>name</c> is <c>AWSManagedRulesBotControlRuleSet</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WafBotControlConfig BotControlConfig { get; set; }

        /// <summary>
        /// Checks to see if the BotControlConfig property is set.
        /// </summary>
        internal bool IsSetBotControlConfig() => this.BotControlConfig != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the WAF rule group (for example, <c>AWSManagedRulesCommonRuleSet</c>).
        /// </para>
        ///  
        /// <para>
        /// For the WAF rule groups that you can specify for each bundle, see the <c>wafRules</c>
        /// parameter of the <c>CreateDistribution</c> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
