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
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartExportTask Request Marshaller
    /// </summary>       
    public class StartExportTaskRequestMarshaller : IMarshaller<IRequest, StartExportTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartExportTaskRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartExportTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "StartExportTask");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetExportOnly())
                {
                    if (publicRequest.ExportOnly.Count == 0)
                        request.Parameters.Add("ExportOnly", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ExportOnly)
                         {
                             request.Parameters.Add("ExportOnly" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetExportTaskIdentifier())
                {
                    request.Parameters.Add("ExportTaskIdentifier", StringUtils.FromString(publicRequest.ExportTaskIdentifier));
                }
                if(publicRequest.IsSetIamRoleArn())
                {
                    request.Parameters.Add("IamRoleArn", StringUtils.FromString(publicRequest.IamRoleArn));
                }
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
                if(publicRequest.IsSetS3BucketName())
                {
                    request.Parameters.Add("S3BucketName", StringUtils.FromString(publicRequest.S3BucketName));
                }
                if(publicRequest.IsSetS3Prefix())
                {
                    request.Parameters.Add("S3Prefix", StringUtils.FromString(publicRequest.S3Prefix));
                }
                if(publicRequest.IsSetSourceArn())
                {
                    request.Parameters.Add("SourceArn", StringUtils.FromString(publicRequest.SourceArn));
                }
            }
            return request;
        }
                    private static StartExportTaskRequestMarshaller _instance = new StartExportTaskRequestMarshaller();        

        internal static StartExportTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartExportTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}