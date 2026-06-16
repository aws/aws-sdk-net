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
 * Do not modify this file. This file is generated from the sustainability-2018-05-10.normal.json service model.
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
namespace Amazon.Sustainability.Model
{
    /// <summary>
    /// Contains estimated carbon emissions data for a specific time period and dimension
    /// grouping.
    /// </summary>
    public partial class EstimatedCarbonEmissions
    {
        private Dictionary<string, string> _dimensionsValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, Emissions> _emissionsValues = AWSConfigs.InitializeCollections ? new Dictionary<string, Emissions>() : null;
        private string _modelVersion;
        private TimePeriod _timePeriod;

        /// <summary>
        /// Gets and sets the property DimensionsValues. 
        /// <para>
        /// The dimensions used to group emissions values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> DimensionsValues
        {
            get { return this._dimensionsValues; }
            set { this._dimensionsValues = value; }
        }

        // Check to see if DimensionsValues property is set
        internal bool IsSetDimensionsValues()
        {
            return this._dimensionsValues != null && (this._dimensionsValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EmissionsValues. 
        /// <para>
        /// The emissions values for the requested emissions types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, Emissions> EmissionsValues
        {
            get { return this._emissionsValues; }
            set { this._emissionsValues = value; }
        }

        // Check to see if EmissionsValues property is set
        internal bool IsSetEmissionsValues()
        {
            return this._emissionsValues != null && (this._emissionsValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The semantic version-formatted string that indicates the methodology version used
        /// to calculate the emission values. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  The AWS Sustainability service reflects the most recent model version for every month.
        /// You will not see two entries for the same month with different <c>ModelVersion</c>
        /// values. To track the evolution of the methodology and compare emission values from
        /// previous versions, we recommend creating a <a href="https://docs.aws.amazon.com/cur/latest/userguide/what-is-data-exports.html">Data
        /// Export</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The reporting period for emission values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimePeriod TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}