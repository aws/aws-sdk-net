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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides aggregated statistical data for sensitive data discovery metrics that apply
    /// to S3 buckets, grouped by bucket sensitivity score (sensitivityScore). If automated
    /// sensitive data discovery is currently disabled for your account, the value for each
    /// metric is 0.
    /// </summary>
    public partial class BucketStatisticsBySensitivity
    {
        private SensitivityAggregations _classificationError;
        private SensitivityAggregations _notClassified;
        private SensitivityAggregations _notSensitive;
        private SensitivityAggregations _sensitive;

        /// <summary>
        /// Gets and sets the property ClassificationError. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of -1.
        /// </para>
        /// </summary>
        public SensitivityAggregations ClassificationError
        {
            get { return this._classificationError; }
            set { this._classificationError = value; }
        }

        // Check to see if ClassificationError property is set
        internal bool IsSetClassificationError()
        {
            return this._classificationError != null;
        }

        /// <summary>
        /// Gets and sets the property NotClassified. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of 50.
        /// </para>
        /// </summary>
        public SensitivityAggregations NotClassified
        {
            get { return this._notClassified; }
            set { this._notClassified = value; }
        }

        // Check to see if NotClassified property is set
        internal bool IsSetNotClassified()
        {
            return this._notClassified != null;
        }

        /// <summary>
        /// Gets and sets the property NotSensitive. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of 1-49.
        /// </para>
        /// </summary>
        public SensitivityAggregations NotSensitive
        {
            get { return this._notSensitive; }
            set { this._notSensitive = value; }
        }

        // Check to see if NotSensitive property is set
        internal bool IsSetNotSensitive()
        {
            return this._notSensitive != null;
        }

        /// <summary>
        /// Gets and sets the property Sensitive. 
        /// <para>
        /// The aggregated statistical data for all buckets that have a sensitivity score of 51-100.
        /// </para>
        /// </summary>
        public SensitivityAggregations Sensitive
        {
            get { return this._sensitive; }
            set { this._sensitive = value; }
        }

        // Check to see if Sensitive property is set
        internal bool IsSetSensitive()
        {
            return this._sensitive != null;
        }

    }
}