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
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDeleteClusterSnapshots Request Marshaller
    /// </summary>       
    public class BatchDeleteClusterSnapshotsRequestMarshaller : IMarshaller<IRequest, BatchDeleteClusterSnapshotsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDeleteClusterSnapshotsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchDeleteClusterSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "BatchDeleteClusterSnapshots");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetIdentifiers())
                {
                    if (publicRequest.Identifiers.Count == 0)
                        request.Parameters.Add("Identifiers", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Identifiers)
                         {
                            if(publicRequestlistValue.IsSetSnapshotClusterIdentifier())
                            {
                                request.Parameters.Add("Identifiers" + "." + "DeleteClusterSnapshotMessage" + "." + publicRequestlistValueIndex + "." + "SnapshotClusterIdentifier", StringUtils.FromString(publicRequestlistValue.SnapshotClusterIdentifier));
                            }
                            if(publicRequestlistValue.IsSetSnapshotIdentifier())
                            {
                                request.Parameters.Add("Identifiers" + "." + "DeleteClusterSnapshotMessage" + "." + publicRequestlistValueIndex + "." + "SnapshotIdentifier", StringUtils.FromString(publicRequestlistValue.SnapshotIdentifier));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static BatchDeleteClusterSnapshotsRequestMarshaller _instance = new BatchDeleteClusterSnapshotsRequestMarshaller();        

        internal static BatchDeleteClusterSnapshotsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDeleteClusterSnapshotsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}