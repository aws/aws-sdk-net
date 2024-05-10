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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// An optional, non-standard action to use for stateless packet handling. You can define
    /// this in addition to the standard action that you must specify. 
    /// 
    ///  
    /// <para>
    /// You define and name the custom actions that you want to be able to use, and then you
    /// reference them by name in your actions settings. 
    /// </para>
    ///  
    /// <para>
    /// You can use custom actions in the following places: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// In a rule group's <a>StatelessRulesAndCustomActions</a> specification. The custom
    /// actions are available for use by name inside the <c>StatelessRulesAndCustomActions</c>
    /// where you define them. You can use them for your stateless rule actions to specify
    /// what to do with a packet that matches the rule's match attributes. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In a <a>FirewallPolicy</a> specification, in <c>StatelessCustomActions</c>. The custom
    /// actions are available for use inside the policy where you define them. You can use
    /// them for the policy's default stateless actions settings to specify what to do with
    /// packets that don't match any of the policy's stateless rules. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CustomAction
    {
        private ActionDefinition _actionDefinition;
        private string _actionName;

        /// <summary>
        /// Gets and sets the property ActionDefinition. 
        /// <para>
        /// The custom action associated with the action name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionDefinition ActionDefinition
        {
            get { return this._actionDefinition; }
            set { this._actionDefinition = value; }
        }

        // Check to see if ActionDefinition property is set
        internal bool IsSetActionDefinition()
        {
            return this._actionDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The descriptive name of the custom action. You can't change the name of a custom action
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

    }
}