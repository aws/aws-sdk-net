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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLaunchConfigurationTemplate Request Marshaller
    /// </summary>       
    public class UpdateLaunchConfigurationTemplateRequestMarshaller : IMarshaller<IRequest, UpdateLaunchConfigurationTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLaunchConfigurationTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLaunchConfigurationTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Mgn");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateLaunchConfigurationTemplate";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociatePublicIpAddress())
                {
                    context.Writer.WritePropertyName("associatePublicIpAddress");
                    context.Writer.Write(publicRequest.AssociatePublicIpAddress);
                }

                if(publicRequest.IsSetBootMode())
                {
                    context.Writer.WritePropertyName("bootMode");
                    context.Writer.Write(publicRequest.BootMode);
                }

                if(publicRequest.IsSetCopyPrivateIp())
                {
                    context.Writer.WritePropertyName("copyPrivateIp");
                    context.Writer.Write(publicRequest.CopyPrivateIp);
                }

                if(publicRequest.IsSetCopyTags())
                {
                    context.Writer.WritePropertyName("copyTags");
                    context.Writer.Write(publicRequest.CopyTags);
                }

                if(publicRequest.IsSetEnableMapAutoTagging())
                {
                    context.Writer.WritePropertyName("enableMapAutoTagging");
                    context.Writer.Write(publicRequest.EnableMapAutoTagging);
                }

                if(publicRequest.IsSetLargeVolumeConf())
                {
                    context.Writer.WritePropertyName("largeVolumeConf");
                    context.Writer.WriteObjectStart();

                    var marshaller = LaunchTemplateDiskConfMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LargeVolumeConf, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLaunchConfigurationTemplateID())
                {
                    context.Writer.WritePropertyName("launchConfigurationTemplateID");
                    context.Writer.Write(publicRequest.LaunchConfigurationTemplateID);
                }

                if(publicRequest.IsSetLaunchDisposition())
                {
                    context.Writer.WritePropertyName("launchDisposition");
                    context.Writer.Write(publicRequest.LaunchDisposition);
                }

                if(publicRequest.IsSetLicensing())
                {
                    context.Writer.WritePropertyName("licensing");
                    context.Writer.WriteObjectStart();

                    var marshaller = LicensingMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Licensing, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMapAutoTaggingMpeID())
                {
                    context.Writer.WritePropertyName("mapAutoTaggingMpeID");
                    context.Writer.Write(publicRequest.MapAutoTaggingMpeID);
                }

                if(publicRequest.IsSetPostLaunchActions())
                {
                    context.Writer.WritePropertyName("postLaunchActions");
                    context.Writer.WriteObjectStart();

                    var marshaller = PostLaunchActionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PostLaunchActions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSmallVolumeConf())
                {
                    context.Writer.WritePropertyName("smallVolumeConf");
                    context.Writer.WriteObjectStart();

                    var marshaller = LaunchTemplateDiskConfMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SmallVolumeConf, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSmallVolumeMaxSize())
                {
                    context.Writer.WritePropertyName("smallVolumeMaxSize");
                    context.Writer.Write(publicRequest.SmallVolumeMaxSize);
                }

                if(publicRequest.IsSetTargetInstanceTypeRightSizingMethod())
                {
                    context.Writer.WritePropertyName("targetInstanceTypeRightSizingMethod");
                    context.Writer.Write(publicRequest.TargetInstanceTypeRightSizingMethod);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateLaunchConfigurationTemplateRequestMarshaller _instance = new UpdateLaunchConfigurationTemplateRequestMarshaller();        

        internal static UpdateLaunchConfigurationTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLaunchConfigurationTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}