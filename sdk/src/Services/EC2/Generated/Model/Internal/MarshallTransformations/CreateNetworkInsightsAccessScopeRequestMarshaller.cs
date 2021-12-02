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
    /// CreateNetworkInsightsAccessScope Request Marshaller
    /// </summary>       
    public class CreateNetworkInsightsAccessScopeRequestMarshaller : IMarshaller<IRequest, CreateNetworkInsightsAccessScopeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkInsightsAccessScopeRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNetworkInsightsAccessScopeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateNetworkInsightsAccessScope");
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
                if(publicRequest.IsSetExcludePaths())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ExcludePaths)
                    {
                        if(publicRequestlistValue.IsSetDestination())
                        {
                            if(publicRequestlistValue.Destination.IsSetPacketHeaderStatement())
                            {
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.DestinationAddresses)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "DestinationAddress" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.DestinationPorts)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "DestinationPort" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.DestinationPrefixLists)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "DestinationPrefixList" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetProtocols())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.Protocols)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "Protocol" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.SourceAddresses)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "SourceAddress" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.SourcePorts)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "SourcePort" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.SourcePrefixLists)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "SourcePrefixList" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                            }
                            if(publicRequestlistValue.Destination.IsSetResourceStatement())
                            {
                                if(publicRequestlistValue.Destination.ResourceStatement.IsSetResources())
                                {
                                    int publicRequestlistValueDestinationResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationResourceStatementlistValue in publicRequestlistValue.Destination.ResourceStatement.Resources)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "ResourceStatement" + "." + "Resource" + "." + publicRequestlistValueDestinationResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationResourceStatementlistValue));
                                        publicRequestlistValueDestinationResourceStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.ResourceStatement.IsSetResourceTypes())
                                {
                                    int publicRequestlistValueDestinationResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationResourceStatementlistValue in publicRequestlistValue.Destination.ResourceStatement.ResourceTypes)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "ResourceStatement" + "." + "ResourceType" + "." + publicRequestlistValueDestinationResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationResourceStatementlistValue));
                                        publicRequestlistValueDestinationResourceStatementlistValueIndex++;
                                    }
                                }
                            }
                        }
                        if(publicRequestlistValue.IsSetSource())
                        {
                            if(publicRequestlistValue.Source.IsSetPacketHeaderStatement())
                            {
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.DestinationAddresses)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "DestinationAddress" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.DestinationPorts)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "DestinationPort" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.DestinationPrefixLists)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "DestinationPrefixList" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetProtocols())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.Protocols)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "Protocol" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.SourceAddresses)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "SourceAddress" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.SourcePorts)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "SourcePort" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.SourcePrefixLists)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "SourcePrefixList" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                            }
                            if(publicRequestlistValue.Source.IsSetResourceStatement())
                            {
                                if(publicRequestlistValue.Source.ResourceStatement.IsSetResources())
                                {
                                    int publicRequestlistValueSourceResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourceResourceStatementlistValue in publicRequestlistValue.Source.ResourceStatement.Resources)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "ResourceStatement" + "." + "Resource" + "." + publicRequestlistValueSourceResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourceResourceStatementlistValue));
                                        publicRequestlistValueSourceResourceStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.ResourceStatement.IsSetResourceTypes())
                                {
                                    int publicRequestlistValueSourceResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourceResourceStatementlistValue in publicRequestlistValue.Source.ResourceStatement.ResourceTypes)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "ResourceStatement" + "." + "ResourceType" + "." + publicRequestlistValueSourceResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourceResourceStatementlistValue));
                                        publicRequestlistValueSourceResourceStatementlistValueIndex++;
                                    }
                                }
                            }
                        }
                        if(publicRequestlistValue.IsSetThroughResources())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ThroughResources)
                            {
                                if(publicRequestlistValuelistValue.IsSetResourceStatement())
                                {
                                    if(publicRequestlistValuelistValue.ResourceStatement.IsSetResources())
                                    {
                                        int publicRequestlistValuelistValueResourceStatementlistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueResourceStatementlistValue in publicRequestlistValuelistValue.ResourceStatement.Resources)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "ThroughResource" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceStatement" + "." + "Resource" + "." + publicRequestlistValuelistValueResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueResourceStatementlistValue));
                                            publicRequestlistValuelistValueResourceStatementlistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.ResourceStatement.IsSetResourceTypes())
                                    {
                                        int publicRequestlistValuelistValueResourceStatementlistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueResourceStatementlistValue in publicRequestlistValuelistValue.ResourceStatement.ResourceTypes)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + publicRequestlistValueIndex + "." + "ThroughResource" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceStatement" + "." + "ResourceType" + "." + publicRequestlistValuelistValueResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueResourceStatementlistValue));
                                            publicRequestlistValuelistValueResourceStatementlistValueIndex++;
                                        }
                                    }
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetMatchPaths())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.MatchPaths)
                    {
                        if(publicRequestlistValue.IsSetDestination())
                        {
                            if(publicRequestlistValue.Destination.IsSetPacketHeaderStatement())
                            {
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.DestinationAddresses)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "DestinationAddress" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.DestinationPorts)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "DestinationPort" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.DestinationPrefixLists)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "DestinationPrefixList" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetProtocols())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.Protocols)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "Protocol" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.SourceAddresses)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "SourceAddress" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.SourcePorts)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "SourcePort" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    int publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationPacketHeaderStatementlistValue in publicRequestlistValue.Destination.PacketHeaderStatement.SourcePrefixLists)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "PacketHeaderStatement" + "." + "SourcePrefixList" + "." + publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationPacketHeaderStatementlistValue));
                                        publicRequestlistValueDestinationPacketHeaderStatementlistValueIndex++;
                                    }
                                }
                            }
                            if(publicRequestlistValue.Destination.IsSetResourceStatement())
                            {
                                if(publicRequestlistValue.Destination.ResourceStatement.IsSetResources())
                                {
                                    int publicRequestlistValueDestinationResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationResourceStatementlistValue in publicRequestlistValue.Destination.ResourceStatement.Resources)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "ResourceStatement" + "." + "Resource" + "." + publicRequestlistValueDestinationResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationResourceStatementlistValue));
                                        publicRequestlistValueDestinationResourceStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Destination.ResourceStatement.IsSetResourceTypes())
                                {
                                    int publicRequestlistValueDestinationResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueDestinationResourceStatementlistValue in publicRequestlistValue.Destination.ResourceStatement.ResourceTypes)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "ResourceStatement" + "." + "ResourceType" + "." + publicRequestlistValueDestinationResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationResourceStatementlistValue));
                                        publicRequestlistValueDestinationResourceStatementlistValueIndex++;
                                    }
                                }
                            }
                        }
                        if(publicRequestlistValue.IsSetSource())
                        {
                            if(publicRequestlistValue.Source.IsSetPacketHeaderStatement())
                            {
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.DestinationAddresses)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "DestinationAddress" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.DestinationPorts)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "DestinationPort" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.DestinationPrefixLists)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "DestinationPrefixList" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetProtocols())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.Protocols)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "Protocol" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.SourceAddresses)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "SourceAddress" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.SourcePorts)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "SourcePort" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    int publicRequestlistValueSourcePacketHeaderStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourcePacketHeaderStatementlistValue in publicRequestlistValue.Source.PacketHeaderStatement.SourcePrefixLists)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "PacketHeaderStatement" + "." + "SourcePrefixList" + "." + publicRequestlistValueSourcePacketHeaderStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourcePacketHeaderStatementlistValue));
                                        publicRequestlistValueSourcePacketHeaderStatementlistValueIndex++;
                                    }
                                }
                            }
                            if(publicRequestlistValue.Source.IsSetResourceStatement())
                            {
                                if(publicRequestlistValue.Source.ResourceStatement.IsSetResources())
                                {
                                    int publicRequestlistValueSourceResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourceResourceStatementlistValue in publicRequestlistValue.Source.ResourceStatement.Resources)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "ResourceStatement" + "." + "Resource" + "." + publicRequestlistValueSourceResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourceResourceStatementlistValue));
                                        publicRequestlistValueSourceResourceStatementlistValueIndex++;
                                    }
                                }
                                if(publicRequestlistValue.Source.ResourceStatement.IsSetResourceTypes())
                                {
                                    int publicRequestlistValueSourceResourceStatementlistValueIndex = 1;
                                    foreach(var publicRequestlistValueSourceResourceStatementlistValue in publicRequestlistValue.Source.ResourceStatement.ResourceTypes)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "Source" + "." + "ResourceStatement" + "." + "ResourceType" + "." + publicRequestlistValueSourceResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValueSourceResourceStatementlistValue));
                                        publicRequestlistValueSourceResourceStatementlistValueIndex++;
                                    }
                                }
                            }
                        }
                        if(publicRequestlistValue.IsSetThroughResources())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ThroughResources)
                            {
                                if(publicRequestlistValuelistValue.IsSetResourceStatement())
                                {
                                    if(publicRequestlistValuelistValue.ResourceStatement.IsSetResources())
                                    {
                                        int publicRequestlistValuelistValueResourceStatementlistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueResourceStatementlistValue in publicRequestlistValuelistValue.ResourceStatement.Resources)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "ThroughResource" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceStatement" + "." + "Resource" + "." + publicRequestlistValuelistValueResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueResourceStatementlistValue));
                                            publicRequestlistValuelistValueResourceStatementlistValueIndex++;
                                        }
                                    }
                                    if(publicRequestlistValuelistValue.ResourceStatement.IsSetResourceTypes())
                                    {
                                        int publicRequestlistValuelistValueResourceStatementlistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueResourceStatementlistValue in publicRequestlistValuelistValue.ResourceStatement.ResourceTypes)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + publicRequestlistValueIndex + "." + "ThroughResource" + "." + publicRequestlistValuelistValueIndex + "." + "ResourceStatement" + "." + "ResourceType" + "." + publicRequestlistValuelistValueResourceStatementlistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueResourceStatementlistValue));
                                            publicRequestlistValuelistValueResourceStatementlistValueIndex++;
                                        }
                                    }
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
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
                    private static CreateNetworkInsightsAccessScopeRequestMarshaller _instance = new CreateNetworkInsightsAccessScopeRequestMarshaller();        

        internal static CreateNetworkInsightsAccessScopeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNetworkInsightsAccessScopeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}