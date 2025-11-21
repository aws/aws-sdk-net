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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateOdbNetwork Request Marshaller
    /// </summary>       
    public class CreateOdbNetworkRequestMarshaller : IMarshaller<IRequest, CreateOdbNetworkRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateOdbNetworkRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateOdbNetworkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.CreateOdbNetwork";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-08-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvailabilityZone())
                {
                    context.Writer.WritePropertyName("availabilityZone");
                    context.Writer.Write(publicRequest.AvailabilityZone);
                }

                if(publicRequest.IsSetAvailabilityZoneId())
                {
                    context.Writer.WritePropertyName("availabilityZoneId");
                    context.Writer.Write(publicRequest.AvailabilityZoneId);
                }

                if(publicRequest.IsSetBackupSubnetCidr())
                {
                    context.Writer.WritePropertyName("backupSubnetCidr");
                    context.Writer.Write(publicRequest.BackupSubnetCidr);
                }

                if(publicRequest.IsSetClientSubnetCidr())
                {
                    context.Writer.WritePropertyName("clientSubnetCidr");
                    context.Writer.Write(publicRequest.ClientSubnetCidr);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCrossRegionS3RestoreSourcesToEnable())
                {
                    context.Writer.WritePropertyName("crossRegionS3RestoreSourcesToEnable");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCrossRegionS3RestoreSourcesToEnableListValue in publicRequest.CrossRegionS3RestoreSourcesToEnable)
                    {
                            context.Writer.Write(publicRequestCrossRegionS3RestoreSourcesToEnableListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCustomDomainName())
                {
                    context.Writer.WritePropertyName("customDomainName");
                    context.Writer.Write(publicRequest.CustomDomainName);
                }

                if(publicRequest.IsSetDefaultDnsPrefix())
                {
                    context.Writer.WritePropertyName("defaultDnsPrefix");
                    context.Writer.Write(publicRequest.DefaultDnsPrefix);
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetKmsAccess())
                {
                    context.Writer.WritePropertyName("kmsAccess");
                    context.Writer.Write(publicRequest.KmsAccess);
                }

                if(publicRequest.IsSetKmsPolicyDocument())
                {
                    context.Writer.WritePropertyName("kmsPolicyDocument");
                    context.Writer.Write(publicRequest.KmsPolicyDocument);
                }

                if(publicRequest.IsSetS3Access())
                {
                    context.Writer.WritePropertyName("s3Access");
                    context.Writer.Write(publicRequest.S3Access);
                }

                if(publicRequest.IsSetS3PolicyDocument())
                {
                    context.Writer.WritePropertyName("s3PolicyDocument");
                    context.Writer.Write(publicRequest.S3PolicyDocument);
                }

                if(publicRequest.IsSetStsAccess())
                {
                    context.Writer.WritePropertyName("stsAccess");
                    context.Writer.Write(publicRequest.StsAccess);
                }

                if(publicRequest.IsSetStsPolicyDocument())
                {
                    context.Writer.WritePropertyName("stsPolicyDocument");
                    context.Writer.Write(publicRequest.StsPolicyDocument);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetZeroEtlAccess())
                {
                    context.Writer.WritePropertyName("zeroEtlAccess");
                    context.Writer.Write(publicRequest.ZeroEtlAccess);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateOdbNetworkRequestMarshaller _instance = new CreateOdbNetworkRequestMarshaller();        

        internal static CreateOdbNetworkRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateOdbNetworkRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}