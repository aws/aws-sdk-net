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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains property information for a service topology edge.
    /// </summary>
    public partial class EdgePropertySummary
    {
        private string _label;
        private TopologyType _topologyType;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// Human-readable relationship description. Only present for LLM-inferred edges.
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

        /// <summary>
        /// Gets and sets the property TopologyType. 
        /// <para>
        /// The topology type of the edge.
        /// </para>
        /// </summary>
        public TopologyType TopologyType
        {
            get { return this._topologyType; }
            set { this._topologyType = value; }
        }

        // Check to see if TopologyType property is set
        internal bool IsSetTopologyType()
        {
            return this._topologyType != null;
        }

    }
}