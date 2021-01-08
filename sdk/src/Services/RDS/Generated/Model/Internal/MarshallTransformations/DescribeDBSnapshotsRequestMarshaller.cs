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
    /// DescribeDBSnapshots Request Marshaller
    /// </summary>       
    public class DescribeDBSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeDBSnapshotsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDBSnapshotsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDBSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "DescribeDBSnapshots");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDBInstanceIdentifier())
                {
                    request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
                }
                if(publicRequest.IsSetDbiResourceId())
                {
                    request.Parameters.Add("DbiResourceId", StringUtils.FromString(publicRequest.DbiResourceId));
                }
                if(publicRequest.IsSetDBSnapshotIdentifier())
                {
                    request.Parameters.Add("DBSnapshotIdentifier", StringUtils.FromString(publicRequest.DBSnapshotIdentifier));
                }
                if(publicRequest.IsSetFilters())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Filters)
                    {
                        if(publicRequestlistValue.IsSetName())
                        {
                            request.Parameters.Add("Filters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                        }
                        if(publicRequestlistValue.IsSetValues())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Values)
                            {
                                request.Parameters.Add("Filters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Values" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetIncludePublic())
                {
                    request.Parameters.Add("IncludePublic", StringUtils.FromBool(publicRequest.IncludePublic));
                }
                if(publicRequest.IsSetIncludeShared())
                {
                    request.Parameters.Add("IncludeShared", StringUtils.FromBool(publicRequest.IncludeShared));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetSnapshotType())
                {
                    request.Parameters.Add("SnapshotType", StringUtils.FromString(publicRequest.SnapshotType));
                }
            }
            return request;
        }
                    private static DescribeDBSnapshotsRequestMarshaller _instance = new DescribeDBSnapshotsRequestMarshaller();        

        internal static DescribeDBSnapshotsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDBSnapshotsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}