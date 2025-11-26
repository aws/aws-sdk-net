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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains information about an audit finding, which represents an
    /// automated analysis result about service behavior, performance issues, or potential
    /// problems identified through heuristic algorithms.
    /// </summary>
    public partial class AuditFinding
    {
        private List<AuditorResult> _auditorResults = AWSConfigs.InitializeCollections ? new List<AuditorResult>() : null;
        private DependencyGraph _dependencyGraph;
        private Dictionary<string, string> _keyAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private MetricGraph _metricGraph;
        private string _operation;
        private string _type;

        /// <summary>
        /// Gets and sets the property AuditorResults. 
        /// <para>
        /// An array of auditor results that contain the specific findings, descriptions, and
        /// severity levels identified by different auditing algorithms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<AuditorResult> AuditorResults
        {
            get { return this._auditorResults; }
            set { this._auditorResults = value; }
        }

        // Check to see if AuditorResults property is set
        internal bool IsSetAuditorResults()
        {
            return this._auditorResults != null && (this._auditorResults.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DependencyGraph. 
        /// <para>
        /// A structure containing nodes and edges that represent the dependency relationships
        /// relevant to this audit finding, helping to understand the context and potential impact.
        /// </para>
        /// </summary>
        public DependencyGraph DependencyGraph
        {
            get { return this._dependencyGraph; }
            set { this._dependencyGraph = value; }
        }

        // Check to see if DependencyGraph property is set
        internal bool IsSetDependencyGraph()
        {
            return this._dependencyGraph != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The key attributes that identify the service or entity this audit finding relates
        /// to. This is a string-to-string map that includes fields like Type, Name, and Environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4)]
        public Dictionary<string, string> KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null && (this._keyAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricGraph. 
        /// <para>
        /// A structure containing metric data queries and time range information that provides
        /// context for the audit finding through relevant performance metrics.
        /// </para>
        /// </summary>
        public MetricGraph MetricGraph
        {
            get { return this._metricGraph; }
            set { this._metricGraph = value; }
        }

        // Check to see if MetricGraph property is set
        internal bool IsSetMetricGraph()
        {
            return this._metricGraph != null;
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The name of the operation associated with this audit finding, if the finding is specific
        /// to a particular service operation.
        /// </para>
        /// </summary>
        public string Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of audit finding.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}