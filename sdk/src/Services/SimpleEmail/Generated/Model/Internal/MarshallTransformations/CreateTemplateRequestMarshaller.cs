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
    /// CreateTemplate Request Marshaller
    /// </summary>       
    public class CreateTemplateRequestMarshaller : IMarshaller<IRequest, CreateTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTemplateRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "CreateTemplate");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetTemplate())
                {
                    if(publicRequest.Template.IsSetHtmlPart())
                    {
                        request.Parameters.Add("Template" + "." + "HtmlPart", StringUtils.FromString(publicRequest.Template.HtmlPart));
                    }
                    if(publicRequest.Template.IsSetSubjectPart())
                    {
                        request.Parameters.Add("Template" + "." + "SubjectPart", StringUtils.FromString(publicRequest.Template.SubjectPart));
                    }
                    if(publicRequest.Template.IsSetTemplateName())
                    {
                        request.Parameters.Add("Template" + "." + "TemplateName", StringUtils.FromString(publicRequest.Template.TemplateName));
                    }
                    if(publicRequest.Template.IsSetTextPart())
                    {
                        request.Parameters.Add("Template" + "." + "TextPart", StringUtils.FromString(publicRequest.Template.TextPart));
                    }
                }
            }
            return request;
        }
                    private static CreateTemplateRequestMarshaller _instance = new CreateTemplateRequestMarshaller();        

        internal static CreateTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}