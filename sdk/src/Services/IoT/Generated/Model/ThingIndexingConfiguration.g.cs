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
    /// The thing indexing configuration. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/managing-index.html">Managing
    /// Thing Indexing</a>.
    /// </summary>
    public partial class ThingIndexingConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomFields. 
        /// <para>
        /// Contains custom field names and their data type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Field> CustomFields { get; set; } = AWSConfigs.InitializeCollections ? new List<Field>() : null;

        /// <summary>
        /// Checks to see if the CustomFields property is set.
        /// </summary>
        internal bool IsSetCustomFields() => this.CustomFields != null && (this.CustomFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeviceDefenderIndexingMode. 
        /// <para>
        /// Device Defender indexing mode. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// VIOLATIONS – Your thing index contains Device Defender violations. To enable Device
        /// Defender indexing, <i>deviceDefenderIndexingMode</i> must not be set to OFF.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OFF - Device Defender indexing is disabled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about Device Defender violations, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/device-defender-detect.html">Device
        /// Defender Detect.</a> 
        /// </para>
        /// </summary>
        public DeviceDefenderIndexingMode DeviceDefenderIndexingMode { get; set; }

        /// <summary>
        /// Checks to see if the DeviceDefenderIndexingMode property is set.
        /// </summary>
        internal bool IsSetDeviceDefenderIndexingMode() => this.DeviceDefenderIndexingMode != null;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Provides additional selections for named shadows and geolocation data. 
        /// </para>
        ///  
        /// <para>
        /// To add named shadows to your fleet indexing configuration, set <c>namedShadowIndexingMode</c>
        /// to be ON and specify your shadow names in <c>namedShadowNames</c> filter.
        /// </para>
        ///  
        /// <para>
        /// To add geolocation data to your fleet indexing configuration: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you store geolocation data in a class/unnamed shadow, set <c>thingIndexingMode</c>
        /// to be <c>REGISTRY_AND_SHADOW</c> and specify your geolocation data in <c>geoLocations</c>
        /// filter. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you store geolocation data in a named shadow, set <c>namedShadowIndexingMode</c>
        /// to be <c>ON</c>, add the shadow name in <c>namedShadowNames</c> filter, and specify
        /// your geolocation data in <c>geoLocations</c> filter. For more information, see <a
        /// href="https://docs.aws.amazon.com/iot/latest/developerguide/managing-fleet-index.html">Managing
        /// fleet indexing</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public IndexingFilter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property ManagedFields. 
        /// <para>
        /// Contains fields that are indexed and whose types are already known by the Fleet Indexing
        /// service. This is an optional field. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/managing-fleet-index.html#managed-field">Managed
        /// fields</a> in the <i>Amazon Web Services IoT Core Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't modify managed fields by updating fleet indexing configuration.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Field> ManagedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<Field>() : null;

        /// <summary>
        /// Checks to see if the ManagedFields property is set.
        /// </summary>
        internal bool IsSetManagedFields() => this.ManagedFields != null && (this.ManagedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NamedShadowIndexingMode. 
        /// <para>
        /// Named shadow indexing mode. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ON – Your thing index contains named shadow. To enable thing named shadow indexing,
        /// <i>namedShadowIndexingMode</i> must not be set to OFF.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OFF - Named shadow indexing is disabled.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about Shadows, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-device-shadows.html">IoT
        /// Device Shadow service.</a> 
        /// </para>
        /// </summary>
        public NamedShadowIndexingMode NamedShadowIndexingMode { get; set; }

        /// <summary>
        /// Checks to see if the NamedShadowIndexingMode property is set.
        /// </summary>
        internal bool IsSetNamedShadowIndexingMode() => this.NamedShadowIndexingMode != null;

        /// <summary>
        /// Gets and sets the property ThingConnectivityIndexingMode. 
        /// <para>
        /// Thing connectivity indexing mode. Valid values are: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// STATUS – Your thing index contains connectivity status. To enable thing connectivity
        /// indexing, <i>thingIndexMode</i> must not be set to OFF.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OFF - Thing connectivity status indexing is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ThingConnectivityIndexingMode ThingConnectivityIndexingMode { get; set; }

        /// <summary>
        /// Checks to see if the ThingConnectivityIndexingMode property is set.
        /// </summary>
        internal bool IsSetThingConnectivityIndexingMode() => this.ThingConnectivityIndexingMode != null;

        /// <summary>
        /// Gets and sets the property ThingIndexingMode. 
        /// <para>
        /// Thing indexing mode. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// REGISTRY – Your thing index contains registry data only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGISTRY_AND_SHADOW - Your thing index contains registry and shadow data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OFF - Thing indexing is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public ThingIndexingMode ThingIndexingMode { get; set; }

        /// <summary>
        /// Checks to see if the ThingIndexingMode property is set.
        /// </summary>
        internal bool IsSetThingIndexingMode() => this.ThingIndexingMode != null;
    }
}
