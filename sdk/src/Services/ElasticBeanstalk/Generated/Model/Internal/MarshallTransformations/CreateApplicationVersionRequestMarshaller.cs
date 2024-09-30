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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplicationVersion Request Marshaller
    /// </summary>       
    public class CreateApplicationVersionRequestMarshaller : IMarshaller<IRequest, CreateApplicationVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationVersionRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateApplicationVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.Parameters.Add("Action", "CreateApplicationVersion");
            request.Parameters.Add("Version", "2010-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplicationName())
                {
                    request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
                }
                if(publicRequest.IsSetAutoCreateApplication())
                {
                    request.Parameters.Add("AutoCreateApplication", StringUtils.FromBool(publicRequest.AutoCreateApplication));
                }
                if(publicRequest.IsSetBuildConfiguration())
                {
                    if(publicRequest.BuildConfiguration.IsSetArtifactName())
                    {
                        request.Parameters.Add("BuildConfiguration" + "." + "ArtifactName", StringUtils.FromString(publicRequest.BuildConfiguration.ArtifactName));
                    }
                    if(publicRequest.BuildConfiguration.IsSetCodeBuildServiceRole())
                    {
                        request.Parameters.Add("BuildConfiguration" + "." + "CodeBuildServiceRole", StringUtils.FromString(publicRequest.BuildConfiguration.CodeBuildServiceRole));
                    }
                    if(publicRequest.BuildConfiguration.IsSetComputeType())
                    {
                        request.Parameters.Add("BuildConfiguration" + "." + "ComputeType", StringUtils.FromString(publicRequest.BuildConfiguration.ComputeType));
                    }
                    if(publicRequest.BuildConfiguration.IsSetImage())
                    {
                        request.Parameters.Add("BuildConfiguration" + "." + "Image", StringUtils.FromString(publicRequest.BuildConfiguration.Image));
                    }
                    if(publicRequest.BuildConfiguration.IsSetTimeoutInMinutes())
                    {
                        request.Parameters.Add("BuildConfiguration" + "." + "TimeoutInMinutes", StringUtils.FromInt(publicRequest.BuildConfiguration.TimeoutInMinutes));
                    }
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetProcess())
                {
                    request.Parameters.Add("Process", StringUtils.FromBool(publicRequest.Process));
                }
                if(publicRequest.IsSetSourceBuildInformation())
                {
                    if(publicRequest.SourceBuildInformation.IsSetSourceLocation())
                    {
                        request.Parameters.Add("SourceBuildInformation" + "." + "SourceLocation", StringUtils.FromString(publicRequest.SourceBuildInformation.SourceLocation));
                    }
                    if(publicRequest.SourceBuildInformation.IsSetSourceRepository())
                    {
                        request.Parameters.Add("SourceBuildInformation" + "." + "SourceRepository", StringUtils.FromString(publicRequest.SourceBuildInformation.SourceRepository));
                    }
                    if(publicRequest.SourceBuildInformation.IsSetSourceType())
                    {
                        request.Parameters.Add("SourceBuildInformation" + "." + "SourceType", StringUtils.FromString(publicRequest.SourceBuildInformation.SourceType));
                    }
                }
                if(publicRequest.IsSetSourceBundle())
                {
                    if(publicRequest.SourceBundle.IsSetS3Bucket())
                    {
                        request.Parameters.Add("SourceBundle" + "." + "S3Bucket", StringUtils.FromString(publicRequest.SourceBundle.S3Bucket));
                    }
                    if(publicRequest.SourceBundle.IsSetS3Key())
                    {
                        request.Parameters.Add("SourceBundle" + "." + "S3Key", StringUtils.FromString(publicRequest.SourceBundle.S3Key));
                    }
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
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
                if(publicRequest.IsSetVersionLabel())
                {
                    request.Parameters.Add("VersionLabel", StringUtils.FromString(publicRequest.VersionLabel));
                }
            }
            return request;
        }
                    private static CreateApplicationVersionRequestMarshaller _instance = new CreateApplicationVersionRequestMarshaller();        

        internal static CreateApplicationVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateApplicationVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}