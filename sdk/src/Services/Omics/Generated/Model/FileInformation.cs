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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Details about a file.
    /// </summary>
    public partial class FileInformation
    {
        private long? _contentLength;
        private long? _partSize;
        private int? _totalParts;

        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        /// The file's content length.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5497558138880)]
        public long ContentLength
        {
            get { return this._contentLength.GetValueOrDefault(); }
            set { this._contentLength = value; }
        }

        // Check to see if ContentLength property is set
        internal bool IsSetContentLength()
        {
            return this._contentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartSize. 
        /// <para>
        /// The file's part size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5368709120)]
        public long PartSize
        {
            get { return this._partSize.GetValueOrDefault(); }
            set { this._partSize = value; }
        }

        // Check to see if PartSize property is set
        internal bool IsSetPartSize()
        {
            return this._partSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalParts. 
        /// <para>
        /// The file's total parts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int TotalParts
        {
            get { return this._totalParts.GetValueOrDefault(); }
            set { this._totalParts = value; }
        }

        // Check to see if TotalParts property is set
        internal bool IsSetTotalParts()
        {
            return this._totalParts.HasValue; 
        }

    }
}