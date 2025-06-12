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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeBulkImportJob operation.
    /// </summary>
    public partial class DescribeBulkImportJobResponse : AmazonWebServiceResponse
    {
        private bool? _adaptiveIngestion;
        private bool? _deleteFilesAfterImport;
        private ErrorReportLocation _errorReportLocation;
        private List<File> _files = AWSConfigs.InitializeCollections ? new List<File>() : null;
        private JobConfiguration _jobConfiguration;
        private DateTime? _jobCreationDate;
        private string _jobId;
        private DateTime? _jobLastUpdateDate;
        private string _jobName;
        private string _jobRoleArn;
        private JobStatus _jobStatus;

        /// <summary>
        /// Gets and sets the property AdaptiveIngestion. 
        /// <para>
        /// If set to true, ingest new data into IoT SiteWise storage. Measurements with notifications,
        /// metrics and transforms are computed. If set to false, historical data is ingested
        /// into IoT SiteWise as is.
        /// </para>
        /// </summary>
        public bool? AdaptiveIngestion
        {
            get { return this._adaptiveIngestion; }
            set { this._adaptiveIngestion = value; }
        }

        // Check to see if AdaptiveIngestion property is set
        internal bool IsSetAdaptiveIngestion()
        {
            return this._adaptiveIngestion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeleteFilesAfterImport. 
        /// <para>
        /// If set to true, your data files is deleted from S3, after ingestion into IoT SiteWise
        /// storage.
        /// </para>
        /// </summary>
        public bool? DeleteFilesAfterImport
        {
            get { return this._deleteFilesAfterImport; }
            set { this._deleteFilesAfterImport = value; }
        }

        // Check to see if DeleteFilesAfterImport property is set
        internal bool IsSetDeleteFilesAfterImport()
        {
            return this._deleteFilesAfterImport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorReportLocation. 
        /// <para>
        /// The Amazon S3 destination where errors associated with the job creation request are
        /// saved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ErrorReportLocation ErrorReportLocation
        {
            get { return this._errorReportLocation; }
            set { this._errorReportLocation = value; }
        }

        // Check to see if ErrorReportLocation property is set
        internal bool IsSetErrorReportLocation()
        {
            return this._errorReportLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Files. 
        /// <para>
        /// The files in the specified Amazon S3 bucket that contain your data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<File> Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files != null && (this._files.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobConfiguration. 
        /// <para>
        /// Contains the configuration information of a job, such as the file format used to save
        /// data in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobConfiguration JobConfiguration
        {
            get { return this._jobConfiguration; }
            set { this._jobConfiguration = value; }
        }

        // Check to see if JobConfiguration property is set
        internal bool IsSetJobConfiguration()
        {
            return this._jobConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property JobCreationDate. 
        /// <para>
        /// The date the job was created, in Unix epoch TIME.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? JobCreationDate
        {
            get { return this._jobCreationDate; }
            set { this._jobCreationDate = value; }
        }

        // Check to see if JobCreationDate property is set
        internal bool IsSetJobCreationDate()
        {
            return this._jobCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property JobLastUpdateDate. 
        /// <para>
        /// The date the job was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? JobLastUpdateDate
        {
            get { return this._jobLastUpdateDate; }
            set { this._jobLastUpdateDate = value; }
        }

        // Check to see if JobLastUpdateDate property is set
        internal bool IsSetJobLastUpdateDate()
        {
            return this._jobLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The unique name that helps identify the job request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
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
        /// Gets and sets the property JobRoleArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the IAM role that allows IoT SiteWise to read Amazon S3 data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string JobRoleArn
        {
            get { return this._jobRoleArn; }
            set { this._jobRoleArn = value; }
        }

        // Check to see if JobRoleArn property is set
        internal bool IsSetJobRoleArn()
        {
            return this._jobRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the bulk import job can be one of following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – IoT SiteWise is waiting for the current bulk import job to finish.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCELLED</c> – The bulk import job has been canceled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> – IoT SiteWise is processing your request to import your data from
        /// Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> – IoT SiteWise successfully completed your request to import data
        /// from Amazon S3.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – IoT SiteWise couldn't process your request to import data from Amazon
        /// S3. You can use logs saved in the specified error report location in Amazon S3 to
        /// troubleshoot issues.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED_WITH_FAILURES</c> – IoT SiteWise completed your request to import data
        /// from Amazon S3 with errors. You can use logs saved in the specified error report location
        /// in Amazon S3 to troubleshoot issues.
        /// </para>
        ///  </li> </ul>
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

    }
}