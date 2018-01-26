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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for Input
    /// </summary>
    public partial class Input
    {
        private string _arn;
        private List<string> _attachedChannels = new List<string>();
        private List<InputDestination> _destinations = new List<InputDestination>();
        private string _id;
        private string _name;
        private List<string> _securityGroups = new List<string>();
        private List<InputSource> _sources = new List<InputSource>();
        private InputState _state;
        private InputType _type;

        /// <summary>
        /// Gets and sets the property Arn. The Unique ARN of the input (generated, immutable).
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AttachedChannels. A list of channel IDs that that input
        /// is attached to (currently an input can only be attached to one channel).
        /// </summary>
        public List<string> AttachedChannels
        {
            get { return this._attachedChannels; }
            set { this._attachedChannels = value; }
        }

        // Check to see if AttachedChannels property is set
        internal bool IsSetAttachedChannels()
        {
            return this._attachedChannels != null && this._attachedChannels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Destinations. A list of the destinations of the input (PUSH-type).
        /// </summary>
        public List<InputDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. The generated ID of the input (unique for user account,
        /// immutable).
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The user-assigned name (This is a mutable value).
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
        /// Gets and sets the property SecurityGroups. A list of IDs for all the security groups
        /// attached to the input.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sources. A list of the sources of the input (PULL-type).
        /// </summary>
        public List<InputSource> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State.
        /// </summary>
        public InputState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public InputType Type
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