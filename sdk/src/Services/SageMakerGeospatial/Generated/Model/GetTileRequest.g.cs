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

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Container for the parameters to the GetTile operation. Gets a web mercator tile for
    /// the given Earth Observation job.
    /// </summary>
    public partial class GetTileRequest : AmazonSageMakerGeospatialRequest
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tile operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property ImageAssets. 
        /// <para>
        /// The particular assets or bands to tile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public List<string> ImageAssets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageAssets property is set.
        /// </summary>
        internal bool IsSetImageAssets() => this.ImageAssets != null && (this.ImageAssets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageMask. 
        /// <para>
        /// Determines whether or not to return a valid data mask.
        /// </para>
        /// </summary>
        public bool? ImageMask { get; set; }

        /// <summary>
        /// Checks to see if the ImageMask property is set.
        /// </summary>
        internal bool IsSetImageMask() => this.ImageMask.HasValue;

        /// <summary>
        /// Gets and sets the property OutputDataType. 
        /// <para>
        /// The output data type of the tile operation.
        /// </para>
        /// </summary>
        public OutputType OutputDataType { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataType property is set.
        /// </summary>
        internal bool IsSetOutputDataType() => this.OutputDataType != null;

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The data format of the output tile. The formats include .npy, .png and .jpg.
        /// </para>
        /// </summary>
        public string OutputFormat { get; set; }

        /// <summary>
        /// Checks to see if the OutputFormat property is set.
        /// </summary>
        internal bool IsSetOutputFormat() => this.OutputFormat != null;

        /// <summary>
        /// Gets and sets the property PropertyFilters. 
        /// <para>
        /// Property filters for the imagery to tile.
        /// </para>
        /// </summary>
        public string PropertyFilters { get; set; }

        /// <summary>
        /// Checks to see if the PropertyFilters property is set.
        /// </summary>
        internal bool IsSetPropertyFilters() => this.PropertyFilters != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Determines what part of the Earth Observation job to tile. 'INPUT' or 'OUTPUT' are
        /// the valid options.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetOptions Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// Time range filter applied to imagery to find the images to tile.
        /// </para>
        /// </summary>
        public string TimeRangeFilter { get; set; }

        /// <summary>
        /// Checks to see if the TimeRangeFilter property is set.
        /// </summary>
        internal bool IsSetTimeRangeFilter() => this.TimeRangeFilter != null;

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The x coordinate of the tile input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? X { get; set; }

        /// <summary>
        /// Checks to see if the X property is set.
        /// </summary>
        internal bool IsSetX() => this.X.HasValue;

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The y coordinate of the tile input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Y { get; set; }

        /// <summary>
        /// Checks to see if the Y property is set.
        /// </summary>
        internal bool IsSetY() => this.Y.HasValue;

        /// <summary>
        /// Gets and sets the property Z. 
        /// <para>
        /// The z coordinate of the tile input.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Z { get; set; }

        /// <summary>
        /// Checks to see if the Z property is set.
        /// </summary>
        internal bool IsSetZ() => this.Z.HasValue;
    }
}
