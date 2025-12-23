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

using Amazon.Runtime.Internal.Util;
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
    internal partial class OpenStreamWithResponseCommand : BaseCommand<TransferUtilityOpenStreamResponse>
    {
        private readonly Logger _logger = Logger.GetLogger(typeof(OpenStreamWithResponseCommand));

        public override async Task<TransferUtilityOpenStreamResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            _logger.DebugFormat("OpenStreamWithResponseCommand: Creating BufferedMultipartStream with MultipartDownloadType={0}",
                _request.MultipartDownloadType);

            _logger.DebugFormat("OpenStreamWithResponseCommand: Configuration - ConcurrentServiceRequests={0}, MaxInMemoryParts={1}, BufferSize={2}",
                _config.ConcurrentServiceRequests,
                _request.MaxInMemoryParts,
                _s3Client.Config.BufferSize
                );

            var bufferedStream = BufferedMultipartStream.Create(_s3Client, _request, _config, this.RequestEventHandler);
            await bufferedStream.InitializeAsync(cancellationToken).ConfigureAwait(false);
            
            // Populate metadata from the initial GetObject response (from discovery phase)
            var discoveryResult = bufferedStream.DiscoveryResult;

            _logger.DebugFormat("OpenStreamWithResponseCommand: Stream initialized successfully - ObjectSize={0}, TotalParts={1}, IsSinglePart={2}",
                discoveryResult.ObjectSize,
                discoveryResult.TotalParts,
                discoveryResult.IsSinglePart);

            var response = ResponseMapper.MapGetObjectResponseToOpenStream(discoveryResult.InitialResponse);
            
            // SEP Part GET Step 7 / Ranged GET Step 9:
            // Set ContentLength to total object size (not just first part)
            response.Headers.ContentLength = discoveryResult.ObjectSize;
            
            // Set ContentRange to represent the entire object: bytes 0-(ContentLength-1)/ContentLength
            // S3 returns null for 0-byte objects, so we match that behavior
            if (discoveryResult.ObjectSize == 0)
            {
                response.ContentRange = null;
            }
            else
            {
                response.ContentRange = $"bytes 0-{discoveryResult.ObjectSize - 1}/{discoveryResult.ObjectSize}";
            }
            
            // SEP Part GET Step 7 / Ranged GET Step 9:
            // Handle composite checksums for multipart objects
            // Per spec: "If ChecksumType is COMPOSITE, set all checksum value members to null 
            // as the checksum value returned from a part GET request is not the composite 
            // checksum for the entire object"
            if (response.ChecksumType == ChecksumType.COMPOSITE)
            {
                response.ChecksumCRC32 = null;
                response.ChecksumCRC32C = null;
                response.ChecksumCRC64NVME = null;
                response.ChecksumSHA1 = null;
                response.ChecksumSHA256 = null;
            }
            
            response.ResponseStream = bufferedStream;
            return response;
            
        }
    }
}
