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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The notification that informs a user of an update in Audit Manager. For example,
    /// this includes the notification that's sent when a control set is delegated for review.
    /// </summary>
    public partial class Notification
    {
        private string _assessmentId;
        private string _assessmentName;
        private string _controlSetId;
        private string _controlSetName;
        private string _description;
        private DateTime? _eventTime;
        private string _id;
        private string _source;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentName. 
        /// <para>
        ///  The name of the related assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=300)]
        public string AssessmentName
        {
            get { return this._assessmentName; }
            set { this._assessmentName = value; }
        }

        // Check to see if AssessmentName property is set
        internal bool IsSetAssessmentName()
        {
            return this._assessmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSetId. 
        /// <para>
        ///  The identifier for the control set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ControlSetId
        {
            get { return this._controlSetId; }
            set { this._controlSetId = value; }
        }

        // Check to see if ControlSetId property is set
        internal bool IsSetControlSetId()
        {
            return this._controlSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ControlSetName. 
        /// <para>
        ///  Specifies the name of the control set that the notification is about. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ControlSetName
        {
            get { return this._controlSetName; }
            set { this._controlSetName = value; }
        }

        // Check to see if ControlSetName property is set
        internal bool IsSetControlSetName()
        {
            return this._controlSetName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the notification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        ///  The time when the notification was sent. 
        /// </para>
        /// </summary>
        public DateTime? EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The unique identifier for the notification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=47, Max=50)]
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
        /// Gets and sets the property Source. 
        /// <para>
        ///  The sender of the notification. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}