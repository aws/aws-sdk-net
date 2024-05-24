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
    /// CreateReceiptFilter Request Marshaller
    /// </summary>       
    public class CreateReceiptFilterRequestMarshaller : IMarshaller<IRequest, CreateReceiptFilterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReceiptFilterRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReceiptFilterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmail");
            request.Parameters.Add("Action", "CreateReceiptFilter");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetFilter())
                {
                    if(publicRequest.Filter.IsSetIpFilter())
                    {
                        if(publicRequest.Filter.IpFilter.IsSetCidr())
                        {
                            request.Parameters.Add("Filter" + "." + "IpFilter" + "." + "Cidr", StringUtils.FromString(publicRequest.Filter.IpFilter.Cidr));
                        }
                        if(publicRequest.Filter.IpFilter.IsSetPolicy())
                        {
                            request.Parameters.Add("Filter" + "." + "IpFilter" + "." + "Policy", StringUtils.FromString(publicRequest.Filter.IpFilter.Policy));
                        }
                    }
                    if(publicRequest.Filter.IsSetName())
                    {
                        request.Parameters.Add("Filter" + "." + "Name", StringUtils.FromString(publicRequest.Filter.Name));
                    }
                }
            }
            return request;
        }
                    private static CreateReceiptFilterRequestMarshaller _instance = new CreateReceiptFilterRequestMarshaller();        

        internal static CreateReceiptFilterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReceiptFilterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}