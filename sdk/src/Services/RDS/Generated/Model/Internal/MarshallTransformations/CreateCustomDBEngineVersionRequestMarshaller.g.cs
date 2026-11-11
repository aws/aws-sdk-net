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

using Amazon.RDS.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCustomDBEngineVersion Request Marshaller
    /// </summary>
    public partial class CreateCustomDBEngineVersionRequestMarshaller : IMarshaller<IRequest, CreateCustomDBEngineVersionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomDBEngineVersionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateCustomDBEngineVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "CreateCustomDBEngineVersion");
            request.Parameters.Add("Version", "2014-10-31");

            if (publicRequest.IsSetDatabaseInstallationFiles())
            {
                if (publicRequest.DatabaseInstallationFiles.Count == 0)
                {
                    request.Parameters.Add("DatabaseInstallationFiles", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.DatabaseInstallationFiles)
                    {
                        request.Parameters.Add("DatabaseInstallationFiles" + ".member" + "." + index0, StringUtils.FromString(item0));
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetDatabaseInstallationFilesS3BucketName())
            {
                request.Parameters.Add("DatabaseInstallationFilesS3BucketName", StringUtils.FromString(publicRequest.DatabaseInstallationFilesS3BucketName));
            }
            if (publicRequest.IsSetDatabaseInstallationFilesS3Prefix())
            {
                request.Parameters.Add("DatabaseInstallationFilesS3Prefix", StringUtils.FromString(publicRequest.DatabaseInstallationFilesS3Prefix));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
            }
            if (publicRequest.IsSetEngineVersion())
            {
                request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
            }
            if (publicRequest.IsSetImageId())
            {
                request.Parameters.Add("ImageId", StringUtils.FromString(publicRequest.ImageId));
            }
            if (publicRequest.IsSetKMSKeyId())
            {
                request.Parameters.Add("KMSKeyId", StringUtils.FromString(publicRequest.KMSKeyId));
            }
            if (publicRequest.IsSetManifest())
            {
                request.Parameters.Add("Manifest", StringUtils.FromString(publicRequest.Manifest));
            }
            if (publicRequest.IsSetSourceCustomDbEngineVersionIdentifier())
            {
                request.Parameters.Add("SourceCustomDbEngineVersionIdentifier", StringUtils.FromString(publicRequest.SourceCustomDbEngineVersionIdentifier));
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
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Key", StringUtils.FromString(item0.Key));
                        }
                        if (item0.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + ".Tag" + "." + index0 + ".Value", StringUtils.FromString(item0.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetUseAwsProvidedLatestImage())
            {
                request.Parameters.Add("UseAwsProvidedLatestImage", StringUtils.FromBool(publicRequest.UseAwsProvidedLatestImage.Value));
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly CreateCustomDBEngineVersionRequestMarshaller _instance = new();

        internal static CreateCustomDBEngineVersionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateCustomDBEngineVersionRequestMarshaller Instance => _instance;
    }
}
