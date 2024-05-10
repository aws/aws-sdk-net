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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A custom action that can be used for stateless packet handling.
    /// </summary>
    public partial class FirewallPolicyStatelessCustomActionsDetails
    {
        private StatelessCustomActionDefinition _actionDefinition;
        private string _actionName;

        /// <summary>
        /// Gets and sets the property ActionDefinition. 
        /// <para>
        /// The definition of the custom action.
        /// </para>
        /// </summary>
        public StatelessCustomActionDefinition ActionDefinition
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
        /// The name of the custom action.
        /// </para>
        /// </summary>
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