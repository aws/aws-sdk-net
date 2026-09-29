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

using Amazon.MedicalImaging.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MedicalImaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteImageSet Request Marshaller
    /// </summary>
    public partial class DeleteImageSetRequestMarshaller : IMarshaller<IRequest, DeleteImageSetRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteImageSetRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteImageSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MedicalImaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDatastoreId())
            {
                throw new AmazonMedicalImagingException("Request object does not have required field DatastoreId set");
            }
            request.AddPathResource("{datastoreId}", StringUtils.FromString(publicRequest.DatastoreId));

            if (!publicRequest.IsSetImageSetId())
            {
                throw new AmazonMedicalImagingException("Request object does not have required field ImageSetId set");
            }
            request.AddPathResource("{imageSetId}", StringUtils.FromString(publicRequest.ImageSetId));

            request.ResourcePath = "/datastore/{datastoreId}/imageSet/{imageSetId}/deleteImageSet";

            request.HostPrefix = $"runtime-";

            return request;
        }

        private static readonly DeleteImageSetRequestMarshaller _instance = new();

        internal static DeleteImageSetRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteImageSetRequestMarshaller Instance => _instance;
    }
}
