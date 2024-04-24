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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.AppType);
            }

            if(requestObject.IsSetCodeEditorAppSettings())
            {
                context.Writer.WritePropertyName("CodeEditorAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = SpaceCodeEditorAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CodeEditorAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCustomFileSystems())
            {
                context.Writer.WritePropertyName("CustomFileSystems");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCustomFileSystemsListValue in requestObject.CustomFileSystems)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomFileSystemMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomFileSystemsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetJupyterLabAppSettings())
            {
                context.Writer.WritePropertyName("JupyterLabAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = SpaceJupyterLabAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.JupyterLabAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetJupyterServerAppSettings())
            {
                context.Writer.WritePropertyName("JupyterServerAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = JupyterServerAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.JupyterServerAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKernelGatewayAppSettings())
            {
                context.Writer.WritePropertyName("KernelGatewayAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = KernelGatewayAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.KernelGatewayAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSpaceStorageSettings())
            {
                context.Writer.WritePropertyName("SpaceStorageSettings");
                context.Writer.WriteObjectStart();

                var marshaller = SpaceStorageSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SpaceStorageSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SpaceSettingsMarshaller Instance = new SpaceSettingsMarshaller();

    }
}