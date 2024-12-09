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
    /// DescribeClusterSnapshots Request Marshaller
    /// </summary>       
    public class DescribeClusterSnapshotsRequestMarshaller : IMarshaller<IRequest, DescribeClusterSnapshotsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeClusterSnapshotsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeClusterSnapshotsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "DescribeClusterSnapshots");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClusterExists())
                {
                    request.Parameters.Add("ClusterExists", StringUtils.FromBool(publicRequest.ClusterExists));
                }
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
                if(publicRequest.IsSetEndTime())
                {
                    request.Parameters.Add("EndTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.EndTime));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxRecords())
                {
                    request.Parameters.Add("MaxRecords", StringUtils.FromInt(publicRequest.MaxRecords));
                }
                if(publicRequest.IsSetOwnerAccount())
                {
                    request.Parameters.Add("OwnerAccount", StringUtils.FromString(publicRequest.OwnerAccount));
                }
                if(publicRequest.IsSetSnapshotArn())
                {
                    request.Parameters.Add("SnapshotArn", StringUtils.FromString(publicRequest.SnapshotArn));
                }
                if(publicRequest.IsSetSnapshotIdentifier())
                {
                    request.Parameters.Add("SnapshotIdentifier", StringUtils.FromString(publicRequest.SnapshotIdentifier));
                }
                if(publicRequest.IsSetSnapshotType())
                {
                    request.Parameters.Add("SnapshotType", StringUtils.FromString(publicRequest.SnapshotType));
                }
                if(publicRequest.IsSetSortingEntities())
                {
                    if (publicRequest.SortingEntities.Count == 0)
                        request.Parameters.Add("SortingEntities", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SortingEntities)
                         {
                            if(publicRequestlistValue.IsSetAttribute())
                            {
                                request.Parameters.Add("SortingEntities" + "." + "SnapshotSortingEntity" + "." + publicRequestlistValueIndex + "." + "Attribute", StringUtils.FromString(publicRequestlistValue.Attribute));
                            }
                            if(publicRequestlistValue.IsSetSortOrder())
                            {
                                request.Parameters.Add("SortingEntities" + "." + "SnapshotSortingEntity" + "." + publicRequestlistValueIndex + "." + "SortOrder", StringUtils.FromString(publicRequestlistValue.SortOrder));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetStartTime())
                {
                    request.Parameters.Add("StartTime", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.StartTime));
                }
                if(publicRequest.IsSetTagKeys())
                {
                    if (publicRequest.TagKeys.Count == 0)
                        request.Parameters.Add("TagKeys", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagKeys)
                         {
                             request.Parameters.Add("TagKeys" + "." + "TagKey" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTagValues())
                {
                    if (publicRequest.TagValues.Count == 0)
                        request.Parameters.Add("TagValues", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagValues)
                         {
                             request.Parameters.Add("TagValues" + "." + "TagValue" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static DescribeClusterSnapshotsRequestMarshaller _instance = new DescribeClusterSnapshotsRequestMarshaller();        

        internal static DescribeClusterSnapshotsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeClusterSnapshotsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}