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

using Amazon.SimpleEmail.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendRawEmail Request Marshaller
    /// </summary>
    public partial class SendRawEmailRequestMarshaller : IMarshaller<IRequest, SendRawEmailRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendRawEmailRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendRawEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SendRawEmail");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetConfigurationSetName())
            {
                request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
            }
            if (publicRequest.IsSetDestinations())
            {
                if (publicRequest.Destinations.Count == 0)
                {
                    request.Parameters.Add("Destinations", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Destinations)
                    {
                        request.Parameters.Add("Destinations" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetFromArn())
            {
                request.Parameters.Add("FromArn", StringUtils.FromString(publicRequest.FromArn));
            }
            if (publicRequest.IsSetRawMessage())
            {
                if (publicRequest.RawMessage.IsSetData())
                {
                    request.Parameters.Add("RawMessage" + ".Data", StringUtils.FromMemoryStream(publicRequest.RawMessage.Data));
                }
            }
            if (publicRequest.IsSetReturnPathArn())
            {
                request.Parameters.Add("ReturnPathArn", StringUtils.FromString(publicRequest.ReturnPathArn));
            }
            if (publicRequest.IsSetSource())
            {
                request.Parameters.Add("Source", StringUtils.FromString(publicRequest.Source));
            }
            if (publicRequest.IsSetSourceArn())
            {
                request.Parameters.Add("SourceArn", StringUtils.FromString(publicRequest.SourceArn));
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
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

        private static readonly SendRawEmailRequestMarshaller _instance = new();

        internal static SendRawEmailRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendRawEmailRequestMarshaller Instance => _instance;
    }
}
