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

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeVolumes Request Marshaller
    /// </summary>       
    public class DescribeVolumesRequestMarshaller : IMarshaller<IRequest, DescribeVolumesRequest> 
    {
        public IRequest Marshall(DescribeVolumesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorks");
            string target = "OpsWorks_20130218.DescribeVolumes";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetInstanceId())
                {
                    writer.WritePropertyName("InstanceId");
                    writer.Write(publicRequest.InstanceId);
                }

                if(publicRequest.IsSetRaidArrayId())
                {
                    writer.WritePropertyName("RaidArrayId");
                    writer.Write(publicRequest.RaidArrayId);
                }

                if(publicRequest.IsSetStackId())
                {
                    writer.WritePropertyName("StackId");
                    writer.Write(publicRequest.StackId);
                }

                if(publicRequest.IsSetVolumeIds())
                {
                    writer.WritePropertyName("VolumeIds");
                    writer.WriteArrayStart();
                    foreach(var publicRequestVolumeIdsListValue in publicRequest.VolumeIds)
                    {
                        writer.Write(publicRequestVolumeIdsListValue);
                    }
                    writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}