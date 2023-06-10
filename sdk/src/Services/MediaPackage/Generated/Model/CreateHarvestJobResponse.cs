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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// This is the response object from the CreateHarvestJob operation.
    /// </summary>
    public partial class CreateHarvestJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _channelId;
        private string _createdAt;
        private string _endTime;
        private string _id;
        private string _originEndpointId;
        private S3Destination _s3Destination;
        private string _startTime;
        private Status _status;

        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) assigned to the HarvestJob.
        /// </summary>
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
        /// Gets and sets the property ChannelId. The ID of the Channel that the HarvestJob will
        /// harvest from.
        /// </summary>
        public string ChannelId
        {
            get { return this._channelId; }
            set { this._channelId = value; }
        }

        // Check to see if ChannelId property is set
        internal bool IsSetChannelId()
        {
            return this._channelId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time the HarvestJob was submitted.
        /// </summary>
        public string CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. The end of the time-window which will be harvested.
        /// </summary>
        public string EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property Id. The ID of the HarvestJob. The ID must be unique within
        /// the regionand it cannot be changed after the HarvestJob is submitted.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property OriginEndpointId. The ID of the OriginEndpoint that the
        /// HarvestJob will harvest from.This cannot be changed after the HarvestJob is submitted.
        /// </summary>
        public string OriginEndpointId
        {
            get { return this._originEndpointId; }
            set { this._originEndpointId = value; }
        }

        // Check to see if OriginEndpointId property is set
        internal bool IsSetOriginEndpointId()
        {
            return this._originEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property S3Destination.
        /// </summary>
        public S3Destination S3Destination
        {
            get { return this._s3Destination; }
            set { this._s3Destination = value; }
        }

        // Check to see if S3Destination property is set
        internal bool IsSetS3Destination()
        {
            return this._s3Destination != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. The start of the time-window which will be harvested.
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Status. The current status of the HarvestJob. Consider
        /// setting up a CloudWatch Event to listen forHarvestJobs as they succeed or fail. In
        /// the event of failure, the CloudWatch Event willinclude an explanation of why the HarvestJob
        /// failed.
        /// </summary>
        public Status Status
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