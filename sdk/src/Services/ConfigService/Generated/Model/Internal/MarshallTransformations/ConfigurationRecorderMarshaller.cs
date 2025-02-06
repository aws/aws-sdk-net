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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfigurationRecorder Marshaller
    /// </summary>
    public class ConfigurationRecorderMarshaller : IRequestMarshaller<ConfigurationRecorder, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConfigurationRecorder requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetRecordingGroup())
            {
                context.Writer.WritePropertyName("recordingGroup");
                context.Writer.WriteStartObject();

                var marshaller = RecordingGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordingGroup, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecordingMode())
            {
                context.Writer.WritePropertyName("recordingMode");
                context.Writer.WriteStartObject();

                var marshaller = RecordingModeMarshaller.Instance;
                marshaller.Marshall(requestObject.RecordingMode, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRecordingScope())
            {
                context.Writer.WritePropertyName("recordingScope");
                context.Writer.WriteStringValue(requestObject.RecordingScope);
            }

            if(requestObject.IsSetRoleARN())
            {
                context.Writer.WritePropertyName("roleARN");
                context.Writer.WriteStringValue(requestObject.RoleARN);
            }

            if(requestObject.IsSetServicePrincipal())
            {
                context.Writer.WritePropertyName("servicePrincipal");
                context.Writer.WriteStringValue(requestObject.ServicePrincipal);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConfigurationRecorderMarshaller Instance = new ConfigurationRecorderMarshaller();

    }
}