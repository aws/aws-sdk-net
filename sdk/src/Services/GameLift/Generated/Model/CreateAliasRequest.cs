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
    /// Creates an alias for a fleet. You can use an alias to anonymize your fleet by referencing
    /// an alias instead of a specific fleet when you create game sessions. Amazon GameLift
    /// supports two types of routing strategies for aliases: simple and terminal. Use a simple
    /// alias to point to an active fleet. Use a terminal alias to display a message to incoming
    /// traffic instead of routing players to an active fleet. This option is useful when
    /// a game server is no longer supported but you want to provide better messaging than
    /// a standard 404 error.
    /// 
    ///  
    /// <para>
    /// To create a fleet alias, specify an alias name, routing strategy, and optional description.
    /// If successful, a new alias record is returned, including an alias ID, which you can
    /// reference when creating a game session. To reassign the alias to another fleet ID,
    /// call <a>UpdateAlias</a>.
    /// </para>
    /// </summary>
    public partial class CreateAliasRequest : AmazonGameLiftRequest
    {
        private string _description;
        private string _name;
        private RoutingStrategy _routingStrategy;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Human-readable description of the alias.
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
        /// Descriptive label associated with this alias. Alias names do not need to be unique.
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
        /// Object specifying the fleet and routing type to use for the alias.
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