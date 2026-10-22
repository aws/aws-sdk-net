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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// The four preconditions a likelihood signal assessed.
    /// </summary>
    public partial class SignalPreconditions
    {
        /// <summary>
        /// Gets and sets the property AccessLevel. What level of access exploitation requires.
        /// </summary>
        public SignalAccessPrecondition AccessLevel { get; set; }

        /// <summary>
        /// Checks to see if the AccessLevel property is set.
        /// </summary>
        internal bool IsSetAccessLevel() => this.AccessLevel != null;

        /// <summary>
        /// Gets and sets the property ConfigurationNeeded. Whether exploitation depends on a
        /// non-default configuration.
        /// </summary>
        public SignalPrecondition ConfigurationNeeded { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationNeeded property is set.
        /// </summary>
        internal bool IsSetConfigurationNeeded() => this.ConfigurationNeeded != null;

        /// <summary>
        /// Gets and sets the property ReachableFromAttacker. Whether the vulnerable code path
        /// is reachable by an attacker.
        /// </summary>
        public SignalPrecondition ReachableFromAttacker { get; set; }

        /// <summary>
        /// Checks to see if the ReachableFromAttacker property is set.
        /// </summary>
        internal bool IsSetReachableFromAttacker() => this.ReachableFromAttacker != null;

        /// <summary>
        /// Gets and sets the property UserInteractionRequired. Whether exploitation requires
        /// a user other than the attacker to take part, for example by opening a link or a file
        /// (CVSS User Interaction).
        /// </summary>
        public SignalPrecondition UserInteractionRequired { get; set; }

        /// <summary>
        /// Checks to see if the UserInteractionRequired property is set.
        /// </summary>
        internal bool IsSetUserInteractionRequired() => this.UserInteractionRequired != null;
    }
}
