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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// The metrics data returned from a <code>GetMetricData</code> operation.
    /// </summary>
    public partial class HistoricalMetricResult
    {
        private List<HistoricalMetricData> _collections = new List<HistoricalMetricData>();
        private Dimensions _dimensions;

        /// <summary>
        /// Gets and sets the property Collections. 
        /// <para>
        /// A list of <code>HistoricalMetricData</code> objects.
        /// </para>
        /// </summary>
        public List<HistoricalMetricData> Collections
        {
            get { return this._collections; }
            set { this._collections = value; }
        }

        // Check to see if Collections property is set
        internal bool IsSetCollections()
        {
            return this._collections != null && this._collections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The <code>Dimensions</code> for the metrics.
        /// </para>
        /// </summary>
        public Dimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

    }
}