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
    /// Specifies the configured epsilon value and the utility in terms of total aggregations,
    /// as well as the remaining aggregations available.
    /// </summary>
    public partial class DifferentialPrivacyPrivacyBudget
    {
        private List<DifferentialPrivacyPrivacyBudgetAggregation> _aggregations = AWSConfigs.InitializeCollections ? new List<DifferentialPrivacyPrivacyBudgetAggregation>() : null;
        private int? _epsilon;

        /// <summary>
        /// Gets and sets the property Aggregations. 
        /// <para>
        /// This information includes the configured epsilon value and the utility in terms of
        /// total aggregations, as well as the remaining aggregations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DifferentialPrivacyPrivacyBudgetAggregation> Aggregations
        {
            get { return this._aggregations; }
            set { this._aggregations = value; }
        }

        // Check to see if Aggregations property is set
        internal bool IsSetAggregations()
        {
            return this._aggregations != null && (this._aggregations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Epsilon. 
        /// <para>
        /// The epsilon value that you configured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public int? Epsilon
        {
            get { return this._epsilon; }
            set { this._epsilon = value; }
        }

        // Check to see if Epsilon property is set
        internal bool IsSetEpsilon()
        {
            return this._epsilon.HasValue; 
        }

    }
}