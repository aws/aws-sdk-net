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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using System.Globalization;
using Amazon.S3.Util;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public partial class GetObjectMetadataRequestMarshaller : IMarshaller<IRequest, GetObjectMetadataRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, GetObjectMetadataRequest publicRequest)
        {
            if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKey())
            {
                defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyHeader, publicRequest.ServerSideEncryptionCustomerProvidedKey);
                if (publicRequest.IsSetServerSideEncryptionCustomerProvidedKeyMD5())
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, publicRequest.ServerSideEncryptionCustomerProvidedKeyMD5);
                else
                    defaultRequest.Headers.Add(HeaderKeys.XAmzSSECustomerKeyMD5Header, AmazonS3Util.ComputeEncodedMD5FromEncodedString(publicRequest.ServerSideEncryptionCustomerProvidedKey));
            }
        }
    }
}
    
