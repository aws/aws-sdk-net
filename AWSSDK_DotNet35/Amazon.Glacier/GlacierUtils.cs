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
using System.IO;
using System.Text;
using System.Threading;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

namespace Amazon.Glacier
{
    /// <summary>
    /// This class defines utility methods and constants for use with Glacier service.
    /// </summary>
    public static class GlacierUtils
    {
        /// <summary>
        /// Constant for in progress job status
        /// </summary>
        public const string JOB_STATUS_INPROGRESS = "InProgress";

        /// <summary>
        /// Constant for failed job status
        /// </summary>
        public const string JOB_STATUS_FAILED = "Failed";

        /// <summary>
        /// Constant for succeeded job status
        /// </summary>
        public const string JOB_STATUS_SUCCEEDED = "Succeeded";

        /// <summary>
        /// Creates a stream that wraps the passed in stream with the length of the stream set to the part size.
        /// This is useful when using multi part upload API by wrapping the stream being uploaded and setting it 
        /// to the Body property on the UploadMultipartPartRequest object.
        /// </summary>
        /// <param name="stream">Stream that is wrapped.</param>
        /// <param name="partSize">The part size to be read from the original stream.</param>
        /// <returns></returns>
        public static Stream CreatePartStream(Stream stream, long partSize)
        {
            return new PartialWrapperStream(stream, partSize);
        }
    }
}
