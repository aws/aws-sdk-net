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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// The ThingTypeProperties contains information about the thing type including: a thing
    /// type description, and a list of searchable thing attribute names.
    /// </summary>
    public partial class ThingTypeProperties
    {
        private Mqtt5Configuration _mqtt5Configuration;
        private List<string> _searchableAttributes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _thingTypeDescription;

        /// <summary>
        /// Gets and sets the property Mqtt5Configuration. 
        /// <para>
        /// The configuration to add user-defined properties to enrich MQTT 5 messages.
        /// </para>
        /// </summary>
        public Mqtt5Configuration Mqtt5Configuration
        {
            get { return this._mqtt5Configuration; }
            set { this._mqtt5Configuration = value; }
        }

        // Check to see if Mqtt5Configuration property is set
        internal bool IsSetMqtt5Configuration()
        {
            return this._mqtt5Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property SearchableAttributes. 
        /// <para>
        /// A list of searchable thing attribute names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SearchableAttributes
        {
            get { return this._searchableAttributes; }
            set { this._searchableAttributes = value; }
        }

        // Check to see if SearchableAttributes property is set
        internal bool IsSetSearchableAttributes()
        {
            return this._searchableAttributes != null && (this._searchableAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThingTypeDescription. 
        /// <para>
        /// The description of the thing type.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2028)]
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