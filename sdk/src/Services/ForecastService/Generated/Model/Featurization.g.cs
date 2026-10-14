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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// <note> 
    /// <para>
    /// This object belongs to the <a>CreatePredictor</a> operation. If you created your predictor
    /// with <a>CreateAutoPredictor</a>, see <a>AttributeConfig</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Provides featurization (transformation) information for a dataset field. This object
    /// is part of the <a>FeaturizationConfig</a> object.
    /// </para>
    ///  
    /// <para>
    /// For example:
    /// </para>
    ///  
    /// <para>
    ///  <c>{</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"AttributeName": "demand",</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>FeaturizationPipeline [ {</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"FeaturizationMethodName": "filling",</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>"FeaturizationMethodParameters": {"aggregation": "avg", "backfill": "nan"}</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>} ]</c> 
    /// </para>
    ///  
    /// <para>
    ///  <c>}</c> 
    /// </para>
    /// </summary>
    public partial class Featurization
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the schema attribute that specifies the data field to be featurized. Amazon
        /// Forecast supports the target field of the <c>TARGET_TIME_SERIES</c> and the <c>RELATED_TIME_SERIES</c>
        /// datasets. For example, for the <c>RETAIL</c> domain, the target is <c>demand</c>,
        /// and for the <c>CUSTOM</c> domain, the target is <c>target_value</c>. For more information,
        /// see <a>howitworks-missing-values</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property FeaturizationPipeline. 
        /// <para>
        /// An array of one <c>FeaturizationMethod</c> object that specifies the feature transformation
        /// method.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1)]
        public List<FeaturizationMethod> FeaturizationPipeline { get; set; } = AWSConfigs.InitializeCollections ? new List<FeaturizationMethod>() : null;

        /// <summary>
        /// Checks to see if the FeaturizationPipeline property is set.
        /// </summary>
        internal bool IsSetFeaturizationPipeline() => this.FeaturizationPipeline != null && (this.FeaturizationPipeline.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
