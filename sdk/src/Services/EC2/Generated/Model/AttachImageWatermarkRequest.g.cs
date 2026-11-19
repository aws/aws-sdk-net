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
    /// Container for the parameters to the AttachImageWatermark operation. Attaches a watermark
    /// to a non-public AMI. The watermark is a structured identifier that automatically propagates
    /// to all derivative images created through <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateImage.html">CreateImage</a>,
    /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CopyImage.html">CopyImage</a>.
    /// <para> Only the AMI owner can attach watermarks. Watermarks cannot be added to public
    /// AMIs. </para>
    /// </summary>
    public partial class AttachImageWatermarkRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property WatermarkName. 
        /// <para>
        /// The name for the watermark. Combined with the caller's account ID to form the <c>WatermarkKey</c>
        /// (<c>accountId:watermarkName</c>).
        /// </para>
        ///  
        /// <para>
        /// Constraints: 3-128 alphanumeric characters, parentheses (()), square brackets ([]),
        /// spaces ( ), periods (.), slashes (/), dashes (-), single quotes ('), at-signs (@),
        /// or underscores(_)
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 128)]
        public string WatermarkName { get; set; }

        /// <summary>
        /// Checks to see if the WatermarkName property is set.
        /// </summary>
        internal bool IsSetWatermarkName() => this.WatermarkName != null;
    }
}
