/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CopySnapshot Request Marshaller
    /// </summary>       
    public class CopySnapshotRequestMarshaller : IMarshaller<IRequest, CopySnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopySnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopySnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "CopySnapshot");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetSourceSnapshotName())
                {
                    request.Parameters.Add("SourceSnapshotName", StringUtils.FromString(publicRequest.SourceSnapshotName));
                }
                if(publicRequest.IsSetTargetBucket())
                {
                    request.Parameters.Add("TargetBucket", StringUtils.FromString(publicRequest.TargetBucket));
                }
                if(publicRequest.IsSetTargetSnapshotName())
                {
                    request.Parameters.Add("TargetSnapshotName", StringUtils.FromString(publicRequest.TargetSnapshotName));
                }
            }
            return request;
        }
                    private static CopySnapshotRequestMarshaller _instance = new CopySnapshotRequestMarshaller();        

        internal static CopySnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopySnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}