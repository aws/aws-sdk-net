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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// Container for the parameters to the CreateHarvestJob operation.
    /// Creates a new HarvestJob record.
    /// </summary>
    public partial class CreateHarvestJobRequest : AmazonMediaPackageRequest
    {
        private string _endTime;
        private string _id;
        private string _originEndpointId;
        private S3Destination _s3Destination;
        private string _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. The end of the time-window which will be harvested
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// the regionand it cannot be changed after the HarvestJob is submitted
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property StartTime. The start of the time-window which will be harvested
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}