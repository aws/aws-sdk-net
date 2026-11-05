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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The ThingTypeProperties contains information about the thing type including: a thing
    /// type description, and a list of searchable thing attribute names.
    /// </summary>
    public partial class ThingTypeProperties
    {
        /// <summary>
        /// Gets and sets the property Mqtt5Configuration. 
        /// <para>
        /// The configuration to add user-defined properties to enrich MQTT 5 messages.
        /// </para>
        /// </summary>
        public Mqtt5Configuration Mqtt5Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Mqtt5Configuration property is set.
        /// </summary>
        internal bool IsSetMqtt5Configuration() => this.Mqtt5Configuration != null;

        /// <summary>
        /// Gets and sets the property SearchableAttributes. 
        /// <para>
        /// A list of searchable thing attribute names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SearchableAttributes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SearchableAttributes property is set.
        /// </summary>
        internal bool IsSetSearchableAttributes() => this.SearchableAttributes != null && (this.SearchableAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThingTypeDescription. 
        /// <para>
        /// The description of the thing type.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2028)]
        public string ThingTypeDescription { get; set; }

        /// <summary>
        /// Checks to see if the ThingTypeDescription property is set.
        /// </summary>
        internal bool IsSetThingTypeDescription() => this.ThingTypeDescription != null;
    }
}
