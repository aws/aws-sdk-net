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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information about a job configuration schema version.
    /// </summary>
    public partial class JobConfigSchemaVersionSummary
    {
        private string _jobConfigSchemaVersion;

        /// <summary>
        /// Gets and sets the property JobConfigSchemaVersion. 
        /// <para>
        /// The version of the job configuration schema.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=16)]
        public string JobConfigSchemaVersion
        {
            get { return this._jobConfigSchemaVersion; }
            set { this._jobConfigSchemaVersion = value; }
        }

        // Check to see if JobConfigSchemaVersion property is set
        internal bool IsSetJobConfigSchemaVersion()
        {
            return this._jobConfigSchemaVersion != null;
        }

    }
}