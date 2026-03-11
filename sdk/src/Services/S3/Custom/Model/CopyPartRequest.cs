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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    public partial class CopyPartRequest : AmazonWebServiceRequest
    {
        private long? firstByte;
        private long? lastByte;
        /// <summary>
        /// The location of the first byte in the range if only a portion of the 
        /// source object is to be copied as the part. 
        /// </summary>
        /// <remarks>
        /// The LastByte property must also be set or this value will be ignored.
        /// </remarks>
        public long? FirstByte
        {
            get { return this.firstByte; }
            set { this.firstByte = value; }
        }

        /// <summary>
        /// Checks if FirstByte property is set.
        /// </summary>
        /// <returns>true if FirstByte property is set.</returns>
        internal bool IsSetFirstByte()
        {
            return this.firstByte.HasValue;
        }

        /// <summary>
        /// The location of the last byte in the range if only a portion of the 
        /// source object is to be copied as the part.  
        /// </summary>
        /// <remarks>
        /// The FirstByte property must also be set or this value will be ignored.
        /// </remarks>
        public long? LastByte
        {
            get { return this.lastByte; }
            set { this.lastByte = value; }
        }

        /// <summary>
        /// Checks if LastByte property is set.
        /// </summary>
        /// <returns>true if LastByte property is set.</returns>
        internal bool IsSetLastByte()
        {
            return this.lastByte.HasValue;
        }
    }
}
