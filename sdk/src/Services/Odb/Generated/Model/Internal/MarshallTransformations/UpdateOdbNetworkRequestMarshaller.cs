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
    /// UpdateOdbNetwork Request Marshaller
    /// </summary>       
    public class UpdateOdbNetworkRequestMarshaller : IMarshaller<IRequest, UpdateOdbNetworkRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateOdbNetworkRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateOdbNetworkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Odb");
            string target = "Odb.UpdateOdbNetwork";
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
                if(publicRequest.IsSetCrossRegionS3RestoreSourcesToDisable())
                {
                    context.Writer.WritePropertyName("crossRegionS3RestoreSourcesToDisable");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCrossRegionS3RestoreSourcesToDisableListValue in publicRequest.CrossRegionS3RestoreSourcesToDisable)
                    {
                            context.Writer.Write(publicRequestCrossRegionS3RestoreSourcesToDisableListValue);
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetOdbNetworkId())
                {
                    context.Writer.WritePropertyName("odbNetworkId");
                    context.Writer.Write(publicRequest.OdbNetworkId);
                }

                if(publicRequest.IsSetPeeredCidrsToBeAdded())
                {
                    context.Writer.WritePropertyName("peeredCidrsToBeAdded");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPeeredCidrsToBeAddedListValue in publicRequest.PeeredCidrsToBeAdded)
                    {
                            context.Writer.Write(publicRequestPeeredCidrsToBeAddedListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPeeredCidrsToBeRemoved())
                {
                    context.Writer.WritePropertyName("peeredCidrsToBeRemoved");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPeeredCidrsToBeRemovedListValue in publicRequest.PeeredCidrsToBeRemoved)
                    {
                            context.Writer.Write(publicRequestPeeredCidrsToBeRemovedListValue);
                    }
                    context.Writer.WriteArrayEnd();
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
        private static UpdateOdbNetworkRequestMarshaller _instance = new UpdateOdbNetworkRequestMarshaller();        

        internal static UpdateOdbNetworkRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateOdbNetworkRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}