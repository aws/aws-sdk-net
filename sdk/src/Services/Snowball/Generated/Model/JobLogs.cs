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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Contains job logs. Whenever a Snow device is used to import data into or export data
    /// out of Amazon S3, you'll have the option of downloading a PDF job report. Job logs
    /// are returned as a part of the response syntax of the <c>DescribeJob</c> action in
    /// the <c>JobMetadata</c> data type. The job logs can be accessed for up to 60 minutes
    /// after this request has been made. To access any of the job logs after 60 minutes have
    /// passed, you'll have to make another call to the <c>DescribeJob</c> action.
    /// 
    ///  
    /// <para>
    /// For import jobs, the PDF job report becomes available at the end of the import process.
    /// For export jobs, your job report typically becomes available while the Snow device
    /// for your job part is being delivered to you.
    /// </para>
    ///  
    /// <para>
    /// The job report provides you insight into the state of your Amazon S3 data transfer.
    /// The report includes details about your job or job part for your records.
    /// </para>
    ///  
    /// <para>
    /// For deeper visibility into the status of your transferred objects, you can look at
    /// the two associated logs: a success log and a failure log. The logs are saved in comma-separated
    /// value (CSV) format, and the name of each log includes the ID of the job or job part
    /// that the log describes.
    /// </para>
    /// </summary>
    public partial class JobLogs
    {
        private string _jobCompletionReportURI;
        private string _jobFailureLogURI;
        private string _jobSuccessLogURI;

        /// <summary>
        /// Gets and sets the property JobCompletionReportURI. 
        /// <para>
        /// A link to an Amazon S3 presigned URL where the job completion report is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string JobCompletionReportURI
        {
            get { return this._jobCompletionReportURI; }
            set { this._jobCompletionReportURI = value; }
        }

        // Check to see if JobCompletionReportURI property is set
        internal bool IsSetJobCompletionReportURI()
        {
            return this._jobCompletionReportURI != null;
        }

        /// <summary>
        /// Gets and sets the property JobFailureLogURI. 
        /// <para>
        /// A link to an Amazon S3 presigned URL where the job failure log is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string JobFailureLogURI
        {
            get { return this._jobFailureLogURI; }
            set { this._jobFailureLogURI = value; }
        }

        // Check to see if JobFailureLogURI property is set
        internal bool IsSetJobFailureLogURI()
        {
            return this._jobFailureLogURI != null;
        }

        /// <summary>
        /// Gets and sets the property JobSuccessLogURI. 
        /// <para>
        /// A link to an Amazon S3 presigned URL where the job success log is located.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string JobSuccessLogURI
        {
            get { return this._jobSuccessLogURI; }
            set { this._jobSuccessLogURI = value; }
        }

        // Check to see if JobSuccessLogURI property is set
        internal bool IsSetJobSuccessLogURI()
        {
            return this._jobSuccessLogURI != null;
        }

    }
}