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
    /// ValidateConfigurationSettings Request Marshaller
    /// </summary>       
    public class ValidateConfigurationSettingsRequestMarshaller : IMarshaller<IRequest, ValidateConfigurationSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ValidateConfigurationSettingsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ValidateConfigurationSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "ValidateConfigurationSettings");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
                if(publicRequest.IsSetEnvironmentName())
                {
                    request.Parameters.Add("EnvironmentName", StringUtils.FromString(publicRequest.EnvironmentName));
                }
                if(publicRequest.IsSetOptionSettings())
                {
                    if (publicRequest.OptionSettings.Count == 0)
                        request.Parameters.Add("OptionSettings", "");
                    else
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
                }
                if(publicRequest.IsSetTemplateName())
                {
                    request.Parameters.Add("TemplateName", StringUtils.FromString(publicRequest.TemplateName));
                }
            }
            return request;
        }
                    private static ValidateConfigurationSettingsRequestMarshaller _instance = new ValidateConfigurationSettingsRequestMarshaller();        

        internal static ValidateConfigurationSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ValidateConfigurationSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}