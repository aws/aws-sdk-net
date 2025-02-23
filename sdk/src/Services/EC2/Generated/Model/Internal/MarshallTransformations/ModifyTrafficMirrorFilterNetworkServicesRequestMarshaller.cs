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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyTrafficMirrorFilterNetworkServices Request Marshaller
    /// </summary>       
    public class ModifyTrafficMirrorFilterNetworkServicesRequestMarshaller : IMarshaller<IRequest, ModifyTrafficMirrorFilterNetworkServicesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyTrafficMirrorFilterNetworkServicesRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyTrafficMirrorFilterNetworkServicesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifyTrafficMirrorFilterNetworkServices");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddNetworkServices())
                {
                    if (publicRequest.AddNetworkServices.Count == 0)
                        request.Parameters.Add("AddNetworkService", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddNetworkServices)
                         {
                             request.Parameters.Add("AddNetworkService" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetRemoveNetworkServices())
                {
                    if (publicRequest.RemoveNetworkServices.Count == 0)
                        request.Parameters.Add("RemoveNetworkService", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveNetworkServices)
                         {
                             request.Parameters.Add("RemoveNetworkService" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTrafficMirrorFilterId())
                {
                    request.Parameters.Add("TrafficMirrorFilterId", StringUtils.FromString(publicRequest.TrafficMirrorFilterId));
                }
            }
            return request;
        }
                    private static ModifyTrafficMirrorFilterNetworkServicesRequestMarshaller _instance = new ModifyTrafficMirrorFilterNetworkServicesRequestMarshaller();        

        internal static ModifyTrafficMirrorFilterNetworkServicesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyTrafficMirrorFilterNetworkServicesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}