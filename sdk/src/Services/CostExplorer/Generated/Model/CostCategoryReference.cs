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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// A reference to a Cost Category containing only enough information to identify the
    /// Cost Category.
    /// 
    ///  
    /// <para>
    /// You can use this information to retrieve the full Cost Category information using
    /// <c>DescribeCostCategory</c>.
    /// </para>
    /// </summary>
    public partial class CostCategoryReference
    {
        private string _costCategoryArn;
        private string _defaultValue;
        private string _effectiveEnd;
        private string _effectiveStart;
        private string _name;
        private int? _numberOfRules;
        private List<CostCategoryProcessingStatus> _processingStatus = AWSConfigs.InitializeCollections ? new List<CostCategoryProcessingStatus>() : null;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        /// The unique identifier for your Cost Category. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CostCategoryArn
        {
            get { return this._costCategoryArn; }
            set { this._costCategoryArn = value; }
        }

        // Check to see if CostCategoryArn property is set
        internal bool IsSetCostCategoryArn()
        {
            return this._costCategoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultValue.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string DefaultValue
        {
            get { return this._defaultValue; }
            set { this._defaultValue = value; }
        }

        // Check to see if DefaultValue property is set
        internal bool IsSetDefaultValue()
        {
            return this._defaultValue != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveEnd. 
        /// <para>
        /// The Cost Category's effective end date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EffectiveEnd
        {
            get { return this._effectiveEnd; }
            set { this._effectiveEnd = value; }
        }

        // Check to see if EffectiveEnd property is set
        internal bool IsSetEffectiveEnd()
        {
            return this._effectiveEnd != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        /// The Cost Category's effective start date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EffectiveStart
        {
            get { return this._effectiveStart; }
            set { this._effectiveStart = value; }
        }

        // Check to see if EffectiveStart property is set
        internal bool IsSetEffectiveStart()
        {
            return this._effectiveStart != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfRules. 
        /// <para>
        /// The number of rules that are associated with a specific Cost Category. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? NumberOfRules
        {
            get { return this._numberOfRules; }
            set { this._numberOfRules = value; }
        }

        // Check to see if NumberOfRules property is set
        internal bool IsSetNumberOfRules()
        {
            return this._numberOfRules.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessingStatus. 
        /// <para>
        /// The list of processing statuses for Cost Management products for a specific cost category.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CostCategoryProcessingStatus> ProcessingStatus
        {
            get { return this._processingStatus; }
            set { this._processingStatus = value; }
        }

        // Check to see if ProcessingStatus property is set
        internal bool IsSetProcessingStatus()
        {
            return this._processingStatus != null && (this._processingStatus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// A list of unique cost category values in a specific cost category. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}