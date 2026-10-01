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

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.GreengrassV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetComponentVersionArtifact Request Marshaller
    /// </summary>
    public partial class GetComponentVersionArtifactRequestMarshaller : IMarshaller<IRequest, GetComponentVersionArtifactRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetComponentVersionArtifactRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GetComponentVersionArtifactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GreengrassV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-30";
            request.HttpMethod = "GET";

            if (publicRequest.IsSetS3EndpointType())
            {
                request.Parameters.Add("s3EndpointType", StringUtils.FromString(publicRequest.S3EndpointType));
            }

            if (publicRequest.IsSetIotEndpointType())
            {
                request.Headers["x-amz-iot-endpoint-type"] = publicRequest.IotEndpointType;
            }

            if (!publicRequest.IsSetArn())
            {
                throw new AmazonGreengrassV2Exception("Request object does not have required field Arn set");
            }
            request.AddPathResource("{arn}", StringUtils.FromString(publicRequest.Arn));

            if (!publicRequest.IsSetArtifactName())
            {
                throw new AmazonGreengrassV2Exception("Request object does not have required field ArtifactName set");
            }
            request.AddPathResource("{artifactName+}", StringUtils.FromString(publicRequest.ArtifactName.TrimStart('/')));

            request.ResourcePath = "/greengrass/v2/components/{arn}/artifacts/{artifactName+}";

            request.UseQueryString = true;

            return request;
        }

        private static readonly GetComponentVersionArtifactRequestMarshaller _instance = new();

        internal static GetComponentVersionArtifactRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetComponentVersionArtifactRequestMarshaller Instance => _instance;
    }
}
