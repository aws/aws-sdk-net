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

using Amazon.S3;

namespace LambdaBenchmarks;

public class S3GetObjectInputPayload
{
    public string BucketName { get; set; }
    public string TestFileKey { get; set; }
}


public class S3LambdaBenchmarks
{
    private AmazonS3Client _s3Client = new AmazonS3Client();

    /// <summary>
    /// Test S3 GetObject, it should return a 10KB File.
    /// </summary>
    public async Task<string> GetObjectHandler(S3GetObjectInputPayload payload)
    {
        var response = await _s3Client.GetObjectAsync(payload.BucketName, payload.TestFileKey);

        using StreamReader reader = new StreamReader(response.ResponseStream);
        return reader.ReadToEnd();
    }
}
