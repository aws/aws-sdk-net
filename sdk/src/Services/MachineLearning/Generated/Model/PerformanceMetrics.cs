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
 * Do not modify this file. This file is generated from the machinelearning-2014-12-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Model
{
    /// <summary>
    /// Measurements of how well the <code>MLModel</code> performed on known observations.
    /// One of the following metrics is returned, based on the type of the <code>MLModel</code>:
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// BinaryAUC: The binary <code>MLModel</code> uses the Area Under the Curve (AUC) technique
    /// to measure performance. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// RegressionRMSE: The regression <code>MLModel</code> uses the Root Mean Square Error
    /// (RMSE) technique to measure performance. RMSE measures the difference between predicted
    /// and actual values for a single variable.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MulticlassAvgFScore: The multiclass <code>MLModel</code> uses the F1 score technique
    /// to measure performance. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For more information about performance metrics, please see the <a href="http://docs.aws.amazon.com/machine-learning/latest/dg">Amazon
    /// Machine Learning Developer Guide</a>. 
    /// </para>
    /// </summary>
    public partial class PerformanceMetrics
    {
        private Dictionary<string, string> _properties = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Properties.
        /// </summary>
        public Dictionary<string, string> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        // Check to see if Properties property is set
        internal bool IsSetProperties()
        {
            return this._properties != null && this._properties.Count > 0; 
        }

    }
}