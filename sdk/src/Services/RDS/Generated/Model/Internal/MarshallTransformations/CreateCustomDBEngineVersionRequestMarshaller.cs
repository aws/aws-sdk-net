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
    /// CreateCustomDBEngineVersion Request Marshaller
    /// </summary>       
    public class CreateCustomDBEngineVersionRequestMarshaller : IMarshaller<IRequest, CreateCustomDBEngineVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomDBEngineVersionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCustomDBEngineVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "CreateCustomDBEngineVersion");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDatabaseInstallationFilesS3BucketName())
                {
                    request.Parameters.Add("DatabaseInstallationFilesS3BucketName", StringUtils.FromString(publicRequest.DatabaseInstallationFilesS3BucketName));
                }
                if(publicRequest.IsSetDatabaseInstallationFilesS3Prefix())
                {
                    request.Parameters.Add("DatabaseInstallationFilesS3Prefix", StringUtils.FromString(publicRequest.DatabaseInstallationFilesS3Prefix));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
                if(publicRequest.IsSetImageId())
                {
                    request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
                }
                if(publicRequest.IsSetKMSKeyId())
                {
                    request.Parameters.Add("KMSKeyId", StringUtils.FromString(publicRequest.KMSKeyId));
                }
                if(publicRequest.IsSetManifest())
                {
                    request.Parameters.Add("Manifest", StringUtils.FromString(publicRequest.Manifest));
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
            }
            return request;
        }
                    private static CreateCustomDBEngineVersionRequestMarshaller _instance = new CreateCustomDBEngineVersionRequestMarshaller();        

        internal static CreateCustomDBEngineVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCustomDBEngineVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}