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
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIpamPool Request Marshaller
    /// </summary>       
    public class CreateIpamPoolRequestMarshaller : IMarshaller<IRequest, CreateIpamPoolRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIpamPoolRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIpamPoolRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateIpamPool");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddressFamily())
                {
                    request.Parameters.Add("AddressFamily", StringUtils.FromString(publicRequest.AddressFamily));
                }
                if(publicRequest.IsSetAllocationDefaultNetmaskLength())
                {
                    request.Parameters.Add("AllocationDefaultNetmaskLength", StringUtils.FromInt(publicRequest.AllocationDefaultNetmaskLength));
                }
                if(publicRequest.IsSetAllocationMaxNetmaskLength())
                {
                    request.Parameters.Add("AllocationMaxNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMaxNetmaskLength));
                }
                if(publicRequest.IsSetAllocationMinNetmaskLength())
                {
                    request.Parameters.Add("AllocationMinNetmaskLength", StringUtils.FromInt(publicRequest.AllocationMinNetmaskLength));
                }
                if(publicRequest.IsSetAllocationResourceTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.AllocationResourceTags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("AllocationResourceTag" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("AllocationResourceTag" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetAutoImport())
                {
                    request.Parameters.Add("AutoImport", StringUtils.FromBool(publicRequest.AutoImport));
                }
                if(publicRequest.IsSetAwsService())
                {
                    request.Parameters.Add("AwsService", StringUtils.FromString(publicRequest.AwsService));
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
                if(publicRequest.IsSetIpamScopeId())
                {
                    request.Parameters.Add("IpamScopeId", StringUtils.FromString(publicRequest.IpamScopeId));
                }
                if(publicRequest.IsSetLocale())
                {
                    request.Parameters.Add("Locale", StringUtils.FromString(publicRequest.Locale));
                }
                if(publicRequest.IsSetPublicIpSource())
                {
                    request.Parameters.Add("PublicIpSource", StringUtils.FromString(publicRequest.PublicIpSource));
                }
                if(publicRequest.IsSetPubliclyAdvertisable())
                {
                    request.Parameters.Add("PubliclyAdvertisable", StringUtils.FromBool(publicRequest.PubliclyAdvertisable));
                }
                if(publicRequest.IsSetSourceIpamPoolId())
                {
                    request.Parameters.Add("SourceIpamPoolId", StringUtils.FromString(publicRequest.SourceIpamPoolId));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
            }
            return request;
        }
                    private static CreateIpamPoolRequestMarshaller _instance = new CreateIpamPoolRequestMarshaller();        

        internal static CreateIpamPoolRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIpamPoolRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}