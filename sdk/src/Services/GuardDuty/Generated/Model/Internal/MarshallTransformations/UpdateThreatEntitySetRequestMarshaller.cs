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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateThreatEntitySet Request Marshaller
    /// </summary>       
    public class UpdateThreatEntitySetRequestMarshaller : IMarshaller<IRequest, UpdateThreatEntitySetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateThreatEntitySetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateThreatEntitySetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GuardDuty");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-11-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDetectorId())
                throw new AmazonGuardDutyException("Request object does not have required field DetectorId set");
            request.AddPathResource("{detectorId}", StringUtils.FromString(publicRequest.DetectorId));
            if (!publicRequest.IsSetThreatEntitySetId())
                throw new AmazonGuardDutyException("Request object does not have required field ThreatEntitySetId set");
            request.AddPathResource("{threatEntitySetId}", StringUtils.FromString(publicRequest.ThreatEntitySetId));
            request.ResourcePath = "/detector/{detectorId}/threatentityset/{threatEntitySetId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActivate())
                {
                    context.Writer.WritePropertyName("activate");
                    context.Writer.Write(publicRequest.Activate);
                }

                if(publicRequest.IsSetExpectedBucketOwner())
                {
                    context.Writer.WritePropertyName("expectedBucketOwner");
                    context.Writer.Write(publicRequest.ExpectedBucketOwner);
                }

                if(publicRequest.IsSetLocation())
                {
                    context.Writer.WritePropertyName("location");
                    context.Writer.Write(publicRequest.Location);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateThreatEntitySetRequestMarshaller _instance = new UpdateThreatEntitySetRequestMarshaller();        

        internal static UpdateThreatEntitySetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateThreatEntitySetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}