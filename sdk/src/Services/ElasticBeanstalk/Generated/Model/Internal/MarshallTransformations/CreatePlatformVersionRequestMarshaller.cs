/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePlatformVersion Request Marshaller
    /// </summary>       
    public class CreatePlatformVersionRequestMarshaller : IMarshaller<IRequest, CreatePlatformVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePlatformVersionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePlatformVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "CreatePlatformVersion");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEnvironmentName())
                {
                    request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
                }
                if(publicRequest.IsSetOptionSettings())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.OptionSettings)
                    {
                        if(publicRequestlistValue.IsSetNamespace())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Namespace", StringUtils.FromString(publicRequestlistValue.Namespace));
                        }
                        if(publicRequestlistValue.IsSetOptionName())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionName", StringUtils.FromString(publicRequestlistValue.OptionName));
                        }
                        if(publicRequestlistValue.IsSetResourceName())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceName", StringUtils.FromString(publicRequestlistValue.ResourceName));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetPlatformDefinitionBundle())
                {
                    if(publicRequest.PlatformDefinitionBundle.IsSetS3Bucket())
                    {
                        request.Parameters.Add("PlatformDefinitionBundle" + "." + "S3Bucket", StringUtils.FromString(publicRequest.PlatformDefinitionBundle.S3Bucket));
                    }
                    if(publicRequest.PlatformDefinitionBundle.IsSetS3Key())
                    {
                        request.Parameters.Add("PlatformDefinitionBundle" + "." + "S3Key", StringUtils.FromString(publicRequest.PlatformDefinitionBundle.S3Key));
                    }
                }
                if(publicRequest.IsSetPlatformName())
                {
                    request.Parameters.Add("PlatformName", StringUtils.FromString(publicRequest.PlatformName));
                }
                if(publicRequest.IsSetPlatformVersion())
                {
                    request.Parameters.Add("PlatformVersion", StringUtils.FromString(publicRequest.PlatformVersion));
                }
            }
            return request;
        }
                    private static CreatePlatformVersionRequestMarshaller _instance = new CreatePlatformVersionRequestMarshaller();        

        internal static CreatePlatformVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePlatformVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}