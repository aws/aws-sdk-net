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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeOrganizationOverview Request Marshaller
    /// </summary>       
    public class DescribeOrganizationOverviewRequestMarshaller : IMarshaller<IRequest, DescribeOrganizationOverviewRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeOrganizationOverviewRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeOrganizationOverviewRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsGuru");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/organization/overview";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountIds())
                {
                    context.Writer.WritePropertyName("AccountIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                    {
                            context.Writer.Write(publicRequestAccountIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFromTime())
                {
                    context.Writer.WritePropertyName("FromTime");
                    context.Writer.Write(publicRequest.FromTime);
                }

                if(publicRequest.IsSetOrganizationalUnitIds())
                {
                    context.Writer.WritePropertyName("OrganizationalUnitIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestOrganizationalUnitIdsListValue in publicRequest.OrganizationalUnitIds)
                    {
                            context.Writer.Write(publicRequestOrganizationalUnitIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetToTime())
                {
                    context.Writer.WritePropertyName("ToTime");
                    context.Writer.Write(publicRequest.ToTime);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DescribeOrganizationOverviewRequestMarshaller _instance = new DescribeOrganizationOverviewRequestMarshaller();        

        internal static DescribeOrganizationOverviewRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeOrganizationOverviewRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}