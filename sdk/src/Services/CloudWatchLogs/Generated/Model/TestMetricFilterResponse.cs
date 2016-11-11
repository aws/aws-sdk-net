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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the TestMetricFilter operation.
    /// </summary>
    public partial class TestMetricFilterResponse : AmazonWebServiceResponse
    {
        private List<MetricFilterMatchRecord> _matches = new List<MetricFilterMatchRecord>();

        /// <summary>
        /// Gets and sets the property Matches. 
        /// <para>
        /// The matched events.
        /// </para>
        /// </summary>
        public List<MetricFilterMatchRecord> Matches
        {
            get { return this._matches; }
            set { this._matches = value; }
        }

        // Check to see if Matches property is set
        internal bool IsSetMatches()
        {
            return this._matches != null && this._matches.Count > 0; 
        }

    }
}