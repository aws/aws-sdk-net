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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOpenIDConnectProvider Request Marshaller
    /// </summary>       
    public class CreateOpenIDConnectProviderRequestMarshaller : IMarshaller<IRequest, CreateOpenIDConnectProviderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOpenIDConnectProviderRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOpenIDConnectProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IdentityManagement");
            request.Parameters.Add("Action", "CreateOpenIDConnectProvider");
            request.Parameters.Add("Version", "2010-05-08");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientIDList())
                {
                    if (publicRequest.ClientIDList.Count == 0)
                        request.Parameters.Add("ClientIDList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ClientIDList)
                         {
                             request.Parameters.Add("ClientIDList" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetThumbprintList())
                {
                    if (publicRequest.ThumbprintList.Count == 0)
                        request.Parameters.Add("ThumbprintList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ThumbprintList)
                         {
                             request.Parameters.Add("ThumbprintList" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetUrl())
                {
                    request.Parameters.Add("Url", StringUtils.FromString(publicRequest.Url));
                }
            }
            return request;
        }
                    private static CreateOpenIDConnectProviderRequestMarshaller _instance = new CreateOpenIDConnectProviderRequestMarshaller();        

        internal static CreateOpenIDConnectProviderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOpenIDConnectProviderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}