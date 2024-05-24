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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains information about the messages in the turn.
    /// </summary>
    public partial class TurnSpecification
    {
        private AgentTurnSpecification _agentTurn;
        private UserTurnSpecification _userTurn;

        /// <summary>
        /// Gets and sets the property AgentTurn. 
        /// <para>
        /// Contains information about the agent messages in the turn.
        /// </para>
        /// </summary>
        public AgentTurnSpecification AgentTurn
        {
            get { return this._agentTurn; }
            set { this._agentTurn = value; }
        }

        // Check to see if AgentTurn property is set
        internal bool IsSetAgentTurn()
        {
            return this._agentTurn != null;
        }

        /// <summary>
        /// Gets and sets the property UserTurn. 
        /// <para>
        /// Contains information about the user messages in the turn.
        /// </para>
        /// </summary>
        public UserTurnSpecification UserTurn
        {
            get { return this._userTurn; }
            set { this._userTurn = value; }
        }

        // Check to see if UserTurn property is set
        internal bool IsSetUserTurn()
        {
            return this._userTurn != null;
        }

    }
}