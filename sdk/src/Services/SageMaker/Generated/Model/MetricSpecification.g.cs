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
    /// An object containing information about a metric.
    /// </summary>
    public partial class MetricSpecification
    {
        /// <summary>
        /// Gets and sets the property Customized. 
        /// <para>
        /// Information about a customized metric.
        /// </para>
        /// </summary>
        public CustomizedMetricSpecification Customized { get; set; }

        /// <summary>
        /// Checks to see if the Customized property is set.
        /// </summary>
        internal bool IsSetCustomized() => this.Customized != null;

        /// <summary>
        /// Gets and sets the property Predefined. 
        /// <para>
        /// Information about a predefined metric.
        /// </para>
        /// </summary>
        public PredefinedMetricSpecification Predefined { get; set; }

        /// <summary>
        /// Checks to see if the Predefined property is set.
        /// </summary>
        internal bool IsSetPredefined() => this.Predefined != null;
    }
}
