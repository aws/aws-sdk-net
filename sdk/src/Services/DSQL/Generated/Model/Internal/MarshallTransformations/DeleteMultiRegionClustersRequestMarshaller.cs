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
 * Do not modify this file. This file is generated from the dsql-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DSQL.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DSQL.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMultiRegionClusters Request Marshaller
    /// </summary>       
    public class DeleteMultiRegionClustersRequestMarshaller : IMarshaller<IRequest, DeleteMultiRegionClustersRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteMultiRegionClustersRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteMultiRegionClustersRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DSQL");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            
            if (publicRequest.IsSetClientToken())
                request.Parameters.Add("client-token", StringUtils.FromString(publicRequest.ClientToken));
            else            
                request.Parameters.Add("client-token", System.Guid.NewGuid().ToString());
                
            
            if (publicRequest.IsSetLinkedClusterArns())
                request.ParameterCollection.Add("linked-cluster-arns", publicRequest.LinkedClusterArns);
            request.ResourcePath = "/multi-region-clusters";
            request.UseQueryString = true;

            return request;
        }
        private static DeleteMultiRegionClustersRequestMarshaller _instance = new DeleteMultiRegionClustersRequestMarshaller();        

        internal static DeleteMultiRegionClustersRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteMultiRegionClustersRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}