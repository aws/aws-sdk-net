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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
    /// Controls on the analysis specifications that can be run on a configured table.
    /// </summary>
    public partial class ConsolidatedPolicyAggregation
    {
        private AdditionalAnalyses _additionalAnalyses;
        private List<AggregateColumn> _aggregateColumns = AWSConfigs.InitializeCollections ? new List<AggregateColumn>() : null;
        private List<string> _allowedAdditionalAnalyses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedJoinOperators = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _allowedResultReceivers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _dimensionColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _joinColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private JoinRequiredOption _joinRequired;
        private List<AggregationConstraint> _outputConstraints = AWSConfigs.InitializeCollections ? new List<AggregationConstraint>() : null;
        private List<string> _scalarFunctions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AdditionalAnalyses. 
        /// <para>
        ///  Additional analyses for the consolidated policy aggregation.
        /// </para>
        /// </summary>
        public AdditionalAnalyses AdditionalAnalyses
        {
            get { return this._additionalAnalyses; }
            set { this._additionalAnalyses = value; }
        }

        // Check to see if AdditionalAnalyses property is set
        internal bool IsSetAdditionalAnalyses()
        {
            return this._additionalAnalyses != null;
        }

        /// <summary>
        /// Gets and sets the property AggregateColumns. 
        /// <para>
        ///  Aggregate columns in consolidated policy aggregation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AggregateColumn> AggregateColumns
        {
            get { return this._aggregateColumns; }
            set { this._aggregateColumns = value; }
        }

        // Check to see if AggregateColumns property is set
        internal bool IsSetAggregateColumns()
        {
            return this._aggregateColumns != null && (this._aggregateColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedAdditionalAnalyses. 
        /// <para>
        ///  The additional analyses allowed by the consolidated policy aggregation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=25)]
        public List<string> AllowedAdditionalAnalyses
        {
            get { return this._allowedAdditionalAnalyses; }
            set { this._allowedAdditionalAnalyses = value; }
        }

        // Check to see if AllowedAdditionalAnalyses property is set
        internal bool IsSetAllowedAdditionalAnalyses()
        {
            return this._allowedAdditionalAnalyses != null && (this._allowedAdditionalAnalyses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedJoinOperators. 
        /// <para>
        ///  The allowed join operators.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> AllowedJoinOperators
        {
            get { return this._allowedJoinOperators; }
            set { this._allowedJoinOperators = value; }
        }

        // Check to see if AllowedJoinOperators property is set
        internal bool IsSetAllowedJoinOperators()
        {
            return this._allowedJoinOperators != null && (this._allowedJoinOperators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AllowedResultReceivers. 
        /// <para>
        ///  The allowed result receivers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AllowedResultReceivers
        {
            get { return this._allowedResultReceivers; }
            set { this._allowedResultReceivers = value; }
        }

        // Check to see if AllowedResultReceivers property is set
        internal bool IsSetAllowedResultReceivers()
        {
            return this._allowedResultReceivers != null && (this._allowedResultReceivers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DimensionColumns. 
        /// <para>
        ///  The dimension columns of the consolidated policy aggregation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DimensionColumns
        {
            get { return this._dimensionColumns; }
            set { this._dimensionColumns = value; }
        }

        // Check to see if DimensionColumns property is set
        internal bool IsSetDimensionColumns()
        {
            return this._dimensionColumns != null && (this._dimensionColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        ///  The columns to join on.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> JoinColumns
        {
            get { return this._joinColumns; }
            set { this._joinColumns = value; }
        }

        // Check to see if JoinColumns property is set
        internal bool IsSetJoinColumns()
        {
            return this._joinColumns != null && (this._joinColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JoinRequired. 
        /// <para>
        ///  Join required
        /// </para>
        /// </summary>
        public JoinRequiredOption JoinRequired
        {
            get { return this._joinRequired; }
            set { this._joinRequired = value; }
        }

        // Check to see if JoinRequired property is set
        internal bool IsSetJoinRequired()
        {
            return this._joinRequired != null;
        }

        /// <summary>
        /// Gets and sets the property OutputConstraints. 
        /// <para>
        ///  The output constraints of the consolidated policy aggregation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AggregationConstraint> OutputConstraints
        {
            get { return this._outputConstraints; }
            set { this._outputConstraints = value; }
        }

        // Check to see if OutputConstraints property is set
        internal bool IsSetOutputConstraints()
        {
            return this._outputConstraints != null && (this._outputConstraints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScalarFunctions. 
        /// <para>
        ///  The scalar functions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ScalarFunctions
        {
            get { return this._scalarFunctions; }
            set { this._scalarFunctions = value; }
        }

        // Check to see if ScalarFunctions property is set
        internal bool IsSetScalarFunctions()
        {
            return this._scalarFunctions != null && (this._scalarFunctions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}