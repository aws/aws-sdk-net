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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// This is the response object from the GetPolicyPreviewJob operation.
    /// </summary>
    public partial class GetPolicyPreviewJobResponse : AmazonWebServiceResponse
    {
        private PolicyPreviewJobDetails _jobDetails;
        private string _jobId;
        private PolicyPreviewJobParameters _jobParameters;
        private string _outputs3Uri;

        /// <summary>
        /// Gets and sets the property JobDetails. 
        /// <para>
        /// Details about the job execution, including current status, submission time, start
        /// time, completion time, and any errors that occurred.
        /// </para>
        /// </summary>
        public PolicyPreviewJobDetails JobDetails
        {
            get { return this._jobDetails; }
            set { this._jobDetails = value; }
        }

        // Check to see if JobDetails property is set
        internal bool IsSetJobDetails()
        {
            return this._jobDetails != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the policy preview job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property JobParameters. 
        /// <para>
        /// The original parameters used to create the policy preview job, including the analysis
        /// time window and policy configurations.
        /// </para>
        /// </summary>
        public PolicyPreviewJobParameters JobParameters
        {
            get { return this._jobParameters; }
            set { this._jobParameters = value; }
        }

        // Check to see if JobParameters property is set
        internal bool IsSetJobParameters()
        {
            return this._jobParameters != null;
        }

        /// <summary>
        /// Gets and sets the property OutputS3Uri. 
        /// <para>
        /// The Amazon S3 URI where the analysis report is stored. The report contains metadata
        /// for CloudTrail events that would be denied by the proposed policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputS3Uri
        {
            get { return this._outputs3Uri; }
            set { this._outputs3Uri = value; }
        }

        // Check to see if OutputS3Uri property is set
        internal bool IsSetOutputS3Uri()
        {
            return this._outputs3Uri != null;
        }

    }
}