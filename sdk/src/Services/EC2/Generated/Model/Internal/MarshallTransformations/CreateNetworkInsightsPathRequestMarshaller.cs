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
    /// CreateNetworkInsightsPath Request Marshaller
    /// </summary>       
    public class CreateNetworkInsightsPathRequestMarshaller : IMarshaller<IRequest, CreateNetworkInsightsPathRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkInsightsPathRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNetworkInsightsPathRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateNetworkInsightsPath");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                else if(!(publicRequest.IsSetClientToken()))
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
                }
                if(publicRequest.IsSetDestination())
                {
                    request.Parameters.Add("Destination", StringUtils.FromString(publicRequest.Destination));
                }
                if(publicRequest.IsSetDestinationIp())
                {
                    request.Parameters.Add("DestinationIp", StringUtils.FromString(publicRequest.DestinationIp));
                }
                if(publicRequest.IsSetDestinationPort())
                {
                    request.Parameters.Add("DestinationPort", StringUtils.FromInt(publicRequest.DestinationPort));
                }
                if(publicRequest.IsSetFilterAtDestination())
                {
                    if(publicRequest.FilterAtDestination.IsSetDestinationAddress())
                    {
                        request.Parameters.Add("FilterAtDestination" + "." + "DestinationAddress", StringUtils.FromString(publicRequest.FilterAtDestination.DestinationAddress));
                    }
                    if(publicRequest.FilterAtDestination.IsSetDestinationPortRange())
                    {
                        if(publicRequest.FilterAtDestination.DestinationPortRange.IsSetFromPort())
                        {
                            request.Parameters.Add("FilterAtDestination" + "." + "DestinationPortRange" + "." + "FromPort", StringUtils.FromInt(publicRequest.FilterAtDestination.DestinationPortRange.FromPort));
                        }
                        if(publicRequest.FilterAtDestination.DestinationPortRange.IsSetToPort())
                        {
                            request.Parameters.Add("FilterAtDestination" + "." + "DestinationPortRange" + "." + "ToPort", StringUtils.FromInt(publicRequest.FilterAtDestination.DestinationPortRange.ToPort));
                        }
                    }
                    if(publicRequest.FilterAtDestination.IsSetSourceAddress())
                    {
                        request.Parameters.Add("FilterAtDestination" + "." + "SourceAddress", StringUtils.FromString(publicRequest.FilterAtDestination.SourceAddress));
                    }
                    if(publicRequest.FilterAtDestination.IsSetSourcePortRange())
                    {
                        if(publicRequest.FilterAtDestination.SourcePortRange.IsSetFromPort())
                        {
                            request.Parameters.Add("FilterAtDestination" + "." + "SourcePortRange" + "." + "FromPort", StringUtils.FromInt(publicRequest.FilterAtDestination.SourcePortRange.FromPort));
                        }
                        if(publicRequest.FilterAtDestination.SourcePortRange.IsSetToPort())
                        {
                            request.Parameters.Add("FilterAtDestination" + "." + "SourcePortRange" + "." + "ToPort", StringUtils.FromInt(publicRequest.FilterAtDestination.SourcePortRange.ToPort));
                        }
                    }
                }
                if(publicRequest.IsSetFilterAtSource())
                {
                    if(publicRequest.FilterAtSource.IsSetDestinationAddress())
                    {
                        request.Parameters.Add("FilterAtSource" + "." + "DestinationAddress", StringUtils.FromString(publicRequest.FilterAtSource.DestinationAddress));
                    }
                    if(publicRequest.FilterAtSource.IsSetDestinationPortRange())
                    {
                        if(publicRequest.FilterAtSource.DestinationPortRange.IsSetFromPort())
                        {
                            request.Parameters.Add("FilterAtSource" + "." + "DestinationPortRange" + "." + "FromPort", StringUtils.FromInt(publicRequest.FilterAtSource.DestinationPortRange.FromPort));
                        }
                        if(publicRequest.FilterAtSource.DestinationPortRange.IsSetToPort())
                        {
                            request.Parameters.Add("FilterAtSource" + "." + "DestinationPortRange" + "." + "ToPort", StringUtils.FromInt(publicRequest.FilterAtSource.DestinationPortRange.ToPort));
                        }
                    }
                    if(publicRequest.FilterAtSource.IsSetSourceAddress())
                    {
                        request.Parameters.Add("FilterAtSource" + "." + "SourceAddress", StringUtils.FromString(publicRequest.FilterAtSource.SourceAddress));
                    }
                    if(publicRequest.FilterAtSource.IsSetSourcePortRange())
                    {
                        if(publicRequest.FilterAtSource.SourcePortRange.IsSetFromPort())
                        {
                            request.Parameters.Add("FilterAtSource" + "." + "SourcePortRange" + "." + "FromPort", StringUtils.FromInt(publicRequest.FilterAtSource.SourcePortRange.FromPort));
                        }
                        if(publicRequest.FilterAtSource.SourcePortRange.IsSetToPort())
                        {
                            request.Parameters.Add("FilterAtSource" + "." + "SourcePortRange" + "." + "ToPort", StringUtils.FromInt(publicRequest.FilterAtSource.SourcePortRange.ToPort));
                        }
                    }
                }
                if(publicRequest.IsSetProtocol())
                {
                    request.Parameters.Add("Protocol", StringUtils.FromString(publicRequest.Protocol));
                }
                if(publicRequest.IsSetSource())
                {
                    request.Parameters.Add("Source", StringUtils.FromString(publicRequest.Source));
                }
                if(publicRequest.IsSetSourceIp())
                {
                    request.Parameters.Add("SourceIp", StringUtils.FromString(publicRequest.SourceIp));
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
                    private static CreateNetworkInsightsPathRequestMarshaller _instance = new CreateNetworkInsightsPathRequestMarshaller();        

        internal static CreateNetworkInsightsPathRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNetworkInsightsPathRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}