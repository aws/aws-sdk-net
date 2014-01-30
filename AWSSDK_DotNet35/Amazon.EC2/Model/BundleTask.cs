/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a bundle task.</para>
    /// </summary>
    public class BundleTask
    {
        
        private string instanceId;
        private string bundleId;
        private BundleTaskState state;
        private DateTime? startTime;
        private DateTime? updateTime;
        private Storage storage;
        private string progress;
        private BundleTaskError bundleTaskError;


        /// <summary>
        /// The ID of the instance associated with this bundle task.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The ID for this bundle task.
        ///  
        /// </summary>
        public string BundleId
        {
            get { return this.bundleId; }
            set { this.bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this.bundleId != null;
        }

        /// <summary>
        /// The state of the task.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, waiting-for-shutdown, bundling, storing, cancelling, complete, failed</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public BundleTaskState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The time this task started.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// The time of the most recent update for the task.
        ///  
        /// </summary>
        public DateTime UpdateTime
        {
            get { return this.updateTime ?? default(DateTime); }
            set { this.updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this.updateTime.HasValue;
        }

        /// <summary>
        /// The Amazon S3 storage locations.
        ///  
        /// </summary>
        public Storage Storage
        {
            get { return this.storage; }
            set { this.storage = value; }
        }

        // Check to see if Storage property is set
        internal bool IsSetStorage()
        {
            return this.storage != null;
        }

        /// <summary>
        /// The level of task completion, as a percent (for example, 20%).
        ///  
        /// </summary>
        public string Progress
        {
            get { return this.progress; }
            set { this.progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this.progress != null;
        }

        /// <summary>
        /// If the task fails, a description of the error.
        ///  
        /// </summary>
        public BundleTaskError BundleTaskError
        {
            get { return this.bundleTaskError; }
            set { this.bundleTaskError = value; }
        }

        // Check to see if BundleTaskError property is set
        internal bool IsSetBundleTaskError()
        {
            return this.bundleTaskError != null;
        }
    }
}
