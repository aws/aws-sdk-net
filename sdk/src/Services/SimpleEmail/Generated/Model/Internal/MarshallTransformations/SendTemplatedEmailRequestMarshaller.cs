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
    /// SendTemplatedEmail Request Marshaller
    /// </summary>       
    public class SendTemplatedEmailRequestMarshaller : IMarshaller<IRequest, SendTemplatedEmailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendTemplatedEmailRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendTemplatedEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "SendTemplatedEmail");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConfigurationSetName())
                {
                    request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
                }
                if(publicRequest.IsSetDestination())
                {
                    if(publicRequest.Destination.IsSetBccAddresses())
                    {
                        if (publicRequest.Destination.BccAddresses.Count == 0)
                            request.Parameters.Add("Destination" + "." + "BccAddresses", "");
                        else
                        {
                             int publicRequestDestinationlistValueIndex = 1;
                             foreach(var publicRequestDestinationlistValue in publicRequest.Destination.BccAddresses)
                             {
                                 request.Parameters.Add("Destination" + "." + "BccAddresses" + "." + "member" + "." + publicRequestDestinationlistValueIndex, StringUtils.FromString(publicRequestDestinationlistValue));
                                 publicRequestDestinationlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Destination.IsSetCcAddresses())
                    {
                        if (publicRequest.Destination.CcAddresses.Count == 0)
                            request.Parameters.Add("Destination" + "." + "CcAddresses", "");
                        else
                        {
                             int publicRequestDestinationlistValueIndex = 1;
                             foreach(var publicRequestDestinationlistValue in publicRequest.Destination.CcAddresses)
                             {
                                 request.Parameters.Add("Destination" + "." + "CcAddresses" + "." + "member" + "." + publicRequestDestinationlistValueIndex, StringUtils.FromString(publicRequestDestinationlistValue));
                                 publicRequestDestinationlistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Destination.IsSetToAddresses())
                    {
                        if (publicRequest.Destination.ToAddresses.Count == 0)
                            request.Parameters.Add("Destination" + "." + "ToAddresses", "");
                        else
                        {
                             int publicRequestDestinationlistValueIndex = 1;
                             foreach(var publicRequestDestinationlistValue in publicRequest.Destination.ToAddresses)
                             {
                                 request.Parameters.Add("Destination" + "." + "ToAddresses" + "." + "member" + "." + publicRequestDestinationlistValueIndex, StringUtils.FromString(publicRequestDestinationlistValue));
                                 publicRequestDestinationlistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetReplyToAddresses())
                {
                    if (publicRequest.ReplyToAddresses.Count == 0)
                        request.Parameters.Add("ReplyToAddresses", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ReplyToAddresses)
                         {
                             request.Parameters.Add("ReplyToAddresses" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetReturnPath())
                {
                    request.Parameters.Add("ReturnPath", StringUtils.FromString(publicRequest.ReturnPath));
                }
                if(publicRequest.IsSetReturnPathArn())
                {
                    request.Parameters.Add("ReturnPathArn", StringUtils.FromString(publicRequest.ReturnPathArn));
                }
                if(publicRequest.IsSetSource())
                {
                    request.Parameters.Add("Source", StringUtils.FromString(publicRequest.Source));
                }
                if(publicRequest.IsSetSourceArn())
                {
                    request.Parameters.Add("SourceArn", StringUtils.FromString(publicRequest.SourceArn));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTemplate())
                {
                    request.Parameters.Add("Template", StringUtils.FromString(publicRequest.Template));
                }
                if(publicRequest.IsSetTemplateArn())
                {
                    request.Parameters.Add("TemplateArn", StringUtils.FromString(publicRequest.TemplateArn));
                }
                if(publicRequest.IsSetTemplateData())
                {
                    request.Parameters.Add("TemplateData", StringUtils.FromString(publicRequest.TemplateData));
                }
            }
            return request;
        }
                    private static SendTemplatedEmailRequestMarshaller _instance = new SendTemplatedEmailRequestMarshaller();        

        internal static SendTemplatedEmailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendTemplatedEmailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}