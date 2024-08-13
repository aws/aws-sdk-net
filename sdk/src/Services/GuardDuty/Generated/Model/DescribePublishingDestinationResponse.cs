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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the DescribePublishingDestination operation.
    /// </summary>
    public partial class DescribePublishingDestinationResponse : AmazonWebServiceResponse
    {
        private string _destinationId;
        private DestinationProperties _destinationProperties;
        private DestinationType _destinationType;
        private long? _publishingFailureStartTimestamp;
        private PublishingStatus _status;

        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the publishing destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationId
        {
            get { return this._destinationId; }
            set { this._destinationId = value; }
        }

        // Check to see if DestinationId property is set
        internal bool IsSetDestinationId()
        {
            return this._destinationId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationProperties. 
        /// <para>
        /// A <c>DestinationProperties</c> object that includes the <c>DestinationArn</c> and
        /// <c>KmsKeyArn</c> of the publishing destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DestinationProperties DestinationProperties
        {
            get { return this._destinationProperties; }
            set { this._destinationProperties = value; }
        }

        // Check to see if DestinationProperties property is set
        internal bool IsSetDestinationProperties()
        {
            return this._destinationProperties != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of publishing destination. Currently, only Amazon S3 buckets are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public DestinationType DestinationType
        {
            get { return this._destinationType; }
            set { this._destinationType = value; }
        }

        // Check to see if DestinationType property is set
        internal bool IsSetDestinationType()
        {
            return this._destinationType != null;
        }

        /// <summary>
        /// Gets and sets the property PublishingFailureStartTimestamp. 
        /// <para>
        /// The time, in epoch millisecond format, at which GuardDuty was first unable to publish
        /// findings to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? PublishingFailureStartTimestamp
        {
            get { return this._publishingFailureStartTimestamp; }
            set { this._publishingFailureStartTimestamp = value; }
        }

        // Check to see if PublishingFailureStartTimestamp property is set
        internal bool IsSetPublishingFailureStartTimestamp()
        {
            return this._publishingFailureStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the publishing destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public PublishingStatus Status
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