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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Specify the driver that the job runs on.
    /// </summary>
    public partial class JobDriver
    {
        private SparkSubmitJobDriver _sparkSubmitJobDriver;

        /// <summary>
        /// Gets and sets the property SparkSubmitJobDriver. 
        /// <para>
        /// The job driver parameters specified for spark submit.
        /// </para>
        /// </summary>
        public SparkSubmitJobDriver SparkSubmitJobDriver
        {
            get { return this._sparkSubmitJobDriver; }
            set { this._sparkSubmitJobDriver = value; }
        }

        // Check to see if SparkSubmitJobDriver property is set
        internal bool IsSetSparkSubmitJobDriver()
        {
            return this._sparkSubmitJobDriver != null;
        }

    }
}