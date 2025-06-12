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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
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
namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Measurements of how well the <c>MLModel</c> performed on known observations. One of
    /// the following metrics is returned, based on the type of the <c>MLModel</c>: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// BinaryAUC: The binary <c>MLModel</c> uses the Area Under the Curve (AUC) technique
    /// to measure performance. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// RegressionRMSE: The regression <c>MLModel</c> uses the Root Mean Square Error (RMSE)
    /// technique to measure performance. RMSE measures the difference between predicted and
    /// actual values for a single variable.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MulticlassAvgFScore: The multiclass <c>MLModel</c> uses the F1 score technique to
    /// measure performance. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information about performance metrics, please see the <a href="https://docs.aws.amazon.com/machine-learning/latest/dg">Amazon
    /// Machine Learning Developer Guide</a>. 
    /// </para>
    /// </summary>
    public partial class PerformanceMetrics
    {
        private Dictionary<string, string> _properties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Properties.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && (this._properties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}