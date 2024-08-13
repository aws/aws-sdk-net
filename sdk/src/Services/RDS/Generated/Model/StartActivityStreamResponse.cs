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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the StartActivityStream operation.
    /// </summary>
    public partial class StartActivityStreamResponse : AmazonWebServiceResponse
    {
        private bool? _applyImmediately;
        private bool? _engineNativeAuditFieldsIncluded;
        private string _kinesisStreamName;
        private string _kmsKeyId;
        private ActivityStreamMode _mode;
        private ActivityStreamStatus _status;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// Indicates whether or not the database activity stream will start as soon as possible,
        /// regardless of the maintenance window for the database.
        /// </para>
        /// </summary>
        public bool? ApplyImmediately
        {
            get { return this._applyImmediately; }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineNativeAuditFieldsIncluded. 
        /// <para>
        /// Indicates whether engine-native audit fields are included in the database activity
        /// stream.
        /// </para>
        /// </summary>
        public bool? EngineNativeAuditFieldsIncluded
        {
            get { return this._engineNativeAuditFieldsIncluded; }
            set { this._engineNativeAuditFieldsIncluded = value; }
        }

        // Check to see if EngineNativeAuditFieldsIncluded property is set
        internal bool IsSetEngineNativeAuditFieldsIncluded()
        {
            return this._engineNativeAuditFieldsIncluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KinesisStreamName. 
        /// <para>
        /// The name of the Amazon Kinesis data stream to be used for the database activity stream.
        /// </para>
        /// </summary>
        public string KinesisStreamName
        {
            get { return this._kinesisStreamName; }
            set { this._kinesisStreamName = value; }
        }

        // Check to see if KinesisStreamName property is set
        internal bool IsSetKinesisStreamName()
        {
            return this._kinesisStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of messages in the database
        /// activity stream.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the database activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the database activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamStatus Status
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