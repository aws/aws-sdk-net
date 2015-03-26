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
using System.Threading;
using System.Threading.Tasks;
using Windows.Storage;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO;
using Amazon.S3.Util;
using Amazon.Util;

namespace Amazon.S3.Model
{
    public partial class GetObjectResponse
    {
        [CLSCompliant(false)]
        public async Task WriteResponseStreamToFileAsync(IStorageFile storageFile, bool append, CancellationToken cancellationToken)
        {
            Stream outputStream = await storageFile.OpenStreamForWriteAsync().ConfigureAwait(false); 
            if (append)
            {                
                outputStream.Seek(0, SeekOrigin.End);
            }

            try
            {
                long current = 0;
                var inputStream = this.ResponseStream;
                byte[] buffer = new byte[S3Constants.DefaultBufferSize];
                int bytesRead = 0;
                long totalIncrementTransferred = 0;
                while ((bytesRead = await inputStream.ReadAsync(buffer, 0, buffer.Length)
                    .ConfigureAwait(continueOnCapturedContext: false)) > 0)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    await outputStream.WriteAsync(buffer, 0, bytesRead)
                        .ConfigureAwait(continueOnCapturedContext: false);
                    current += bytesRead;
                    totalIncrementTransferred += bytesRead;

                    if (totalIncrementTransferred >= AWSSDKUtils.DefaultProgressUpdateInterval ||
                        current == this.ContentLength)
                    {
                        this.OnRaiseProgressEvent(storageFile.Path, bytesRead, current, this.ContentLength);
                        totalIncrementTransferred = 0;
                    }
                }
				
				ValidateWrittenStreamSize(current);
            }
            finally
            {
                if (outputStream!=null)
                {
                    outputStream.Dispose();
                }                
            }
        }
    }
}
