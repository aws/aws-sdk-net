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
namespace Amazon.DocDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CopyDBClusterSnapshot Request Marshaller
    /// </summary>       
    public class CopyDBClusterSnapshotRequestMarshaller : IMarshaller<IRequest, CopyDBClusterSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopyDBClusterSnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopyDBClusterSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DocDB");
            request.Parameters.Add("Action", "CopyDBClusterSnapshot");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCopyTags())
                {
                    request.Parameters.Add("CopyTags", StringUtils.FromBool(publicRequest.CopyTags));
                }
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
                if(publicRequest.IsSetPreSignedUrl())
                {
                    request.Parameters.Add("PreSignedUrl", StringUtils.FromString(publicRequest.PreSignedUrl));
                }
                if(publicRequest.IsSetSourceDBClusterSnapshotIdentifier())
                {
                    request.Parameters.Add("SourceDBClusterSnapshotIdentifier", StringUtils.FromString(publicRequest.SourceDBClusterSnapshotIdentifier));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTargetDBClusterSnapshotIdentifier())
                {
                    request.Parameters.Add("TargetDBClusterSnapshotIdentifier", StringUtils.FromString(publicRequest.TargetDBClusterSnapshotIdentifier));
                }
            }
            return request;
        }
                    private static CopyDBClusterSnapshotRequestMarshaller _instance = new CopyDBClusterSnapshotRequestMarshaller();        

        internal static CopyDBClusterSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopyDBClusterSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}