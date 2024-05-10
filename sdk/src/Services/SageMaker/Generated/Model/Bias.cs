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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private MetricsSource _postTrainingReport;
        private MetricsSource _preTrainingReport;
        private MetricsSource _report;

        /// <summary>
        /// Gets and sets the property PostTrainingReport. 
        /// <para>
        /// The post-training bias report for a model.
        /// </para>
        /// </summary>
        public MetricsSource PostTrainingReport
        {
            get { return this._postTrainingReport; }
            set { this._postTrainingReport = value; }
        }

        // Check to see if PostTrainingReport property is set
        internal bool IsSetPostTrainingReport()
        {
            return this._postTrainingReport != null;
        }

        /// <summary>
        /// Gets and sets the property PreTrainingReport. 
        /// <para>
        /// The pre-training bias report for a model.
        /// </para>
        /// </summary>
        public MetricsSource PreTrainingReport
        {
            get { return this._preTrainingReport; }
            set { this._preTrainingReport = value; }
        }

        // Check to see if PreTrainingReport property is set
        internal bool IsSetPreTrainingReport()
        {
            return this._preTrainingReport != null;
        }

        /// <summary>
        /// Gets and sets the property Report. 
        /// <para>
        /// The bias report for a model
        /// </para>
        /// </summary>
        public MetricsSource Report
        {
            get { return this._report; }
            set { this._report = value; }
        }

        // Check to see if Report property is set
        internal bool IsSetReport()
        {
            return this._report != null;
        }

    }
}