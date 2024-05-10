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
    /// This is the response object from the DisableKinesisStreamingDestination operation.
    /// </summary>
    public partial class DisableKinesisStreamingDestinationResponse : AmazonWebServiceResponse
    {
        private DestinationStatus _destinationStatus;
        private EnableKinesisStreamingConfiguration _enableKinesisStreamingConfiguration;
        private string _streamArn;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property DestinationStatus. 
        /// <para>
        /// The current status of the replication.
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
        /// Gets and sets the property EnableKinesisStreamingConfiguration. 
        /// <para>
        /// The destination for the Kinesis streaming information that is being enabled.
        /// </para>
        /// </summary>
        public EnableKinesisStreamingConfiguration EnableKinesisStreamingConfiguration
        {
            get { return this._enableKinesisStreamingConfiguration; }
            set { this._enableKinesisStreamingConfiguration = value; }
        }

        // Check to see if EnableKinesisStreamingConfiguration property is set
        internal bool IsSetEnableKinesisStreamingConfiguration()
        {
            return this._enableKinesisStreamingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The ARN for the specific Kinesis data stream.
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

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table being modified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}