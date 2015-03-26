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
using System.Globalization;
using System.Linq;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// This class represents the byte range for a range GET from S3.
    /// </summary>
    public class ByteRange
    {
        /// <summary>
        /// Constructs a ByteRange and sets the start and end.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public ByteRange(long start, long end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// The starting byte number of the range
        /// </summary>
        public long Start
        {
            get;
            set;
        }

        /// <summary>
        /// The ending byte number of the range
        /// </summary>
        public long End
        {
            get;
            set;
        }

        /// <summary>
        /// The formatted string representing the byte range to be set for the range header.
        /// </summary>
        public string FormattedByteRange
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "bytes={0}-{1}", this.Start, this.End);
            }
        }
    }
}
