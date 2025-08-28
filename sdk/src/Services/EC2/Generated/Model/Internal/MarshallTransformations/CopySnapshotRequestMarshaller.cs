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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CopySnapshot Request Marshaller
    /// </summary>       
    public class CopySnapshotRequestMarshaller : IMarshaller<IRequest, CopySnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CopySnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CopySnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CopySnapshot");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCompletionDurationMinutes())
                {
                    request.Parameters.Add("CompletionDurationMinutes", StringUtils.FromInt(publicRequest.CompletionDurationMinutes));
                }
                if(publicRequest.IsSetDescription())
                {
                    request.Parameters.Add("Description", StringUtils.FromString(publicRequest.Description));
                }
                if(publicRequest.IsSetDestinationAvailabilityZone())
                {
                    request.Parameters.Add("DestinationAvailabilityZone", StringUtils.FromString(publicRequest.DestinationAvailabilityZone));
                }
                if(publicRequest.IsSetDestinationOutpostArn())
                {
                    request.Parameters.Add("DestinationOutpostArn", StringUtils.FromString(publicRequest.DestinationOutpostArn));
                }
                if(publicRequest.IsSetDestinationRegion())
                {
                    request.Parameters.Add("DestinationRegion", StringUtils.FromString(publicRequest.DestinationRegion));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetEncrypted())
                {
                    request.Parameters.Add("Encrypted", StringUtils.FromBool(publicRequest.Encrypted));
                }
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
                if(publicRequest.IsSetPresignedUrl())
                {
                    request.Parameters.Add("PresignedUrl", StringUtils.FromString(publicRequest.PresignedUrl));
                }
                if(publicRequest.IsSetSourceRegion())
                {
                    request.Parameters.Add("SourceRegion", StringUtils.FromString(publicRequest.SourceRegion));
                }
                if(publicRequest.IsSetSourceSnapshotId())
                {
                    request.Parameters.Add("SourceSnapshotId", StringUtils.FromString(publicRequest.SourceSnapshotId));
                }
                if(publicRequest.IsSetTagSpecifications())
                {
                    if (publicRequest.TagSpecifications.Count == 0)
                        request.Parameters.Add("TagSpecification", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                         {
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                            if(publicRequestlistValue.IsSetTags())
                            {
                                if (publicRequestlistValue.Tags.Count == 0)
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                                     {
                                        if(publicRequestlistValuelistValue.IsSetKey())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                        }
                                        if(publicRequestlistValuelistValue.IsSetValue())
                                        {
                                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                        }
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static CopySnapshotRequestMarshaller _instance = new CopySnapshotRequestMarshaller();        

        internal static CopySnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CopySnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}