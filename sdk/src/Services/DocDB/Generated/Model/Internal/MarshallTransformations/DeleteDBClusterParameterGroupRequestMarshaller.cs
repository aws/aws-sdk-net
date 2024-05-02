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
 * Do not modify this file. This file is generated from the docdb-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DocDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DocDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteDBClusterParameterGroup Request Marshaller
    /// </summary>       
    public class DeleteDBClusterParameterGroupRequestMarshaller : IMarshaller<IRequest, DeleteDBClusterParameterGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteDBClusterParameterGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteDBClusterParameterGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DocDB");
            request.Parameters.Add("Action", "DeleteDBClusterParameterGroup");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBClusterParameterGroupName())
                {
                    request.Parameters.Add("DBClusterParameterGroupName", StringUtils.FromString(publicRequest.DBClusterParameterGroupName));
                }
            }
            return request;
        }
                    private static DeleteDBClusterParameterGroupRequestMarshaller _instance = new DeleteDBClusterParameterGroupRequestMarshaller();        

        internal static DeleteDBClusterParameterGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteDBClusterParameterGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}