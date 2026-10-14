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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Use the split charge rule to split the cost of one cost category value across several
    /// other target values.
    /// </summary>
    public partial class CostCategorySplitChargeRule
    {
        /// <summary>
        /// Gets and sets the property Method. 
        /// <para>
        /// The method that's used to define how to split your source costs across your targets.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <c>Proportional</c> - Allocates charges across your targets based on the proportional
        /// weighted cost of each target.
        /// </para>
        ///  
        /// <para>
        ///  <c>Fixed</c> - Allocates charges across your targets based on your defined allocation
        /// percentage.
        /// </para>
        ///  
        /// <para>
        /// ><c>Even</c> - Allocates costs evenly across all targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CostCategorySplitChargeMethod Method { get; set; }

        /// <summary>
        /// Checks to see if the Method property is set.
        /// </summary>
        internal bool IsSetMethod() => this.Method != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for a split charge method. This is only required for the <c>FIXED</c>
        /// method. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<CostCategorySplitChargeRuleParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new List<CostCategorySplitChargeRuleParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The cost category value that you want to split. That value can't be used as a source
        /// or a target in other split charge rules. To indicate uncategorized costs, you can
        /// use an empty string as the source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The cost category values that you want to split costs across. These values can't be
        /// used as a source in other split charge rules. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public List<string> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
