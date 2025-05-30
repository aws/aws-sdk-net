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
    /// ProvisionByoipCidr Request Marshaller
    /// </summary>       
    public class ProvisionByoipCidrRequestMarshaller : IMarshaller<IRequest, ProvisionByoipCidrRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ProvisionByoipCidrRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ProvisionByoipCidrRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ProvisionByoipCidr");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCidr())
                {
                    request.Parameters.Add("Cidr", StringUtils.FromString(publicRequest.Cidr));
                }
                if(publicRequest.IsSetCidrAuthorizationContext())
                {
                    if(publicRequest.CidrAuthorizationContext.IsSetMessage())
                    {
                        request.Parameters.Add("CidrAuthorizationContext" + "." + "Message", StringUtils.FromString(publicRequest.CidrAuthorizationContext.Message));
                    }
                    if(publicRequest.CidrAuthorizationContext.IsSetSignature())
                    {
                        request.Parameters.Add("CidrAuthorizationContext" + "." + "Signature", StringUtils.FromString(publicRequest.CidrAuthorizationContext.Signature));
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetMultiRegion())
                {
                    request.Parameters.Add("MultiRegion", StringUtils.FromBool(publicRequest.MultiRegion));
                }
                if(publicRequest.IsSetNetworkBorderGroup())
                {
                    request.Parameters.Add("NetworkBorderGroup", StringUtils.FromString(publicRequest.NetworkBorderGroup));
                }
                if(publicRequest.IsSetPoolTagSpecifications())
                {
                    if (publicRequest.PoolTagSpecifications.Count == 0)
                        request.Parameters.Add("PoolTagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.PoolTagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("PoolTagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("PoolTagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("PoolTagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("PoolTagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetPubliclyAdvertisable())
                {
                    request.Parameters.Add("PubliclyAdvertisable", StringUtils.FromBool(publicRequest.PubliclyAdvertisable));
                }
            }
            return request;
        }
                    private static ProvisionByoipCidrRequestMarshaller _instance = new ProvisionByoipCidrRequestMarshaller();        

        internal static ProvisionByoipCidrRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProvisionByoipCidrRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}