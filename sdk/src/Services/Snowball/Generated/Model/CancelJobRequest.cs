/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the CancelJob operation.
    /// Cancels the specified job. Note that you can only cancel a job before its <code>JobState</code>
    /// value changes to <code>PreparingAppliance</code>. Requesting the <code>ListJobs</code>
    /// or <code>DescribeJob</code> action will return a job's <code>JobState</code> as part
    /// of the response element data returned.
    /// </summary>
    public partial class CancelJobRequest : AmazonSnowballRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The 39 character job ID for the job that you want to cancel, for example <code>JID123e4567-e89b-12d3-a456-426655440000</code>.
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

    }
}