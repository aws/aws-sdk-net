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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
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
namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// The progress of a multipart attachment upload, returned by <a>DescribeAttachmentUploadStatus</a>.
    /// </summary>
    public partial class UploadProgress
    {
        private int? _completedPartsCount;
        private int? _totalParts;

        /// <summary>
        /// Gets and sets the property CompletedPartsCount. 
        /// <para>
        /// The number of parts that have been successfully uploaded.
        /// </para>
        /// </summary>
        public int? CompletedPartsCount
        {
            get { return this._completedPartsCount; }
            set { this._completedPartsCount = value; }
        }

        // Check to see if CompletedPartsCount property is set
        internal bool IsSetCompletedPartsCount()
        {
            return this._completedPartsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalParts. 
        /// <para>
        /// The total number of parts that the file is split into.
        /// </para>
        /// </summary>
        public int? TotalParts
        {
            get { return this._totalParts; }
            set { this._totalParts = value; }
        }

        // Check to see if TotalParts property is set
        internal bool IsSetTotalParts()
        {
            return this._totalParts.HasValue; 
        }

    }
}