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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// The output for the <a>GetMetricStatistics</a> action.
    /// </summary>
    public partial class GetMetricStatisticsResult : AmazonWebServiceResponse
    {
        private List<Datapoint> _datapoints = new List<Datapoint>();
        private string _label;

        /// <summary>
        /// Gets and sets the property Datapoints. 
        /// <para>
        ///  The datapoints for the specified metric. 
        /// </para>
        /// </summary>
        public List<Datapoint> Datapoints
        {
            get { return this._datapoints; }
            set { this._datapoints = value; }
        }

        // Check to see if Datapoints property is set
        internal bool IsSetDatapoints()
        {
            return this._datapoints != null && this._datapoints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  A label describing the specified metric. 
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

    }
}