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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EksContainer Marshaller
    /// </summary>
    public class EksContainerMarshaller : IRequestMarshaller<EksContainer, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EksContainer requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArgs())
            {
                context.Writer.WritePropertyName("args");
                context.Writer.WriteStartArray();
                foreach(var requestObjectArgsListValue in requestObject.Args)
                {
                        context.Writer.WriteStringValue(requestObjectArgsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.WriteStringValue(requestObjectCommandListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEnv())
            {
                context.Writer.WritePropertyName("env");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEnvListValue in requestObject.Env)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EksContainerEnvironmentVariableMarshaller.Instance;
                    marshaller.Marshall(requestObjectEnvListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.WriteStringValue(requestObject.Image);
            }

            if(requestObject.IsSetImagePullPolicy())
            {
                context.Writer.WritePropertyName("imagePullPolicy");
                context.Writer.WriteStringValue(requestObject.ImagePullPolicy);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetResources())
            {
                context.Writer.WritePropertyName("resources");
                context.Writer.WriteStartObject();

                var marshaller = EksContainerResourceRequirementsMarshaller.Instance;
                marshaller.Marshall(requestObject.Resources, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecurityContext())
            {
                context.Writer.WritePropertyName("securityContext");
                context.Writer.WriteStartObject();

                var marshaller = EksContainerSecurityContextMarshaller.Instance;
                marshaller.Marshall(requestObject.SecurityContext, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVolumeMounts())
            {
                context.Writer.WritePropertyName("volumeMounts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectVolumeMountsListValue in requestObject.VolumeMounts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EksContainerVolumeMountMarshaller.Instance;
                    marshaller.Marshall(requestObjectVolumeMountsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EksContainerMarshaller Instance = new EksContainerMarshaller();

    }
}