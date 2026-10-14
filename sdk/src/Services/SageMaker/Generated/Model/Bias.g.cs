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
    /// Contains bias metrics for a model.
    /// </summary>
    public partial class Bias
    {
        /// <summary>
        /// Gets and sets the property PostTrainingReport. 
        /// <para>
        /// The post-training bias report for a model.
        /// </para>
        /// </summary>
        public MetricsSource PostTrainingReport { get; set; }

        /// <summary>
        /// Checks to see if the PostTrainingReport property is set.
        /// </summary>
        internal bool IsSetPostTrainingReport() => this.PostTrainingReport != null;

        /// <summary>
        /// Gets and sets the property PreTrainingReport. 
        /// <para>
        /// The pre-training bias report for a model.
        /// </para>
        /// </summary>
        public MetricsSource PreTrainingReport { get; set; }

        /// <summary>
        /// Checks to see if the PreTrainingReport property is set.
        /// </summary>
        internal bool IsSetPreTrainingReport() => this.PreTrainingReport != null;

        /// <summary>
        /// Gets and sets the property Report. 
        /// <para>
        /// The bias report for a model
        /// </para>
        /// </summary>
        public MetricsSource Report { get; set; }

        /// <summary>
        /// Checks to see if the Report property is set.
        /// </summary>
        internal bool IsSetReport() => this.Report != null;
    }
}
