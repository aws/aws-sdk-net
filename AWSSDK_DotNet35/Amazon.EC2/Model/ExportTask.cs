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
    /// <summary>Export Task
    /// </summary>
    public class ExportTask
    {
        
        private string exportTaskId;
        private string description;
        private ExportTaskState state;
        private string statusMessage;
        private InstanceExportDetails instanceExportDetails;
        private ExportToS3Task exportToS3Task;

        public string ExportTaskId
        {
            get { return this.exportTaskId; }
            set { this.exportTaskId = value; }
        }

        // Check to see if ExportTaskId property is set
        internal bool IsSetExportTaskId()
        {
            return this.exportTaskId != null;
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
        public ExportTaskState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }
        public string StatusMessage
        {
            get { return this.statusMessage; }
            set { this.statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this.statusMessage != null;
        }
        public InstanceExportDetails InstanceExportDetails
        {
            get { return this.instanceExportDetails; }
            set { this.instanceExportDetails = value; }
        }

        // Check to see if InstanceExportDetails property is set
        internal bool IsSetInstanceExportDetails()
        {
            return this.instanceExportDetails != null;
        }
        public ExportToS3Task ExportToS3Task
        {
            get { return this.exportToS3Task; }
            set { this.exportToS3Task = value; }
        }

        // Check to see if ExportToS3Task property is set
        internal bool IsSetExportToS3Task()
        {
            return this.exportToS3Task != null;
        }
    }
}
