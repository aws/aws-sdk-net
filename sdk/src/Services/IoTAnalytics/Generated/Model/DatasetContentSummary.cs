/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Summary information about data set contents.
    /// </summary>
    public partial class DatasetContentSummary
    {
        private DateTime? _creationTime;
        private DateTime? _scheduleTime;
        private DatasetContentStatus _status;
        private string _version;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The actual time the creation of the data set contents was started.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduleTime. 
        /// <para>
        /// The time the creation of the data set contents was scheduled to start.
        /// </para>
        /// </summary>
        public DateTime ScheduleTime
        {
            get { return this._scheduleTime.GetValueOrDefault(); }
            set { this._scheduleTime = value; }
        }

        // Check to see if ScheduleTime property is set
        internal bool IsSetScheduleTime()
        {
            return this._scheduleTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the data set contents.
        /// </para>
        /// </summary>
        public DatasetContentStatus Status
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
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the data set contents.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}