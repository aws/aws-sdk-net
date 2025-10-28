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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListContacts Request Marshaller
    /// </summary>       
    public class ListContactsRequestMarshaller : IMarshaller<IRequest, ListContactsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListContactsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListContactsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GroundStation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-05-23";
            request.HttpMethod = "POST";

            request.ResourcePath = "/contacts";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetEndTime())
                {
                    context.Writer.WritePropertyName("endTime");
                    context.Writer.Write(publicRequest.EndTime);
                }

                if(publicRequest.IsSetEphemeris())
                {
                    context.Writer.WritePropertyName("ephemeris");
                    context.Writer.WriteObjectStart();

                    var marshaller = EphemerisFilterMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Ephemeris, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetGroundStation())
                {
                    context.Writer.WritePropertyName("groundStation");
                    context.Writer.Write(publicRequest.GroundStation);
                }

                if(publicRequest.IsSetMaxResults())
                {
                    context.Writer.WritePropertyName("maxResults");
                    context.Writer.Write(publicRequest.MaxResults);
                }

                if(publicRequest.IsSetMissionProfileArn())
                {
                    context.Writer.WritePropertyName("missionProfileArn");
                    context.Writer.Write(publicRequest.MissionProfileArn);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetSatelliteArn())
                {
                    context.Writer.WritePropertyName("satelliteArn");
                    context.Writer.Write(publicRequest.SatelliteArn);
                }

                if(publicRequest.IsSetStartTime())
                {
                    context.Writer.WritePropertyName("startTime");
                    context.Writer.Write(publicRequest.StartTime);
                }

                if(publicRequest.IsSetStatusList())
                {
                    context.Writer.WritePropertyName("statusList");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStatusListListValue in publicRequest.StatusList)
                    {
                            context.Writer.Write(publicRequestStatusListListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ListContactsRequestMarshaller _instance = new ListContactsRequestMarshaller();        

        internal static ListContactsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListContactsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}