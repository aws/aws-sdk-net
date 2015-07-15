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
    internal partial class SimpleUploadCommand : BaseCommand
    {
        public SemaphoreSlim AsyncThrottler { get; set; }

        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            try
            {
                if (AsyncThrottler != null)
                {
                    await this.AsyncThrottler.WaitAsync(cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);
                }

                var putRequest = ConstructRequest();
                await _s3Client.PutObjectAsync(putRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            finally
            {
                if (this.AsyncThrottler != null)
                {
                    AsyncThrottler.Release();
                }
            }
        }
    }
}
