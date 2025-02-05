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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SparkGluePropertiesInput Marshaller
    /// </summary>
    public class SparkGluePropertiesInputMarshaller : IRequestMarshaller<SparkGluePropertiesInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SparkGluePropertiesInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalArgs())
            {
                context.Writer.WritePropertyName("additionalArgs");
                context.Writer.WriteStartObject();

                var marshaller = SparkGlueArgsMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalArgs, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGlueConnectionName())
            {
                context.Writer.WritePropertyName("glueConnectionName");
                context.Writer.WriteStringValue(requestObject.GlueConnectionName);
            }

            if(requestObject.IsSetGlueVersion())
            {
                context.Writer.WritePropertyName("glueVersion");
                context.Writer.WriteStringValue(requestObject.GlueVersion);
            }

            if(requestObject.IsSetIdleTimeout())
            {
                context.Writer.WritePropertyName("idleTimeout");
                context.Writer.WriteNumberValue(requestObject.IdleTimeout.Value);
            }

            if(requestObject.IsSetJavaVirtualEnv())
            {
                context.Writer.WritePropertyName("javaVirtualEnv");
                context.Writer.WriteStringValue(requestObject.JavaVirtualEnv);
            }

            if(requestObject.IsSetNumberOfWorkers())
            {
                context.Writer.WritePropertyName("numberOfWorkers");
                context.Writer.WriteNumberValue(requestObject.NumberOfWorkers.Value);
            }

            if(requestObject.IsSetPythonVirtualEnv())
            {
                context.Writer.WritePropertyName("pythonVirtualEnv");
                context.Writer.WriteStringValue(requestObject.PythonVirtualEnv);
            }

            if(requestObject.IsSetWorkerType())
            {
                context.Writer.WritePropertyName("workerType");
                context.Writer.WriteStringValue(requestObject.WorkerType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SparkGluePropertiesInputMarshaller Instance = new SparkGluePropertiesInputMarshaller();

    }
}