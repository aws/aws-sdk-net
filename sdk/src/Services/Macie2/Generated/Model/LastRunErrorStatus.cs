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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
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
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Specifies whether any account- or bucket-level access errors occurred when a classification
    /// job ran. For information about using logging data to investigate these errors, see
    /// <a href="https://docs.aws.amazon.com/macie/latest/user/discovery-jobs-monitor-cw-logs.html">Monitoring
    /// sensitive data discovery jobs</a> in the <i>Amazon Macie User Guide</i>.
    /// </summary>
    public partial class LastRunErrorStatus
    {
        private LastRunErrorStatusCode _code;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Specifies whether any account- or bucket-level access errors occurred when the job
        /// ran. For a recurring job, this value indicates the error status of the job's most
        /// recent run. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// ERROR - One or more errors occurred. Amazon Macie didn't process all the data specified
        /// for the job.
        /// </para>
        /// </li> <li>
        /// <para>
        /// NONE - No errors occurred. Macie processed all the data specified for the job.
        /// </para>
        /// </li></ul>
        /// </summary>
        public LastRunErrorStatusCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

    }
}