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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the DescribeJob operation.
    /// </summary>
    public partial class DescribeJobResponse : AmazonWebServiceResponse
    {
        private JobMetadata _jobMetadata;
        private List<JobMetadata> _subJobMetadata = new List<JobMetadata>();

        /// <summary>
        /// Gets and sets the property JobMetadata. 
        /// <para>
        /// Information about a specific job, including shipping information, job status, and
        /// other important metadata.
        /// </para>
        /// </summary>
        public JobMetadata JobMetadata
        {
            get { return this._jobMetadata; }
            set { this._jobMetadata = value; }
        }

        // Check to see if JobMetadata property is set
        internal bool IsSetJobMetadata()
        {
            return this._jobMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property SubJobMetadata. 
        /// <para>
        /// Information about a specific job part (in the case of an export job), including shipping
        /// information, job status, and other important metadata.
        /// </para>
        /// </summary>
        public List<JobMetadata> SubJobMetadata
        {
            get { return this._subJobMetadata; }
            set { this._subJobMetadata = value; }
        }

        // Check to see if SubJobMetadata property is set
        internal bool IsSetSubJobMetadata()
        {
            return this._subJobMetadata != null && this._subJobMetadata.Count > 0; 
        }

    }
}