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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLabel operation.
    /// Creates a label for an event.
    /// </summary>
    public partial class CreateLabelRequest : AmazonLookoutEquipmentRequest
    {
        private string _clientToken;
        private DateTime? _endTime;
        private string _equipment;
        private string _faultCode;
        private string _labelGroupName;
        private string _notes;
        private LabelRating _rating;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier for the request to create a label. If you do not set the client
        /// request token, Lookout for Equipment generates one. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the labeled event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Equipment. 
        /// <para>
        ///  Indicates that a label pertains to a particular piece of equipment. 
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string Equipment
        {
            get { return this._equipment; }
            set { this._equipment = value; }
        }

        // Check to see if Equipment property is set
        internal bool IsSetEquipment()
        {
            return this._equipment != null;
        }

        /// <summary>
        /// Gets and sets the property FaultCode. 
        /// <para>
        ///  Provides additional information about the label. The fault code must be defined in
        /// the FaultCodes attribute of the label group.
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string FaultCode
        {
            get { return this._faultCode; }
            set { this._faultCode = value; }
        }

        // Check to see if FaultCode property is set
        internal bool IsSetFaultCode()
        {
            return this._faultCode != null;
        }

        /// <summary>
        /// Gets and sets the property LabelGroupName. 
        /// <para>
        ///  The name of a group of labels. 
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string LabelGroupName
        {
            get { return this._labelGroupName; }
            set { this._labelGroupName = value; }
        }

        // Check to see if LabelGroupName property is set
        internal bool IsSetLabelGroupName()
        {
            return this._labelGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Notes. 
        /// <para>
        ///  Metadata providing additional information about the label. 
        /// </para>
        ///  
        /// <para>
        /// Data in this field will be retained for service usage. Follow best practices for the
        /// security of your data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2560)]
        public string Notes
        {
            get { return this._notes; }
            set { this._notes = value; }
        }

        // Check to see if Notes property is set
        internal bool IsSetNotes()
        {
            return this._notes != null;
        }

        /// <summary>
        /// Gets and sets the property Rating. 
        /// <para>
        ///  Indicates whether a labeled event represents an anomaly. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LabelRating Rating
        {
            get { return this._rating; }
            set { this._rating = value; }
        }

        // Check to see if Rating property is set
        internal bool IsSetRating()
        {
            return this._rating != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the labeled event. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}