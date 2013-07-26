/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>A list of the part sizes of the multipart upload.</para>
    /// </summary>
    public class PartListElement
    {
        
        private string rangeInBytes;
        private string sHA256TreeHash;

        /// <summary>
        /// The byte range of a part, inclusive of the upper value of the range.
        ///  
        /// </summary>
        public string RangeInBytes
        {
            get { return this.rangeInBytes; }
            set { this.rangeInBytes = value; }
        }

        // Check to see if RangeInBytes property is set
        internal bool IsSetRangeInBytes()
        {
            return this.rangeInBytes != null;
        }

        /// <summary>
        /// The SHA256 tree hash value that Amazon Glacier calculated for the part. This field is never <c>null</c>.
        ///  
        /// </summary>
        public string SHA256TreeHash
        {
            get { return this.sHA256TreeHash; }
            set { this.sHA256TreeHash = value; }
        }

        // Check to see if SHA256TreeHash property is set
        internal bool IsSetSHA256TreeHash()
        {
            return this.sHA256TreeHash != null;
        }
    }
}
