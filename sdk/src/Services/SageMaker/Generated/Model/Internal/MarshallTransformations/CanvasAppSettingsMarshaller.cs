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
                context.Writer.WriteStartObject();

                var marshaller = DirectDeploySettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DirectDeploySettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmrServerlessSettings())
            {
                context.Writer.WritePropertyName("EmrServerlessSettings");
                context.Writer.WriteStartObject();

                var marshaller = EmrServerlessSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EmrServerlessSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGenerativeAiSettings())
            {
                context.Writer.WritePropertyName("GenerativeAiSettings");
                context.Writer.WriteStartObject();

                var marshaller = GenerativeAiSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.GenerativeAiSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIdentityProviderOAuthSettings())
            {
                context.Writer.WritePropertyName("IdentityProviderOAuthSettings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIdentityProviderOAuthSettingsListValue in requestObject.IdentityProviderOAuthSettings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IdentityProviderOAuthSettingMarshaller.Instance;
                    marshaller.Marshall(requestObjectIdentityProviderOAuthSettingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetKendraSettings())
            {
                context.Writer.WritePropertyName("KendraSettings");
                context.Writer.WriteStartObject();

                var marshaller = KendraSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.KendraSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModelRegisterSettings())
            {
                context.Writer.WritePropertyName("ModelRegisterSettings");
                context.Writer.WriteStartObject();

                var marshaller = ModelRegisterSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ModelRegisterSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTimeSeriesForecastingSettings())
            {
                context.Writer.WritePropertyName("TimeSeriesForecastingSettings");
                context.Writer.WriteStartObject();

                var marshaller = TimeSeriesForecastingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.TimeSeriesForecastingSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWorkspaceSettings())
            {
                context.Writer.WritePropertyName("WorkspaceSettings");
                context.Writer.WriteStartObject();

                var marshaller = WorkspaceSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkspaceSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CanvasAppSettingsMarshaller Instance = new CanvasAppSettingsMarshaller();

    }
}