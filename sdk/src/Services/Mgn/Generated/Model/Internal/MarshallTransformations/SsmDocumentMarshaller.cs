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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SsmDocument Marshaller
    /// </summary>
    public class SsmDocumentMarshaller : IRequestMarshaller<SsmDocument, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SsmDocument requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionName())
            {
                context.Writer.WritePropertyName("actionName");
                context.Writer.WriteStringValue(requestObject.ActionName);
            }

            if(requestObject.IsSetExternalParameters())
            {
                context.Writer.WritePropertyName("externalParameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectExternalParametersKvp in requestObject.ExternalParameters)
                {
                    context.Writer.WritePropertyName(requestObjectExternalParametersKvp.Key);
                    var requestObjectExternalParametersValue = requestObjectExternalParametersKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SsmExternalParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectExternalParametersValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMustSucceedForCutover())
            {
                context.Writer.WritePropertyName("mustSucceedForCutover");
                context.Writer.WriteBooleanValue(requestObject.MustSucceedForCutover.Value);
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
                        context.Writer.WriteStartObject();

                        var marshaller = SsmParameterStoreParameterMarshaller.Instance;
                        marshaller.Marshall(requestObjectParametersValueListValue, context);

                        context.Writer.WriteEndObject();
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSsmDocumentName())
            {
                context.Writer.WritePropertyName("ssmDocumentName");
                context.Writer.WriteStringValue(requestObject.SsmDocumentName);
            }

            if(requestObject.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("timeoutSeconds");
                context.Writer.WriteNumberValue(requestObject.TimeoutSeconds.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SsmDocumentMarshaller Instance = new SsmDocumentMarshaller();

    }
}