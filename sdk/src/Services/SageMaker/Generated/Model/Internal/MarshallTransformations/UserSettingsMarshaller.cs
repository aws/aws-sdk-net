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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UserSettings Marshaller
    /// </summary>
    public class UserSettingsMarshaller : IRequestMarshaller<UserSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UserSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAutoMountHomeEFS())
            {
                context.Writer.WritePropertyName("AutoMountHomeEFS");
                context.Writer.WriteStringValue(requestObject.AutoMountHomeEFS);
            }

            if(requestObject.IsSetCanvasAppSettings())
            {
                context.Writer.WritePropertyName("CanvasAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = CanvasAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CanvasAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCodeEditorAppSettings())
            {
                context.Writer.WritePropertyName("CodeEditorAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = CodeEditorAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeEditorAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomFileSystemConfigs())
            {
                context.Writer.WritePropertyName("CustomFileSystemConfigs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomFileSystemConfigsListValue in requestObject.CustomFileSystemConfigs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomFileSystemConfigMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomFileSystemConfigsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCustomPosixUserConfig())
            {
                context.Writer.WritePropertyName("CustomPosixUserConfig");
                context.Writer.WriteStartObject();

                var marshaller = CustomPosixUserConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomPosixUserConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDefaultLandingUri())
            {
                context.Writer.WritePropertyName("DefaultLandingUri");
                context.Writer.WriteStringValue(requestObject.DefaultLandingUri);
            }

            if(requestObject.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("ExecutionRole");
                context.Writer.WriteStringValue(requestObject.ExecutionRole);
            }

            if(requestObject.IsSetJupyterLabAppSettings())
            {
                context.Writer.WritePropertyName("JupyterLabAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = JupyterLabAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.JupyterLabAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJupyterServerAppSettings())
            {
                context.Writer.WritePropertyName("JupyterServerAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = JupyterServerAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.JupyterServerAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetKernelGatewayAppSettings())
            {
                context.Writer.WritePropertyName("KernelGatewayAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = KernelGatewayAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.KernelGatewayAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRSessionAppSettings())
            {
                context.Writer.WritePropertyName("RSessionAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = RSessionAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RSessionAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRStudioServerProAppSettings())
            {
                context.Writer.WritePropertyName("RStudioServerProAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = RStudioServerProAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RStudioServerProAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSharingSettings())
            {
                context.Writer.WritePropertyName("SharingSettings");
                context.Writer.WriteStartObject();

                var marshaller = SharingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SharingSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSpaceStorageSettings())
            {
                context.Writer.WritePropertyName("SpaceStorageSettings");
                context.Writer.WriteStartObject();

                var marshaller = DefaultSpaceStorageSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SpaceStorageSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStudioWebPortal())
            {
                context.Writer.WritePropertyName("StudioWebPortal");
                context.Writer.WriteStringValue(requestObject.StudioWebPortal);
            }

            if(requestObject.IsSetStudioWebPortalSettings())
            {
                context.Writer.WritePropertyName("StudioWebPortalSettings");
                context.Writer.WriteStartObject();

                var marshaller = StudioWebPortalSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.StudioWebPortalSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTensorBoardAppSettings())
            {
                context.Writer.WritePropertyName("TensorBoardAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = TensorBoardAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TensorBoardAppSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UserSettingsMarshaller Instance = new UserSettingsMarshaller();

    }
}