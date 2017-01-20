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
    /// The ThingTypeProperties contains information about the thing type including: a thing
    /// type description, and a list of searchable thing attribute names.
    /// </summary>
    public partial class ThingTypeProperties
    {
        private List<string> _searchableAttributes = new List<string>();
        private string _thingTypeDescription;

        /// <summary>
        /// Gets and sets the property SearchableAttributes. 
        /// <para>
        /// A list of searchable thing attribute names.
        /// </para>
        /// </summary>
        public List<string> SearchableAttributes
        {
            get { return this._searchableAttributes; }
            set { this._searchableAttributes = value; }
        }

        // Check to see if SearchableAttributes property is set
        internal bool IsSetSearchableAttributes()
        {
            return this._searchableAttributes != null && this._searchableAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ThingTypeDescription. 
        /// <para>
        /// The description of the thing type.
        /// </para>
        /// </summary>
        public string ThingTypeDescription
        {
            get { return this._thingTypeDescription; }
            set { this._thingTypeDescription = value; }
        }

        // Check to see if ThingTypeDescription property is set
        internal bool IsSetThingTypeDescription()
        {
            return this._thingTypeDescription != null;
        }

    }
}