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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the DetectModerationLabels operation. Detects unsafe
    /// content in a specified JPEG or PNG format image. Use <c>DetectModerationLabels</c>
    /// to moderate images depending on your requirements. For example, you might want to
    /// filter images that contain nudity, but not images containing suggestive content. <para>
    /// To filter images, use the labels returned by <c>DetectModerationLabels</c> to determine
    /// which types of content are appropriate. </para> <para> For information about moderation
    /// labels, see Detecting Unsafe Content in the Amazon Rekognition Developer Guide. </para>
    /// <para> You pass the input image either as base64-encoded image bytes or as a reference
    /// to an image in an Amazon S3 bucket. If you use the AWS CLI to call Amazon Rekognition
    /// operations, passing image bytes is not supported. The image must be either a PNG or
    /// JPEG formatted file. </para> <para> You can specify an adapter to use when retrieving
    /// label predictions by providing a <c>ProjectVersionArn</c> to the <c>ProjectVersion</c>
    /// argument. </para>
    /// </summary>
    public partial class DetectModerationLabelsRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property HumanLoopConfig. 
        /// <para>
        /// Sets up the configuration for human evaluation, including the FlowDefinition the image
        /// will be sent to.
        /// </para>
        /// </summary>
        public HumanLoopConfig HumanLoopConfig { get; set; }

        /// <summary>
        /// Checks to see if the HumanLoopConfig property is set.
        /// </summary>
        internal bool IsSetHumanLoopConfig() => this.HumanLoopConfig != null;

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The input image as base64-encoded bytes or an S3 object. If you use the AWS CLI to
        /// call Amazon Rekognition operations, passing base64-encoded image bytes is not supported.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you are using an AWS SDK to call Amazon Rekognition, you might not need to base64-encode
        /// image bytes passed using the <c>Bytes</c> field. For more information, see Images
        /// in the Amazon Rekognition developer guide.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Image Image { get; set; }

        /// <summary>
        /// Checks to see if the Image property is set.
        /// </summary>
        internal bool IsSetImage() => this.Image != null;

        /// <summary>
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Specifies the minimum confidence level for the labels to return. Amazon Rekognition
        /// doesn't return any labels with a confidence level lower than this specified value.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>MinConfidence</c>, the operation returns labels with confidence
        /// values greater than or equal to 50 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? MinConfidence { get; set; }

        /// <summary>
        /// Checks to see if the MinConfidence property is set.
        /// </summary>
        internal bool IsSetMinConfidence() => this.MinConfidence.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectVersion. 
        /// <para>
        /// Identifier for the custom adapter. Expects the ProjectVersionArn as a value. Use the
        /// CreateProject or CreateProjectVersion APIs to create a custom adapter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProjectVersion property is set.
        /// </summary>
        internal bool IsSetProjectVersion() => this.ProjectVersion != null;
    }
}
