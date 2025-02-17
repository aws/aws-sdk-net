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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Tables.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3Tables.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListNamespaces Request Marshaller
    /// </summary>       
    public class ListNamespacesRequestMarshaller : IMarshaller<IRequest, ListNamespacesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListNamespacesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListNamespacesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Tables");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetTableBucketARN())
                throw new AmazonS3TablesException("Request object does not have required field TableBucketARN set");
            request.AddPathResource("{tableBucketARN}", StringUtils.FromString(publicRequest.TableBucketARN));
            
            if (publicRequest.IsSetContinuationToken())
                request.Parameters.Add("continuationToken", StringUtils.FromString(publicRequest.ContinuationToken));
            
            if (publicRequest.IsSetMaxNamespaces())
                request.Parameters.Add("maxNamespaces", StringUtils.FromInt(publicRequest.MaxNamespaces));
            
            if (publicRequest.IsSetPrefix())
                request.Parameters.Add("prefix", StringUtils.FromString(publicRequest.Prefix));
            request.ResourcePath = "/namespaces/{tableBucketARN}";
            request.UseQueryString = true;

            return request;
        }
        private static ListNamespacesRequestMarshaller _instance = new ListNamespacesRequestMarshaller();        

        internal static ListNamespacesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListNamespacesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}