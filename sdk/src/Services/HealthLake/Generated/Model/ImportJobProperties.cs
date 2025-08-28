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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
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
namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// The import job properties.
    /// </summary>
    public partial class ImportJobProperties
    {
        private string _dataAccessRoleArn;
        private string _datastoreId;
        private DateTime? _endTime;
        private InputDataConfig _inputDataConfig;
        private string _jobId;
        private string _jobName;
        private OutputDataConfig _jobOutputDataConfig;
        private JobProgressReport _jobProgressReport;
        private JobStatus _jobStatus;
        private string _message;
        private DateTime? _submitTime;
        private ValidationLevel _validationLevel;

        /// <summary>
        /// Gets and sets the property DataAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that grants AWS HealthLake access to the input data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DataAccessRoleArn
        {
            get { return this._dataAccessRoleArn; }
            set { this._dataAccessRoleArn = value; }
        }

        // Check to see if DataAccessRoleArn property is set
        internal bool IsSetDataAccessRoleArn()
        {
            return this._dataAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the import job was completed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// The input data configuration supplied when the import job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The import job identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The import job name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobOutputDataConfig.
        /// </summary>
        public OutputDataConfig JobOutputDataConfig
        {
            get { return this._jobOutputDataConfig; }
            set { this._jobOutputDataConfig = value; }
        }

        // Check to see if JobOutputDataConfig property is set
        internal bool IsSetJobOutputDataConfig()
        {
            return this._jobOutputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobProgressReport. 
        /// <para>
        /// Displays the progress of the import job, including total resources scanned, total
        /// resources imported, and total size of data imported.
        /// </para>
        /// </summary>
        public JobProgressReport JobProgressReport
        {
            get { return this._jobProgressReport; }
            set { this._jobProgressReport = value; }
        }

        // Check to see if JobProgressReport property is set
        internal bool IsSetJobProgressReport()
        {
            return this._jobProgressReport != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The import job status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobStatus JobStatus
        {
            get { return this._jobStatus; }
            set { this._jobStatus = value; }
        }

        // Check to see if JobStatus property is set
        internal bool IsSetJobStatus()
        {
            return this._jobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// An explanation of any errors that might have occurred during the FHIR import job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The time the import job was submitted for processing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? SubmitTime
        {
            get { return this._submitTime; }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidationLevel. 
        /// <para>
        /// The validation level of the import job.
        /// </para>
        /// </summary>
        public ValidationLevel ValidationLevel
        {
            get { return this._validationLevel; }
            set { this._validationLevel = value; }
        }

        // Check to see if ValidationLevel property is set
        internal bool IsSetValidationLevel()
        {
            return this._validationLevel != null;
        }

    }
}