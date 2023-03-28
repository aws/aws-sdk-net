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
    /// This is the response object from the GetRotationOverride operation.
    /// </summary>
    public partial class GetRotationOverrideResponse : AmazonWebServiceResponse
    {
        private DateTime? _createTime;
        private DateTime? _endTime;
        private List<string> _newContactIds = new List<string>();
        private string _rotationArn;
        private string _rotationOverrideId;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time when the override was created.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time when the override ends.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property NewContactIds. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the contacts assigned to the override of the on-call
        /// rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
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
        /// Gets and sets the property RotationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the on-call rotation that was overridden.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RotationArn
        {
            get { return this._rotationArn; }
            set { this._rotationArn = value; }
        }

        // Check to see if RotationArn property is set
        internal bool IsSetRotationArn()
        {
            return this._rotationArn != null;
        }

        /// <summary>
        /// Gets and sets the property RotationOverrideId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the override to an on-call rotation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=39)]
        public string RotationOverrideId
        {
            get { return this._rotationOverrideId; }
            set { this._rotationOverrideId = value; }
        }

        // Check to see if RotationOverrideId property is set
        internal bool IsSetRotationOverrideId()
        {
            return this._rotationOverrideId != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the override goes into effect.
        /// </para>
        /// </summary>
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