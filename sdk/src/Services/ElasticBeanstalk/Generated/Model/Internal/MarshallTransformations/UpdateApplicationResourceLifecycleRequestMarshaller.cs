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
    /// UpdateApplicationResourceLifecycle Request Marshaller
    /// </summary>       
    public class UpdateApplicationResourceLifecycleRequestMarshaller : IMarshaller<IRequest, UpdateApplicationResourceLifecycleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateApplicationResourceLifecycleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateApplicationResourceLifecycleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "UpdateApplicationResourceLifecycle");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
                if(publicRequest.IsSetResourceLifecycleConfig())
                {
                    if(publicRequest.ResourceLifecycleConfig.IsSetServiceRole())
                    {
                        request.Parameters.Add("ResourceLifecycleConfig" + "." + "ServiceRole", StringUtils.FromString(publicRequest.ResourceLifecycleConfig.ServiceRole));
                    }
                    if(publicRequest.ResourceLifecycleConfig.IsSetVersionLifecycleConfig())
                    {
                        if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.IsSetMaxAgeRule())
                        {
                            if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.IsSetDeleteSourceFromS3())
                            {
                                request.Parameters.Add("ResourceLifecycleConfig" + "." + "VersionLifecycleConfig" + "." + "MaxAgeRule" + "." + "DeleteSourceFromS3", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.DeleteSourceFromS3));
                            }
                            if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.IsSetEnabled())
                            {
                                request.Parameters.Add("ResourceLifecycleConfig" + "." + "VersionLifecycleConfig" + "." + "MaxAgeRule" + "." + "Enabled", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.Enabled));
                            }
                            if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.IsSetMaxAgeInDays())
                            {
                                request.Parameters.Add("ResourceLifecycleConfig" + "." + "VersionLifecycleConfig" + "." + "MaxAgeRule" + "." + "MaxAgeInDays", StringUtils.FromInt(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxAgeRule.MaxAgeInDays));
                            }
                        }
                        if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.IsSetMaxCountRule())
                        {
                            if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.IsSetDeleteSourceFromS3())
                            {
                                request.Parameters.Add("ResourceLifecycleConfig" + "." + "VersionLifecycleConfig" + "." + "MaxCountRule" + "." + "DeleteSourceFromS3", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.DeleteSourceFromS3));
                            }
                            if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.IsSetEnabled())
                            {
                                request.Parameters.Add("ResourceLifecycleConfig" + "." + "VersionLifecycleConfig" + "." + "MaxCountRule" + "." + "Enabled", StringUtils.FromBool(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.Enabled));
                            }
                            if(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.IsSetMaxCount())
                            {
                                request.Parameters.Add("ResourceLifecycleConfig" + "." + "VersionLifecycleConfig" + "." + "MaxCountRule" + "." + "MaxCount", StringUtils.FromInt(publicRequest.ResourceLifecycleConfig.VersionLifecycleConfig.MaxCountRule.MaxCount));
                            }
                        }
                    }
                }
            }
            return request;
        }
                    private static UpdateApplicationResourceLifecycleRequestMarshaller _instance = new UpdateApplicationResourceLifecycleRequestMarshaller();        

        internal static UpdateApplicationResourceLifecycleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateApplicationResourceLifecycleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}