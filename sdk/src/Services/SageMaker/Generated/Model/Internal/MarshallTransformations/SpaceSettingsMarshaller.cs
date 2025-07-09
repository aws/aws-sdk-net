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
    /// SpaceSettings Marshaller
    /// </summary>
    public class SpaceSettingsMarshaller : IRequestMarshaller<SpaceSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SpaceSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppType())
            {
                context.Writer.WritePropertyName("AppType");
                context.Writer.WriteStringValue(requestObject.AppType);
            }

            if(requestObject.IsSetCodeEditorAppSettings())
            {
                context.Writer.WritePropertyName("CodeEditorAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = SpaceCodeEditorAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeEditorAppSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomFileSystems())
            {
                context.Writer.WritePropertyName("CustomFileSystems");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomFileSystemsListValue in requestObject.CustomFileSystems)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomFileSystemMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomFileSystemsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJupyterLabAppSettings())
            {
                context.Writer.WritePropertyName("JupyterLabAppSettings");
                context.Writer.WriteStartObject();

                var marshaller = SpaceJupyterLabAppSettingsMarshaller.Instance;
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

            if(requestObject.IsSetRemoteAccess())
            {
                context.Writer.WritePropertyName("RemoteAccess");
                context.Writer.WriteStringValue(requestObject.RemoteAccess);
            }

            if(requestObject.IsSetSpaceManagedResources())
            {
                context.Writer.WritePropertyName("SpaceManagedResources");
                context.Writer.WriteStringValue(requestObject.SpaceManagedResources);
            }

            if(requestObject.IsSetSpaceStorageSettings())
            {
                context.Writer.WritePropertyName("SpaceStorageSettings");
                context.Writer.WriteStartObject();

                var marshaller = SpaceStorageSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SpaceStorageSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SpaceSettingsMarshaller Instance = new SpaceSettingsMarshaller();

    }
}