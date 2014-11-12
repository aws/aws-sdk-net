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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an export task.
    /// </summary>
    public partial class ExportTask
    {
        private string _description;
        private string _exportTaskId;
        private ExportToS3Task _exportToS3Task;
        private InstanceExportDetails _instanceExportDetails;
        private ExportTaskState _state;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the resource being exported.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExportTaskId. 
        /// <para>
        /// The ID of the export task.
        /// </para>
        /// </summary>
        public string ExportTaskId
        {
            get { return this._exportTaskId; }
            set { this._exportTaskId = value; }
        }

        // Check to see if ExportTaskId property is set
        internal bool IsSetExportTaskId()
        {
            return this._exportTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToS3Task.
        /// </summary>
        public ExportToS3Task ExportToS3Task
        {
            get { return this._exportToS3Task; }
            set { this._exportToS3Task = value; }
        }

        // Check to see if ExportToS3Task property is set
        internal bool IsSetExportToS3Task()
        {
            return this._exportToS3Task != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceExportDetails. 
        /// <para>
        /// The instance being exported.
        /// </para>
        /// </summary>
        public InstanceExportDetails InstanceExportDetails
        {
            get { return this._instanceExportDetails; }
            set { this._instanceExportDetails = value; }
        }

        // Check to see if InstanceExportDetails property is set
        internal bool IsSetInstanceExportDetails()
        {
            return this._instanceExportDetails != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the conversion task.
        /// </para>
        /// </summary>
        public ExportTaskState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message related to the export task.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}