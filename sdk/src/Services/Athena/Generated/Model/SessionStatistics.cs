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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains statistics for a session.
    /// </summary>
    public partial class SessionStatistics
    {
        private long? _dpuExecutionInMillis;

        /// <summary>
        /// Gets and sets the property DpuExecutionInMillis. 
        /// <para>
        /// The data processing unit execution time for a session in milliseconds.
        /// </para>
        /// </summary>
        public long DpuExecutionInMillis
        {
            get { return this._dpuExecutionInMillis.GetValueOrDefault(); }
            set { this._dpuExecutionInMillis = value; }
        }

        // Check to see if DpuExecutionInMillis property is set
        internal bool IsSetDpuExecutionInMillis()
        {
            return this._dpuExecutionInMillis.HasValue; 
        }

    }
}