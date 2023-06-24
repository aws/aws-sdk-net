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
 * Do not modify this file. This file is generated from the codecatalyst-2022-09-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCatalyst.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCatalyst.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListSourceRepositoryBranches Request Marshaller
    /// </summary>       
    public class ListSourceRepositoryBranchesRequestMarshaller : IMarshaller<IRequest, ListSourceRepositoryBranchesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListSourceRepositoryBranchesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListSourceRepositoryBranchesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCatalyst");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-09-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetProjectName())
                throw new AmazonCodeCatalystException("Request object does not have required field ProjectName set");
            request.AddPathResource("{projectName}", StringUtils.FromString(publicRequest.ProjectName));
            if (!publicRequest.IsSetSourceRepositoryName())
                throw new AmazonCodeCatalystException("Request object does not have required field SourceRepositoryName set");
            request.AddPathResource("{sourceRepositoryName}", StringUtils.FromString(publicRequest.SourceRepositoryName));
            if (!publicRequest.IsSetSpaceName())
                throw new AmazonCodeCatalystException("Request object does not have required field SpaceName set");
            request.AddPathResource("{spaceName}", StringUtils.FromString(publicRequest.SpaceName));
            request.ResourcePath = "/v1/spaces/{spaceName}/projects/{projectName}/sourceRepositories/{sourceRepositoryName}/branches";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListSourceRepositoryBranchesRequestMarshaller _instance = new ListSourceRepositoryBranchesRequestMarshaller();        

        internal static ListSourceRepositoryBranchesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListSourceRepositoryBranchesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}