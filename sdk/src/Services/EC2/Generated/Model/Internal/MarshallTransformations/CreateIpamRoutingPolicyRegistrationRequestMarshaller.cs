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
    /// CreateIpamRoutingPolicyRegistration Request Marshaller
    /// </summary>       
    public class CreateIpamRoutingPolicyRegistrationRequestMarshaller : IMarshaller<IRequest, CreateIpamRoutingPolicyRegistrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIpamRoutingPolicyRegistrationRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIpamRoutingPolicyRegistrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateIpamRoutingPolicyRegistration");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAsns())
                {
                    if (publicRequest.Asns.Count == 0)
                        request.Parameters.Add("Asn", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Asns)
                         {
                             request.Parameters.Add("Asn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetCidr())
                {
                    request.Parameters.Add("Cidr", StringUtils.FromString(publicRequest.Cidr));
                }
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetForce())
                {
                    request.Parameters.Add("Force", StringUtils.FromBool(publicRequest.Force));
                }
                if(publicRequest.IsSetIpamInternetRegistryAssociationId())
                {
                    request.Parameters.Add("IpamInternetRegistryAssociationId", StringUtils.FromString(publicRequest.IpamInternetRegistryAssociationId));
                }
                if(publicRequest.IsSetMaxLength())
                {
                    request.Parameters.Add("MaxLength", StringUtils.FromInt(publicRequest.MaxLength));
                }
                if(publicRequest.IsSetPermitMoreSpecificAnnouncements())
                {
                    request.Parameters.Add("PermitMoreSpecificAnnouncements", StringUtils.FromBool(publicRequest.PermitMoreSpecificAnnouncements));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif
            return request;
        }
                    private static CreateIpamRoutingPolicyRegistrationRequestMarshaller _instance = new CreateIpamRoutingPolicyRegistrationRequestMarshaller();        

        internal static CreateIpamRoutingPolicyRegistrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIpamRoutingPolicyRegistrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}