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
    /// CanvasAppSettings Marshaller
    /// </summary>
    public class CanvasAppSettingsMarshaller : IRequestMarshaller<CanvasAppSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CanvasAppSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDirectDeploySettings())
            {
                context.Writer.WritePropertyName("DirectDeploySettings");
                context.Writer.WriteObjectStart();

                var marshaller = DirectDeploySettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectDeploySettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGenerativeAiSettings())
            {
                context.Writer.WritePropertyName("GenerativeAiSettings");
                context.Writer.WriteObjectStart();

                var marshaller = GenerativeAiSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.GenerativeAiSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIdentityProviderOAuthSettings())
            {
                context.Writer.WritePropertyName("IdentityProviderOAuthSettings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIdentityProviderOAuthSettingsListValue in requestObject.IdentityProviderOAuthSettings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentityProviderOAuthSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectIdentityProviderOAuthSettingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetKendraSettings())
            {
                context.Writer.WritePropertyName("KendraSettings");
                context.Writer.WriteObjectStart();

                var marshaller = KendraSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.KendraSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetModelRegisterSettings())
            {
                context.Writer.WritePropertyName("ModelRegisterSettings");
                context.Writer.WriteObjectStart();

                var marshaller = ModelRegisterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelRegisterSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTimeSeriesForecastingSettings())
            {
                context.Writer.WritePropertyName("TimeSeriesForecastingSettings");
                context.Writer.WriteObjectStart();

                var marshaller = TimeSeriesForecastingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSeriesForecastingSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWorkspaceSettings())
            {
                context.Writer.WritePropertyName("WorkspaceSettings");
                context.Writer.WriteObjectStart();

                var marshaller = WorkspaceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkspaceSettings, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CanvasAppSettingsMarshaller Instance = new CanvasAppSettingsMarshaller();

    }
}