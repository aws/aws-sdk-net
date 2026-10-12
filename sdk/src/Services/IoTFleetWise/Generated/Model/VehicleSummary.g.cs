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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about a vehicle.
    /// 
    ///  
    /// <para>
    /// To return this information about vehicles in your account, you can use the API operation.
    /// </para>
    /// </summary>
    public partial class VehicleSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Static information about a vehicle in a key-value pair. For example:
        /// </para>
        ///  
        /// <para>
        ///  <c>"engineType"</c> : <c>"1.3 L R2"</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the vehicle was created in seconds since epoch (January 1, 1970 at midnight
        /// UTC time).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DecoderManifestArn. 
        /// <para>
        /// The ARN of a decoder manifest associated with the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DecoderManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the DecoderManifestArn property is set.
        /// </summary>
        internal bool IsSetDecoderManifestArn() => this.DecoderManifestArn != null;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time the vehicle was last updated in seconds since epoch (January 1, 1970 at midnight
        /// UTC time). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        /// The ARN of a vehicle model (model manifest) associated with the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelManifestArn property is set.
        /// </summary>
        internal bool IsSetModelManifestArn() => this.ModelManifestArn != null;

        /// <summary>
        /// Gets and sets the property VehicleName. 
        /// <para>
        /// The unique ID of the vehicle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string VehicleName { get; set; }

        /// <summary>
        /// Checks to see if the VehicleName property is set.
        /// </summary>
        internal bool IsSetVehicleName() => this.VehicleName != null;
    }
}
