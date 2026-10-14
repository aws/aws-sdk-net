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
    /// Model quality statistics and constraints.
    /// </summary>
    public partial class ModelQuality
    {
        /// <summary>
        /// Gets and sets the property Constraints. 
        /// <para>
        /// Model quality constraints.
        /// </para>
        /// </summary>
        public MetricsSource Constraints { get; set; }

        /// <summary>
        /// Checks to see if the Constraints property is set.
        /// </summary>
        internal bool IsSetConstraints() => this.Constraints != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Model quality statistics.
        /// </para>
        /// </summary>
        public MetricsSource Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;
    }
}
