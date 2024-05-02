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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
        private ChangeAction _action;
        private string _identifier;
        private string _identifierPath;
        private CoreNetworkChangeValues _newValues;
        private CoreNetworkChangeValues _previousValues;
        private ChangeType _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take for a core network.
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The resource identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property IdentifierPath. 
        /// <para>
        /// Uniquely identifies the path for a change within the changeset. For example, the <c>IdentifierPath</c>
        /// for a core network segment change might be <c>"CORE_NETWORK_SEGMENT/us-east-1/devsegment"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string IdentifierPath
        {
            get { return this._identifierPath; }
            set { this._identifierPath = value; }
        }

        // Check to see if IdentifierPath property is set
        internal bool IsSetIdentifierPath()
        {
            return this._identifierPath != null;
        }

        /// <summary>
        /// Gets and sets the property NewValues. 
        /// <para>
        /// The new value for a core network
        /// </para>
        /// </summary>
        public CoreNetworkChangeValues NewValues
        {
            get { return this._newValues; }
            set { this._newValues = value; }
        }

        // Check to see if NewValues property is set
        internal bool IsSetNewValues()
        {
            return this._newValues != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousValues. 
        /// <para>
        /// The previous values for a core network.
        /// </para>
        /// </summary>
        public CoreNetworkChangeValues PreviousValues
        {
            get { return this._previousValues; }
            set { this._previousValues = value; }
        }

        // Check to see if PreviousValues property is set
        internal bool IsSetPreviousValues()
        {
            return this._previousValues != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of change.
        /// </para>
        /// </summary>
        public ChangeType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}