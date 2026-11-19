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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The watermark filter criteria for an allowed image. Each entry can specify one or
    /// more fields. All specified fields must match the same watermark on the image.
    /// </summary>
    public partial class ImageWatermarkFilterRequest
    {
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
        public int? MaximumDaysSinceSourceImageCreated { get; set; }

        /// <summary>
        /// Checks to see if the MaximumDaysSinceSourceImageCreated property is set.
        /// </summary>
        internal bool IsSetMaximumDaysSinceSourceImageCreated() => this.MaximumDaysSinceSourceImageCreated.HasValue;

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
        public int? MaximumDaysSinceWatermarkCreated { get; set; }

        /// <summary>
        /// Checks to see if the MaximumDaysSinceWatermarkCreated property is set.
        /// </summary>
        internal bool IsSetMaximumDaysSinceWatermarkCreated() => this.MaximumDaysSinceWatermarkCreated.HasValue;

        /// <summary>
        /// Gets and sets the property SourceImageRegion. 
        /// <para>
        /// The Region where the watermark was originally created. Supports wildcards (<c>*</c>,
        /// <c>?</c>).
        /// </para>
        /// </summary>
        public string SourceImageRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageRegion property is set.
        /// </summary>
        internal bool IsSetSourceImageRegion() => this.SourceImageRegion != null;

        /// <summary>
        /// Gets and sets the property WatermarkKey. 
        /// <para>
        /// The <c>accountId:name</c> of the watermark. Supports wildcards (<c>*</c>, <c>?</c>).
        /// </para>
        /// </summary>
        public string WatermarkKey { get; set; }

        /// <summary>
        /// Checks to see if the WatermarkKey property is set.
        /// </summary>
        internal bool IsSetWatermarkKey() => this.WatermarkKey != null;
    }
}
