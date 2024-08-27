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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Step defines the list of agents to be routed or route based on the agent requirements
    /// such as ProficiencyLevel, Name, or Value.
    /// </summary>
    public partial class RoutingCriteriaInputStep
    {
        private RoutingCriteriaInputStepExpiry _expiry;
        private Expression _expression;

        /// <summary>
        /// Gets and sets the property Expiry. 
        /// <para>
        /// An object to specify the expiration of a routing step.
        /// </para>
        /// </summary>
        public RoutingCriteriaInputStepExpiry Expiry
        {
            get { return this._expiry; }
            set { this._expiry = value; }
        }

        // Check to see if Expiry property is set
        internal bool IsSetExpiry()
        {
            return this._expiry != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// A tagged union to specify expression for a routing step.
        /// </para>
        /// </summary>
        public Expression Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

    }
}