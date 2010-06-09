/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.AutoScaling.Model
{
    ///<summary>
    ///The Activity data type.
    ///A Scaling Activity is a long-running process that represents a change to your AutoScalingGroup,
    ///such as changing the size of the group. It can also be a process to replace an instance, or a process
    ///to perform any other long-running operations supported by the API.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://autoscaling.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class Activity
    {
        private string activityIdField;
        private string descriptionField;
        private string causeField;
        private DateTime? startTimeField;
        private DateTime? endTimeField;
        private string statusCodeField;
        private string statusMessageField;
        private Decimal? progressField;

        /// <summary>
        /// Gets and sets the ActivityId property.
        /// Activity ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "ActivityId")]
        public string ActivityId
        {
            get { return this.activityIdField ; }
            set { this.activityIdField= value; }
        }

        /// <summary>
        /// Sets the ActivityId property
        /// </summary>
        /// <param name="activityId">Activity ID.</param>
        /// <returns>this instance</returns>
        public Activity WithActivityId(string activityId)
        {
            this.activityIdField = activityId;
            return this;
        }

        /// <summary>
        /// Checks if ActivityId property is set
        /// </summary>
        /// <returns>true if ActivityId property is set</returns>
        public bool IsSetActivityId()
        {
            return  this.activityIdField != null;
        }

        /// <summary>
        /// Gets and sets the Description property.
        /// Friendly, more verbose description of the Scaling Activity.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField ; }
            set { this.descriptionField= value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">Friendly, more verbose description of the Scaling Activity.</param>
        /// <returns>this instance</returns>
        public Activity WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return  this.descriptionField != null;
        }

        /// <summary>
        /// Gets and sets the Cause property.
        /// The reason (cause) the activity was begun.
        /// </summary>
        [XmlElementAttribute(ElementName = "Cause")]
        public string Cause
        {
            get { return this.causeField ; }
            set { this.causeField= value; }
        }

        /// <summary>
        /// Sets the Cause property
        /// </summary>
        /// <param name="cause">The reason (cause) the activity was begun.</param>
        /// <returns>this instance</returns>
        public Activity WithCause(string cause)
        {
            this.causeField = cause;
            return this;
        }

        /// <summary>
        /// Checks if Cause property is set
        /// </summary>
        /// <returns>true if Cause property is set</returns>
        public bool IsSetCause()
        {
            return  this.causeField != null;
        }

        /// <summary>
        /// Gets and sets the StartTime property.
        /// Start time of this activity.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public DateTime StartTime
        {
            get { return this.startTimeField.GetValueOrDefault() ; }
            set { this.startTimeField= value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">Start time of this activity.</param>
        /// <returns>this instance</returns>
        public Activity WithStartTime(DateTime startTime)
        {
            this.startTimeField = startTime;
            return this;
        }

        /// <summary>
        /// Checks if StartTime property is set
        /// </summary>
        /// <returns>true if StartTime property is set</returns>
        public bool IsSetStartTime()
        {
            return  this.startTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the EndTime property.
        /// End time of the activity, if the activity has finished. If the
        /// activity is not yet finished and is still in progress, this EndTime isn't be returned.
        /// </summary>
        [XmlElementAttribute(ElementName = "EndTime")]
        public DateTime EndTime
        {
            get { return this.endTimeField.GetValueOrDefault() ; }
            set { this.endTimeField= value; }
        }

        /// <summary>
        /// Sets the EndTime property
        /// </summary>
        /// <param name="endTime">End time of the activity, if the activity has finished. If the
        /// activity is not yet finished and is still in progress, this EndTime isn't be returned.</param>
        /// <returns>this instance</returns>
        public Activity WithEndTime(DateTime endTime)
        {
            this.endTimeField = endTime;
            return this;
        }

        /// <summary>
        /// Checks if EndTime property is set
        /// </summary>
        /// <returns>true if EndTime property is set</returns>
        public bool IsSetEndTime()
        {
            return  this.endTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the StatusCode property.
        /// Current status of the activity. Valid values are InProgress | Successful | Failed.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusCode")]
        public string StatusCode
        {
            get { return this.statusCodeField ; }
            set { this.statusCodeField= value; }
        }

        /// <summary>
        /// Sets the StatusCode property
        /// </summary>
        /// <param name="statusCode">Current status of the activity. Valid values are InProgress | Successful | Failed.</param>
        /// <returns>this instance</returns>
        public Activity WithStatusCode(string statusCode)
        {
            this.statusCodeField = statusCode;
            return this;
        }

        /// <summary>
        /// Checks if StatusCode property is set
        /// </summary>
        /// <returns>true if StatusCode property is set</returns>
        public bool IsSetStatusCode()
        {
            return  this.statusCodeField != null;
        }

        /// <summary>
        /// Gets and sets the StatusMessage property.
        /// Friendly, more verbose description of the status.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusMessage")]
        public string StatusMessage
        {
            get { return this.statusMessageField ; }
            set { this.statusMessageField= value; }
        }

        /// <summary>
        /// Sets the StatusMessage property
        /// </summary>
        /// <param name="statusMessage">Friendly, more verbose description of the status.</param>
        /// <returns>this instance</returns>
        public Activity WithStatusMessage(string statusMessage)
        {
            this.statusMessageField = statusMessage;
            return this;
        }

        /// <summary>
        /// Checks if StatusMessage property is set
        /// </summary>
        /// <returns>true if StatusMessage property is set</returns>
        public bool IsSetStatusMessage()
        {
            return  this.statusMessageField != null;
        }

        /// <summary>
        /// Gets and sets the Progress property.
        /// A value between 0 and 100 indicating the progress of this activity.
        /// </summary>
        [XmlElementAttribute(ElementName = "Progress")]
        public Decimal Progress
        {
            get { return this.progressField.GetValueOrDefault() ; }
            set { this.progressField= value; }
        }

        /// <summary>
        /// Sets the Progress property
        /// </summary>
        /// <param name="progress">A value between 0 and 100 indicating the progress of this activity.</param>
        /// <returns>this instance</returns>
        public Activity WithProgress(Decimal progress)
        {
            this.progressField = progress;
            return this;
        }

        /// <summary>
        /// Checks if Progress property is set
        /// </summary>
        /// <returns>true if Progress property is set</returns>
        public bool IsSetProgress()
        {
            return  this.progressField.HasValue;
        }

    }
}
