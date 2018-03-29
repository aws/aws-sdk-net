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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFpgaImage Request Marshaller
    /// </summary>       
    public class CreateFpgaImageRequestMarshaller : IMarshaller<IRequest, CreateFpgaImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFpgaImageRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFpgaImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateFpgaImage");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetInputStorageLocation())
                {
                    if(publicRequest.InputStorageLocation.IsSetBucket())
                    {
                        request.Parameters.Add("InputStorageLocation" + "." + "Bucket", StringUtils.FromString(publicRequest.InputStorageLocation.Bucket));
                    }
                    if(publicRequest.InputStorageLocation.IsSetKey())
                    {
                        request.Parameters.Add("InputStorageLocation" + "." + "Key", StringUtils.FromString(publicRequest.InputStorageLocation.Key));
                    }
                }
                if(publicRequest.IsSetLogsStorageLocation())
                {
                    if(publicRequest.LogsStorageLocation.IsSetBucket())
                    {
                        request.Parameters.Add("LogsStorageLocation" + "." + "Bucket", StringUtils.FromString(publicRequest.LogsStorageLocation.Bucket));
                    }
                    if(publicRequest.LogsStorageLocation.IsSetKey())
                    {
                        request.Parameters.Add("LogsStorageLocation" + "." + "Key", StringUtils.FromString(publicRequest.LogsStorageLocation.Key));
                    }
                }
                if(publicRequest.IsSetName())
                {
                    request.Parameters.Add("Name", StringUtils.FromString(publicRequest.Name));
                }
            }
            return request;
        }
                    private static CreateFpgaImageRequestMarshaller _instance = new CreateFpgaImageRequestMarshaller();        

        internal static CreateFpgaImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFpgaImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}