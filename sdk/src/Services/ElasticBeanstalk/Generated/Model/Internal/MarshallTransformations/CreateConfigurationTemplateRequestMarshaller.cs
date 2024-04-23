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
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConfigurationTemplate Request Marshaller
    /// </summary>       
    public class CreateConfigurationTemplateRequestMarshaller : IMarshaller<IRequest, CreateConfigurationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateConfigurationTemplateRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateConfigurationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "CreateConfigurationTemplate");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnvironmentId())
                {
                    request.Parameters.Add("EnvironmentId", StringUtils.FromString(publicRequest.EnvironmentId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOptionSettings())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.OptionSettings)
                    {
                        if(publicRequestlistValue.IsSetNamespace())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Namespace", StringUtils.FromString(publicRequestlistValue.Namespace));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetOptionName())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionName", StringUtils.FromString(publicRequestlistValue.OptionName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetResourceName())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceName", StringUtils.FromString(publicRequestlistValue.ResourceName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("OptionSettings" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPlatformArn())
                {
                    request.Parameters.Add("PlatformArn", StringUtils.FromString(publicRequest.PlatformArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSolutionStackName())
                {
                    request.Parameters.Add("SolutionStackName", StringUtils.FromString(publicRequest.SolutionStackName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSourceConfiguration())
                {
                    if(publicRequest.SourceConfiguration.IsSetApplicationName())
                    {
                        request.Parameters.Add("SourceConfiguration" + "." + "ApplicationName", StringUtils.FromString(publicRequest.SourceConfiguration.ApplicationName));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SourceConfiguration.IsSetTemplateName())
                    {
                        request.Parameters.Add("SourceConfiguration" + "." + "TemplateName", StringUtils.FromString(publicRequest.SourceConfiguration.TemplateName));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTemplateName())
                {
                    request.Parameters.Add("TemplateName", StringUtils.FromString(publicRequest.TemplateName));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateConfigurationTemplateRequestMarshaller _instance = new CreateConfigurationTemplateRequestMarshaller();        

        internal static CreateConfigurationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateConfigurationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}