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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
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
namespace Amazon.IoTManagedIntegrations.Model
{
    /// <summary>
    /// Structure representing one over-the-air (OTA) task.
    /// </summary>
    public partial class OtaTaskSummary
    {
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private OtaStatus _status;
        private string _taskArn;
        private string _taskConfigurationId;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp value of when the over-the-air (OTA) task was created at.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp value of when the over-the-air (OTA) task was last updated at.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the over-the-air (OTA) task summary.
        /// </para>
        /// </summary>
        public OtaStatus Status
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
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskConfigurationId. 
        /// <para>
        /// The identifier for the over-the-air (OTA) task configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string TaskConfigurationId
        {
            get { return this._taskConfigurationId; }
            set { this._taskConfigurationId = value; }
        }

        // Check to see if TaskConfigurationId property is set
        internal bool IsSetTaskConfigurationId()
        {
            return this._taskConfigurationId != null;
        }

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The id of the over-the-air (OTA) task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}