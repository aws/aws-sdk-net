/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.SimpleEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.SimpleEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Send Email Request Marshaller
    /// </summary>       
    public class SendEmailRequestMarshaller : IMarshaller<IRequest, SendEmailRequest>
    {
        public IRequest Marshall(SendEmailRequest sendEmailRequest)
        {
            IRequest request = new DefaultRequest(sendEmailRequest, "AmazonSimpleEmailService");
            request.Parameters.Add("Action", "SendEmail");
            request.Parameters.Add("Version", "2010-12-01");
            if (sendEmailRequest != null && sendEmailRequest.IsSetSource())
            {
                request.Parameters.Add("Source", StringUtils.FromString(sendEmailRequest.Source));
            }
            if (sendEmailRequest != null)
            {
                Destination destination = sendEmailRequest.Destination;
                if (destination != null)
                {
                    List<string> toAddressesList = destination.ToAddresses;

                    int toAddressesListIndex = 1;
                    foreach (string toAddressesListValue in toAddressesList)
                    { 
                        request.Parameters.Add("Destination.ToAddresses.member." + toAddressesListIndex, StringUtils.FromString(toAddressesListValue));
                        toAddressesListIndex++;
                    }
                }
                if (destination != null)
                {
                    List<string> ccAddressesList = destination.CcAddresses;

                    int ccAddressesListIndex = 1;
                    foreach (string ccAddressesListValue in ccAddressesList)
                    { 
                        request.Parameters.Add("Destination.CcAddresses.member." + ccAddressesListIndex, StringUtils.FromString(ccAddressesListValue));
                        ccAddressesListIndex++;
                    }
                }
                if (destination != null)
                {
                    List<string> bccAddressesList = destination.BccAddresses;

                    int bccAddressesListIndex = 1;
                    foreach (string bccAddressesListValue in bccAddressesList)
                    { 
                        request.Parameters.Add("Destination.BccAddresses.member." + bccAddressesListIndex, StringUtils.FromString(bccAddressesListValue));
                        bccAddressesListIndex++;
                    }
                }
            }
            if (sendEmailRequest != null)
            {
                Message message = sendEmailRequest.Message;
                if (message != null)
                {
                    Content subject = message.Subject;
                    if (subject != null && subject.IsSetData())
                    {
                        request.Parameters.Add("Message.Subject.Data", StringUtils.FromString(subject.Data));
                    }
                    if (subject != null && subject.IsSetCharset())
                    {
                        request.Parameters.Add("Message.Subject.Charset", StringUtils.FromString(subject.Charset));
                    }
                }
                if (message != null)
                {
                    Body body = message.Body;
                    if (body != null)
                    {
                        Content text = body.Text;
                        if (text != null && text.IsSetData())
                        {
                            request.Parameters.Add("Message.Body.Text.Data", StringUtils.FromString(text.Data));
                        }
                        if (text != null && text.IsSetCharset())
                        {
                            request.Parameters.Add("Message.Body.Text.Charset", StringUtils.FromString(text.Charset));
                        }
                    }
                    if (body != null)
                    {
                        Content html = body.Html;
                        if (html != null && html.IsSetData())
                        {
                            request.Parameters.Add("Message.Body.Html.Data", StringUtils.FromString(html.Data));
                        }
                        if (html != null && html.IsSetCharset())
                        {
                            request.Parameters.Add("Message.Body.Html.Charset", StringUtils.FromString(html.Charset));
                        }
                    }
                }
            }
            if (sendEmailRequest != null)
            {
                List<string> replyToAddressesList = sendEmailRequest.ReplyToAddresses;

                int replyToAddressesListIndex = 1;
                foreach (string replyToAddressesListValue in replyToAddressesList)
                { 
                    request.Parameters.Add("ReplyToAddresses.member." + replyToAddressesListIndex, StringUtils.FromString(replyToAddressesListValue));
                    replyToAddressesListIndex++;
                }
            }
            if (sendEmailRequest != null && sendEmailRequest.IsSetReturnPath())
            {
                request.Parameters.Add("ReturnPath", StringUtils.FromString(sendEmailRequest.ReturnPath));
            }

            return request;
        }
    }
}
