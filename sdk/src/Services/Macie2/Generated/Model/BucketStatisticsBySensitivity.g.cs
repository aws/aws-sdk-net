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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides aggregated statistical data for sensitive data discovery metrics that apply
    /// to S3 buckets, grouped by bucket sensitivity score (sensitivityScore). If automated
    /// sensitive data discovery is currently disabled for your account, the value for most
    /// of these metrics is 0.
    /// </summary>
    public partial class BucketStatisticsBySensitivity
    {
        /// <summary>
        /// Gets and sets the property ClassificationError. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of -1.
        /// </para>
        /// </summary>
        public SensitivityAggregations ClassificationError { get; set; }

        /// <summary>
        /// Checks to see if the ClassificationError property is set.
        /// </summary>
        internal bool IsSetClassificationError() => this.ClassificationError != null;

        /// <summary>
        /// Gets and sets the property NotClassified. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of 50.
        /// </para>
        /// </summary>
        public SensitivityAggregations NotClassified { get; set; }

        /// <summary>
        /// Checks to see if the NotClassified property is set.
        /// </summary>
        internal bool IsSetNotClassified() => this.NotClassified != null;

        /// <summary>
        /// Gets and sets the property NotSensitive. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of 1-49.
        /// </para>
        /// </summary>
        public SensitivityAggregations NotSensitive { get; set; }

        /// <summary>
        /// Checks to see if the NotSensitive property is set.
        /// </summary>
        internal bool IsSetNotSensitive() => this.NotSensitive != null;

        /// <summary>
        /// Gets and sets the property Sensitive. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of 51-100.
        /// </para>
        /// </summary>
        public SensitivityAggregations Sensitive { get; set; }

        /// <summary>
        /// Checks to see if the Sensitive property is set.
        /// </summary>
        internal bool IsSetSensitive() => this.Sensitive != null;
    }
}
