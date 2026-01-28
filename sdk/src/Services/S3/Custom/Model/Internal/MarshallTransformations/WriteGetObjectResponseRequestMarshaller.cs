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
using System;
using System.Globalization;
using System.IO;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Util;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;
using Amazon.Runtime;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public partial class WriteGetObjectResponseRequestMarshaller : IMarshaller<IRequest, WriteGetObjectResponseRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        partial void PreMarshallCustomization(DefaultRequest defaultRequest, WriteGetObjectResponseRequest publicRequest)
        {
            if (!publicRequest.IsSetRequestRoute())
                throw new System.ArgumentException("RequestRoute is a required property and must be set before making this call.", "WriteGetObjectResponseRequest.RequestRoute");
            if (!publicRequest.IsSetRequestToken())
                throw new System.ArgumentException("RequestToken is a required property and must be set before making this call.", "WriteGetObjectResponseRequest.RequestToken");

            AmazonS3Util.SetMetadataHeaders(defaultRequest, publicRequest.Metadata);

            var stream = publicRequest.Body ?? new MemoryStream();
            defaultRequest.ContentStream = stream;

            if (!publicRequest.IsSetContentLength())
            {
                if (defaultRequest.ContentStream.CanSeek)
                {
                    defaultRequest.Headers["Content-Length"] = defaultRequest.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    defaultRequest.Headers[HeaderKeys.TransferEncodingHeader] = "chunked";
                }
            }

            if (!publicRequest.IsSetContentType())
                defaultRequest.Headers["x-amz-fwd-header-Content-Type"] = "binary/octet-stream";

            var hostPrefixLabels = new
            {
                RequestRoute = StringUtils.FromString(publicRequest.RequestRoute)
            };

            if (!HostPrefixUtils.IsValidLabelValue(hostPrefixLabels.RequestRoute))
                throw new AmazonS3Exception("RequestRoute can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");

            defaultRequest.HostPrefix = $"{hostPrefixLabels.RequestRoute}.";
        }
    }
}
