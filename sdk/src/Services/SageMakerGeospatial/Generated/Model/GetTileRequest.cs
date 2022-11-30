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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Container for the parameters to the GetTile operation.
    /// Gets a web mercator tile for the given Earth Observation job.
    /// </summary>
    public partial class GetTileRequest : AmazonSageMakerGeospatialRequest
    {
        private string _arn;
        private List<string> _imageAssets = new List<string>();
        private bool? _imageMask;
        private OutputType _outputDataType;
        private string _outputFormat;
        private string _propertyFilters;
        private TargetOptions _target;
        private string _timeRangeFilter;
        private int? _x;
        private int? _y;
        private int? _z;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the tile operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageAssets. 
        /// <para>
        /// The particular assets or bands to tile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> ImageAssets
        {
            get { return this._imageAssets; }
            set { this._imageAssets = value; }
        }

        // Check to see if ImageAssets property is set
        internal bool IsSetImageAssets()
        {
            return this._imageAssets != null && this._imageAssets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ImageMask. 
        /// <para>
        /// Determines whether or not to return a valid data mask.
        /// </para>
        /// </summary>
        public bool ImageMask
        {
            get { return this._imageMask.GetValueOrDefault(); }
            set { this._imageMask = value; }
        }

        // Check to see if ImageMask property is set
        internal bool IsSetImageMask()
        {
            return this._imageMask.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataType. 
        /// <para>
        /// The output data type of the tile operation.
        /// </para>
        /// </summary>
        public OutputType OutputDataType
        {
            get { return this._outputDataType; }
            set { this._outputDataType = value; }
        }

        // Check to see if OutputDataType property is set
        internal bool IsSetOutputDataType()
        {
            return this._outputDataType != null;
        }

        /// <summary>
        /// Gets and sets the property OutputFormat. 
        /// <para>
        /// The data format of the output tile. The formats include .npy, .png and .jpg.
        /// </para>
        /// </summary>
        public string OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyFilters. 
        /// <para>
        /// Property filters for the imagery to tile.
        /// </para>
        /// </summary>
        public string PropertyFilters
        {
            get { return this._propertyFilters; }
            set { this._propertyFilters = value; }
        }

        // Check to see if PropertyFilters property is set
        internal bool IsSetPropertyFilters()
        {
            return this._propertyFilters != null;
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// Determines what part of the Earth Observation job to tile. 'INPUT' or 'OUTPUT' are
        /// the valid options.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetOptions Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property TimeRangeFilter. 
        /// <para>
        /// Time range filter applied to imagery to find the images to tile.
        /// </para>
        /// </summary>
        public string TimeRangeFilter
        {
            get { return this._timeRangeFilter; }
            set { this._timeRangeFilter = value; }
        }

        // Check to see if TimeRangeFilter property is set
        internal bool IsSetTimeRangeFilter()
        {
            return this._timeRangeFilter != null;
        }

        /// <summary>
        /// Gets and sets the property X. 
        /// <para>
        /// The x coordinate of the tile input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int X
        {
            get { return this._x.GetValueOrDefault(); }
            set { this._x = value; }
        }

        // Check to see if X property is set
        internal bool IsSetX()
        {
            return this._x.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Y. 
        /// <para>
        /// The y coordinate of the tile input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Y
        {
            get { return this._y.GetValueOrDefault(); }
            set { this._y = value; }
        }

        // Check to see if Y property is set
        internal bool IsSetY()
        {
            return this._y.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Z. 
        /// <para>
        /// The z coordinate of the tile input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Z
        {
            get { return this._z.GetValueOrDefault(); }
            set { this._z = value; }
        }

        // Check to see if Z property is set
        internal bool IsSetZ()
        {
            return this._z.HasValue; 
        }

    }
}