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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// This is the response object from the BatchImportFindings operation.
    /// </summary>
    public partial class BatchImportFindingsResponse : AmazonWebServiceResponse
    {
        private int? _failedCount;
        private List<ImportFindingsError> _failedFindings = new List<ImportFindingsError>();
        private int? _successCount;

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The number of findings that cannot be imported.
        /// </para>
        /// </summary>
        public int FailedCount
        {
            get { return this._failedCount.GetValueOrDefault(); }
            set { this._failedCount = value; }
        }

        // Check to see if FailedCount property is set
        internal bool IsSetFailedCount()
        {
            return this._failedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedFindings. 
        /// <para>
        /// The list of the findings that cannot be imported.
        /// </para>
        /// </summary>
        public List<ImportFindingsError> FailedFindings
        {
            get { return this._failedFindings; }
            set { this._failedFindings = value; }
        }

        // Check to see if FailedFindings property is set
        internal bool IsSetFailedFindings()
        {
            return this._failedFindings != null && this._failedFindings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessCount. 
        /// <para>
        /// The number of findings that were successfully imported
        /// </para>
        /// </summary>
        public int SuccessCount
        {
            get { return this._successCount.GetValueOrDefault(); }
            set { this._successCount = value; }
        }

        // Check to see if SuccessCount property is set
        internal bool IsSetSuccessCount()
        {
            return this._successCount.HasValue; 
        }

    }
}