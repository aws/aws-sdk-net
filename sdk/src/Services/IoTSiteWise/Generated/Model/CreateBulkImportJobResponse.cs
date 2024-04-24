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
    /// This is the response object from the CreateBulkImportJob operation.
    /// </summary>
    public partial class CreateBulkImportJobResponse : AmazonWebServiceResponse
    {
        private string _jobId;
        private string _jobName;
        private JobStatus _jobStatus;

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