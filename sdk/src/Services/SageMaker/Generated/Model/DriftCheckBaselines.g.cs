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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Represents the drift check baselines that can be used when the model monitor is set
    /// using the model package.
    /// </summary>
    public partial class DriftCheckBaselines
    {
        /// <summary>
        /// Gets and sets the property Bias. 
        /// <para>
        /// Represents the drift check bias baselines that can be used when the model monitor
        /// is set using the model package. 
        /// </para>
        /// </summary>
        public DriftCheckBias Bias { get; set; }

        /// <summary>
        /// Checks to see if the Bias property is set.
        /// </summary>
        internal bool IsSetBias() => this.Bias != null;

        /// <summary>
        /// Gets and sets the property Explainability. 
        /// <para>
        /// Represents the drift check explainability baselines that can be used when the model
        /// monitor is set using the model package. 
        /// </para>
        /// </summary>
        public DriftCheckExplainability Explainability { get; set; }

        /// <summary>
        /// Checks to see if the Explainability property is set.
        /// </summary>
        internal bool IsSetExplainability() => this.Explainability != null;

        /// <summary>
        /// Gets and sets the property ModelDataQuality. 
        /// <para>
        /// Represents the drift check model data quality baselines that can be used when the
        /// model monitor is set using the model package.
        /// </para>
        /// </summary>
        public DriftCheckModelDataQuality ModelDataQuality { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataQuality property is set.
        /// </summary>
        internal bool IsSetModelDataQuality() => this.ModelDataQuality != null;

        /// <summary>
        /// Gets and sets the property ModelQuality. 
        /// <para>
        /// Represents the drift check model quality baselines that can be used when the model
        /// monitor is set using the model package.
        /// </para>
        /// </summary>
        public DriftCheckModelQuality ModelQuality { get; set; }

        /// <summary>
        /// Checks to see if the ModelQuality property is set.
        /// </summary>
        internal bool IsSetModelQuality() => this.ModelQuality != null;
    }
}
