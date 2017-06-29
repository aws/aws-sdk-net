/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAlias operation.
    /// Creates an alias for a fleet. In most situations, you can use an alias ID in place
    /// of a fleet ID. By using a fleet alias instead of a specific fleet ID, you can switch
    /// gameplay and players to a new fleet without changing your game client or other game
    /// components. For example, for games in production, using an alias allows you to seamlessly
    /// redirect your player base to a new game server update. 
    /// 
    ///  
    /// <para>
    /// Amazon GameLift supports two types of routing strategies for aliases: simple and terminal.
    /// A simple alias points to an active fleet. A terminal alias is used to display messaging
    /// or link to a URL instead of routing players to an active fleet. For example, you might
    /// use a terminal alias when a game version is no longer supported and you want to direct
    /// players to an upgrade site. 
    /// </para>
    ///  
    /// <para>
    /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
    /// Each simple alias can point to only one fleet, but a fleet can have multiple aliases.
    /// If successful, a new alias record is returned, including an alias ID, which you can
    /// reference when creating a game session. You can reassign an alias to another fleet
    /// by calling <code>UpdateAlias</code>.
    /// </para>
    ///  
    /// <para>
    /// Alias-related operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAliases</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteAlias</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ResolveAlias</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateAliasRequest : AmazonGameLiftRequest
    {
        private string _description;
        private string _name;
        private RoutingStrategy _routingStrategy;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description of an alias.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label that is associated with an alias. Alias names do not need to be
        /// unique.
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
        /// Gets and sets the property RoutingStrategy. 
        /// <para>
        /// Object that specifies the fleet and routing type to use for the alias.
        /// </para>
        /// </summary>
        public RoutingStrategy RoutingStrategy
        {
            get { return this._routingStrategy; }
            set { this._routingStrategy = value; }
        }

        // Check to see if RoutingStrategy property is set
        internal bool IsSetRoutingStrategy()
        {
            return this._routingStrategy != null;
        }

    }
}