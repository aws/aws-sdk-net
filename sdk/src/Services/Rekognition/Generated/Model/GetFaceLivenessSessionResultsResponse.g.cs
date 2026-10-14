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
    /// This is the response object from the GetFaceLivenessSessionResults operation.
    /// </summary>
    public partial class GetFaceLivenessSessionResultsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AuditImages. 
        /// <para>
        /// A set of images from the Face Liveness video that can be used for audit purposes.
        /// It includes a bounding box of the face and the Base64-encoded bytes that return an
        /// image. If the CreateFaceLivenessSession request included an OutputConfig argument,
        /// the image will be uploaded to an S3Object specified in the output configuration. If
        /// no Amazon S3 bucket is defined, raw bytes are sent instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuditImage> AuditImages { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditImage>() : null;

        /// <summary>
        /// Checks to see if the AuditImages property is set.
        /// </summary>
        internal bool IsSetAuditImages() => this.AuditImages != null && (this.AuditImages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Challenge. 
        /// <para>
        /// Contains information regarding the challenge type used for the Face Liveness check.
        /// </para>
        /// </summary>
        public Challenge Challenge { get; set; }

        /// <summary>
        /// Checks to see if the Challenge property is set.
        /// </summary>
        internal bool IsSetChallenge() => this.Challenge != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Probabalistic confidence score for if the person in the given video was live, represented
        /// as a float value between 0 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence.HasValue;

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// A list of conditions that were detected in the Face Liveness video and that contributed
        /// to the returned <c>Confidence</c> score. Each item contains a code and a human-readable
        /// message. Feedback is returned only for sessions with a <c>Status</c> of <c>SUCCEEDED</c>,
        /// and the list is empty when no such conditions were detected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<FeedbackItem> Feedback { get; set; } = AWSConfigs.InitializeCollections ? new List<FeedbackItem>() : null;

        /// <summary>
        /// Checks to see if the Feedback property is set.
        /// </summary>
        internal bool IsSetFeedback() => this.Feedback != null && (this.Feedback.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the client that streamed the video for the Face Liveness session.
        /// </para>
        /// </summary>
        public SessionMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property ReferenceImage. 
        /// <para>
        /// A high-quality image from the Face Liveness video that can be used for face comparison
        /// or search. It includes a bounding box of the face and the Base64-encoded bytes that
        /// return an image. If the CreateFaceLivenessSession request included an OutputConfig
        /// argument, the image will be uploaded to an S3Object specified in the output configuration.
        /// In case the reference image is not returned, it's recommended to retry the Liveness
        /// check.
        /// </para>
        /// </summary>
        public AuditImage ReferenceImage { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceImage property is set.
        /// </summary>
        internal bool IsSetReferenceImage() => this.ReferenceImage != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The sessionId for which this request was called.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Represents a status corresponding to the state of the session. Possible statuses are:
        /// CREATED, IN_PROGRESS, SUCCEEDED, FAILED, EXPIRED.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LivenessSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
