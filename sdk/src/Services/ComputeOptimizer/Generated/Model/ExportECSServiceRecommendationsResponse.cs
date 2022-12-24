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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the ExportECSServiceRecommendations operation.
    /// </summary>
    public partial class ExportECSServiceRecommendationsResponse : AmazonWebServiceResponse
    {
        private string _jobId;
        private S3Destination _s3Destination;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        ///  The identification number of the export job. 
        /// </para>
        ///  
        /// <para>
        /// To view the status of an export job, use the <a>DescribeRecommendationExportJobs</a>
        /// action and specify the job ID. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property S3Destination.
        /// </summary>
        public S3Destination S3Destination
        {
            get { return this._s3Destination; }
            set { this._s3Destination = value; }
        }

        // Check to see if S3Destination property is set
        internal bool IsSetS3Destination()
        {
            return this._s3Destination != null;
        }

    }
}