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
    /// SendBulkTemplatedEmail Request Marshaller
    /// </summary>       
    public class SendBulkTemplatedEmailRequestMarshaller : IMarshaller<IRequest, SendBulkTemplatedEmailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendBulkTemplatedEmailRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendBulkTemplatedEmailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "SendBulkTemplatedEmail");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetConfigurationSetName())
                {
                    request.Parameters.Add("ConfigurationSetName", StringUtils.FromString(publicRequest.ConfigurationSetName));
                }
                if(publicRequest.IsSetDefaultTags())
                {
                    if (publicRequest.DefaultTags.Count == 0)
                        request.Parameters.Add("DefaultTags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.DefaultTags)
                         {
                            if(publicRequestlistValue.IsSetName())
                            {
                                request.Parameters.Add("DefaultTags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("DefaultTags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetDefaultTemplateData())
                {
                    request.Parameters.Add("DefaultTemplateData", StringUtils.FromString(publicRequest.DefaultTemplateData));
                }
                if(publicRequest.IsSetDestinations())
                {
                    if (publicRequest.Destinations.Count == 0)
                        request.Parameters.Add("Destinations", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Destinations)
                         {
                            if(publicRequestlistValue.IsSetDestination())
                            {
                                if(publicRequestlistValue.Destination.IsSetBccAddresses())
                                {
                                    if (publicRequestlistValue.Destination.BccAddresses.Count == 0)
                                        request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "BccAddresses", "");
                                    else
                                    {
                                         int publicRequestlistValueDestinationlistValueIndex = 1;
                                         foreach(var publicRequestlistValueDestinationlistValue in publicRequestlistValue.Destination.BccAddresses)
                                         {
                                             request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "BccAddresses" + "." + "member" + "." + publicRequestlistValueDestinationlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationlistValue));
                                             publicRequestlistValueDestinationlistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestlistValue.Destination.IsSetCcAddresses())
                                {
                                    if (publicRequestlistValue.Destination.CcAddresses.Count == 0)
                                        request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "CcAddresses", "");
                                    else
                                    {
                                         int publicRequestlistValueDestinationlistValueIndex = 1;
                                         foreach(var publicRequestlistValueDestinationlistValue in publicRequestlistValue.Destination.CcAddresses)
                                         {
                                             request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "CcAddresses" + "." + "member" + "." + publicRequestlistValueDestinationlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationlistValue));
                                             publicRequestlistValueDestinationlistValueIndex++;
                                         }
                                    }
                                }
                                if(publicRequestlistValue.Destination.IsSetToAddresses())
                                {
                                    if (publicRequestlistValue.Destination.ToAddresses.Count == 0)
                                        request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "ToAddresses", "");
                                    else
                                    {
                                         int publicRequestlistValueDestinationlistValueIndex = 1;
                                         foreach(var publicRequestlistValueDestinationlistValue in publicRequestlistValue.Destination.ToAddresses)
                                         {
                                             request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Destination" + "." + "ToAddresses" + "." + "member" + "." + publicRequestlistValueDestinationlistValueIndex, StringUtils.FromString(publicRequestlistValueDestinationlistValue));
                                             publicRequestlistValueDestinationlistValueIndex++;
                                         }
                                    }
                                }
                            }
                            if(publicRequestlistValue.IsSetReplacementTags())
                            {
                                if (publicRequestlistValue.ReplacementTags.Count == 0)
                                    request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReplacementTags", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ReplacementTags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetName())
                                        {
                                            request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReplacementTags" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValuelistValue.Name));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReplacementTags" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetReplacementTemplateData())
                            {
                                request.Parameters.Add("Destinations" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ReplacementTemplateData", StringUtils.FromString(publicRequestlistValue.ReplacementTemplateData));
                            }
                             publicRequestlistValueIndex++;
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
                if(publicRequest.IsSetTemplate())
                {
                    request.Parameters.Add("Template", StringUtils.FromString(publicRequest.Template));
                }
                if(publicRequest.IsSetTemplateArn())
                {
                    request.Parameters.Add("TemplateArn", StringUtils.FromString(publicRequest.TemplateArn));
                }
            }
            return request;
        }
                    private static SendBulkTemplatedEmailRequestMarshaller _instance = new SendBulkTemplatedEmailRequestMarshaller();        

        internal static SendBulkTemplatedEmailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendBulkTemplatedEmailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}