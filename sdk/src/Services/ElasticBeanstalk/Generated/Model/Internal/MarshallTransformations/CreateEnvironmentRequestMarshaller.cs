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
    /// CreateEnvironment Request Marshaller
    /// </summary>       
    public class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "CreateEnvironment");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCNAMEPrefix())
                {
                    request.Parameters.Add("CNAMEPrefix", StringUtils.FromString(publicRequest.CNAMEPrefix));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnvironmentName())
                {
                    request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetGroupName())
                {
                    request.Parameters.Add("GroupName", StringUtils.FromString(publicRequest.GroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOperationsRole())
                {
                    request.Parameters.Add("OperationsRole", StringUtils.FromString(publicRequest.OperationsRole));
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
                if(publicRequest.IsSetOptionsToRemove())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.OptionsToRemove)
                    {
                        if(publicRequestlistValue.IsSetNamespace())
                        {
                            request.Parameters.Add("OptionsToRemove" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Namespace", StringUtils.FromString(publicRequestlistValue.Namespace));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetOptionName())
                        {
                            request.Parameters.Add("OptionsToRemove" + "." + "member" + "." + publicRequestlistValueIndex + "." + "OptionName", StringUtils.FromString(publicRequestlistValue.OptionName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetResourceName())
                        {
                            request.Parameters.Add("OptionsToRemove" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceName", StringUtils.FromString(publicRequestlistValue.ResourceName));
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
                if(publicRequest.IsSetTier())
                {
                    if(publicRequest.Tier.IsSetName())
                    {
                        request.Parameters.Add("Tier" + "." + "Name", StringUtils.FromString(publicRequest.Tier.Name));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Tier.IsSetType())
                    {
                        request.Parameters.Add("Tier" + "." + "Type", StringUtils.FromString(publicRequest.Tier.Type));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.Tier.IsSetVersion())
                    {
                        request.Parameters.Add("Tier" + "." + "Version", StringUtils.FromString(publicRequest.Tier.Version));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVersionLabel())
                {
                    request.Parameters.Add("VersionLabel", StringUtils.FromString(publicRequest.VersionLabel));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateEnvironmentRequestMarshaller _instance = new CreateEnvironmentRequestMarshaller();        

        internal static CreateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}