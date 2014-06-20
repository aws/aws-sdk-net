/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AddInstanceGroups Request Marshaller
    /// </summary>       
    public class AddInstanceGroupsRequestMarshaller : IMarshaller<IRequest, AddInstanceGroupsRequest> 
    {
        public IRequest Marshall(AddInstanceGroupsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.AddInstanceGroups";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetInstanceGroups())
                {
                    writer.WritePropertyName("InstanceGroups");
                    writer.WriteArrayStart();
                    foreach(var publicRequestInstanceGroupsListValue in publicRequest.InstanceGroups)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestInstanceGroupsListValue.IsSetBidPrice())
                        {
                            writer.WritePropertyName("BidPrice");
                            writer.Write(publicRequestInstanceGroupsListValue.BidPrice);
                        }

                        if(publicRequestInstanceGroupsListValue.IsSetInstanceCount())
                        {
                            writer.WritePropertyName("InstanceCount");
                            writer.Write(publicRequestInstanceGroupsListValue.InstanceCount);
                        }

                        if(publicRequestInstanceGroupsListValue.IsSetInstanceRole())
                        {
                            writer.WritePropertyName("InstanceRole");
                            writer.Write(publicRequestInstanceGroupsListValue.InstanceRole);
                        }

                        if(publicRequestInstanceGroupsListValue.IsSetInstanceType())
                        {
                            writer.WritePropertyName("InstanceType");
                            writer.Write(publicRequestInstanceGroupsListValue.InstanceType);
                        }

                        if(publicRequestInstanceGroupsListValue.IsSetMarket())
                        {
                            writer.WritePropertyName("Market");
                            writer.Write(publicRequestInstanceGroupsListValue.Market);
                        }

                        if(publicRequestInstanceGroupsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestInstanceGroupsListValue.Name);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetJobFlowId())
                {
                    writer.WritePropertyName("JobFlowId");
                    writer.Write(publicRequest.JobFlowId);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}