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
    /// Details about a sequence.
    /// </summary>
    public partial class SequenceInformation
    {
        private string _alignment;
        private string _generatedFrom;
        private long? _totalBaseCount;
        private long? _totalReadCount;

        /// <summary>
        /// Gets and sets the property Alignment. 
        /// <para>
        /// The sequence's alignment setting.
        /// </para>
        /// </summary>
        public string Alignment
        {
            get { return this._alignment; }
            set { this._alignment = value; }
        }

        // Check to see if Alignment property is set
        internal bool IsSetAlignment()
        {
            return this._alignment != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedFrom. 
        /// <para>
        /// Where the sequence originated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string GeneratedFrom
        {
            get { return this._generatedFrom; }
            set { this._generatedFrom = value; }
        }

        // Check to see if GeneratedFrom property is set
        internal bool IsSetGeneratedFrom()
        {
            return this._generatedFrom != null;
        }

        /// <summary>
        /// Gets and sets the property TotalBaseCount. 
        /// <para>
        /// The sequence's total base count.
        /// </para>
        /// </summary>
        public long TotalBaseCount
        {
            get { return this._totalBaseCount.GetValueOrDefault(); }
            set { this._totalBaseCount = value; }
        }

        // Check to see if TotalBaseCount property is set
        internal bool IsSetTotalBaseCount()
        {
            return this._totalBaseCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalReadCount. 
        /// <para>
        /// The sequence's total read count.
        /// </para>
        /// </summary>
        public long TotalReadCount
        {
            get { return this._totalReadCount.GetValueOrDefault(); }
            set { this._totalReadCount = value; }
        }

        // Check to see if TotalReadCount property is set
        internal bool IsSetTotalReadCount()
        {
            return this._totalReadCount.HasValue; 
        }

    }
}