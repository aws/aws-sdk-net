/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides featurization (transformation) information for a dataset field. This object
    /// is part of the <a>FeaturizationConfig</a> object.
    /// 
    ///  
    /// <para>
    /// For example:
    /// </para>
    ///  
    /// <para>
    ///  <code>{</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"AttributeName": "demand",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>FeaturizationPipeline [ {</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"FeaturizationMethodName": "filling",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>"FeaturizationMethodParameters": {"aggregation": "avg", "backfill": "nan"}</code>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <code>} ]</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>}</code> 
    /// </para>
    /// </summary>
    public partial class Featurization
    {
        private string _attributeName;
        private List<FeaturizationMethod> _featurizationPipeline = new List<FeaturizationMethod>();

        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the schema attribute that specifies the data field to be featurized. Amazon
        /// Forecast supports the target field of the <code>TARGET_TIME_SERIES</code> and the
        /// <code>RELATED_TIME_SERIES</code> datasets. For example, for the <code>RETAIL</code>
        /// domain, the target is <code>demand</code>, and for the <code>CUSTOM</code> domain,
        /// the target is <code>target_value</code>. For more information, see <a>howitworks-missing-values</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AttributeName
        {
            get { return this._attributeName; }
            set { this._attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this._attributeName != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturizationPipeline. 
        /// <para>
        /// An array of one <code>FeaturizationMethod</code> object that specifies the feature
        /// transformation method.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<FeaturizationMethod> FeaturizationPipeline
        {
            get { return this._featurizationPipeline; }
            set { this._featurizationPipeline = value; }
        }

        // Check to see if FeaturizationPipeline property is set
        internal bool IsSetFeaturizationPipeline()
        {
            return this._featurizationPipeline != null && this._featurizationPipeline.Count > 0; 
        }

    }
}