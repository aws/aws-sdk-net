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
    /// The metadata that you can use to filter and group your results. You can use <c>GetDimensionValues</c>
    /// to find specific values.
    /// </summary>
    public partial class DimensionValues
    {
        private Dimension _key;
        private List<string> _matchOptions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The names of the metadata types that you can use to filter and group your results.
        /// For example, <c>AZ</c> returns a list of Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// Not all dimensions are supported in each API. Refer to the documentation for each
        /// specific API to see what is supported.
        /// </para>
        ///  
        /// <para>
        ///  <c>LINKED_ACCOUNT_NAME</c> and <c>SERVICE_CODE</c> can only be used in <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_CostCategoryRule.html">CostCategoryRule</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ANOMALY_TOTAL_IMPACT_ABSOLUTE</c> and <c>ANOMALY_TOTAL_IMPACT_PERCENTAGE</c> can
        /// only be used in <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_AnomalySubscription.html">AnomalySubscriptions</a>.
        /// </para>
        /// </summary>
        public Dimension Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property MatchOptions. 
        /// <para>
        /// The match options that you can use to filter your results.
        /// </para>
        ///  
        /// <para>
        ///  <c>MatchOptions</c> is only applicable for actions related to Cost Category and Anomaly
        /// Subscriptions. Refer to the documentation for each specific API to see what is supported.
        /// </para>
        ///  
        /// <para>
        /// The default values for <c>MatchOptions</c> are <c>EQUALS</c> and <c>CASE_SENSITIVE</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchOptions
        {
            get { return this._matchOptions; }
            set { this._matchOptions = value; }
        }

        // Check to see if MatchOptions property is set
        internal bool IsSetMatchOptions()
        {
            return this._matchOptions != null && (this._matchOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// The metadata values that you can use to filter and group your results. You can use
        /// <c>GetDimensionValues</c> to find specific values.
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