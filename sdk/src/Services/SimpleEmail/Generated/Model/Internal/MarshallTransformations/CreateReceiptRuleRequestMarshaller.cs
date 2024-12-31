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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateReceiptRule Request Marshaller
    /// </summary>       
    public class CreateReceiptRuleRequestMarshaller : IMarshaller<IRequest, CreateReceiptRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReceiptRuleRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReceiptRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "CreateReceiptRule");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAfter())
                {
                    request.Parameters.Add("After", StringUtils.FromString(publicRequest.After));
                }
                if(publicRequest.IsSetRule())
                {
                    if(publicRequest.Rule.IsSetActions())
                    {
                        if (publicRequest.Rule.Actions.Count == 0)
                            request.Parameters.Add("Rule" + "." + "Actions", "");
                        else
                        {
                             int publicRequestRulelistValueIndex = 1;
                             foreach(var publicRequestRulelistValue in publicRequest.Rule.Actions)
                             {
                                if(publicRequestRulelistValue.IsSetAddHeaderAction())
                                {
                                    if(publicRequestRulelistValue.AddHeaderAction.IsSetHeaderName())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "AddHeaderAction" + "." + "HeaderName", StringUtils.FromString(publicRequestRulelistValue.AddHeaderAction.HeaderName));
                                    }
                                    if(publicRequestRulelistValue.AddHeaderAction.IsSetHeaderValue())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "AddHeaderAction" + "." + "HeaderValue", StringUtils.FromString(publicRequestRulelistValue.AddHeaderAction.HeaderValue));
                                    }
                                }
                                if(publicRequestRulelistValue.IsSetBounceAction())
                                {
                                    if(publicRequestRulelistValue.BounceAction.IsSetMessage())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "BounceAction" + "." + "Message", StringUtils.FromString(publicRequestRulelistValue.BounceAction.Message));
                                    }
                                    if(publicRequestRulelistValue.BounceAction.IsSetSender())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "BounceAction" + "." + "Sender", StringUtils.FromString(publicRequestRulelistValue.BounceAction.Sender));
                                    }
                                    if(publicRequestRulelistValue.BounceAction.IsSetSmtpReplyCode())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "BounceAction" + "." + "SmtpReplyCode", StringUtils.FromString(publicRequestRulelistValue.BounceAction.SmtpReplyCode));
                                    }
                                    if(publicRequestRulelistValue.BounceAction.IsSetStatusCode())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "BounceAction" + "." + "StatusCode", StringUtils.FromString(publicRequestRulelistValue.BounceAction.StatusCode));
                                    }
                                    if(publicRequestRulelistValue.BounceAction.IsSetTopicArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "BounceAction" + "." + "TopicArn", StringUtils.FromString(publicRequestRulelistValue.BounceAction.TopicArn));
                                    }
                                }
                                if(publicRequestRulelistValue.IsSetConnectAction())
                                {
                                    if(publicRequestRulelistValue.ConnectAction.IsSetIAMRoleARN())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "ConnectAction" + "." + "IAMRoleARN", StringUtils.FromString(publicRequestRulelistValue.ConnectAction.IAMRoleARN));
                                    }
                                    if(publicRequestRulelistValue.ConnectAction.IsSetInstanceARN())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "ConnectAction" + "." + "InstanceARN", StringUtils.FromString(publicRequestRulelistValue.ConnectAction.InstanceARN));
                                    }
                                }
                                if(publicRequestRulelistValue.IsSetLambdaAction())
                                {
                                    if(publicRequestRulelistValue.LambdaAction.IsSetFunctionArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "LambdaAction" + "." + "FunctionArn", StringUtils.FromString(publicRequestRulelistValue.LambdaAction.FunctionArn));
                                    }
                                    if(publicRequestRulelistValue.LambdaAction.IsSetInvocationType())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "LambdaAction" + "." + "InvocationType", StringUtils.FromString(publicRequestRulelistValue.LambdaAction.InvocationType));
                                    }
                                    if(publicRequestRulelistValue.LambdaAction.IsSetTopicArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "LambdaAction" + "." + "TopicArn", StringUtils.FromString(publicRequestRulelistValue.LambdaAction.TopicArn));
                                    }
                                }
                                if(publicRequestRulelistValue.IsSetS3Action())
                                {
                                    if(publicRequestRulelistValue.S3Action.IsSetBucketName())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "S3Action" + "." + "BucketName", StringUtils.FromString(publicRequestRulelistValue.S3Action.BucketName));
                                    }
                                    if(publicRequestRulelistValue.S3Action.IsSetIamRoleArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "S3Action" + "." + "IamRoleArn", StringUtils.FromString(publicRequestRulelistValue.S3Action.IamRoleArn));
                                    }
                                    if(publicRequestRulelistValue.S3Action.IsSetKmsKeyArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "S3Action" + "." + "KmsKeyArn", StringUtils.FromString(publicRequestRulelistValue.S3Action.KmsKeyArn));
                                    }
                                    if(publicRequestRulelistValue.S3Action.IsSetObjectKeyPrefix())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "S3Action" + "." + "ObjectKeyPrefix", StringUtils.FromString(publicRequestRulelistValue.S3Action.ObjectKeyPrefix));
                                    }
                                    if(publicRequestRulelistValue.S3Action.IsSetTopicArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "S3Action" + "." + "TopicArn", StringUtils.FromString(publicRequestRulelistValue.S3Action.TopicArn));
                                    }
                                }
                                if(publicRequestRulelistValue.IsSetSNSAction())
                                {
                                    if(publicRequestRulelistValue.SNSAction.IsSetEncoding())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "SNSAction" + "." + "Encoding", StringUtils.FromString(publicRequestRulelistValue.SNSAction.Encoding));
                                    }
                                    if(publicRequestRulelistValue.SNSAction.IsSetTopicArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "SNSAction" + "." + "TopicArn", StringUtils.FromString(publicRequestRulelistValue.SNSAction.TopicArn));
                                    }
                                }
                                if(publicRequestRulelistValue.IsSetStopAction())
                                {
                                    if(publicRequestRulelistValue.StopAction.IsSetScope())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "StopAction" + "." + "Scope", StringUtils.FromString(publicRequestRulelistValue.StopAction.Scope));
                                    }
                                    if(publicRequestRulelistValue.StopAction.IsSetTopicArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "StopAction" + "." + "TopicArn", StringUtils.FromString(publicRequestRulelistValue.StopAction.TopicArn));
                                    }
                                }
                                if(publicRequestRulelistValue.IsSetWorkmailAction())
                                {
                                    if(publicRequestRulelistValue.WorkmailAction.IsSetOrganizationArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "WorkmailAction" + "." + "OrganizationArn", StringUtils.FromString(publicRequestRulelistValue.WorkmailAction.OrganizationArn));
                                    }
                                    if(publicRequestRulelistValue.WorkmailAction.IsSetTopicArn())
                                    {
                                        request.Parameters.Add("Rule" + "." + "Actions" + "." + "member" + "." + publicRequestRulelistValueIndex + "." + "WorkmailAction" + "." + "TopicArn", StringUtils.FromString(publicRequestRulelistValue.WorkmailAction.TopicArn));
                                    }
                                }
                                 publicRequestRulelistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Rule.IsSetEnabled())
                    {
                        request.Parameters.Add("Rule" + "." + "Enabled", StringUtils.FromBool(publicRequest.Rule.Enabled));
                    }
                    if(publicRequest.Rule.IsSetName())
                    {
                        request.Parameters.Add("Rule" + "." + "Name", StringUtils.FromString(publicRequest.Rule.Name));
                    }
                    if(publicRequest.Rule.IsSetRecipients())
                    {
                        if (publicRequest.Rule.Recipients.Count == 0)
                            request.Parameters.Add("Rule" + "." + "Recipients", "");
                        else
                        {
                             int publicRequestRulelistValueIndex = 1;
                             foreach(var publicRequestRulelistValue in publicRequest.Rule.Recipients)
                             {
                                 request.Parameters.Add("Rule" + "." + "Recipients" + "." + "member" + "." + publicRequestRulelistValueIndex, StringUtils.FromString(publicRequestRulelistValue));
                                 publicRequestRulelistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Rule.IsSetScanEnabled())
                    {
                        request.Parameters.Add("Rule" + "." + "ScanEnabled", StringUtils.FromBool(publicRequest.Rule.ScanEnabled));
                    }
                    if(publicRequest.Rule.IsSetTlsPolicy())
                    {
                        request.Parameters.Add("Rule" + "." + "TlsPolicy", StringUtils.FromString(publicRequest.Rule.TlsPolicy));
                    }
                }
                if(publicRequest.IsSetRuleSetName())
                {
                    request.Parameters.Add("RuleSetName", StringUtils.FromString(publicRequest.RuleSetName));
                }
            }
            return request;
        }
                    private static CreateReceiptRuleRequestMarshaller _instance = new CreateReceiptRuleRequestMarshaller();        

        internal static CreateReceiptRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReceiptRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}