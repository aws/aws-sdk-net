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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteRule Request Marshaller
    /// </summary>       
    public class DeleteRuleRequestMarshaller : IMarshaller<IRequest, DeleteRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.VPCLattice");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-30";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetListenerIdentifier())
                throw new AmazonVPCLatticeException("Request object does not have required field ListenerIdentifier set");
            request.AddPathResource("{listenerIdentifier}", StringUtils.FromString(publicRequest.ListenerIdentifier));
            if (!publicRequest.IsSetRuleIdentifier())
                throw new AmazonVPCLatticeException("Request object does not have required field RuleIdentifier set");
            request.AddPathResource("{ruleIdentifier}", StringUtils.FromString(publicRequest.RuleIdentifier));
            if (!publicRequest.IsSetServiceIdentifier())
                throw new AmazonVPCLatticeException("Request object does not have required field ServiceIdentifier set");
            request.AddPathResource("{serviceIdentifier}", StringUtils.FromString(publicRequest.ServiceIdentifier));
            request.ResourcePath = "/services/{serviceIdentifier}/listeners/{listenerIdentifier}/rules/{ruleIdentifier}";

            return request;
        }
        private static DeleteRuleRequestMarshaller _instance = new DeleteRuleRequestMarshaller();        

        internal static DeleteRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}