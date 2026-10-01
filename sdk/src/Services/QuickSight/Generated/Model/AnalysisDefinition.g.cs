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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The definition of an analysis.
    /// </summary>
    public partial class AnalysisDefinition
    {
        /// <summary>
        /// Gets and sets the property AnalysisDefaults.
        /// </summary>
        public AnalysisDefaults AnalysisDefaults { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisDefaults property is set.
        /// </summary>
        internal bool IsSetAnalysisDefaults() => this.AnalysisDefaults != null;

        /// <summary>
        /// Gets and sets the property CalculatedFields. 
        /// <para>
        /// An array of calculated field definitions for the analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<CalculatedField> CalculatedFields { get; set; } = AWSConfigs.InitializeCollections ? new List<CalculatedField>() : null;

        /// <summary>
        /// Checks to see if the CalculatedFields property is set.
        /// </summary>
        internal bool IsSetCalculatedFields() => this.CalculatedFields != null && (this.CalculatedFields.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ColumnConfigurations. 
        /// <para>
        ///  An array of analysis-level column configurations. Column configurations can be used
        /// to set default formatting for a column to be used throughout an analysis. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<ColumnConfiguration> ColumnConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ColumnConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ColumnConfigurations property is set.
        /// </summary>
        internal bool IsSetColumnConfigurations() => this.ColumnConfigurations != null && (this.ColumnConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataSetIdentifierDeclarations. 
        /// <para>
        /// An array of dataset identifier declarations. This mapping allows the usage of dataset
        /// identifiers instead of dataset ARNs throughout analysis sub-structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 50)]
        public List<DataSetIdentifierDeclaration> DataSetIdentifierDeclarations { get; set; } = AWSConfigs.InitializeCollections ? new List<DataSetIdentifierDeclaration>() : null;

        /// <summary>
        /// Checks to see if the DataSetIdentifierDeclarations property is set.
        /// </summary>
        internal bool IsSetDataSetIdentifierDeclarations() => this.DataSetIdentifierDeclarations != null && (this.DataSetIdentifierDeclarations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilterGroups. 
        /// <para>
        /// Filter definitions for an analysis.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/adding-a-filter.html">Filtering
        /// Data in Amazon Quick Sight</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000)]
        public List<FilterGroup> FilterGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<FilterGroup>() : null;

        /// <summary>
        /// Checks to see if the FilterGroups property is set.
        /// </summary>
        internal bool IsSetFilterGroups() => this.FilterGroups != null && (this.FilterGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// An array of option definitions for an analysis.
        /// </para>
        /// </summary>
        public AssetOptions Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property ParameterDeclarations. 
        /// <para>
        /// An array of parameter declarations for an analysis.
        /// </para>
        ///  
        /// <para>
        /// Parameters are named variables that can transfer a value for use by an action or an
        /// object.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/quicksight/latest/user/parameters-in-quicksight.html">Parameters
        /// in Amazon Quick Sight</a> in the <i>Amazon Quick Suite User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public List<ParameterDeclaration> ParameterDeclarations { get; set; } = AWSConfigs.InitializeCollections ? new List<ParameterDeclaration>() : null;

        /// <summary>
        /// Checks to see if the ParameterDeclarations property is set.
        /// </summary>
        internal bool IsSetParameterDeclarations() => this.ParameterDeclarations != null && (this.ParameterDeclarations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryExecutionOptions.
        /// </summary>
        public QueryExecutionOptions QueryExecutionOptions { get; set; }

        /// <summary>
        /// Checks to see if the QueryExecutionOptions property is set.
        /// </summary>
        internal bool IsSetQueryExecutionOptions() => this.QueryExecutionOptions != null;

        /// <summary>
        /// Gets and sets the property Sheets. 
        /// <para>
        /// An array of sheet definitions for an analysis. Each <c>SheetDefinition</c> provides
        /// detailed information about a sheet within this analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<SheetDefinition> Sheets { get; set; } = AWSConfigs.InitializeCollections ? new List<SheetDefinition>() : null;

        /// <summary>
        /// Checks to see if the Sheets property is set.
        /// </summary>
        internal bool IsSetSheets() => this.Sheets != null && (this.Sheets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StaticFiles. 
        /// <para>
        /// The static files for the definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<StaticFile> StaticFiles { get; set; } = AWSConfigs.InitializeCollections ? new List<StaticFile>() : null;

        /// <summary>
        /// Checks to see if the StaticFiles property is set.
        /// </summary>
        internal bool IsSetStaticFiles() => this.StaticFiles != null && (this.StaticFiles.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TooltipSheets. 
        /// <para>
        /// An array of tooltip sheet definitions for an analysis. Each <c>TooltipSheetDefinition</c>
        /// provides detailed information about a tooltip sheet within this analysis.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TooltipSheetDefinition> TooltipSheets { get; set; } = AWSConfigs.InitializeCollections ? new List<TooltipSheetDefinition>() : null;

        /// <summary>
        /// Checks to see if the TooltipSheets property is set.
        /// </summary>
        internal bool IsSetTooltipSheets() => this.TooltipSheets != null && (this.TooltipSheets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopicIdentifierDeclarations. 
        /// <para>
        /// An array of topic identifier declarations. This mapping allows the usage of topic
        /// identifiers instead of topic ARNs throughout analysis sub-structures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<TopicIdentifierDeclaration> TopicIdentifierDeclarations { get; set; } = AWSConfigs.InitializeCollections ? new List<TopicIdentifierDeclaration>() : null;

        /// <summary>
        /// Checks to see if the TopicIdentifierDeclarations property is set.
        /// </summary>
        internal bool IsSetTopicIdentifierDeclarations() => this.TopicIdentifierDeclarations != null && (this.TopicIdentifierDeclarations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
