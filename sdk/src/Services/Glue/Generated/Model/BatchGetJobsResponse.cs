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
    /// This is the response object from the BatchGetJobs operation.
    /// </summary>
    public partial class BatchGetJobsResponse : AmazonWebServiceResponse
    {
        private List<Job> _jobs = AWSConfigs.InitializeCollections ? new List<Job>() : null;
        private List<string> _jobsNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Jobs. 
        /// <para>
        /// A list of job definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Job> Jobs
        {
            get { return this._jobs; }
            set { this._jobs = value; }
        }

        // Check to see if Jobs property is set
        internal bool IsSetJobs()
        {
            return this._jobs != null && (this._jobs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JobsNotFound. 
        /// <para>
        /// A list of names of jobs not found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobsNotFound
        {
            get { return this._jobsNotFound; }
            set { this._jobsNotFound = value; }
        }

        // Check to see if JobsNotFound property is set
        internal bool IsSetJobsNotFound()
        {
            return this._jobsNotFound != null && (this._jobsNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}