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
    /// CreateReceiptRule Request Marshaller
    /// </summary>
    public partial class CreateReceiptRuleRequestMarshaller : IMarshaller<IRequest, CreateReceiptRuleRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReceiptRuleRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateReceiptRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateReceiptRule");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetAfter())
            {
                request.Parameters.Add("After", StringUtils.FromString(publicRequest.After));
            }
            if (publicRequest.IsSetRule())
            {
                if (publicRequest.Rule.IsSetActions())
                {
                    if (publicRequest.Rule.Actions.Count == 0)
                    {
                        request.Parameters.Add("Rule" + ".Actions", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Rule.Actions)
                        {
                            if (item1.IsSetAddHeaderAction())
                            {
                                if (item1.AddHeaderAction.IsSetHeaderName())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".AddHeaderAction" + ".HeaderName", StringUtils.FromString(item1.AddHeaderAction.HeaderName));
                                }
                                if (item1.AddHeaderAction.IsSetHeaderValue())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".AddHeaderAction" + ".HeaderValue", StringUtils.FromString(item1.AddHeaderAction.HeaderValue));
                                }
                            }
                            if (item1.IsSetBounceAction())
                            {
                                if (item1.BounceAction.IsSetMessage())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".BounceAction" + ".Message", StringUtils.FromString(item1.BounceAction.Message));
                                }
                                if (item1.BounceAction.IsSetSender())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".BounceAction" + ".Sender", StringUtils.FromString(item1.BounceAction.Sender));
                                }
                                if (item1.BounceAction.IsSetSmtpReplyCode())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".BounceAction" + ".SmtpReplyCode", StringUtils.FromString(item1.BounceAction.SmtpReplyCode));
                                }
                                if (item1.BounceAction.IsSetStatusCode())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".BounceAction" + ".StatusCode", StringUtils.FromString(item1.BounceAction.StatusCode));
                                }
                                if (item1.BounceAction.IsSetTopicArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".BounceAction" + ".TopicArn", StringUtils.FromString(item1.BounceAction.TopicArn));
                                }
                            }
                            if (item1.IsSetConnectAction())
                            {
                                if (item1.ConnectAction.IsSetIAMRoleARN())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".ConnectAction" + ".IAMRoleARN", StringUtils.FromString(item1.ConnectAction.IAMRoleARN));
                                }
                                if (item1.ConnectAction.IsSetInstanceARN())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".ConnectAction" + ".InstanceARN", StringUtils.FromString(item1.ConnectAction.InstanceARN));
                                }
                            }
                            if (item1.IsSetLambdaAction())
                            {
                                if (item1.LambdaAction.IsSetFunctionArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".LambdaAction" + ".FunctionArn", StringUtils.FromString(item1.LambdaAction.FunctionArn));
                                }
                                if (item1.LambdaAction.IsSetInvocationType())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".LambdaAction" + ".InvocationType", StringUtils.FromString(item1.LambdaAction.InvocationType));
                                }
                                if (item1.LambdaAction.IsSetTopicArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".LambdaAction" + ".TopicArn", StringUtils.FromString(item1.LambdaAction.TopicArn));
                                }
                            }
                            if (item1.IsSetS3Action())
                            {
                                if (item1.S3Action.IsSetBucketName())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".S3Action" + ".BucketName", StringUtils.FromString(item1.S3Action.BucketName));
                                }
                                if (item1.S3Action.IsSetIamRoleArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".S3Action" + ".IamRoleArn", StringUtils.FromString(item1.S3Action.IamRoleArn));
                                }
                                if (item1.S3Action.IsSetKmsKeyArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".S3Action" + ".KmsKeyArn", StringUtils.FromString(item1.S3Action.KmsKeyArn));
                                }
                                if (item1.S3Action.IsSetObjectKeyPrefix())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".S3Action" + ".ObjectKeyPrefix", StringUtils.FromString(item1.S3Action.ObjectKeyPrefix));
                                }
                                if (item1.S3Action.IsSetTopicArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".S3Action" + ".TopicArn", StringUtils.FromString(item1.S3Action.TopicArn));
                                }
                            }
                            if (item1.IsSetSNSAction())
                            {
                                if (item1.SNSAction.IsSetEncoding())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".SNSAction" + ".Encoding", StringUtils.FromString(item1.SNSAction.Encoding));
                                }
                                if (item1.SNSAction.IsSetTopicArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".SNSAction" + ".TopicArn", StringUtils.FromString(item1.SNSAction.TopicArn));
                                }
                            }
                            if (item1.IsSetStopAction())
                            {
                                if (item1.StopAction.IsSetScope())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".StopAction" + ".Scope", StringUtils.FromString(item1.StopAction.Scope));
                                }
                                if (item1.StopAction.IsSetTopicArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".StopAction" + ".TopicArn", StringUtils.FromString(item1.StopAction.TopicArn));
                                }
                            }
                            if (item1.IsSetWorkmailAction())
                            {
                                if (item1.WorkmailAction.IsSetOrganizationArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".WorkmailAction" + ".OrganizationArn", StringUtils.FromString(item1.WorkmailAction.OrganizationArn));
                                }
                                if (item1.WorkmailAction.IsSetTopicArn())
                                {
                                    request.Parameters.Add("Rule" + ".Actions" + ".member" + "." + index1 + ".WorkmailAction" + ".TopicArn", StringUtils.FromString(item1.WorkmailAction.TopicArn));
                                }
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.Rule.IsSetEnabled())
                {
                    request.Parameters.Add("Rule" + ".Enabled", StringUtils.FromBool(publicRequest.Rule.Enabled.Value));
                }
                if (publicRequest.Rule.IsSetName())
                {
                    request.Parameters.Add("Rule" + ".Name", StringUtils.FromString(publicRequest.Rule.Name));
                }
                if (publicRequest.Rule.IsSetRecipients())
                {
                    if (publicRequest.Rule.Recipients.Count == 0)
                    {
                        request.Parameters.Add("Rule" + ".Recipients", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.Rule.Recipients)
                        {
                            request.Parameters.Add("Rule" + ".Recipients" + ".member" + "." + index1, StringUtils.FromString(item1));
                            index1++;
                        }
                    }
                }
                if (publicRequest.Rule.IsSetScanEnabled())
                {
                    request.Parameters.Add("Rule" + ".ScanEnabled", StringUtils.FromBool(publicRequest.Rule.ScanEnabled.Value));
                }
                if (publicRequest.Rule.IsSetTlsPolicy())
                {
                    request.Parameters.Add("Rule" + ".TlsPolicy", StringUtils.FromString(publicRequest.Rule.TlsPolicy));
                }
            }
            if (publicRequest.IsSetRuleSetName())
            {
                request.Parameters.Add("RuleSetName", StringUtils.FromString(publicRequest.RuleSetName));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateReceiptRuleRequestMarshaller _instance = new();

        internal static CreateReceiptRuleRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateReceiptRuleRequestMarshaller Instance => _instance;
    }
}
