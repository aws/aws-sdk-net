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
using System.Linq;
using System.Text;

using Amazon.Glacier.Model;

namespace Amazon.Glacier
{
    /// <summary>
    /// Extension methods for Amazon Glacier.
    /// </summary>
    public static class AmazonGlacierExtensions
    {
        /// <summary>
        /// Creates the range formatted string and set the Range property.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.  This can be null which would return the data to the end.</param>
        public static void SetRange(this GetJobOutputRequest request, long start, long? end)
        {
            string range;
            if (end == null)
                range = string.Format("bytes={0}-", start);
            else
                range = string.Format("bytes={0}-{1}", start, end.Value);

            request.Range = range;
        }

        /// <summary>
        /// Creates the range formatted string and set the Range property.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="start">The start of the range.</param>
        /// <param name="end">The end of the range.</param>
        public static void SetRange(this UploadMultipartPartRequest request, long start, long end)
        {
            request.Range = string.Format("bytes {0}-{1}/*", start, end);
        }
    }
}
