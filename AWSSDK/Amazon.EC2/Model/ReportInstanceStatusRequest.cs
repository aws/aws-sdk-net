/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Submits feedback about an instance's status.
    /// </summary>
    /// <remarks>
    /// This action works only for instances that are in the running state.
    /// If your experience with the instance differs from the instance status returned by the 
    /// DescribeInstanceStatus action, use ReportInstanceStatus to report your experience with the instance. 
    /// Amazon EC2 collects this information to improve the accuracy of status checks. 
    /// Use of this action does not change the value returned by DescribeInstanceStatus.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class ReportInstanceStatusRequest
    {
        private List<string> instanceIdField;
        private string statusField;
        private string startTimeField;
        private string endTimeField;
        private List<string> reasonCodeField;
        private string descriptionField;

        /// <summary>
        /// One or more instance IDs. 
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public List<string> InstanceId
        {
            get
            {
                if (this.instanceIdField == null)
                {
                    this.instanceIdField = new List<string>();
                }
                return this.instanceIdField;
            }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets one or more instance IDs. 
        /// </summary>
        /// <param name="list">Instance IDs to report on.</param>
        /// <returns>this instance</returns>
        public ReportInstanceStatusRequest WithInstanceId(params string[] list)
        {
            foreach (string item in list)
            {
                InstanceId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the InstanceId property is set
        /// </summary>
        /// <returns>true if the InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return (InstanceId.Count > 0);
        }

        /// <summary>
        /// The status of all submitted instances.
        /// </summary>
        /// <remarks>
        /// Valid Values: ok | impaired
        /// </remarks>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the status of all submitted instances.
        /// </summary>
        /// <param name="status">Status for the instances.</param>
        /// <returns>this instance</returns>
        public ReportInstanceStatusRequest WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if the Status property is set
        /// </summary>
        /// <returns>true if the Status property is set</returns>
        public bool IsSetStatus()
        {
            return !string.IsNullOrEmpty(this.Status);
        }

        /// <summary>
        /// The time at which the reported instance health state began.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public string StartTime
        {
            get { return this.startTimeField; }
            set { this.startTimeField = value; }
        }

        /// <summary>
        /// Sets the time at which the reported instance health state began.
        /// </summary>
        /// <param name="startTime">The start time of the health state</param>
        /// <returns>this instance</returns>
        public ReportInstanceStatusRequest WithStartTime(string startTime)
        {
            this.startTimeField = startTime;
            return this;
        }

        /// <summary>
        /// Checks if the StartTime property is set.
        /// </summary>
        /// <returns>True if the StartTime property is set</returns>
        public bool IsSetStartTime()
        {
            return !string.IsNullOrEmpty(this.StartTime);
        }

        /// <summary>
        /// The time at which the reported instance health state ended. 
        /// </summary>
        [XmlElementAttribute(ElementName = "EndTime")]
        public string EndTime
        {
            get { return this.endTimeField; }
            set { this.endTimeField = value; }
        }

        /// <summary>
        /// Sets the time at which the reported instance health state ended. 
        /// </summary>
        /// <param name="endTime">The end time of the health state</param>
        /// <returns>this instance</returns>
        public ReportInstanceStatusRequest WithEndTime(string endTime)
        {
            this.endTimeField = endTime;
            return this;
        }

        /// <summary>
        /// Checks if the EndTime property is set.
        /// </summary>
        /// <returns>true if the EndTime property is set</returns>
        public bool IsSetEndTime()
        {
            return !string.IsNullOrEmpty(this.EndTime);
        }

        /// <summary>
        /// Reason codes that describe the specified instances health states.
        /// </summary>
        /// <remarks>
        /// Each code you supply corresponds to an instance ID that you supply in the InstanceID
        /// collection.
        /// Valid Values: instance-stuck-in-state | unresponsive | not-accepting-credentials |
        /// password-not-available | performance-network | performance-instance-store |
        /// performance-ebs-volume | performance-other | other 
        /// </remarks>
        [XmlElementAttribute(ElementName = "ReasonCode")]
        public List<string> ReasonCode
        {
            get
            {
                if (this.reasonCodeField == null)
                {
                    this.reasonCodeField = new List<string>();
                }
                return this.reasonCodeField;
            }
            set { this.reasonCodeField = value; }
        }

        /// <summary>
        /// Sets the reason codes that describe the specified instances health states
        /// </summary>
        /// <param name="list">One or more reason codes</param>
        /// <returns>this instance</returns>
        public ReportInstanceStatusRequest WithReasonCode(params string[] list)
        {
            foreach (string item in list)
            {
                ReasonCode.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the ReasonCode property is set
        /// </summary>
        /// <returns>true if the ReasonCode property is set</returns>
        public bool IsSetReasonCode()
        {
            return (ReasonCode.Count > 0);
        }

        /// <summary>
        /// Description text about the instance health state.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description text about the instance health state.
        /// </summary>
        /// <param name="description"></param>
        /// <returns>this instance</returns>
        public ReportInstanceStatusRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if the Description property is set
        /// </summary>
        /// <returns>true if the Description property is set</returns>
        public bool IsSetDescription()
        {
            return !string.IsNullOrEmpty(this.Description);
        }
    }
}
