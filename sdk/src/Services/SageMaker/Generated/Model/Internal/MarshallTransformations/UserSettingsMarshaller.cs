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
            if(requestObject.IsSetCanvasAppSettings())
            {
                context.Writer.WritePropertyName("CanvasAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = CanvasAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.CanvasAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExecutionRole())
            {
                context.Writer.WritePropertyName("ExecutionRole");
                context.Writer.Write(requestObject.ExecutionRole);
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

            if(requestObject.IsSetRSessionAppSettings())
            {
                context.Writer.WritePropertyName("RSessionAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = RSessionAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RSessionAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRStudioServerProAppSettings())
            {
                context.Writer.WritePropertyName("RStudioServerProAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = RStudioServerProAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.RStudioServerProAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("SecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSecurityGroupsListValue in requestObject.SecurityGroups)
                {
                        context.Writer.Write(requestObjectSecurityGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSharingSettings())
            {
                context.Writer.WritePropertyName("SharingSettings");
                context.Writer.WriteObjectStart();

                var marshaller = SharingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.SharingSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTensorBoardAppSettings())
            {
                context.Writer.WritePropertyName("TensorBoardAppSettings");
                context.Writer.WriteObjectStart();

                var marshaller = TensorBoardAppSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TensorBoardAppSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UserSettingsMarshaller Instance = new UserSettingsMarshaller();

    }
}