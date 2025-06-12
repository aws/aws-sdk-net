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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Filters configuration recorders by recording scope.
    /// </summary>
    public partial class ConfigurationRecorderFilter
    {
        private ConfigurationRecorderFilterName _filterName;
        private List<string> _filterValue = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The name of the type of filter. Currently, only <c>recordingScope</c> is supported.
        /// </para>
        /// </summary>
        public ConfigurationRecorderFilterName FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterValue. 
        /// <para>
        /// The value of the filter. For <c>recordingScope</c>, valid values include: <c>INTERNAL</c>
        /// and <c>PAID</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>INTERNAL</c> indicates that the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ConfigurationItem.html">ConfigurationItems</a>
        /// in scope for the configuration recorder are recorded for free.
        /// </para>
        ///  
        /// <para>
        ///  <c>PAID</c> indicates that the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_ConfigurationItem.html">ConfigurationItems</a>
        /// in scope for the configuration recorder impact the costs to your bill.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FilterValue
        {
            get { return this._filterValue; }
            set { this._filterValue = value; }
        }

        // Check to see if FilterValue property is set
        internal bool IsSetFilterValue()
        {
            return this._filterValue != null && (this._filterValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}