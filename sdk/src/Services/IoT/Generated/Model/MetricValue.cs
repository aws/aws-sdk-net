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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The value to be compared with the <code>metric</code>.
    /// </summary>
    public partial class MetricValue
    {
        private List<string> _cidrs = new List<string>();
        private long? _count;
        private List<int> _ports = new List<int>();

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// If the <code>comparisonOperator</code> calls for a set of CIDRs, use this to specify
        /// that set to be compared with the <code>metric</code>.
        /// </para>
        /// </summary>
        public List<string> Cidrs
        {
            get { return this._cidrs; }
            set { this._cidrs = value; }
        }

        // Check to see if Cidrs property is set
        internal bool IsSetCidrs()
        {
            return this._cidrs != null && this._cidrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// If the <code>comparisonOperator</code> calls for a numeric value, use this to specify
        /// that numeric value to be compared with the <code>metric</code>.
        /// </para>
        /// </summary>
        public long Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// If the <code>comparisonOperator</code> calls for a set of ports, use this to specify
        /// that set to be compared with the <code>metric</code>.
        /// </para>
        /// </summary>
        public List<int> Ports
        {
            get { return this._ports; }
            set { this._ports = value; }
        }

        // Check to see if Ports property is set
        internal bool IsSetPorts()
        {
            return this._ports != null && this._ports.Count > 0; 
        }

    }
}