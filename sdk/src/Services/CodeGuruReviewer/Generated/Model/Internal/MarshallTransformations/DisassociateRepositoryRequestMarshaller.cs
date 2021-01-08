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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruReviewer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateRepository Request Marshaller
    /// </summary>       
    public class DisassociateRepositoryRequestMarshaller : IMarshaller<IRequest, DisassociateRepositoryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateRepositoryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateRepositoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeGuruReviewer");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-19";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetAssociationArn())
                throw new AmazonCodeGuruReviewerException("Request object does not have required field AssociationArn set");
            request.AddPathResource("{AssociationArn}", StringUtils.FromString(publicRequest.AssociationArn));
            request.ResourcePath = "/associations/{AssociationArn}";
            request.MarshallerVersion = 2;

            return request;
        }
        private static DisassociateRepositoryRequestMarshaller _instance = new DisassociateRepositoryRequestMarshaller();        

        internal static DisassociateRepositoryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateRepositoryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}