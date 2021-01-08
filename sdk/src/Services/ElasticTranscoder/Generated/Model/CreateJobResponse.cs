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
    /// The CreateJobResponse structure.
    /// </summary>
    public partial class CreateJobResponse : AmazonWebServiceResponse
    {
        private Job _job;

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// A section of the response body that provides information about the job that is created.
        /// </para>
        /// </summary>
        public Job Job
        {
            get { return this._job; }
            set { this._job = value; }
        }

        // Check to see if Job property is set
        internal bool IsSetJob()
        {
            return this._job != null;
        }

    }
}