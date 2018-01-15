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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The parent object that implements what percentage of traffic will invoke each function
    /// version. For more information, see <a>lambda-traffic-shifting-using-aliases</a>.
    /// </summary>
    public partial class AliasRoutingConfiguration
    {
        private Dictionary<string, double> _additionalVersionWeights = new Dictionary<string, double>();

        /// <summary>
        /// Gets and sets the property AdditionalVersionWeights. 
        /// <para>
        /// Set this value to dictate what percentage of traffic will invoke the updated function
        /// version. If set to an empty string, 100 percent of traffic will invoke <code>function-version</code>.
        /// For more information, see <a>lambda-traffic-shifting-using-aliases</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, double> AdditionalVersionWeights
        {
            get { return this._additionalVersionWeights; }
            set { this._additionalVersionWeights = value; }
        }

        // Check to see if AdditionalVersionWeights property is set
        internal bool IsSetAdditionalVersionWeights()
        {
            return this._additionalVersionWeights != null && this._additionalVersionWeights.Count > 0; 
        }

    }
}