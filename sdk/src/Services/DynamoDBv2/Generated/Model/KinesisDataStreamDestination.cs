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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Describes a Kinesis data stream destination.
    /// </summary>
    public partial class KinesisDataStreamDestination
    {
        private ApproximateCreationDateTimePrecision _approximateCreationDateTimePrecision;
        private DestinationStatus _destinationStatus;
        private string _destinationStatusDescription;
        private string _streamArn;

        /// <summary>
        /// Gets and sets the property ApproximateCreationDateTimePrecision. 
        /// <para>
        /// The precision of the Kinesis data stream timestamp. The values are either <c>MILLISECOND</c>
        /// or <c>MICROSECOND</c>.
        /// </para>
        /// </summary>
        public ApproximateCreationDateTimePrecision ApproximateCreationDateTimePrecision
        {
            get { return this._approximateCreationDateTimePrecision; }
            set { this._approximateCreationDateTimePrecision = value; }
        }

        // Check to see if ApproximateCreationDateTimePrecision property is set
        internal bool IsSetApproximateCreationDateTimePrecision()
        {
            return this._approximateCreationDateTimePrecision != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationStatus. 
        /// <para>
        /// The current status of replication.
        /// </para>
        /// </summary>
        public DestinationStatus DestinationStatus
        {
            get { return this._destinationStatus; }
            set { this._destinationStatus = value; }
        }

        // Check to see if DestinationStatus property is set
        internal bool IsSetDestinationStatus()
        {
            return this._destinationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationStatusDescription. 
        /// <para>
        /// The human-readable string that corresponds to the replica status.
        /// </para>
        /// </summary>
        public string DestinationStatusDescription
        {
            get { return this._destinationStatusDescription; }
            set { this._destinationStatusDescription = value; }
        }

        // Check to see if DestinationStatusDescription property is set
        internal bool IsSetDestinationStatusDescription()
        {
            return this._destinationStatusDescription != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The ARN for a specific Kinesis data stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=37, Max=1024)]
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

    }
}