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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRotationOverride operation.
    /// Creates an override for a rotation in an on-call schedule.
    /// </summary>
    public partial class CreateRotationOverrideRequest : AmazonSSMContactsRequest
    {
        private DateTime? _endTime;
        private string _idempotencyToken;
        private List<string> _newContactIds = new List<string>();
        private string _rotationId;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the override ends.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A token that ensures that the operation is called only once with the specified details.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property NewContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts to replace those in the current on-call
        /// rotation with.
        /// </para>
        ///  
        /// <para>
        /// If you want to include any current team members in the override shift, you must include
        /// their ARNs in the new contact ID list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=30)]
        public List<string> NewContactIds
        {
            get { return this._newContactIds; }
            set { this._newContactIds = value; }
        }

        // Check to see if NewContactIds property is set
        internal bool IsSetNewContactIds()
        {
            return this._newContactIds != null && this._newContactIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RotationId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the rotation to create an override for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RotationId
        {
            get { return this._rotationId; }
            set { this._rotationId = value; }
        }

        // Check to see if RotationId property is set
        internal bool IsSetRotationId()
        {
            return this._rotationId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the override goes into effect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}