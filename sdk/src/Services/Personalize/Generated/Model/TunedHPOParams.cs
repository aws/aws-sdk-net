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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// If hyperparameter optimization (HPO) was performed, contains the hyperparameter values
    /// of the best performing model.
    /// </summary>
    public partial class TunedHPOParams
    {
        private Dictionary<string, string> _algorithmHyperParameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AlgorithmHyperParameters. 
        /// <para>
        /// A list of the hyperparameter values of the best performing model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, string> AlgorithmHyperParameters
        {
            get { return this._algorithmHyperParameters; }
            set { this._algorithmHyperParameters = value; }
        }

        // Check to see if AlgorithmHyperParameters property is set
        internal bool IsSetAlgorithmHyperParameters()
        {
            return this._algorithmHyperParameters != null && this._algorithmHyperParameters.Count > 0; 
        }

    }
}