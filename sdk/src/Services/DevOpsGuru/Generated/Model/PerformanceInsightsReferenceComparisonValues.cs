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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Reference scalar values and other metrics that DevOps Guru displays on a graph in
    /// its console along with the actual metrics it analyzed. Compare these reference values
    /// to your actual metrics to help you understand anomalous behavior that DevOps Guru
    /// detected.
    /// </summary>
    public partial class PerformanceInsightsReferenceComparisonValues
    {
        private PerformanceInsightsReferenceMetric _referenceMetric;
        private PerformanceInsightsReferenceScalar _referenceScalar;

        /// <summary>
        /// Gets and sets the property ReferenceMetric. 
        /// <para>
        /// A metric that DevOps Guru compares to actual metric values. This reference metric
        /// is used to determine if an actual metric should be considered anomalous.
        /// </para>
        /// </summary>
        public PerformanceInsightsReferenceMetric ReferenceMetric
        {
            get { return this._referenceMetric; }
            set { this._referenceMetric = value; }
        }

        // Check to see if ReferenceMetric property is set
        internal bool IsSetReferenceMetric()
        {
            return this._referenceMetric != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceScalar. 
        /// <para>
        /// A scalar value DevOps Guru for a metric that DevOps Guru compares to actual metric
        /// values. This reference value is used to determine if an actual metric value should
        /// be considered anomalous.
        /// </para>
        /// </summary>
        public PerformanceInsightsReferenceScalar ReferenceScalar
        {
            get { return this._referenceScalar; }
            set { this._referenceScalar = value; }
        }

        // Check to see if ReferenceScalar property is set
        internal bool IsSetReferenceScalar()
        {
            return this._referenceScalar != null;
        }

    }
}