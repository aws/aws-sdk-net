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

using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadCommand : BaseCommand
    {
        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            ValidateRequest();
            GetObjectRequest getRequest = ConvertToGetObjectRequest(this._request);

            using (var response = await this._s3Client.GetObjectAsync(getRequest, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false))
            {
                response.WriteObjectProgressEvent += OnWriteObjectProgressEvent;
                //response.WriteObjectProgressEvent += this._request.EventHandler;
#if BCL45
                await response.WriteResponseStreamToFileAsync(this._request.FilePath, false, cancellationToken).
                    ConfigureAwait(continueOnCapturedContext: false);
#elif WIN_RT || WINDOWS_PHONE
             await response.WriteResponseStreamToFileAsync(this._request.StorageFile, false, cancellationToken).
                ConfigureAwait(continueOnCapturedContext: false);
#endif
            }
        }
    }
}
