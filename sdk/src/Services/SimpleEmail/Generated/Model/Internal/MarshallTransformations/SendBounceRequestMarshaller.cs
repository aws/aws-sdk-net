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
    /// SendBounce Request Marshaller
    /// </summary>       
    public class SendBounceRequestMarshaller : IMarshaller<IRequest, SendBounceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendBounceRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendBounceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "SendBounce");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetBouncedRecipientInfoList())
                {
                    if (publicRequest.BouncedRecipientInfoList.Count == 0)
                        request.Parameters.Add("BouncedRecipientInfoList", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.BouncedRecipientInfoList)
                         {
                            if(publicRequestlistValue.IsSetBounceType())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "BounceType", StringUtils.FromString(publicRequestlistValue.BounceType));
                            }
                            if(publicRequestlistValue.IsSetRecipient())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Recipient", StringUtils.FromString(publicRequestlistValue.Recipient));
                            }
                            if(publicRequestlistValue.IsSetRecipientArn())
                            {
                                request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientArn", StringUtils.FromString(publicRequestlistValue.RecipientArn));
                            }
                            if(publicRequestlistValue.IsSetRecipientDsnFields())
                            {
                                if(publicRequestlistValue.RecipientDsnFields.IsSetAction())
                                {
                                    request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "Action", StringUtils.FromString(publicRequestlistValue.RecipientDsnFields.Action));
                                }
                                if(publicRequestlistValue.RecipientDsnFields.IsSetDiagnosticCode())
                                {
                                    request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "DiagnosticCode", StringUtils.FromString(publicRequestlistValue.RecipientDsnFields.DiagnosticCode));
                                }
                                if(publicRequestlistValue.RecipientDsnFields.IsSetExtensionFields())
                                {
                                    if (publicRequestlistValue.RecipientDsnFields.ExtensionFields.Count == 0)
                                        request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "ExtensionFields", "");
                                    else
                                    {
                                         int publicRequestlistValueRecipientDsnFieldslistValueIndex = 1;
                                         foreach(var publicRequestlistValueRecipientDsnFieldslistValue in publicRequestlistValue.RecipientDsnFields.ExtensionFields)
                                         {
                                            if(publicRequestlistValueRecipientDsnFieldslistValue.IsSetName())
                                            {
                                                request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "ExtensionFields" + "." + "member" + "." + publicRequestlistValueRecipientDsnFieldslistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValueRecipientDsnFieldslistValue.Name));
                                            }
                                            if(publicRequestlistValueRecipientDsnFieldslistValue.IsSetValue())
                                            {
                                                request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "ExtensionFields" + "." + "member" + "." + publicRequestlistValueRecipientDsnFieldslistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValueRecipientDsnFieldslistValue.Value));
                                            }
                                             publicRequestlistValueRecipientDsnFieldslistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestlistValue.RecipientDsnFields.IsSetFinalRecipient())
                                {
                                    request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "FinalRecipient", StringUtils.FromString(publicRequestlistValue.RecipientDsnFields.FinalRecipient));
                                }
                                if(publicRequestlistValue.RecipientDsnFields.IsSetLastAttemptDate())
                                {
                                    request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "LastAttemptDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequestlistValue.RecipientDsnFields.LastAttemptDate));
                                }
                                if(publicRequestlistValue.RecipientDsnFields.IsSetRemoteMta())
                                {
                                    request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "RemoteMta", StringUtils.FromString(publicRequestlistValue.RecipientDsnFields.RemoteMta));
                                }
                                if(publicRequestlistValue.RecipientDsnFields.IsSetStatus())
                                {
                                    request.Parameters.Add("BouncedRecipientInfoList" + "." + "member" + "." + publicRequestlistValueIndex + "." + "RecipientDsnFields" + "." + "Status", StringUtils.FromString(publicRequestlistValue.RecipientDsnFields.Status));
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetBounceSender())
                {
                    request.Parameters.Add("BounceSender", StringUtils.FromString(publicRequest.BounceSender));
                }
                if(publicRequest.IsSetBounceSenderArn())
                {
                    request.Parameters.Add("BounceSenderArn", StringUtils.FromString(publicRequest.BounceSenderArn));
                }
                if(publicRequest.IsSetExplanation())
                {
                    request.Parameters.Add("Explanation", StringUtils.FromString(publicRequest.Explanation));
                }
                if(publicRequest.IsSetMessageDsn())
                {
                    if(publicRequest.MessageDsn.IsSetArrivalDate())
                    {
                        request.Parameters.Add("MessageDsn" + "." + "ArrivalDate", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.MessageDsn.ArrivalDate));
                    }
                    if(publicRequest.MessageDsn.IsSetExtensionFields())
                    {
                        if (publicRequest.MessageDsn.ExtensionFields.Count == 0)
                            request.Parameters.Add("MessageDsn" + "." + "ExtensionFields", "");
                        else
                        {
                             int publicRequestMessageDsnlistValueIndex = 1;
                             foreach(var publicRequestMessageDsnlistValue in publicRequest.MessageDsn.ExtensionFields)
                             {
                                if(publicRequestMessageDsnlistValue.IsSetName())
                                {
                                    request.Parameters.Add("MessageDsn" + "." + "ExtensionFields" + "." + "member" + "." + publicRequestMessageDsnlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestMessageDsnlistValue.Name));
                                }
                                if(publicRequestMessageDsnlistValue.IsSetValue())
                                {
                                    request.Parameters.Add("MessageDsn" + "." + "ExtensionFields" + "." + "member" + "." + publicRequestMessageDsnlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestMessageDsnlistValue.Value));
                                }
                                 publicRequestMessageDsnlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.MessageDsn.IsSetReportingMta())
                    {
                        request.Parameters.Add("MessageDsn" + "." + "ReportingMta", StringUtils.FromString(publicRequest.MessageDsn.ReportingMta));
                    }
                }
                if(publicRequest.IsSetOriginalMessageId())
                {
                    request.Parameters.Add("OriginalMessageId", StringUtils.FromString(publicRequest.OriginalMessageId));
                }
            }
            return request;
        }
                    private static SendBounceRequestMarshaller _instance = new SendBounceRequestMarshaller();        

        internal static SendBounceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendBounceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}