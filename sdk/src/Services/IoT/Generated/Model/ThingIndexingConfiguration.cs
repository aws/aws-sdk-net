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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The thing indexing configuration. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/managing-index.html">Managing
    /// Thing Indexing</a>.
    /// </summary>
    public partial class ThingIndexingConfiguration
    {
        private List<Field> _customFields = new List<Field>();
        private DeviceDefenderIndexingMode _deviceDefenderIndexingMode;
        private IndexingFilter _filter;
        private List<Field> _managedFields = new List<Field>();
        private NamedShadowIndexingMode _namedShadowIndexingMode;
        private ThingConnectivityIndexingMode _thingConnectivityIndexingMode;
        private ThingIndexingMode _thingIndexingMode;

        /// <summary>
        /// Gets and sets the property CustomFields. 
        /// <para>
        /// Contains custom field names and their data type.
        /// </para>
        /// </summary>
        public List<Field> CustomFields
        {
            get { return this._customFields; }
            set { this._customFields = value; }
        }

        // Check to see if CustomFields property is set
        internal bool IsSetCustomFields()
        {
            return this._customFields != null && this._customFields.Count > 0; 
        }

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
        public DeviceDefenderIndexingMode DeviceDefenderIndexingMode
        {
            get { return this._deviceDefenderIndexingMode; }
            set { this._deviceDefenderIndexingMode = value; }
        }

        // Check to see if DeviceDefenderIndexingMode property is set
        internal bool IsSetDeviceDefenderIndexingMode()
        {
            return this._deviceDefenderIndexingMode != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Provides additional filters for specific data sources. Named shadow is the only data
        /// source that currently supports and requires a filter. To add named shadows to your
        /// fleet indexing configuration, set <code>namedShadowIndexingMode</code> to be <code>ON</code>
        /// and specify your shadow names in <code>filter</code>.
        /// </para>
        /// </summary>
        public IndexingFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedFields. 
        /// <para>
        /// Contains fields that are indexed and whose types are already known by the Fleet Indexing
        /// service.
        /// </para>
        /// </summary>
        public List<Field> ManagedFields
        {
            get { return this._managedFields; }
            set { this._managedFields = value; }
        }

        // Check to see if ManagedFields property is set
        internal bool IsSetManagedFields()
        {
            return this._managedFields != null && this._managedFields.Count > 0; 
        }

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
        public NamedShadowIndexingMode NamedShadowIndexingMode
        {
            get { return this._namedShadowIndexingMode; }
            set { this._namedShadowIndexingMode = value; }
        }

        // Check to see if NamedShadowIndexingMode property is set
        internal bool IsSetNamedShadowIndexingMode()
        {
            return this._namedShadowIndexingMode != null;
        }

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
        public ThingConnectivityIndexingMode ThingConnectivityIndexingMode
        {
            get { return this._thingConnectivityIndexingMode; }
            set { this._thingConnectivityIndexingMode = value; }
        }

        // Check to see if ThingConnectivityIndexingMode property is set
        internal bool IsSetThingConnectivityIndexingMode()
        {
            return this._thingConnectivityIndexingMode != null;
        }

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
        [AWSProperty(Required=true)]
        public ThingIndexingMode ThingIndexingMode
        {
            get { return this._thingIndexingMode; }
            set { this._thingIndexingMode = value; }
        }

        // Check to see if ThingIndexingMode property is set
        internal bool IsSetThingIndexingMode()
        {
            return this._thingIndexingMode != null;
        }

    }
}