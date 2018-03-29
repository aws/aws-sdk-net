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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ImportExport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ImportExport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJobs Request Marshaller
    /// </summary>       
    public class ListJobsRequestMarshaller : IMarshaller<IRequest, ListJobsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJobsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListJobsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ImportExport");
            request.Parameters.Add("Action", "ListJobs");
            request.Parameters.Add("Version", "2010-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAPIVersion())
                {
                    request.Parameters.Add("APIVersion", StringUtils.FromString(publicRequest.APIVersion));
                }
                if(publicRequest.IsSetMarker())
                {
                    request.Parameters.Add("Marker", StringUtils.FromString(publicRequest.Marker));
                }
                if(publicRequest.IsSetMaxJobs())
                {
                    request.Parameters.Add("MaxJobs", StringUtils.FromInt(publicRequest.MaxJobs));
                }
            }
            return request;
        }
                    private static ListJobsRequestMarshaller _instance = new ListJobsRequestMarshaller();        

        internal static ListJobsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListJobsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}