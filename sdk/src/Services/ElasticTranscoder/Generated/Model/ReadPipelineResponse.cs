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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <code>ReadPipelineResponse</code> structure.
    /// </summary>
    public partial class ReadPipelineResponse : AmazonWebServiceResponse
    {
        private Pipeline _pipeline;
        private List<Warning> _warnings = new List<Warning>();

        /// <summary>
        /// Gets and sets the property Pipeline. 
        /// <para>
        /// A section of the response body that provides information about the pipeline.
        /// </para>
        /// </summary>
        public Pipeline Pipeline
        {
            get { return this._pipeline; }
            set { this._pipeline = value; }
        }

        // Check to see if Pipeline property is set
        internal bool IsSetPipeline()
        {
            return this._pipeline != null;
        }

        /// <summary>
        /// Gets and sets the property Warnings. 
        /// <para>
        /// Elastic Transcoder returns a warning if the resources used by your pipeline are not
        /// in the same region as the pipeline.
        /// </para>
        ///  
        /// <para>
        /// Using resources in the same region, such as your Amazon S3 buckets, Amazon SNS notification
        /// topics, and AWS KMS key, reduces processing time and prevents cross-regional charges.
        /// </para>
        /// </summary>
        public List<Warning> Warnings
        {
            get { return this._warnings; }
            set { this._warnings = value; }
        }

        // Check to see if Warnings property is set
        internal bool IsSetWarnings()
        {
            return this._warnings != null && this._warnings.Count > 0; 
        }

    }
}