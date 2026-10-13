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
    /// Container for the parameters to the CreateStreamProcessor operation. <important> <para>
    /// Service availability notice: Streaming Video and Bulk Image Analysis is no longer
    /// available to new customers. For more information, see <a href="https://docs.aws.amazon.com/rekognition/latest/dg/rekognition-availability-changes.html">Rekognition
    /// feature availability changes</a>. </para> <para> <b>This change does not impact the
    /// availability of other Amazon Rekognition features.</b> </para> </important> <para>
    /// Creates an Amazon Rekognition stream processor that you can use to detect and recognize
    /// faces or to detect labels in a streaming video. </para> <para> Amazon Rekognition
    /// Video is a consumer of live video from Amazon Kinesis Video Streams. There are two
    /// different settings for stream processors in Amazon Rekognition: detecting faces and
    /// detecting labels. </para> <ul> <li> <para> If you are creating a stream processor
    /// for detecting faces, you provide as input a Kinesis video stream (<c>Input</c>) and
    /// a Kinesis data stream (<c>Output</c>) stream for receiving the output. You must use
    /// the <c>FaceSearch</c> option in <c>Settings</c>, specifying the collection that contains
    /// the faces you want to recognize. After you have finished analyzing a streaming video,
    /// use <a>StopStreamProcessor</a> to stop processing. </para> </li> <li> <para> If you
    /// are creating a stream processor to detect labels, you provide as input a Kinesis video
    /// stream (<c>Input</c>), Amazon S3 bucket information (<c>Output</c>), and an Amazon
    /// SNS topic ARN (<c>NotificationChannel</c>). You can also provide a KMS key ID to encrypt
    /// the data sent to your Amazon S3 bucket. You specify what you want to detect by using
    /// the <c>ConnectedHome</c> option in settings, and selecting one of the following: <c>PERSON</c>,
    /// <c>PET</c>, <c>PACKAGE</c>, <c>ALL</c> You can also specify where in the frame you
    /// want Amazon Rekognition to monitor with <c>RegionsOfInterest</c>. When you run the
    /// <a>StartStreamProcessor</a> operation on a label detection stream processor, you input
    /// start and stop information to determine the length of the processing time. </para>
    /// </li> </ul> <para> Use <c>Name</c> to assign an identifier for the stream processor.
    /// You use <c>Name</c> to manage the stream processor. For example, you can start processing
    /// the source video by calling <a>StartStreamProcessor</a> with the <c>Name</c> field.
    /// </para> <para> This operation requires permissions to perform the <c>rekognition:CreateStreamProcessor</c>
    /// action. If you want to tag your stream processor, you also require permission to perform
    /// the <c>rekognition:TagResource</c> operation. </para>
    /// </summary>
    public partial class CreateStreamProcessorRequest : AmazonRekognitionRequest
    {
        /// <summary>
        /// Gets and sets the property DataSharingPreference. 
        /// <para>
        ///  Shows whether you are sharing data with Rekognition to improve model performance.
        /// You can choose this option at the account level or on a per-stream basis. Note that
        /// if you opt out at the account level this setting is ignored on individual streams.
        /// 
        /// </para>
        /// </summary>
        public StreamProcessorDataSharingPreference DataSharingPreference { get; set; }

        /// <summary>
        /// Checks to see if the DataSharingPreference property is set.
        /// </summary>
        internal bool IsSetDataSharingPreference() => this.DataSharingPreference != null;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// Kinesis video stream stream that provides the source streaming video. If you are using
        /// the AWS CLI, the parameter name is <c>StreamProcessorInput</c>. This is required for
        /// both face search and label detection stream processors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamProcessorInput Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The identifier for your AWS Key Management Service key (AWS KMS key). This is an
        /// optional parameter for label detection stream processors and should not be used to
        /// create a face search stream processor. You can supply the Amazon Resource Name (ARN)
        /// of your KMS key, the ID of your KMS key, an alias for your KMS key, or an alias ARN.
        /// The key is used to encrypt results and data published to your Amazon S3 bucket, which
        /// includes image frames and hero images. Your source images are unaffected. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An identifier you assign to the stream processor. You can use <c>Name</c> to manage
        /// the stream processor. For example, you can get the current status of the stream processor
        /// by calling <a>DescribeStreamProcessor</a>. <c>Name</c> is idempotent. This is required
        /// for both face search and label detection stream processors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NotificationChannel.
        /// </summary>
        public StreamProcessorNotificationChannel NotificationChannel { get; set; }

        /// <summary>
        /// Checks to see if the NotificationChannel property is set.
        /// </summary>
        internal bool IsSetNotificationChannel() => this.NotificationChannel != null;

        /// <summary>
        /// Gets and sets the property Output. 
        /// <para>
        /// Kinesis data stream stream or Amazon S3 bucket location to which Amazon Rekognition
        /// Video puts the analysis results. If you are using the AWS CLI, the parameter name
        /// is <c>StreamProcessorOutput</c>. This must be a <a>S3Destination</a> of an Amazon
        /// S3 bucket that you own for a label detection stream processor or a Kinesis data stream
        /// ARN for a face search stream processor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamProcessorOutput Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property RegionsOfInterest. 
        /// <para>
        ///  Specifies locations in the frames where Amazon Rekognition checks for objects or
        /// people. You can specify up to 10 regions of interest, and each region has either a
        /// polygon or a bounding box. This is an optional parameter for label detection stream
        /// processors and should not be used to create a face search stream processor. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<RegionOfInterest> RegionsOfInterest { get; set; } = AWSConfigs.InitializeCollections ? new List<RegionOfInterest>() : null;

        /// <summary>
        /// Checks to see if the RegionsOfInterest property is set.
        /// </summary>
        internal bool IsSetRegionsOfInterest() => this.RegionsOfInterest != null && (this.RegionsOfInterest.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the IAM role that allows access to the stream
        /// processor. The IAM role provides Rekognition read permissions for a Kinesis stream.
        /// It also provides write permissions to an Amazon S3 bucket and Amazon Simple Notification
        /// Service topic for a label detection stream processor. This is required for both face
        /// search and label detection stream processors.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Input parameters used in a streaming video analyzed by a stream processor. You can
        /// use <c>FaceSearch</c> to recognize faces in a streaming video, or you can use <c>ConnectedHome</c>
        /// to detect labels.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamProcessorSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A set of tags (key-value pairs) that you want to attach to the stream processor.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
