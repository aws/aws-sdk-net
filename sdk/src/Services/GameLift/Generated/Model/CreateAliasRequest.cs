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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAlias operation.
    /// Creates an alias for a fleet. In most situations, you can use an alias ID in place
    /// of a fleet ID. An alias provides a level of abstraction for a fleet that is useful
    /// when redirecting player traffic from one fleet to another, such as when updating your
    /// game build. 
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
    /// If successful, a new alias record is returned, including an alias ID and an ARN. You
    /// can reassign an alias to another fleet by calling <code>UpdateAlias</code>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class CreateAliasRequest : AmazonGameLiftRequest
    {
        private string _description;
        private string _name;
        private RoutingStrategy _routingStrategy;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the alias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// A descriptive label that is associated with an alias. Alias names do not need to be
        /// unique.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// The routing configuration, including routing type and fleet target, for the alias.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new alias resource. Tags are developer-defined key-value
        /// pairs. Tagging Amazon Web Services resources are useful for resource management, access
        /// management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}