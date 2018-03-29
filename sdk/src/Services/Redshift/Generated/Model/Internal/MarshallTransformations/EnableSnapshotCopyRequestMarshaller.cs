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
    /// EnableSnapshotCopy Request Marshaller
    /// </summary>       
    public class EnableSnapshotCopyRequestMarshaller : IMarshaller<IRequest, EnableSnapshotCopyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EnableSnapshotCopyRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EnableSnapshotCopyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "EnableSnapshotCopy");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
                if(publicRequest.IsSetDestinationRegion())
                {
                    request.Parameters.Add("DestinationRegion", StringUtils.FromString(publicRequest.DestinationRegion));
                }
                if(publicRequest.IsSetRetentionPeriod())
                {
                    request.Parameters.Add("RetentionPeriod", StringUtils.FromInt(publicRequest.RetentionPeriod));
                }
                if(publicRequest.IsSetSnapshotCopyGrantName())
                {
                    request.Parameters.Add("SnapshotCopyGrantName", StringUtils.FromString(publicRequest.SnapshotCopyGrantName));
                }
            }
            return request;
        }
                    private static EnableSnapshotCopyRequestMarshaller _instance = new EnableSnapshotCopyRequestMarshaller();        

        internal static EnableSnapshotCopyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnableSnapshotCopyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}