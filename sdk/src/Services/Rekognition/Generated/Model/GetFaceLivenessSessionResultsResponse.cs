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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
        private List<AuditImage> _auditImages = AWSConfigs.InitializeCollections ? new List<AuditImage>() : null;
        private Challenge _challenge;
        private float? _confidence;
        private AuditImage _referenceImage;
        private string _sessionId;
        private LivenessSessionStatus _status;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AuditImage> AuditImages
        {
            get { return this._auditImages; }
            set { this._auditImages = value; }
        }

        // Check to see if AuditImages property is set
        internal bool IsSetAuditImages()
        {
            return this._auditImages != null && (this._auditImages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Challenge. 
        /// <para>
        /// Contains information regarding the challenge type used for the Face Liveness check.
        /// </para>
        /// </summary>
        public Challenge Challenge
        {
            get { return this._challenge; }
            set { this._challenge = value; }
        }

        // Check to see if Challenge property is set
        internal bool IsSetChallenge()
        {
            return this._challenge != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Probabalistic confidence score for if the person in the given video was live, represented
        /// as a float value between 0 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

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
        public AuditImage ReferenceImage
        {
            get { return this._referenceImage; }
            set { this._referenceImage = value; }
        }

        // Check to see if ReferenceImage property is set
        internal bool IsSetReferenceImage()
        {
            return this._referenceImage != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The sessionId for which this request was called.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Represents a status corresponding to the state of the session. Possible statuses are:
        /// CREATED, IN_PROGRESS, SUCCEEDED, FAILED, EXPIRED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LivenessSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}