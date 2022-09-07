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
    /// You must enable IoT SiteWise to export data to Amazon S3 before you create a bulk
    /// import job. For more information about how to configure storage settings, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_PutStorageConfiguration.html">PutStorageConfiguration</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateBulkImportJobRequest : AmazonIoTSiteWiseRequest
    {
        private ErrorReportLocation _errorReportLocation;
        private List<File> _files = new List<File>();
        private JobConfiguration _jobConfiguration;
        private string _jobName;
        private string _jobRoleArn;

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
            return this._files != null && this._files.Count > 0; 
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