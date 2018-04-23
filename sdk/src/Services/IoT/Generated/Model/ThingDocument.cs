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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The thing search index document.
    /// </summary>
    public partial class ThingDocument
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _shadow;
        private List<string> _thingGroupNames = new List<string>();
        private string _thingId;
        private string _thingName;
        private string _thingTypeName;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// The attributes.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Shadow. 
        /// <para>
        /// The shadow.
        /// </para>
        /// </summary>
        public string Shadow
        {
            get { return this._shadow; }
            set { this._shadow = value; }
        }

        // Check to see if Shadow property is set
        internal bool IsSetShadow()
        {
            return this._shadow != null;
        }

        /// <summary>
        /// Gets and sets the property ThingGroupNames. 
        /// <para>
        /// Thing group names.
        /// </para>
        /// </summary>
        public List<string> ThingGroupNames
        {
            get { return this._thingGroupNames; }
            set { this._thingGroupNames = value; }
        }

        // Check to see if ThingGroupNames property is set
        internal bool IsSetThingGroupNames()
        {
            return this._thingGroupNames != null && this._thingGroupNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThingId. 
        /// <para>
        /// The thing ID.
        /// </para>
        /// </summary>
        public string ThingId
        {
            get { return this._thingId; }
            set { this._thingId = value; }
        }

        // Check to see if ThingId property is set
        internal bool IsSetThingId()
        {
            return this._thingId != null;
        }

        /// <summary>
        /// Gets and sets the property ThingName. 
        /// <para>
        /// The thing name.
        /// </para>
        /// </summary>
        public string ThingName
        {
            get { return this._thingName; }
            set { this._thingName = value; }
        }

        // Check to see if ThingName property is set
        internal bool IsSetThingName()
        {
            return this._thingName != null;
        }

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The thing type name.
        /// </para>
        /// </summary>
        public string ThingTypeName
        {
            get { return this._thingTypeName; }
            set { this._thingTypeName = value; }
        }

        // Check to see if ThingTypeName property is set
        internal bool IsSetThingTypeName()
        {
            return this._thingTypeName != null;
        }

    }
}