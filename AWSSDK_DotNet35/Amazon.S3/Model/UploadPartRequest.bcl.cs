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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to request upload of a part in a multipart upload operation.
    /// </summary>
    /// <remarks>
    /// <para>
    /// If PartSize is not specified then the rest of the content from the file
    /// or stream will be sent to Amazon S3.
    /// </para>
    /// <para>
    /// You must set either the FilePath or InputStream.  If FilePath is set then the FilePosition
    /// property must be set.
    /// </para>
    /// </remarks>
    public partial class UploadPartRequest : AmazonWebServiceRequest
    {
        /// <summary>
        /// Overrides the default request timeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the Timeout property of the HTTPWebRequest/HttpClient object used
        /// to send requests.
        /// </para>
        /// <para>
        /// Please specify a timeout value only if the operation will not complete within the default intervals
        /// specified for an HttpWebRequest/HttpClient.
        /// </para>
        /// </remarks>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        /// <seealso cref="P:System.Net.Http.HttpClient.Timeout"/>
        public TimeSpan? Timeout
        {
            get { return this.TimeoutInternal; }
            set { this.TimeoutInternal = value; }
        }


        /// <summary>
        /// Overrides the default ReadWriteTimeout value.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the value is set, the value is assigned to the ReadWriteTimeout property of the HTTPWebRequest/WebRequestHandler object used
        /// to send requests.
        /// </para>
        /// <exception cref="System.ArgumentNullException">The timeout specified is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">The timeout specified is less than or equal to zero and is not Infinite.</exception>
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.Http.WebRequestHandler.ReadWriteTimeout"/>
        public TimeSpan? ReadWriteTimeout
        {
            get { return this.ReadWriteTimeoutInternal; }
            set { this.ReadWriteTimeoutInternal = value; }
        }

        internal void SetupForFilePath()
        {
            var fileStream = new FileStream(this.FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            fileStream.Position = this.FilePosition;
            this.InputStream = fileStream;
        }
    }
}
