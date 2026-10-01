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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Details describing a core network change.
    /// </summary>
    public partial class CoreNetworkChange
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take for a core network.
        /// </para>
        /// </summary>
        public ChangeAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The resource identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property IdentifierPath. 
        /// <para>
        /// Uniquely identifies the path for a change within the changeset. For example, the <c>IdentifierPath</c>
        /// for a core network segment change might be <c>"CORE_NETWORK_SEGMENT/us-east-1/devsegment"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string IdentifierPath { get; set; }

        /// <summary>
        /// Checks to see if the IdentifierPath property is set.
        /// </summary>
        internal bool IsSetIdentifierPath() => this.IdentifierPath != null;

        /// <summary>
        /// Gets and sets the property NewValues. 
        /// <para>
        /// The new value for a core network
        /// </para>
        /// </summary>
        public CoreNetworkChangeValues NewValues { get; set; }

        /// <summary>
        /// Checks to see if the NewValues property is set.
        /// </summary>
        internal bool IsSetNewValues() => this.NewValues != null;

        /// <summary>
        /// Gets and sets the property PreviousValues. 
        /// <para>
        /// The previous values for a core network.
        /// </para>
        /// </summary>
        public CoreNetworkChangeValues PreviousValues { get; set; }

        /// <summary>
        /// Checks to see if the PreviousValues property is set.
        /// </summary>
        internal bool IsSetPreviousValues() => this.PreviousValues != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of change.
        /// </para>
        /// </summary>
        public ChangeType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
