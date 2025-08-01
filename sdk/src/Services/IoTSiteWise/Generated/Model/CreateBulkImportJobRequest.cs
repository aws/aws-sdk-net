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
    /// Container for the parameters to the CreateBulkImportJob operation.
    /// Defines a job to ingest data to IoT SiteWise from Amazon S3. For more information,
    /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/CreateBulkImportJob.html">Create
    /// a bulk import job (CLI)</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// Before you create a bulk import job, you must enable IoT SiteWise warm tier or IoT
    /// SiteWise cold tier. For more information about how to configure storage settings,
    /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_PutStorageConfiguration.html">PutStorageConfiguration</a>.
    /// </para>
    ///  
    /// <para>
    /// Bulk import is designed to store historical data to IoT SiteWise.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Newly ingested data in the hot tier triggers notifications and computations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After data moves from the hot tier to the warm or cold tier based on retention settings,
    /// it does not trigger computations or notifications.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data older than 7 days does not trigger computations or notifications.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class CreateBulkImportJobRequest : AmazonIoTSiteWiseRequest
    {
        private bool? _adaptiveIngestion;
        private bool? _deleteFilesAfterImport;
        private ErrorReportLocation _errorReportLocation;
        private List<File> _files = AWSConfigs.InitializeCollections ? new List<File>() : null;
        private JobConfiguration _jobConfiguration;
        private string _jobName;
        private string _jobRoleArn;

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

    }
}