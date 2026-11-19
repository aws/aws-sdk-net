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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNetworkInsightsAccessScope Request Marshaller
    /// </summary>
    public partial class CreateNetworkInsightsAccessScopeRequestMarshaller : IMarshaller<IRequest, CreateNetworkInsightsAccessScopeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNetworkInsightsAccessScopeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateNetworkInsightsAccessScopeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateNetworkInsightsAccessScope");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetClientToken())
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
            }
            else
            {
                request.Parameters.Add("ClientToken", StringUtils.FromString(Guid.NewGuid().ToString()));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetExcludePaths())
            {
                if (publicRequest.ExcludePaths.Count == 0)
                {
                    request.Parameters.Add("ExcludePath", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ExcludePaths)
                    {
                        if (item0.IsSetDestination())
                        {
                            if (item0.Destination.IsSetPacketHeaderStatement())
                            {
                                if (item0.Destination.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    if (item0.Destination.PacketHeaderStatement.DestinationAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.DestinationAddresses)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    if (item0.Destination.PacketHeaderStatement.DestinationPorts.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.DestinationPorts)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    if (item0.Destination.PacketHeaderStatement.DestinationPrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.DestinationPrefixLists)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetProtocols())
                                {
                                    if (item0.Destination.PacketHeaderStatement.Protocols.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".Protocol", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.Protocols)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".Protocol" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    if (item0.Destination.PacketHeaderStatement.SourceAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourceAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.SourceAddresses)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourceAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    if (item0.Destination.PacketHeaderStatement.SourcePorts.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.SourcePorts)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    if (item0.Destination.PacketHeaderStatement.SourcePrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.SourcePrefixLists)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                            if (item0.Destination.IsSetResourceStatement())
                            {
                                if (item0.Destination.ResourceStatement.IsSetResourceTypes())
                                {
                                    if (item0.Destination.ResourceStatement.ResourceTypes.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".ResourceType", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.ResourceStatement.ResourceTypes)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".ResourceType" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.ResourceStatement.IsSetResources())
                                {
                                    if (item0.Destination.ResourceStatement.Resources.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".Resource", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.ResourceStatement.Resources)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".Resource" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                        }
                        if (item0.IsSetSource())
                        {
                            if (item0.Source.IsSetPacketHeaderStatement())
                            {
                                if (item0.Source.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    if (item0.Source.PacketHeaderStatement.DestinationAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.DestinationAddresses)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    if (item0.Source.PacketHeaderStatement.DestinationPorts.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.DestinationPorts)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    if (item0.Source.PacketHeaderStatement.DestinationPrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.DestinationPrefixLists)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetProtocols())
                                {
                                    if (item0.Source.PacketHeaderStatement.Protocols.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".Protocol", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.Protocols)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".Protocol" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    if (item0.Source.PacketHeaderStatement.SourceAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourceAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.SourceAddresses)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourceAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    if (item0.Source.PacketHeaderStatement.SourcePorts.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.SourcePorts)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    if (item0.Source.PacketHeaderStatement.SourcePrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.SourcePrefixLists)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                            if (item0.Source.IsSetResourceStatement())
                            {
                                if (item0.Source.ResourceStatement.IsSetResourceTypes())
                                {
                                    if (item0.Source.ResourceStatement.ResourceTypes.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".ResourceStatement" + ".ResourceType", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.ResourceStatement.ResourceTypes)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".ResourceStatement" + ".ResourceType" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.ResourceStatement.IsSetResources())
                                {
                                    if (item0.Source.ResourceStatement.Resources.Count == 0)
                                    {
                                        request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".ResourceStatement" + ".Resource", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.ResourceStatement.Resources)
                                        {
                                            request.Parameters.Add("ExcludePath" + "." + index0 + ".Source" + ".ResourceStatement" + ".Resource" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                        }
                        if (item0.IsSetThroughResources())
                        {
                            if (item0.ThroughResources.Count == 0)
                            {
                                request.Parameters.Add("ExcludePath" + "." + index0 + ".ThroughResource", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ThroughResources)
                                {
                                    if (item1.IsSetResourceStatement())
                                    {
                                        if (item1.ResourceStatement.IsSetResourceTypes())
                                        {
                                            if (item1.ResourceStatement.ResourceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("ExcludePath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".ResourceType", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.ResourceStatement.ResourceTypes)
                                                {
                                                    request.Parameters.Add("ExcludePath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".ResourceType" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.ResourceStatement.IsSetResources())
                                        {
                                            if (item1.ResourceStatement.Resources.Count == 0)
                                            {
                                                request.Parameters.Add("ExcludePath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".Resource", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.ResourceStatement.Resources)
                                                {
                                                    request.Parameters.Add("ExcludePath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".Resource" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetMatchPaths())
            {
                if (publicRequest.MatchPaths.Count == 0)
                {
                    request.Parameters.Add("MatchPath", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.MatchPaths)
                    {
                        if (item0.IsSetDestination())
                        {
                            if (item0.Destination.IsSetPacketHeaderStatement())
                            {
                                if (item0.Destination.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    if (item0.Destination.PacketHeaderStatement.DestinationAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.DestinationAddresses)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    if (item0.Destination.PacketHeaderStatement.DestinationPorts.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.DestinationPorts)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    if (item0.Destination.PacketHeaderStatement.DestinationPrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.DestinationPrefixLists)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".DestinationPrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetProtocols())
                                {
                                    if (item0.Destination.PacketHeaderStatement.Protocols.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".Protocol", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.Protocols)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".Protocol" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    if (item0.Destination.PacketHeaderStatement.SourceAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourceAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.SourceAddresses)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourceAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    if (item0.Destination.PacketHeaderStatement.SourcePorts.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.SourcePorts)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    if (item0.Destination.PacketHeaderStatement.SourcePrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.PacketHeaderStatement.SourcePrefixLists)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".PacketHeaderStatement" + ".SourcePrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                            if (item0.Destination.IsSetResourceStatement())
                            {
                                if (item0.Destination.ResourceStatement.IsSetResourceTypes())
                                {
                                    if (item0.Destination.ResourceStatement.ResourceTypes.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".ResourceType", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.ResourceStatement.ResourceTypes)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".ResourceType" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Destination.ResourceStatement.IsSetResources())
                                {
                                    if (item0.Destination.ResourceStatement.Resources.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".Resource", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Destination.ResourceStatement.Resources)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Destination" + ".ResourceStatement" + ".Resource" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                        }
                        if (item0.IsSetSource())
                        {
                            if (item0.Source.IsSetPacketHeaderStatement())
                            {
                                if (item0.Source.PacketHeaderStatement.IsSetDestinationAddresses())
                                {
                                    if (item0.Source.PacketHeaderStatement.DestinationAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.DestinationAddresses)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetDestinationPorts())
                                {
                                    if (item0.Source.PacketHeaderStatement.DestinationPorts.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.DestinationPorts)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetDestinationPrefixLists())
                                {
                                    if (item0.Source.PacketHeaderStatement.DestinationPrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.DestinationPrefixLists)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".DestinationPrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetProtocols())
                                {
                                    if (item0.Source.PacketHeaderStatement.Protocols.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".Protocol", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.Protocols)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".Protocol" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetSourceAddresses())
                                {
                                    if (item0.Source.PacketHeaderStatement.SourceAddresses.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourceAddress", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.SourceAddresses)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourceAddress" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetSourcePorts())
                                {
                                    if (item0.Source.PacketHeaderStatement.SourcePorts.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePort", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.SourcePorts)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePort" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.PacketHeaderStatement.IsSetSourcePrefixLists())
                                {
                                    if (item0.Source.PacketHeaderStatement.SourcePrefixLists.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePrefixList", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.PacketHeaderStatement.SourcePrefixLists)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".PacketHeaderStatement" + ".SourcePrefixList" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                            if (item0.Source.IsSetResourceStatement())
                            {
                                if (item0.Source.ResourceStatement.IsSetResourceTypes())
                                {
                                    if (item0.Source.ResourceStatement.ResourceTypes.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".ResourceStatement" + ".ResourceType", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.ResourceStatement.ResourceTypes)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".ResourceStatement" + ".ResourceType" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                                if (item0.Source.ResourceStatement.IsSetResources())
                                {
                                    if (item0.Source.ResourceStatement.Resources.Count == 0)
                                    {
                                        request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".ResourceStatement" + ".Resource", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item0.Source.ResourceStatement.Resources)
                                        {
                                            request.Parameters.Add("MatchPath" + "." + index0 + ".Source" + ".ResourceStatement" + ".Resource" + "." + index3, StringUtils.FromString(item3));
                                            index3++;
                                        }
                                    }
                                }
                            }
                        }
                        if (item0.IsSetThroughResources())
                        {
                            if (item0.ThroughResources.Count == 0)
                            {
                                request.Parameters.Add("MatchPath" + "." + index0 + ".ThroughResource", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ThroughResources)
                                {
                                    if (item1.IsSetResourceStatement())
                                    {
                                        if (item1.ResourceStatement.IsSetResourceTypes())
                                        {
                                            if (item1.ResourceStatement.ResourceTypes.Count == 0)
                                            {
                                                request.Parameters.Add("MatchPath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".ResourceType", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.ResourceStatement.ResourceTypes)
                                                {
                                                    request.Parameters.Add("MatchPath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".ResourceType" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                        if (item1.ResourceStatement.IsSetResources())
                                        {
                                            if (item1.ResourceStatement.Resources.Count == 0)
                                            {
                                                request.Parameters.Add("MatchPath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".Resource", "");
                                            }
                                            else
                                            {
                                                int index3 = 1;
                                                foreach (var item3 in item1.ResourceStatement.Resources)
                                                {
                                                    request.Parameters.Add("MatchPath" + "." + index0 + ".ThroughResource" + "." + index1 + ".ResourceStatement" + ".Resource" + "." + index3, StringUtils.FromString(item3));
                                                    index3++;
                                                }
                                            }
                                        }
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTagSpecifications())
            {
                if (publicRequest.TagSpecifications.Count == 0)
                {
                    request.Parameters.Add("TagSpecification", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.TagSpecifications)
                    {
                        if (item0.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + index0 + ".ResourceType", StringUtils.FromString(item0.ResourceType));
                        }
                        if (item0.IsSetTags())
                        {
                            if (item0.Tags.Count == 0)
                            {
                                request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.Tags)
                                {
                                    if (item1.IsSetKey())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Key", StringUtils.FromString(item1.Key));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("TagSpecification" + "." + index0 + ".Tag" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        index0++;
                    }
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateNetworkInsightsAccessScopeRequestMarshaller _instance = new();

        internal static CreateNetworkInsightsAccessScopeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateNetworkInsightsAccessScopeRequestMarshaller Instance => _instance;
    }
}
