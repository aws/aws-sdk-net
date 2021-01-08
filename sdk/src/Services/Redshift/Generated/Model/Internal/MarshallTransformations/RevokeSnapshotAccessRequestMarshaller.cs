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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevokeSnapshotAccess Request Marshaller
    /// </summary>       
    public class RevokeSnapshotAccessRequestMarshaller : IMarshaller<IRequest, RevokeSnapshotAccessRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RevokeSnapshotAccessRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RevokeSnapshotAccessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "RevokeSnapshotAccess");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccountWithRestoreAccess())
                {
                    request.Parameters.Add("AccountWithRestoreAccess", StringUtils.FromString(publicRequest.AccountWithRestoreAccess));
                }
                if(publicRequest.IsSetSnapshotClusterIdentifier())
                {
                    request.Parameters.Add("SnapshotClusterIdentifier", StringUtils.FromString(publicRequest.SnapshotClusterIdentifier));
                }
                if(publicRequest.IsSetSnapshotIdentifier())
                {
                    request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(publicRequest.SnapshotIdentifier));
                }
            }
            return request;
        }
                    private static RevokeSnapshotAccessRequestMarshaller _instance = new RevokeSnapshotAccessRequestMarshaller();        

        internal static RevokeSnapshotAccessRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RevokeSnapshotAccessRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}