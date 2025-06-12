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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Properties of a conversion job
    /// </summary>
    public partial class ConversionProperties
    {
        private string _dataTimestamp;
        private bool? _forceUefi;
        private string _rootVolumeName;
        private Dictionary<string, Dictionary<string, string>> _volumeToConversionMap = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;
        private Dictionary<string, List<ProductCode>> _volumeToProductCodes = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ProductCode>>() : null;
        private Dictionary<string, long> _volumeToVolumeSize = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Gets and sets the property DataTimestamp. 
        /// <para>
        /// The timestamp of when the snapshot being converted was taken
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string DataTimestamp
        {
            get { return this._dataTimestamp; }
            set { this._dataTimestamp = value; }
        }

        // Check to see if DataTimestamp property is set
        internal bool IsSetDataTimestamp()
        {
            return this._dataTimestamp != null;
        }

        /// <summary>
        /// Gets and sets the property ForceUefi. 
        /// <para>
        /// Whether the volume being converted uses UEFI or not
        /// </para>
        /// </summary>
        public bool? ForceUefi
        {
            get { return this._forceUefi; }
            set { this._forceUefi = value; }
        }

        // Check to see if ForceUefi property is set
        internal bool IsSetForceUefi()
        {
            return this._forceUefi.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RootVolumeName. 
        /// <para>
        /// The root volume name of a conversion job
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string RootVolumeName
        {
            get { return this._rootVolumeName; }
            set { this._rootVolumeName = value; }
        }

        // Check to see if RootVolumeName property is set
        internal bool IsSetRootVolumeName()
        {
            return this._rootVolumeName != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeToConversionMap. 
        /// <para>
        /// A mapping between the volumes being converted and the converted snapshot ids
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> VolumeToConversionMap
        {
            get { return this._volumeToConversionMap; }
            set { this._volumeToConversionMap = value; }
        }

        // Check to see if VolumeToConversionMap property is set
        internal bool IsSetVolumeToConversionMap()
        {
            return this._volumeToConversionMap != null && (this._volumeToConversionMap.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VolumeToProductCodes. 
        /// <para>
        /// A mapping between the volumes being converted and the product codes associated with
        /// them
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<ProductCode>> VolumeToProductCodes
        {
            get { return this._volumeToProductCodes; }
            set { this._volumeToProductCodes = value; }
        }

        // Check to see if VolumeToProductCodes property is set
        internal bool IsSetVolumeToProductCodes()
        {
            return this._volumeToProductCodes != null && (this._volumeToProductCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VolumeToVolumeSize. 
        /// <para>
        /// A mapping between the volumes and their sizes
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> VolumeToVolumeSize
        {
            get { return this._volumeToVolumeSize; }
            set { this._volumeToVolumeSize = value; }
        }

        // Check to see if VolumeToVolumeSize property is set
        internal bool IsSetVolumeToVolumeSize()
        {
            return this._volumeToVolumeSize != null && (this._volumeToVolumeSize.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}