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

using Amazon.S3.Transfer;

namespace LambdaBenchmarks;

public class S3TransferUtilityUploadStreamInputPayload
{
    public string BucketName { get; set; }
}

public class S3TransferUtilityLambdaBenchmarks
{
    private TransferUtility _transferUtility = new TransferUtility();
    private TransferUtilityUploadRequest _transferUtilityUploadStreamRequest;
    private MemoryStream _contentStream = null;

    public S3TransferUtilityLambdaBenchmarks()
    {
        _contentStream = new MemoryStream(Utilities.GenerateTestBytes(Utilities.MegSize * 100));
    }
    /// <summary>
    /// Test uploading a 100MB stream using the Transfer Utility. 
    /// </summary>
    public async Task UploadStreamHandler(S3TransferUtilityUploadStreamInputPayload payload)
    {
        var request = GetTransferUtilityUploadStreamRequest(payload);
        request.Key = $"test-lambda-upload-stream-{Guid.NewGuid()}";
        await _transferUtility.UploadAsync(request);
    }

    private TransferUtilityUploadRequest GetTransferUtilityUploadStreamRequest(S3TransferUtilityUploadStreamInputPayload payload)
    {
        if (_transferUtilityUploadStreamRequest != null && _transferUtilityUploadStreamRequest.BucketName == payload.BucketName)
            return _transferUtilityUploadStreamRequest;

        _transferUtilityUploadStreamRequest = new TransferUtilityUploadRequest
        {
            BucketName = payload.BucketName,
            InputStream = _contentStream,
            AutoCloseStream = false,
        };

        return _transferUtilityUploadStreamRequest;
    }
}
