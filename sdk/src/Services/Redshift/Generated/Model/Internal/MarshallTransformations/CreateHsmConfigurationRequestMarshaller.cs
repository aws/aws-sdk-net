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
    /// CreateHsmConfiguration Request Marshaller
    /// </summary>       
    public class CreateHsmConfigurationRequestMarshaller : IMarshaller<IRequest, CreateHsmConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHsmConfigurationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHsmConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "CreateHsmConfiguration");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetHsmConfigurationIdentifier())
                {
                    request.Parameters.Add("HsmConfigurationIdentifier", StringUtils.FromString(publicRequest.HsmConfigurationIdentifier));
                }
                if(publicRequest.IsSetHsmIpAddress())
                {
                    request.Parameters.Add("HsmIpAddress", StringUtils.FromString(publicRequest.HsmIpAddress));
                }
                if(publicRequest.IsSetHsmPartitionName())
                {
                    request.Parameters.Add("HsmPartitionName", StringUtils.FromString(publicRequest.HsmPartitionName));
                }
                if(publicRequest.IsSetHsmPartitionPassword())
                {
                    request.Parameters.Add("HsmPartitionPassword", StringUtils.FromString(publicRequest.HsmPartitionPassword));
                }
                if(publicRequest.IsSetHsmServerPublicCertificate())
                {
                    request.Parameters.Add("HsmServerPublicCertificate", StringUtils.FromString(publicRequest.HsmServerPublicCertificate));
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
                                request.Parameters.Add("Tags" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static CreateHsmConfigurationRequestMarshaller _instance = new CreateHsmConfigurationRequestMarshaller();        

        internal static CreateHsmConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHsmConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}