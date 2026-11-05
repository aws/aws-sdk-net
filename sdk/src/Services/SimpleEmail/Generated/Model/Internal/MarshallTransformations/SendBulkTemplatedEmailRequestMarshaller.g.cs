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
    /// SendBulkTemplatedEmail Request Marshaller
    /// </summary>
    public partial class SendBulkTemplatedEmailRequestMarshaller : IMarshaller<IRequest, SendBulkTemplatedEmailRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendBulkTemplatedEmailRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendBulkTemplatedEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SendBulkTemplatedEmail");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetConfigurationSetName())
            {
                request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
            }
            if (publicRequest.IsSetDefaultTags())
            {
                if (publicRequest.DefaultTags.Count == 0)
                {
                    request.Parameters.Add("DefaultTags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DefaultTags)
                    {
                        if (item0.IsSetName())
                        {
                            request.Parameters.Add("DefaultTags" + ".member" + "." + index0 + ".Name", StringUtils.FromString(item0.Name));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("DefaultTags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDefaultTemplateData())
            {
                request.Parameters.Add("DefaultTemplateData", StringUtils.FromString(publicRequest.DefaultTemplateData));
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
                        if (item0.IsSetDestination())
                        {
                            if (item0.Destination.IsSetBccAddresses())
                            {
                                if (item0.Destination.BccAddresses.Count == 0)
                                {
                                    request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".Destination" + ".BccAddresses", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.Destination.BccAddresses)
                                    {
                                        request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".Destination" + ".BccAddresses" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            if (item0.Destination.IsSetCcAddresses())
                            {
                                if (item0.Destination.CcAddresses.Count == 0)
                                {
                                    request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".Destination" + ".CcAddresses", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.Destination.CcAddresses)
                                    {
                                        request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".Destination" + ".CcAddresses" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                            if (item0.Destination.IsSetToAddresses())
                            {
                                if (item0.Destination.ToAddresses.Count == 0)
                                {
                                    request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".Destination" + ".ToAddresses", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.Destination.ToAddresses)
                                    {
                                        request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".Destination" + ".ToAddresses" + ".member" + "." + index2, StringUtils.FromString(item2));
                                        index2++;
                                    }
                                }
                            }
                        }
                        if (item0.IsSetReplacementTags())
                        {
                            if (item0.ReplacementTags.Count == 0)
                            {
                                request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".ReplacementTags", "");
                            }
                            else
                            {
                                int index1 = 1;
                                foreach (var item1 in item0.ReplacementTags)
                                {
                                    if (item1.IsSetName())
                                    {
                                        request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".ReplacementTags" + ".member" + "." + index1 + ".Name", StringUtils.FromString(item1.Name));
                                    }
                                    if (item1.IsSetValue())
                                    {
                                        request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".ReplacementTags" + ".member" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                                    }
                                    index1++;
                                }
                            }
                        }
                        if (item0.IsSetReplacementTemplateData())
                        {
                            request.Parameters.Add("Destinations" + ".member" + "." + index0 + ".ReplacementTemplateData", StringUtils.FromString(item0.ReplacementTemplateData));
                        }
                        index0++;
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
            if (publicRequest.IsSetTemplate())
            {
                request.Parameters.Add("Template", StringUtils.FromString(publicRequest.Template));
            }
            if (publicRequest.IsSetTemplateArn())
            {
                request.Parameters.Add("TemplateArn", StringUtils.FromString(publicRequest.TemplateArn));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SendBulkTemplatedEmailRequestMarshaller _instance = new();

        internal static SendBulkTemplatedEmailRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendBulkTemplatedEmailRequestMarshaller Instance => _instance;
    }
}
