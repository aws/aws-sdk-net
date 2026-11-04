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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.ElasticBeanstalk.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateApplicationVersion Request Marshaller
    /// </summary>
    public partial class CreateApplicationVersionRequestMarshaller : IMarshaller<IRequest, CreateApplicationVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateApplicationVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateApplicationVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticBeanstalk");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateApplicationVersion");
            request.Parameters.Add("Version", "2010-12-01");

            if (publicRequest.IsSetApplicationName())
            {
                request.Parameters.Add("ApplicationName", StringUtils.FromString(publicRequest.ApplicationName));
            }
            if (publicRequest.IsSetAutoCreateApplication())
            {
                request.Parameters.Add("AutoCreateApplication", StringUtils.FromBool(publicRequest.AutoCreateApplication.Value));
            }
            if (publicRequest.IsSetBuildConfiguration())
            {
                if (publicRequest.BuildConfiguration.IsSetArtifactName())
                {
                    request.Parameters.Add("BuildConfiguration" + ".ArtifactName", StringUtils.FromString(publicRequest.BuildConfiguration.ArtifactName));
                }
                if (publicRequest.BuildConfiguration.IsSetCodeBuildServiceRole())
                {
                    request.Parameters.Add("BuildConfiguration" + ".CodeBuildServiceRole", StringUtils.FromString(publicRequest.BuildConfiguration.CodeBuildServiceRole));
                }
                if (publicRequest.BuildConfiguration.IsSetComputeType())
                {
                    request.Parameters.Add("BuildConfiguration" + ".ComputeType", StringUtils.FromString(publicRequest.BuildConfiguration.ComputeType));
                }
                if (publicRequest.BuildConfiguration.IsSetImage())
                {
                    request.Parameters.Add("BuildConfiguration" + ".Image", StringUtils.FromString(publicRequest.BuildConfiguration.Image));
                }
                if (publicRequest.BuildConfiguration.IsSetTimeoutInMinutes())
                {
                    request.Parameters.Add("BuildConfiguration" + ".TimeoutInMinutes", StringUtils.FromInt(publicRequest.BuildConfiguration.TimeoutInMinutes.Value));
                }
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetImageConfiguration())
            {
                if (publicRequest.ImageConfiguration.IsSetBuild())
                {
                    if (publicRequest.ImageConfiguration.Build.IsSetArchitecture())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Build" + ".Architecture", StringUtils.FromString(publicRequest.ImageConfiguration.Build.Architecture));
                    }
                    if (publicRequest.ImageConfiguration.Build.IsSetBuildpack())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Build" + ".Buildpack", StringUtils.FromString(publicRequest.ImageConfiguration.Build.Buildpack));
                    }
                    if (publicRequest.ImageConfiguration.Build.IsSetCodeBuildServiceRole())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Build" + ".CodeBuildServiceRole", StringUtils.FromString(publicRequest.ImageConfiguration.Build.CodeBuildServiceRole));
                    }
                    if (publicRequest.ImageConfiguration.Build.IsSetComputeType())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Build" + ".ComputeType", StringUtils.FromString(publicRequest.ImageConfiguration.Build.ComputeType));
                    }
                    if (publicRequest.ImageConfiguration.Build.IsSetDockerfileLocation())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Build" + ".DockerfileLocation", StringUtils.FromString(publicRequest.ImageConfiguration.Build.DockerfileLocation));
                    }
                    if (publicRequest.ImageConfiguration.Build.IsSetTimeoutInMinutes())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Build" + ".TimeoutInMinutes", StringUtils.FromInt(publicRequest.ImageConfiguration.Build.TimeoutInMinutes.Value));
                    }
                    if (publicRequest.ImageConfiguration.Build.IsSetType())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Build" + ".Type", StringUtils.FromString(publicRequest.ImageConfiguration.Build.Type));
                    }
                }
                if (publicRequest.ImageConfiguration.IsSetSource())
                {
                    if (publicRequest.ImageConfiguration.Source.IsSetUri())
                    {
                        request.Parameters.Add("ImageConfiguration" + ".Source" + ".Uri", StringUtils.FromString(publicRequest.ImageConfiguration.Source.Uri));
                    }
                }
            }
            if (publicRequest.IsSetProcess())
            {
                request.Parameters.Add("Process", StringUtils.FromBool(publicRequest.Process.Value));
            }
            if (publicRequest.IsSetSourceBuildInformation())
            {
                if (publicRequest.SourceBuildInformation.IsSetSourceLocation())
                {
                    request.Parameters.Add("SourceBuildInformation" + ".SourceLocation", StringUtils.FromString(publicRequest.SourceBuildInformation.SourceLocation));
                }
                if (publicRequest.SourceBuildInformation.IsSetSourceRepository())
                {
                    request.Parameters.Add("SourceBuildInformation" + ".SourceRepository", StringUtils.FromString(publicRequest.SourceBuildInformation.SourceRepository));
                }
                if (publicRequest.SourceBuildInformation.IsSetSourceType())
                {
                    request.Parameters.Add("SourceBuildInformation" + ".SourceType", StringUtils.FromString(publicRequest.SourceBuildInformation.SourceType));
                }
            }
            if (publicRequest.IsSetSourceBundle())
            {
                if (publicRequest.SourceBundle.IsSetS3Bucket())
                {
                    request.Parameters.Add("SourceBundle" + ".S3Bucket", StringUtils.FromString(publicRequest.SourceBundle.S3Bucket));
                }
                if (publicRequest.SourceBundle.IsSetS3Key())
                {
                    request.Parameters.Add("SourceBundle" + ".S3Key", StringUtils.FromString(publicRequest.SourceBundle.S3Key));
                }
            }
            if (publicRequest.IsSetTags())
            {
                if (publicRequest.Tags.Count == 0)
                {
                    request.Parameters.Add("Tags", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.Tags)
                    {
                        if (item0.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".member" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetVersionLabel())
            {
                request.Parameters.Add("VersionLabel", StringUtils.FromString(publicRequest.VersionLabel));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateApplicationVersionRequestMarshaller _instance = new();

        internal static CreateApplicationVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateApplicationVersionRequestMarshaller Instance => _instance;
    }
}
