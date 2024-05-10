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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ARCZonalShift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ARCZonalShift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeletePracticeRunConfiguration Request Marshaller
    /// </summary>       
    public class DeletePracticeRunConfigurationRequestMarshaller : IMarshaller<IRequest, DeletePracticeRunConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeletePracticeRunConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeletePracticeRunConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ARCZonalShift");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-10-30";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetResourceIdentifier())
                throw new AmazonARCZonalShiftException("Request object does not have required field ResourceIdentifier set");
            request.AddPathResource("{resourceIdentifier}", StringUtils.FromString(publicRequest.ResourceIdentifier));
            request.ResourcePath = "/configuration/{resourceIdentifier}";

            return request;
        }
        private static DeletePracticeRunConfigurationRequestMarshaller _instance = new DeletePracticeRunConfigurationRequestMarshaller();        

        internal static DeletePracticeRunConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeletePracticeRunConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}