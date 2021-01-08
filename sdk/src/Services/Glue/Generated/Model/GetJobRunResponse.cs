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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the GetJobRun operation.
    /// </summary>
    public partial class GetJobRunResponse : AmazonWebServiceResponse
    {
        private JobRun _jobRun;

        /// <summary>
        /// Gets and sets the property JobRun. 
        /// <para>
        /// The requested job-run metadata.
        /// </para>
        /// </summary>
        public JobRun JobRun
        {
            get { return this._jobRun; }
            set { this._jobRun = value; }
        }

        // Check to see if JobRun property is set
        internal bool IsSetJobRun()
        {
            return this._jobRun != null;
        }

    }
}