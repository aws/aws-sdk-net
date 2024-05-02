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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Describes the properties for hyperparameter optimization (HPO).
    /// </summary>
    public partial class HPOConfig
    {
        private HyperParameterRanges _algorithmHyperParameterRanges;
        private HPOObjective _hpoObjective;
        private HPOResourceConfig _hpoResourceConfig;

        /// <summary>
        /// Gets and sets the property AlgorithmHyperParameterRanges. 
        /// <para>
        /// The hyperparameters and their allowable ranges.
        /// </para>
        /// </summary>
        public HyperParameterRanges AlgorithmHyperParameterRanges
        {
            get { return this._algorithmHyperParameterRanges; }
            set { this._algorithmHyperParameterRanges = value; }
        }

        // Check to see if AlgorithmHyperParameterRanges property is set
        internal bool IsSetAlgorithmHyperParameterRanges()
        {
            return this._algorithmHyperParameterRanges != null;
        }

        /// <summary>
        /// Gets and sets the property HpoObjective. 
        /// <para>
        /// The metric to optimize during HPO.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Personalize doesn't support configuring the <c>hpoObjective</c> at this time.
        /// </para>
        ///  </note>
        /// </summary>
        public HPOObjective HpoObjective
        {
            get { return this._hpoObjective; }
            set { this._hpoObjective = value; }
        }

        // Check to see if HpoObjective property is set
        internal bool IsSetHpoObjective()
        {
            return this._hpoObjective != null;
        }

        /// <summary>
        /// Gets and sets the property HpoResourceConfig. 
        /// <para>
        /// Describes the resource configuration for HPO.
        /// </para>
        /// </summary>
        public HPOResourceConfig HpoResourceConfig
        {
            get { return this._hpoResourceConfig; }
            set { this._hpoResourceConfig = value; }
        }

        // Check to see if HpoResourceConfig property is set
        internal bool IsSetHpoResourceConfig()
        {
            return this._hpoResourceConfig != null;
        }

    }
}