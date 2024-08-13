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
    /// An execution property of a job.
    /// </summary>
    public partial class ExecutionProperty
    {
        private int? _maxConcurrentRuns;

        /// <summary>
        /// Gets and sets the property MaxConcurrentRuns. 
        /// <para>
        /// The maximum number of concurrent runs allowed for the job. The default is 1. An error
        /// is returned when this threshold is reached. The maximum value you can specify is controlled
        /// by a service limit.
        /// </para>
        /// </summary>
        public int? MaxConcurrentRuns
        {
            get { return this._maxConcurrentRuns; }
            set { this._maxConcurrentRuns = value; }
        }

        // Check to see if MaxConcurrentRuns property is set
        internal bool IsSetMaxConcurrentRuns()
        {
            return this._maxConcurrentRuns.HasValue; 
        }

    }
}