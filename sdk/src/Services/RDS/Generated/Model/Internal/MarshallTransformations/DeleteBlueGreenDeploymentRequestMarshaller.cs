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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteBlueGreenDeployment Request Marshaller
    /// </summary>       
    public class DeleteBlueGreenDeploymentRequestMarshaller : IMarshaller<IRequest, DeleteBlueGreenDeploymentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteBlueGreenDeploymentRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteBlueGreenDeploymentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "DeleteBlueGreenDeployment");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetBlueGreenDeploymentIdentifier())
                {
                    request.Parameters.Add("BlueGreenDeploymentIdentifier", StringUtils.FromString(publicRequest.BlueGreenDeploymentIdentifier));
                }
                if(publicRequest.IsSetDeleteTarget())
                {
                    request.Parameters.Add("DeleteTarget", StringUtils.FromBool(publicRequest.DeleteTarget));
                }
            }
            return request;
        }
                    private static DeleteBlueGreenDeploymentRequestMarshaller _instance = new DeleteBlueGreenDeploymentRequestMarshaller();        

        internal static DeleteBlueGreenDeploymentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteBlueGreenDeploymentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}