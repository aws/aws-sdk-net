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

using System.IO;
using System.Xml;
using System.Text;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Bucket Notification Request Marshaller
    /// </summary>       
    public partial class PutBucketNotificationRequestMarshaller : IMarshaller<IRequest, PutBucketNotificationRequest> ,IMarshaller<IRequest,Amazon.Runtime.AmazonWebServiceRequest>
	{
        partial void PostMarshallCustomization(DefaultRequest defaultRequest, PutBucketNotificationRequest publicRequest)
        {
            if (publicRequest.IsSetChecksumAlgorithm())
                defaultRequest.Headers[S3Constants.AmzHeaderSdkChecksumAlgorithm] = S3Transforms.ToStringValue(publicRequest.ChecksumAlgorithm);
        }
    }
}
    
