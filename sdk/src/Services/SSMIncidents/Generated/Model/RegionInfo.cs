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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
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
namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// Information about a Amazon Web Services Region in your replication set.
    /// </summary>
    public partial class RegionInfo
    {
        private string _sseKmsKeyId;
        private RegionStatus _status;
        private string _statusMessage;
        private DateTime? _statusUpdateDateTime;

        /// <summary>
        /// Gets and sets the property SseKmsKeyId. 
        /// <para>
        /// The ID of the KMS key used to encrypt the data in this Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string SseKmsKeyId
        {
            get { return this._sseKmsKeyId; }
            set { this._sseKmsKeyId = value; }
        }

        // Check to see if SseKmsKeyId property is set
        internal bool IsSetSseKmsKeyId()
        {
            return this._sseKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon Web Services Region in the replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Information displayed about the status of the Amazon Web Services Region.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StatusUpdateDateTime. 
        /// <para>
        /// The timestamp for when Incident Manager updated the status of the Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StatusUpdateDateTime
        {
            get { return this._statusUpdateDateTime; }
            set { this._statusUpdateDateTime = value; }
        }

        // Check to see if StatusUpdateDateTime property is set
        internal bool IsSetStatusUpdateDateTime()
        {
            return this._statusUpdateDateTime.HasValue; 
        }

    }
}