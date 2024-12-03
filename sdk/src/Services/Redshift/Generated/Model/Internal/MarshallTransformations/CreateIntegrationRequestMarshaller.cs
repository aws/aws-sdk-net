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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIntegration Request Marshaller
    /// </summary>       
    public class CreateIntegrationRequestMarshaller : IMarshaller<IRequest, CreateIntegrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIntegrationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIntegrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "CreateIntegration");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAdditionalEncryptionContext())
                {
                    int mapIndex = 1;
                    foreach(var key in publicRequest.AdditionalEncryptionContext.Keys)
                    {
                        String value;
                        bool hasValue = publicRequest.AdditionalEncryptionContext.TryGetValue(key, out value);
                        request.Parameters.Add("AdditionalEncryptionContext" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                        if (hasValue)
                        {
                            request.Parameters.Add("AdditionalEncryptionContext" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                        }
                        mapIndex++;
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetIntegrationName())
                {
                    request.Parameters.Add("IntegrationName", StringUtils.FromString(publicRequest.IntegrationName));
                }
                if(publicRequest.IsSetKMSKeyId())
                {
                    request.Parameters.Add("KMSKeyId", StringUtils.FromString(publicRequest.KMSKeyId));
                }
                if(publicRequest.IsSetSourceArn())
                {
                    request.Parameters.Add("SourceArn", StringUtils.FromString(publicRequest.SourceArn));
                }
                if(publicRequest.IsSetTagList())
                {
                    if (publicRequest.TagList.Count == 0)
                        request.Parameters.Add("TagList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagList)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("TagList" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("TagList" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTargetArn())
                {
                    request.Parameters.Add("TargetArn", StringUtils.FromString(publicRequest.TargetArn));
                }
            }
            return request;
        }
                    private static CreateIntegrationRequestMarshaller _instance = new CreateIntegrationRequestMarshaller();        

        internal static CreateIntegrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIntegrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}