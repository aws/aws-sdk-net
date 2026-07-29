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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The watermark filter criteria for an allowed image. Each entry can specify one or
    /// more fields. All specified fields must match the same watermark on the image.
    /// </summary>
    public partial class ImageWatermarkFilterRequest
    {
        private int? _maximumDaysSinceSourceImageCreated;
        private int? _maximumDaysSinceWatermarkCreated;
        private string _sourceImageRegion;
        private string _watermarkKey;

        /// <summary>
        /// Gets and sets the property MaximumDaysSinceSourceImageCreated. 
        /// <para>
        /// The maximum number of days that have elapsed since the source image was created.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        public int? MaximumDaysSinceSourceImageCreated
        {
            get { return this._maximumDaysSinceSourceImageCreated; }
            set { this._maximumDaysSinceSourceImageCreated = value; }
        }

        // Check to see if MaximumDaysSinceSourceImageCreated property is set
        internal bool IsSetMaximumDaysSinceSourceImageCreated()
        {
            return this._maximumDaysSinceSourceImageCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaximumDaysSinceWatermarkCreated. 
        /// <para>
        /// The maximum number of days that have elapsed since the watermark was attached to the
        /// image.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Minimum value of 0. Maximum value of 2147483647.
        /// </para>
        /// </summary>
        public int? MaximumDaysSinceWatermarkCreated
        {
            get { return this._maximumDaysSinceWatermarkCreated; }
            set { this._maximumDaysSinceWatermarkCreated = value; }
        }

        // Check to see if MaximumDaysSinceWatermarkCreated property is set
        internal bool IsSetMaximumDaysSinceWatermarkCreated()
        {
            return this._maximumDaysSinceWatermarkCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceImageRegion. 
        /// <para>
        /// The Region where the watermark was originally created. Supports wildcards (<c>*</c>,
        /// <c>?</c>).
        /// </para>
        /// </summary>
        public string SourceImageRegion
        {
            get { return this._sourceImageRegion; }
            set { this._sourceImageRegion = value; }
        }

        // Check to see if SourceImageRegion property is set
        internal bool IsSetSourceImageRegion()
        {
            return this._sourceImageRegion != null;
        }

        /// <summary>
        /// Gets and sets the property WatermarkKey. 
        /// <para>
        /// The <c>accountId:name</c> of the watermark. Supports wildcards (<c>*</c>, <c>?</c>).
        /// </para>
        /// </summary>
        public string WatermarkKey
        {
            get { return this._watermarkKey; }
            set { this._watermarkKey = value; }
        }

        // Check to see if WatermarkKey property is set
        internal bool IsSetWatermarkKey()
        {
            return this._watermarkKey != null;
        }

    }
}