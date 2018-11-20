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
    /// Container for the parameters to the CreateThingType operation.
    /// Creates a new thing type.
    /// </summary>
    public partial class CreateThingTypeRequest : AmazonIoTRequest
    {
        private List<Tag> _tags = new List<Tag>();
        private string _thingTypeName;
        private ThingTypeProperties _thingTypeProperties;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Metadata which can be used to manage the thing type.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ThingTypeName. 
        /// <para>
        /// The name of the thing type.
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

        /// <summary>
        /// Gets and sets the property ThingTypeProperties. 
        /// <para>
        /// The ThingTypeProperties for the thing type to create. It contains information about
        /// the new thing type including a description, and a list of searchable thing attribute
        /// names.
        /// </para>
        /// </summary>
        public ThingTypeProperties ThingTypeProperties
        {
            get { return this._thingTypeProperties; }
            set { this._thingTypeProperties = value; }
        }

        // Check to see if ThingTypeProperties property is set
        internal bool IsSetThingTypeProperties()
        {
            return this._thingTypeProperties != null;
        }

    }
}