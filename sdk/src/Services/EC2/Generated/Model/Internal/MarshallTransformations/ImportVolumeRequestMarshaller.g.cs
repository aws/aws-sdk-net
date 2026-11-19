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

using Amazon.EC2.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportVolume Request Marshaller
    /// </summary>
    public partial class ImportVolumeRequestMarshaller : IMarshaller<IRequest, ImportVolumeRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportVolumeRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ImportVolumeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "ImportVolume");
            request.Parameters.Add("Version", "2016-11-15");

            if (publicRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
            }
            if (publicRequest.IsSetAvailabilityZoneId())
            {
                request.Parameters.Add("AvailabilityZoneId", StringUtils.FromString(publicRequest.AvailabilityZoneId));
            }
            if (publicRequest.IsSetDescription())
            {
                request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
            }
            if (publicRequest.IsSetDryRun())
            {
                request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun.Value));
            }
            if (publicRequest.IsSetImage())
            {
                if (publicRequest.Image.IsSetBytes())
                {
                    request.Parameters.Add("Image" + ".Bytes", StringUtils.FromLong(publicRequest.Image.Bytes.Value));
                }
                if (publicRequest.Image.IsSetFormat())
                {
                    request.Parameters.Add("Image" + ".Format", StringUtils.FromString(publicRequest.Image.Format));
                }
                if (publicRequest.Image.IsSetImportManifestUrl())
                {
                    request.Parameters.Add("Image" + ".ImportManifestUrl", StringUtils.FromString(publicRequest.Image.ImportManifestUrl));
                }
            }
            if (publicRequest.IsSetVolume())
            {
                if (publicRequest.Volume.IsSetSize())
                {
                    request.Parameters.Add("Volume" + ".Size", StringUtils.FromLong(publicRequest.Volume.Size.Value));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly ImportVolumeRequestMarshaller _instance = new();

        internal static ImportVolumeRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ImportVolumeRequestMarshaller Instance => _instance;
    }
}
