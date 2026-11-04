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
    /// SendBounce Request Marshaller
    /// </summary>
    public partial class SendBounceRequestMarshaller : IMarshaller<IRequest, SendBounceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendBounceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendBounceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "SendBounce");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetBounceSender())
            {
                request.Parameters.Add("BounceSender", StringUtils.FromString(publicRequest.BounceSender));
            }
            if (publicRequest.IsSetBounceSenderArn())
            {
                request.Parameters.Add("BounceSenderArn", StringUtils.FromString(publicRequest.BounceSenderArn));
            }
            if (publicRequest.IsSetBouncedRecipientInfoList())
            {
                if (publicRequest.BouncedRecipientInfoList.Count == 0)
                {
                    request.Parameters.Add("BouncedRecipientInfoList", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.BouncedRecipientInfoList)
                    {
                        if (item0.IsSetBounceType())
                        {
                            request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".BounceType", StringUtils.FromString(item0.BounceType));
                        }
                        if (item0.IsSetRecipient())
                        {
                            request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".Recipient", StringUtils.FromString(item0.Recipient));
                        }
                        if (item0.IsSetRecipientArn())
                        {
                            request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientArn", StringUtils.FromString(item0.RecipientArn));
                        }
                        if (item0.IsSetRecipientDsnFields())
                        {
                            if (item0.RecipientDsnFields.IsSetAction())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".Action", StringUtils.FromString(item0.RecipientDsnFields.Action));
                            }
                            if (item0.RecipientDsnFields.IsSetDiagnosticCode())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".DiagnosticCode", StringUtils.FromString(item0.RecipientDsnFields.DiagnosticCode));
                            }
                            if (item0.RecipientDsnFields.IsSetExtensionFields())
                            {
                                if (item0.RecipientDsnFields.ExtensionFields.Count == 0)
                                {
                                    request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".ExtensionFields", "");
                                }
                                else
                                {
                                    int index2 = 1;
                                    foreach (var item2 in item0.RecipientDsnFields.ExtensionFields)
                                    {
                                        if (item2.IsSetName())
                                        {
                                            request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".ExtensionFields" + ".member" + "." + index2 + ".Name", StringUtils.FromString(item2.Name));
                                        }
                                        if (item2.IsSetValue())
                                        {
                                            request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".ExtensionFields" + ".member" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                        }
                                        index2++;
                                    }
                                }
                            }
                            if (item0.RecipientDsnFields.IsSetFinalRecipient())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".FinalRecipient", StringUtils.FromString(item0.RecipientDsnFields.FinalRecipient));
                            }
                            if (item0.RecipientDsnFields.IsSetLastAttemptDate())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".LastAttemptDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(item0.RecipientDsnFields.LastAttemptDate.Value));
                            }
                            if (item0.RecipientDsnFields.IsSetRemoteMta())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".RemoteMta", StringUtils.FromString(item0.RecipientDsnFields.RemoteMta));
                            }
                            if (item0.RecipientDsnFields.IsSetStatus())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + ".member" + "." + index0 + ".RecipientDsnFields" + ".Status", StringUtils.FromString(item0.RecipientDsnFields.Status));
                            }
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetExplanation())
            {
                request.Parameters.Add("Explanation", StringUtils.FromString(publicRequest.Explanation));
            }
            if (publicRequest.IsSetMessageDsn())
            {
                if (publicRequest.MessageDsn.IsSetArrivalDate())
                {
                    request.Parameters.Add("MessageDsn" + ".ArrivalDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.MessageDsn.ArrivalDate.Value));
                }
                if (publicRequest.MessageDsn.IsSetExtensionFields())
                {
                    if (publicRequest.MessageDsn.ExtensionFields.Count == 0)
                    {
                        request.Parameters.Add("MessageDsn" + ".ExtensionFields", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.MessageDsn.ExtensionFields)
                        {
                            if (item1.IsSetName())
                            {
                                request.Parameters.Add("MessageDsn" + ".ExtensionFields" + ".member" + "." + index1 + ".Name", StringUtils.FromString(item1.Name));
                            }
                            if (item1.IsSetValue())
                            {
                                request.Parameters.Add("MessageDsn" + ".ExtensionFields" + ".member" + "." + index1 + ".Value", StringUtils.FromString(item1.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.MessageDsn.IsSetReportingMta())
                {
                    request.Parameters.Add("MessageDsn" + ".ReportingMta", StringUtils.FromString(publicRequest.MessageDsn.ReportingMta));
                }
            }
            if (publicRequest.IsSetOriginalMessageId())
            {
                request.Parameters.Add("OriginalMessageId", StringUtils.FromString(publicRequest.OriginalMessageId));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly SendBounceRequestMarshaller _instance = new();

        internal static SendBounceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendBounceRequestMarshaller Instance => _instance;
    }
}
