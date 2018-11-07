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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// The metadata that you can use to filter and group your results. You can use <code>GetDimensionValues</code>
    /// to find specific values.
    /// </summary>
    public partial class DimensionValues
    {
        private Dimension _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The names of the metadata types that you can use to filter and group your results.
        /// For example, <code>AZ</code> returns a list of Availability Zones.
        /// </para>
        /// </summary>
        public Dimension Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The metadata values that you can use to filter and group your results. You can use
        /// <code>GetDimensionValues</code> to find specific values.
        /// </para>
        ///  
        /// <para>
        /// Valid values for the <code>SERVICE</code> dimension are <code>Amazon Elastic Compute
        /// Cloud - Compute</code>, <code>Amazon Elasticsearch Service</code>, <code>Amazon ElastiCache</code>,
        /// <code>Amazon Redshift</code>, and <code>Amazon Relational Database Service</code>.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}