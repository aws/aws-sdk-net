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
    /// UpdateJob Request Marshaller
    /// </summary>       
    public class UpdateJobRequestMarshaller : IMarshaller<IRequest, UpdateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateJobRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ImportExport");
            request.Parameters.Add("Action", "UpdateJob");
            request.Parameters.Add("Version", "2010-06-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAPIVersion())
                {
                    request.Parameters.Add("APIVersion", StringUtils.FromString(publicRequest.APIVersion));
                }
                if(publicRequest.IsSetJobId())
                {
                    request.Parameters.Add("JobId", StringUtils.FromString(publicRequest.JobId));
                }
                if(publicRequest.IsSetJobType())
                {
                    request.Parameters.Add("JobType", StringUtils.FromString(publicRequest.JobType));
                }
                if(publicRequest.IsSetManifest())
                {
                    request.Parameters.Add("Manifest", StringUtils.FromString(publicRequest.Manifest));
                }
                if(publicRequest.IsSetValidateOnly())
                {
                    request.Parameters.Add("ValidateOnly", StringUtils.FromBool(publicRequest.ValidateOnly));
                }
            }
            return request;
        }
                    private static UpdateJobRequestMarshaller _instance = new UpdateJobRequestMarshaller();        

        internal static UpdateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}