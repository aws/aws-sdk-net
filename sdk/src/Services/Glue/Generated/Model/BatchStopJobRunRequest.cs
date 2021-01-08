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
    /// Container for the parameters to the BatchStopJobRun operation.
    /// Stops one or more job runs for a specified job definition.
    /// </summary>
    public partial class BatchStopJobRunRequest : AmazonGlueRequest
    {
        private string _jobName;
        private List<string> _jobRunIds = new List<string>();

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job definition for which to stop job runs.
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
        /// Gets and sets the property JobRunIds. 
        /// <para>
        /// A list of the <code>JobRunIds</code> that should be stopped for that job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> JobRunIds
        {
            get { return this._jobRunIds; }
            set { this._jobRunIds = value; }
        }

        // Check to see if JobRunIds property is set
        internal bool IsSetJobRunIds()
        {
            return this._jobRunIds != null && this._jobRunIds.Count > 0; 
        }

    }
}