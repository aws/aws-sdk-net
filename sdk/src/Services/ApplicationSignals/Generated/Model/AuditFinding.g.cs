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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AuditorResults. 
        /// <para>
        /// An array of auditor results that contain the specific findings, descriptions, and
        /// severity levels identified by different auditing algorithms.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 5)]
        public List<AuditorResult> AuditorResults { get; set; } = AWSConfigs.InitializeCollections ? new List<AuditorResult>() : null;

        /// <summary>
        /// Checks to see if the AuditorResults property is set.
        /// </summary>
        internal bool IsSetAuditorResults() => this.AuditorResults != null && (this.AuditorResults.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DependencyGraph. 
        /// <para>
        /// A structure containing nodes and edges that represent the dependency relationships
        /// relevant to this audit finding, helping to understand the context and potential impact.
        /// </para>
        /// </summary>
        public DependencyGraph DependencyGraph { get; set; }

        /// <summary>
        /// Checks to see if the DependencyGraph property is set.
        /// </summary>
        internal bool IsSetDependencyGraph() => this.DependencyGraph != null;

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// The key attributes that identify the service or entity this audit finding relates
        /// to. This is a string-to-string map that includes fields like Type, Name, and Environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4)]
        public Dictionary<string, string> KeyAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KeyAttributes property is set.
        /// </summary>
        internal bool IsSetKeyAttributes() => this.KeyAttributes != null && (this.KeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MetricGraph. 
        /// <para>
        /// A structure containing metric data queries and time range information that provides
        /// context for the audit finding through relevant performance metrics.
        /// </para>
        /// </summary>
        public MetricGraph MetricGraph { get; set; }

        /// <summary>
        /// Checks to see if the MetricGraph property is set.
        /// </summary>
        internal bool IsSetMetricGraph() => this.MetricGraph != null;

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The name of the operation associated with this audit finding, if the finding is specific
        /// to a particular service operation.
        /// </para>
        /// </summary>
        public string Operation { get; set; }

        /// <summary>
        /// Checks to see if the Operation property is set.
        /// </summary>
        internal bool IsSetOperation() => this.Operation != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of audit finding.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
