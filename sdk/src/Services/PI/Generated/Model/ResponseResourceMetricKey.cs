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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PI.Model
{
    /// <summary>
    /// An object describing a Performance Insights metric and one or more dimensions for
    /// that metric.
    /// </summary>
    public partial class ResponseResourceMetricKey
    {
        private Dictionary<string, string> _dimensions = new Dictionary<string, string>();
        private string _metric;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The valid dimensions for the metric.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The name of a Performance Insights metric to be measured.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Metric</code> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db.load.avg</code> - a scaled representation of the number of active sessions
        /// for the database engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sampledload.avg</code> - the raw number of active sessions for the database
        /// engine.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

    }
}