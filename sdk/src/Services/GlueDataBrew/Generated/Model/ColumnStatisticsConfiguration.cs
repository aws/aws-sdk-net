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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
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
namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Configuration for column evaluations for a profile job. ColumnStatisticsConfiguration
    /// can be used to select evaluations and override parameters of evaluations for particular
    /// columns.
    /// </summary>
    public partial class ColumnStatisticsConfiguration
    {
        private List<ColumnSelector> _selectors = AWSConfigs.InitializeCollections ? new List<ColumnSelector>() : null;
        private StatisticsConfiguration _statistics;

        /// <summary>
        /// Gets and sets the property Selectors. 
        /// <para>
        /// List of column selectors. Selectors can be used to select columns from the dataset.
        /// When selectors are undefined, configuration will be applied to all supported columns.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<ColumnSelector> Selectors
        {
            get { return this._selectors; }
            set { this._selectors = value; }
        }

        // Check to see if Selectors property is set
        internal bool IsSetSelectors()
        {
            return this._selectors != null && (this._selectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Configuration for evaluations. Statistics can be used to select evaluations and override
        /// parameters of evaluations. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatisticsConfiguration Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null;
        }

    }
}