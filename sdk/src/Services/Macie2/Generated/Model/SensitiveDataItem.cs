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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the category, types, and occurrences of sensitive data
    /// that produced a sensitive data finding.
    /// </summary>
    public partial class SensitiveDataItem
    {
        private SensitiveDataItemCategory _category;
        private List<DefaultDetection> _detections = AWSConfigs.InitializeCollections ? new List<DefaultDetection>() : null;
        private long? _totalCount;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of sensitive data that was detected. For example: CREDENTIALS, for credentials
        /// data such as private keys or Amazon Web Services secret access keys; FINANCIAL_INFORMATION,
        /// for financial data such as credit card numbers; or, PERSONAL_INFORMATION, for personal
        /// health information, such as health insurance identification numbers, or personally
        /// identifiable information, such as passport numbers.
        /// </para>
        /// </summary>
        public SensitiveDataItemCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Detections. 
        /// <para>
        /// An array of objects, one for each type of sensitive data that was detected. Each object
        /// reports the number of occurrences of a specific type of sensitive data that was detected,
        /// and the location of up to 15 of those occurrences.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DefaultDetection> Detections
        {
            get { return this._detections; }
            set { this._detections = value; }
        }

        // Check to see if Detections property is set
        internal bool IsSetDetections()
        {
            return this._detections != null && (this._detections.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of occurrences of the sensitive data that was detected.
        /// </para>
        /// </summary>
        public long? TotalCount
        {
            get { return this._totalCount; }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}