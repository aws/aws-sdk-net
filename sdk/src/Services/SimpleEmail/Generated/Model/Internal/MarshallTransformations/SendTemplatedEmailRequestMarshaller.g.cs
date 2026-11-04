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
    /// SendTemplatedEmail Request Marshaller
    /// </summary>
    public partial class SendTemplatedEmailRequestMarshaller : IMarshaller<IRequest, SendTemplatedEmailRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendTemplatedEmailRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendTemplatedEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SendTemplatedEmail");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetConfigurationSetName())
            {
                request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
            }
            if (publicRequest.IsSetDestination())
            {
                if (publicRequest.Destination.IsSetBccAddresses())
                {
                    if (publicRequest.Destination.BccAddresses.Count == 0)
                    {
                        request.Parameters.Add("Destination" + ".BccAddresses", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Destination.BccAddresses)
                        {
                            request.Parameters.Add("Destination" + ".BccAddresses" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.Destination.IsSetCcAddresses())
                {
                    if (publicRequest.Destination.CcAddresses.Count == 0)
                    {
                        request.Parameters.Add("Destination" + ".CcAddresses", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Destination.CcAddresses)
                        {
                            request.Parameters.Add("Destination" + ".CcAddresses" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.Destination.IsSetToAddresses())
                {
                    if (publicRequest.Destination.ToAddresses.Count == 0)
                    {
                        request.Parameters.Add("Destination" + ".ToAddresses", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Destination.ToAddresses)
                        {
                            request.Parameters.Add("Destination" + ".ToAddresses" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
            }
            if (publicRequest.IsSetReplyToAddresses())
            {
                if (publicRequest.ReplyToAddresses.Count == 0)
                {
                    request.Parameters.Add("ReplyToAddresses", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.ReplyToAddresses)
                    {
                        request.Parameters.Add("ReplyToAddresses" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetReturnPath())
            {
                request.Parameters.Add("ReturnPath", StringUtils.FromString(publicRequest.ReturnPath));
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
            if (publicRequest.IsSetTemplate())
            {
                request.Parameters.Add("Template", StringUtils.FromString(publicRequest.Template));
            }
            if (publicRequest.IsSetTemplateArn())
            {
                request.Parameters.Add("TemplateArn", StringUtils.FromString(publicRequest.TemplateArn));
            }
            if (publicRequest.IsSetTemplateData())
            {
                request.Parameters.Add("TemplateData", StringUtils.FromString(publicRequest.TemplateData));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SendTemplatedEmailRequestMarshaller _instance = new();

        internal static SendTemplatedEmailRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendTemplatedEmailRequestMarshaller Instance => _instance;
    }
}
