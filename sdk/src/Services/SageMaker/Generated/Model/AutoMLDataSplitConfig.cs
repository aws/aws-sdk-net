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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This structure specifies how to split the data into train and validation datasets.
    /// 
    ///  
    /// <para>
    /// If you are using the V1 API (for example <code>CreateAutoMLJob</code>) or the V2 API
    /// for Natural Language Processing problems (for example <code>CreateAutoMLJobV2</code>
    /// with a <code>TextClassificationJobConfig</code> problem type), the validation and
    /// training datasets must contain the same headers. Also, for V1 API jobs, the validation
    /// dataset must be less than 2 GB in size.
    /// </para>
    /// </summary>
    public partial class AutoMLDataSplitConfig
    {
        private float? _validationFraction;

        /// <summary>
        /// Gets and sets the property ValidationFraction. 
        /// <para>
        /// The validation fraction (optional) is a float that specifies the portion of the training
        /// dataset to be used for validation. The default value is 0.2, and values must be greater
        /// than 0 and less than 1. We recommend setting this value to be less than 0.5.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float ValidationFraction
        {
            get { return this._validationFraction.GetValueOrDefault(); }
            set { this._validationFraction = value; }
        }

        // Check to see if ValidationFraction property is set
        internal bool IsSetValidationFraction()
        {
            return this._validationFraction.HasValue; 
        }

    }
}