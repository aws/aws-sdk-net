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
 * Do not modify this file. This file is generated from the notificationscontacts-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NotificationsContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NotificationsContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActivateEmailContact Request Marshaller
    /// </summary>       
    public class ActivateEmailContactRequestMarshaller : IMarshaller<IRequest, ActivateEmailContactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ActivateEmailContactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ActivateEmailContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NotificationsContacts");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetArn())
                throw new AmazonNotificationsContactsException("Request object does not have required field Arn set");
            request.AddPathResource("{arn}", StringUtils.FromString(publicRequest.Arn));
            if (!publicRequest.IsSetCode())
                throw new AmazonNotificationsContactsException("Request object does not have required field Code set");
            request.AddPathResource("{code}", StringUtils.FromString(publicRequest.Code));
            request.ResourcePath = "/emailcontacts/{arn}/activate/{code}";

            return request;
        }
        private static ActivateEmailContactRequestMarshaller _instance = new ActivateEmailContactRequestMarshaller();        

        internal static ActivateEmailContactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ActivateEmailContactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}