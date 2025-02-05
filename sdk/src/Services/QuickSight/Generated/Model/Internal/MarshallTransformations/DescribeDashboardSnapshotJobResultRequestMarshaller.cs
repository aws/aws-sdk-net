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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDashboardSnapshotJobResult Request Marshaller
    /// </summary>       
    public class DescribeDashboardSnapshotJobResultRequestMarshaller : IMarshaller<IRequest, DescribeDashboardSnapshotJobResultRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDashboardSnapshotJobResultRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDashboardSnapshotJobResultRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetDashboardId())
                throw new AmazonQuickSightException("Request object does not have required field DashboardId set");
            request.AddPathResource("{DashboardId}", StringUtils.FromString(publicRequest.DashboardId));
            if (!publicRequest.IsSetSnapshotJobId())
                throw new AmazonQuickSightException("Request object does not have required field SnapshotJobId set");
            request.AddPathResource("{SnapshotJobId}", StringUtils.FromString(publicRequest.SnapshotJobId));
            request.ResourcePath = "/accounts/{AwsAccountId}/dashboards/{DashboardId}/snapshot-jobs/{SnapshotJobId}/result";

            return request;
        }
        private static DescribeDashboardSnapshotJobResultRequestMarshaller _instance = new DescribeDashboardSnapshotJobResultRequestMarshaller();        

        internal static DescribeDashboardSnapshotJobResultRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDashboardSnapshotJobResultRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}