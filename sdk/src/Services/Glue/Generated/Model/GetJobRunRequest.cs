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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetJobRun operation.
    /// Retrieves the metadata for a given job run. Job run history is accessible for 365
    /// days for your workflow and job run.
    /// </summary>
    public partial class GetJobRunRequest : AmazonGlueRequest
    {
        private string _jobName;
        private bool? _predecessorsIncluded;
        private string _runId;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Name of the job definition being run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property PredecessorsIncluded. 
        /// <para>
        /// True if a list of predecessor runs should be returned.
        /// </para>
        /// </summary>
        public bool? PredecessorsIncluded
        {
            get { return this._predecessorsIncluded; }
            set { this._predecessorsIncluded = value; }
        }

        // Check to see if PredecessorsIncluded property is set
        internal bool IsSetPredecessorsIncluded()
        {
            return this._predecessorsIncluded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunId. 
        /// <para>
        /// The ID of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string RunId
        {
            get { return this._runId; }
            set { this._runId = value; }
        }

        // Check to see if RunId property is set
        internal bool IsSetRunId()
        {
            return this._runId != null;
        }

    }
}