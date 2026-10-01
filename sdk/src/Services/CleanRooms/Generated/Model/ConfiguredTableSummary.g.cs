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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The configured table summary for the objects listed by the request.
    /// </summary>
    public partial class ConfiguredTableSummary
    {
        /// <summary>
        /// Gets and sets the property AnalysisMethod. 
        /// <para>
        /// The analysis method for the configured tables. 
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_QUERY</c> allows SQL queries to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>DIRECT_JOB</c> allows PySpark jobs to be run directly on this table.
        /// </para>
        ///  
        /// <para>
        ///  <c>MULTIPLE</c> allows both SQL queries and PySpark jobs to be run directly on this
        /// table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalysisMethod AnalysisMethod { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisMethod property is set.
        /// </summary>
        internal bool IsSetAnalysisMethod() => this.AnalysisMethod != null;

        /// <summary>
        /// Gets and sets the property AnalysisRuleTypes. 
        /// <para>
        /// The types of analysis rules associated with this configured table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> AnalysisRuleTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AnalysisRuleTypes property is set.
        /// </summary>
        internal bool IsSetAnalysisRuleTypes() => this.AnalysisRuleTypes != null && (this.AnalysisRuleTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The unique ARN of the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time the configured table was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID of the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configured table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SelectedAnalysisMethods. 
        /// <para>
        ///  The selected analysis methods for the configured table summary.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelectedAnalysisMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SelectedAnalysisMethods property is set.
        /// </summary>
        internal bool IsSetSelectedAnalysisMethods() => this.SelectedAnalysisMethods != null && (this.SelectedAnalysisMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time the configured table was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateTime property is set.
        /// </summary>
        internal bool IsSetUpdateTime() => this.UpdateTime.HasValue;
    }
}
