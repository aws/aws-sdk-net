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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAttendee Request Marshaller
    /// </summary>       
    public class DeleteAttendeeRequestMarshaller : IMarshaller<IRequest, DeleteAttendeeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAttendeeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteAttendeeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMeetings");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAttendeeId())
                throw new AmazonChimeSDKMeetingsException("Request object does not have required field AttendeeId set");
            request.AddPathResource("{AttendeeId}", StringUtils.FromString(publicRequest.AttendeeId));
            if (!publicRequest.IsSetMeetingId())
                throw new AmazonChimeSDKMeetingsException("Request object does not have required field MeetingId set");
            request.AddPathResource("{MeetingId}", StringUtils.FromString(publicRequest.MeetingId));
            request.ResourcePath = "/meetings/{MeetingId}/attendees/{AttendeeId}";

            return request;
        }
        private static DeleteAttendeeRequestMarshaller _instance = new DeleteAttendeeRequestMarshaller();        

        internal static DeleteAttendeeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteAttendeeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}