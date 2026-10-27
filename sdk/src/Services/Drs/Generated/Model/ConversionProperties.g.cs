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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Properties of a conversion job
    /// </summary>
    public partial class ConversionProperties
    {
        /// <summary>
        /// Gets and sets the property DataTimestamp. 
        /// <para>
        /// The timestamp of when the snapshot being converted was taken
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public string DataTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DataTimestamp property is set.
        /// </summary>
        internal bool IsSetDataTimestamp() => this.DataTimestamp != null;

        /// <summary>
        /// Gets and sets the property ForceUefi. 
        /// <para>
        /// Whether the volume being converted uses UEFI or not
        /// </para>
        /// </summary>
        public bool? ForceUefi { get; set; }

        /// <summary>
        /// Checks to see if the ForceUefi property is set.
        /// </summary>
        internal bool IsSetForceUefi() => this.ForceUefi.HasValue;

        /// <summary>
        /// Gets and sets the property RootVolumeName. 
        /// <para>
        /// The root volume name of a conversion job
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65536)]
        public string RootVolumeName { get; set; }

        /// <summary>
        /// Checks to see if the RootVolumeName property is set.
        /// </summary>
        internal bool IsSetRootVolumeName() => this.RootVolumeName != null;

        /// <summary>
        /// Gets and sets the property VolumeToConversionMap. 
        /// <para>
        /// A mapping between the volumes being converted and the converted snapshot ids
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, string>> VolumeToConversionMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, string>>() : null;

        /// <summary>
        /// Checks to see if the VolumeToConversionMap property is set.
        /// </summary>
        internal bool IsSetVolumeToConversionMap() => this.VolumeToConversionMap != null && (this.VolumeToConversionMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeToProductCodes. 
        /// <para>
        /// A mapping between the volumes being converted and the product codes associated with
        /// them
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<ProductCode>> VolumeToProductCodes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<ProductCode>>() : null;

        /// <summary>
        /// Checks to see if the VolumeToProductCodes property is set.
        /// </summary>
        internal bool IsSetVolumeToProductCodes() => this.VolumeToProductCodes != null && (this.VolumeToProductCodes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VolumeToVolumeSize. 
        /// <para>
        /// A mapping between the volumes and their sizes
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> VolumeToVolumeSize { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Checks to see if the VolumeToVolumeSize property is set.
        /// </summary>
        internal bool IsSetVolumeToVolumeSize() => this.VolumeToVolumeSize != null && (this.VolumeToVolumeSize.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
