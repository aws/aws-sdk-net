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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Imagebuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Imagebuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteInfrastructureConfiguration Request Marshaller
    /// </summary>       
    public class DeleteInfrastructureConfigurationRequestMarshaller : IMarshaller<IRequest, DeleteInfrastructureConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteInfrastructureConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteInfrastructureConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Imagebuilder");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-12-02";            
            request.HttpMethod = "DELETE";

            
            if (publicRequest.IsSetInfrastructureConfigurationArn())
                request.Parameters.Add("infrastructureConfigurationArn", StringUtils.FromString(publicRequest.InfrastructureConfigurationArn));
            request.ResourcePath = "/DeleteInfrastructureConfiguration";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static DeleteInfrastructureConfigurationRequestMarshaller _instance = new DeleteInfrastructureConfigurationRequestMarshaller();        

        internal static DeleteInfrastructureConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteInfrastructureConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}