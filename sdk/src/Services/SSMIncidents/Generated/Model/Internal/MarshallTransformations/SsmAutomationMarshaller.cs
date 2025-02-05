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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SsmAutomation Marshaller
    /// </summary>
    public class SsmAutomationMarshaller : IRequestMarshaller<SsmAutomation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SsmAutomation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDocumentName())
            {
                context.Writer.WritePropertyName("documentName");
                context.Writer.WriteStringValue(requestObject.DocumentName);
            }

            if(requestObject.IsSetDocumentVersion())
            {
                context.Writer.WritePropertyName("documentVersion");
                context.Writer.WriteStringValue(requestObject.DocumentVersion);
            }

            if(requestObject.IsSetDynamicParameters())
            {
                context.Writer.WritePropertyName("dynamicParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDynamicParametersKvp in requestObject.DynamicParameters)
                {
                    context.Writer.WritePropertyName(requestObjectDynamicParametersKvp.Key);
                    var requestObjectDynamicParametersValue = requestObjectDynamicParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = DynamicSsmParameterValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectDynamicParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectParametersValueListValue in requestObjectParametersValue)
                    {
                            context.Writer.WriteStringValue(requestObjectParametersValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("roleArn");
                context.Writer.WriteStringValue(requestObject.RoleArn);
            }

            if(requestObject.IsSetTargetAccount())
            {
                context.Writer.WritePropertyName("targetAccount");
                context.Writer.WriteStringValue(requestObject.TargetAccount);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SsmAutomationMarshaller Instance = new SsmAutomationMarshaller();

    }
}