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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// This is the response object from the UpdatePool operation.
    /// </summary>
    public partial class UpdatePoolResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private bool? _deletionProtectionEnabled;
        private MessageType _messageType;
        private string _optOutListName;
        private string _poolArn;
        private string _poolId;
        private bool? _selfManagedOptOutsEnabled;
        private bool? _sharedRoutesEnabled;
        private PoolStatus _status;
        private string _twoWayChannelArn;
        private bool? _twoWayEnabled;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the pool was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtectionEnabled. 
        /// <para>
        /// When set to true the pool can't be deleted.
        /// </para>
        /// </summary>
        public bool DeletionProtectionEnabled
        {
            get { return this._deletionProtectionEnabled.GetValueOrDefault(); }
            set { this._deletionProtectionEnabled = value; }
        }

        // Check to see if DeletionProtectionEnabled property is set
        internal bool IsSetDeletionProtectionEnabled()
        {
            return this._deletionProtectionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// The type of message for the pool to use.
        /// </para>
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

        /// <summary>
        /// Gets and sets the property OptOutListName. 
        /// <para>
        /// The name of the OptOutList associated with the pool.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OptOutListName
        {
            get { return this._optOutListName; }
            set { this._optOutListName = value; }
        }

        // Check to see if OptOutListName property is set
        internal bool IsSetOptOutListName()
        {
            return this._optOutListName != null;
        }

        /// <summary>
        /// Gets and sets the property PoolArn. 
        /// <para>
        /// The ARN of the pool.
        /// </para>
        /// </summary>
        public string PoolArn
        {
            get { return this._poolArn; }
            set { this._poolArn = value; }
        }

        // Check to see if PoolArn property is set
        internal bool IsSetPoolArn()
        {
            return this._poolArn != null;
        }

        /// <summary>
        /// Gets and sets the property PoolId. 
        /// <para>
        /// The unique identifier of the pool.
        /// </para>
        /// </summary>
        public string PoolId
        {
            get { return this._poolId; }
            set { this._poolId = value; }
        }

        // Check to see if PoolId property is set
        internal bool IsSetPoolId()
        {
            return this._poolId != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedOptOutsEnabled. 
        /// <para>
        /// When an end recipient sends a message that begins with HELP or STOP to one of your
        /// dedicated numbers, Amazon Pinpoint automatically replies with a customizable message
        /// and adds the end recipient to the OptOutList. When set to true you're responsible
        /// for responding to HELP and STOP requests. You're also responsible for tracking and
        /// honoring opt-out requests.
        /// </para>
        /// </summary>
        public bool SelfManagedOptOutsEnabled
        {
            get { return this._selfManagedOptOutsEnabled.GetValueOrDefault(); }
            set { this._selfManagedOptOutsEnabled = value; }
        }

        // Check to see if SelfManagedOptOutsEnabled property is set
        internal bool IsSetSelfManagedOptOutsEnabled()
        {
            return this._selfManagedOptOutsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SharedRoutesEnabled. 
        /// <para>
        /// Indicates whether shared routes are enabled for the pool.
        /// </para>
        /// </summary>
        public bool SharedRoutesEnabled
        {
            get { return this._sharedRoutesEnabled.GetValueOrDefault(); }
            set { this._sharedRoutesEnabled = value; }
        }

        // Check to see if SharedRoutesEnabled property is set
        internal bool IsSetSharedRoutesEnabled()
        {
            return this._sharedRoutesEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the pool update request.
        /// </para>
        /// </summary>
        public PoolStatus Status
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
        /// Gets and sets the property TwoWayChannelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the two way channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string TwoWayChannelArn
        {
            get { return this._twoWayChannelArn; }
            set { this._twoWayChannelArn = value; }
        }

        // Check to see if TwoWayChannelArn property is set
        internal bool IsSetTwoWayChannelArn()
        {
            return this._twoWayChannelArn != null;
        }

        /// <summary>
        /// Gets and sets the property TwoWayEnabled. 
        /// <para>
        /// By default this is set to false. When set to true you can receive incoming text messages
        /// from your end recipients.
        /// </para>
        /// </summary>
        public bool TwoWayEnabled
        {
            get { return this._twoWayEnabled.GetValueOrDefault(); }
            set { this._twoWayEnabled = value; }
        }

        // Check to see if TwoWayEnabled property is set
        internal bool IsSetTwoWayEnabled()
        {
            return this._twoWayEnabled.HasValue; 
        }

    }
}