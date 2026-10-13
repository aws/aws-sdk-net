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
    /// This is the response object from the DescribeStreamProcessor operation.
    /// </summary>
    public partial class DescribeStreamProcessorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// Date and time the stream processor was created
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimestamp property is set.
        /// </summary>
        internal bool IsSetCreationTimestamp() => this.CreationTimestamp.HasValue;

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
        /// Kinesis video stream that provides the source streaming video.
        /// </para>
        /// </summary>
        public StreamProcessorInput Input { get; set; }

        /// <summary>
        /// Checks to see if the Input property is set.
        /// </summary>
        internal bool IsSetInput() => this.Input != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        ///  The identifier for your AWS Key Management Service key (AWS KMS key). This is an
        /// optional parameter for label detection stream processors. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LastUpdateTimestamp. 
        /// <para>
        /// The time, in Unix format, the stream processor was last updated. For example, when
        /// the stream processor moves from a running state to a failed state, or when the user
        /// starts or stops the stream processor.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdateTimestamp() => this.LastUpdateTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the stream processor. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
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
        /// Kinesis data stream to which Amazon Rekognition Video puts the analysis results.
        /// </para>
        /// </summary>
        public StreamProcessorOutput Output { get; set; }

        /// <summary>
        /// Checks to see if the Output property is set.
        /// </summary>
        internal bool IsSetOutput() => this.Output != null;

        /// <summary>
        /// Gets and sets the property RegionsOfInterest. 
        /// <para>
        ///  Specifies locations in the frames where Amazon Rekognition checks for objects or
        /// people. This is an optional parameter for label detection stream processors. 
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
        /// ARN of the IAM role that allows access to the stream processor.
        /// </para>
        /// </summary>
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
        public StreamProcessorSettings Settings { get; set; }

        /// <summary>
        /// Checks to see if the Settings property is set.
        /// </summary>
        internal bool IsSetSettings() => this.Settings != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the stream processor.
        /// </para>
        /// </summary>
        public StreamProcessorStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Detailed status message about the stream processor.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property StreamProcessorArn. 
        /// <para>
        /// ARN of the stream processor.
        /// </para>
        /// </summary>
        public string StreamProcessorArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamProcessorArn property is set.
        /// </summary>
        internal bool IsSetStreamProcessorArn() => this.StreamProcessorArn != null;
    }
}
