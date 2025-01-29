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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMakerFeatureStoreRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMakerFeatureStoreRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetRecord Request Marshaller
    /// </summary>       
    public class GetRecordRequestMarshaller : IMarshaller<IRequest, GetRecordRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetRecordRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetRecordRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SageMakerFeatureStoreRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetFeatureGroupName())
                throw new AmazonSageMakerFeatureStoreRuntimeException("Request object does not have required field FeatureGroupName set");
            request.AddPathResource("{FeatureGroupName}", StringUtils.FromString(publicRequest.FeatureGroupName));
            
            if (publicRequest.IsSetExpirationTimeResponse())
                request.Parameters.Add("ExpirationTimeResponse", StringUtils.FromString(publicRequest.ExpirationTimeResponse));
            
            if (publicRequest.IsSetFeatureNames())
                request.ParameterCollection.Add("FeatureName", publicRequest.FeatureNames);
            
            if (publicRequest.IsSetRecordIdentifierValueAsString())
                request.Parameters.Add("RecordIdentifierValueAsString", StringUtils.FromString(publicRequest.RecordIdentifierValueAsString));
            request.ResourcePath = "/FeatureGroup/{FeatureGroupName}";
            request.UseQueryString = true;

            return request;
        }
        private static GetRecordRequestMarshaller _instance = new GetRecordRequestMarshaller();        

        internal static GetRecordRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetRecordRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}