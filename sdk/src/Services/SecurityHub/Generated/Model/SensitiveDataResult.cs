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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains a detected instance of sensitive data that are based on built-in identifiers.
    /// </summary>
    public partial class SensitiveDataResult
    {
        private string _category;
        private List<SensitiveDataDetections> _detections = new List<SensitiveDataDetections>();
        private long? _totalCount;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of sensitive data that was detected. For example, the category can indicate
        /// that the sensitive data involved credentials, financial information, or personal information.
        /// </para>
        /// </summary>
        public string Category
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
        /// The list of detected instances of sensitive data.
        /// </para>
        /// </summary>
        public List<SensitiveDataDetections> Detections
        {
            get { return this._detections; }
            set { this._detections = value; }
        }

        // Check to see if Detections property is set
        internal bool IsSetDetections()
        {
            return this._detections != null && this._detections.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of occurrences of sensitive data.
        /// </para>
        /// </summary>
        public long TotalCount
        {
            get { return this._totalCount.GetValueOrDefault(); }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}