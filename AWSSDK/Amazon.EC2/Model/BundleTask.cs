/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    ///<summary>
    ///Bundle Task
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class BundleTask
    {    
        private string instanceIdField;
        private string bundleIdField;
        private string bundleStateField;
        private string startTimeField;
        private string updateTimeField;
        private Storage storageField;
        private string progressField;
        private BundleTaskError bundleTaskErrorField;

        /// <summary>
        /// Gets and sets the InstanceId property.
        /// Instance associated with this bundle task.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">Instance associated with this bundle task.</param>
        /// <returns>this instance</returns>
        public BundleTask WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Gets and sets the BundleId property.
        /// Identifier for this task.
        /// </summary>
        [XmlElementAttribute(ElementName = "BundleId")]
        public string BundleId
        {
            get { return this.bundleIdField; }
            set { this.bundleIdField = value; }
        }

        /// <summary>
        /// Sets the BundleId property
        /// </summary>
        /// <param name="bundleId">Identifier for this task.</param>
        /// <returns>this instance</returns>
        public BundleTask WithBundleId(string bundleId)
        {
            this.bundleIdField = bundleId;
            return this;
        }

        /// <summary>
        /// Checks if BundleId property is set
        /// </summary>
        /// <returns>true if BundleId property is set</returns>
        public bool IsSetBundleId()
        {
            return this.bundleIdField != null;
        }

        /// <summary>
        /// Gets and sets the BundleState property.
        /// The state of the task.
        ///
        /// Valid Values: pending |
        /// waiting-for-shutdown | storing | canceling |
        /// complete | failed
        /// </summary>
        [XmlElementAttribute(ElementName = "BundleState")]
        public string BundleState
        {
            get { return this.bundleStateField; }
            set { this.bundleStateField = value; }
        }

        /// <summary>
        /// Sets the BundleState property
        /// </summary>
        /// <param name="bundleState">The state of the task.
        ///
        /// Valid Values: pending |
        /// waiting-for-shutdown | storing | canceling |
        /// complete | failed</param>
        /// <returns>this instance</returns>
        public BundleTask WithBundleState(string bundleState)
        {
            this.bundleStateField = bundleState;
            return this;
        }

        /// <summary>
        /// Checks if BundleState property is set
        /// </summary>
        /// <returns>true if BundleState property is set</returns>
        public bool IsSetBundleState()
        {
            return this.bundleStateField != null;
        }

        /// <summary>
        /// Gets and sets the StartTime property.
        /// The time this task started.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTime")]
        public string StartTime
        {
            get { return this.startTimeField; }
            set { this.startTimeField = value; }
        }

        /// <summary>
        /// Sets the StartTime property
        /// </summary>
        /// <param name="startTime">The time this task started.</param>
        /// <returns>this instance</returns>
        public BundleTask WithStartTime(string startTime)
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
            return this.startTimeField != null;
        }

        /// <summary>
        /// Gets and sets the UpdateTime property.
        /// The time of the most recent update for the
        /// task.
        /// </summary>
        [XmlElementAttribute(ElementName = "UpdateTime")]
        public string UpdateTime
        {
            get { return this.updateTimeField; }
            set { this.updateTimeField = value; }
        }

        /// <summary>
        /// Sets the UpdateTime property
        /// </summary>
        /// <param name="updateTime">The time of the most recent update for the
        /// task.</param>
        /// <returns>this instance</returns>
        public BundleTask WithUpdateTime(string updateTime)
        {
            this.updateTimeField = updateTime;
            return this;
        }

        /// <summary>
        /// Checks if UpdateTime property is set
        /// </summary>
        /// <returns>true if UpdateTime property is set</returns>
        public bool IsSetUpdateTime()
        {
            return this.updateTimeField != null;
        }

        /// <summary>
        /// Gets and sets the Storage property.
        /// Amazon S3 storage locations.
        /// </summary>
        [XmlElementAttribute(ElementName = "Storage")]
        public Storage Storage
        {
            get { return this.storageField; }
            set { this.storageField = value; }
        }

        /// <summary>
        /// Sets the Storage property
        /// </summary>
        /// <param name="storage">Amazon S3 storage locations.</param>
        /// <returns>this instance</returns>
        public BundleTask WithStorage(Storage storage)
        {
            this.storageField = storage;
            return this;
        }

        /// <summary>
        /// Checks if Storage property is set
        /// </summary>
        /// <returns>true if Storage property is set</returns>
        public bool IsSetStorage()
        {
            return this.storageField != null;
        }

        /// <summary>
        /// Gets and sets the Progress property.
        /// The level of task completion, in percent
        /// (e.g., 20%).
        /// </summary>
        [XmlElementAttribute(ElementName = "Progress")]
        public string Progress
        {
            get { return this.progressField; }
            set { this.progressField = value; }
        }

        /// <summary>
        /// Sets the Progress property
        /// </summary>
        /// <param name="progress">The level of task completion, in percent
        /// (e.g., 20%).</param>
        /// <returns>this instance</returns>
        public BundleTask WithProgress(string progress)
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
            return this.progressField != null;
        }

        /// <summary>
        /// Gets and sets the BundleTaskError property.
        /// If the task fails, a description of the error.
        /// </summary>
        [XmlElementAttribute(ElementName = "BundleTaskError")]
        public BundleTaskError BundleTaskError
        {
            get { return this.bundleTaskErrorField; }
            set { this.bundleTaskErrorField = value; }
        }

        /// <summary>
        /// Sets the BundleTaskError property
        /// </summary>
        /// <param name="bundleTaskError">If the task fails, a description of the error.</param>
        /// <returns>this instance</returns>
        public BundleTask WithBundleTaskError(BundleTaskError bundleTaskError)
        {
            this.bundleTaskErrorField = bundleTaskError;
            return this;
        }

        /// <summary>
        /// Checks if BundleTaskError property is set
        /// </summary>
        /// <returns>true if BundleTaskError property is set</returns>
        public bool IsSetBundleTaskError()
        {
            return this.bundleTaskErrorField != null;
        }

    }
}
