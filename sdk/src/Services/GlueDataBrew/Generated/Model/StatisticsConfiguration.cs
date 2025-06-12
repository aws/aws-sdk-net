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
    /// Configuration of evaluations for a profile job. This configuration can be used to
    /// select evaluations and override the parameters of selected evaluations.
    /// </summary>
    public partial class StatisticsConfiguration
    {
        private List<string> _includedStatistics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<StatisticOverride> _overrides = AWSConfigs.InitializeCollections ? new List<StatisticOverride>() : null;

        /// <summary>
        /// Gets and sets the property IncludedStatistics. 
        /// <para>
        /// List of included evaluations. When the list is undefined, all supported evaluations
        /// will be included.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> IncludedStatistics
        {
            get { return this._includedStatistics; }
            set { this._includedStatistics = value; }
        }

        // Check to see if IncludedStatistics property is set
        internal bool IsSetIncludedStatistics()
        {
            return this._includedStatistics != null && (this._includedStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// List of overrides for evaluations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<StatisticOverride> Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null && (this._overrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}