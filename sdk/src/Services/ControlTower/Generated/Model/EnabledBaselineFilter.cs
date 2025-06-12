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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// A filter applied on the <c>ListEnabledBaseline</c> operation. Allowed filters are
    /// <c>baselineIdentifiers</c> and <c>targetIdentifiers</c>. The filter can be applied
    /// for either, or both.
    /// </summary>
    public partial class EnabledBaselineFilter
    {
        private List<string> _baselineIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _inheritanceDriftStatuses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _parentIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _statuses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _targetIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BaselineIdentifiers. 
        /// <para>
        /// Identifiers for the <c>Baseline</c> objects returned as part of the filter operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> BaselineIdentifiers
        {
            get { return this._baselineIdentifiers; }
            set { this._baselineIdentifiers = value; }
        }

        // Check to see if BaselineIdentifiers property is set
        internal bool IsSetBaselineIdentifiers()
        {
            return this._baselineIdentifiers != null && (this._baselineIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InheritanceDriftStatuses. 
        /// <para>
        /// A list of <c>EnabledBaselineDriftStatus</c> items for enabled baselines.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> InheritanceDriftStatuses
        {
            get { return this._inheritanceDriftStatuses; }
            set { this._inheritanceDriftStatuses = value; }
        }

        // Check to see if InheritanceDriftStatuses property is set
        internal bool IsSetInheritanceDriftStatuses()
        {
            return this._inheritanceDriftStatuses != null && (this._inheritanceDriftStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParentIdentifiers. 
        /// <para>
        /// An optional filter that sets up a list of <c>parentIdentifiers</c> to filter the results
        /// of the <c>ListEnabledBaseline</c> output.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> ParentIdentifiers
        {
            get { return this._parentIdentifiers; }
            set { this._parentIdentifiers = value; }
        }

        // Check to see if ParentIdentifiers property is set
        internal bool IsSetParentIdentifiers()
        {
            return this._parentIdentifiers != null && (this._parentIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// A list of <c>EnablementStatus</c> items.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetIdentifiers. 
        /// <para>
        /// Identifiers for the targets of the <c>Baseline</c> filter operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> TargetIdentifiers
        {
            get { return this._targetIdentifiers; }
            set { this._targetIdentifiers = value; }
        }

        // Check to see if TargetIdentifiers property is set
        internal bool IsSetTargetIdentifiers()
        {
            return this._targetIdentifiers != null && (this._targetIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}