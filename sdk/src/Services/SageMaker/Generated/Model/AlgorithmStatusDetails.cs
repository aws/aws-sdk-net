/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Specifies the validation and image scan statuses of the algorithm.
    /// </summary>
    public partial class AlgorithmStatusDetails
    {
        private List<AlgorithmStatusItem> _imageScanStatuses = new List<AlgorithmStatusItem>();
        private List<AlgorithmStatusItem> _validationStatuses = new List<AlgorithmStatusItem>();

        /// <summary>
        /// Gets and sets the property ImageScanStatuses. 
        /// <para>
        /// The status of the scan of the algorithm's Docker image container.
        /// </para>
        /// </summary>
        public List<AlgorithmStatusItem> ImageScanStatuses
        {
            get { return this._imageScanStatuses; }
            set { this._imageScanStatuses = value; }
        }

        // Check to see if ImageScanStatuses property is set
        internal bool IsSetImageScanStatuses()
        {
            return this._imageScanStatuses != null && this._imageScanStatuses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidationStatuses. 
        /// <para>
        /// The status of algorithm validation.
        /// </para>
        /// </summary>
        public List<AlgorithmStatusItem> ValidationStatuses
        {
            get { return this._validationStatuses; }
            set { this._validationStatuses = value; }
        }

        // Check to see if ValidationStatuses property is set
        internal bool IsSetValidationStatuses()
        {
            return this._validationStatuses != null && this._validationStatuses.Count > 0; 
        }

    }
}