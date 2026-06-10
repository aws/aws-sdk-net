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
    /// Describes a watermark attached to an AMI.
    /// </summary>
    public partial class ImageWatermark
    {
        private DateTime? _sourceImageCreationTime;
        private string _sourceImageId;
        private string _sourceImageRegion;
        private DateTime? _watermarkCreationTime;
        private string _watermarkKey;

        /// <summary>
        /// Gets and sets the property SourceImageCreationTime. 
        /// <para>
        /// The creation date of the source AMI, in the following format: <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>.<i>ssssss</i>+<i>HH</i>:<i>MM</i>.
        /// </para>
        /// </summary>
        public DateTime? SourceImageCreationTime
        {
            get { return this._sourceImageCreationTime; }
            set { this._sourceImageCreationTime = value; }
        }

        // Check to see if SourceImageCreationTime property is set
        internal bool IsSetSourceImageCreationTime()
        {
            return this._sourceImageCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceImageId. 
        /// <para>
        /// The ID of the AMI to which the watermark was originally attached.
        /// </para>
        /// </summary>
        public string SourceImageId
        {
            get { return this._sourceImageId; }
            set { this._sourceImageId = value; }
        }

        // Check to see if SourceImageId property is set
        internal bool IsSetSourceImageId()
        {
            return this._sourceImageId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceImageRegion. 
        /// <para>
        /// The Region where the watermark was originally attached.
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
        /// Gets and sets the property WatermarkCreationTime. 
        /// <para>
        /// The date and time the watermark was attached to the AMI, in the following format:
        /// <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>.<i>ssssss</i>+<i>HH</i>:<i>MM</i>.
        /// </para>
        /// </summary>
        public DateTime? WatermarkCreationTime
        {
            get { return this._watermarkCreationTime; }
            set { this._watermarkCreationTime = value; }
        }

        // Check to see if WatermarkCreationTime property is set
        internal bool IsSetWatermarkCreationTime()
        {
            return this._watermarkCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WatermarkKey. 
        /// <para>
        /// The watermark identifier, in <c>accountId:watermarkName</c> format (for example, <c>123456789012:approvedAmi</c>).
        /// The <c>accountId</c> portion is the Amazon Web Services account ID of the watermark
        /// creator. The <c>watermarkName</c> portion is customer-provided.
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