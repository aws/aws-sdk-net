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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutomationExecutionInputs Marshaller
    /// </summary>
    public class AutomationExecutionInputsMarshaller : IRequestMarshaller<AutomationExecutionInputs, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutomationExecutionInputs requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
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

            if(requestObject.IsSetTargetLocations())
            {
                context.Writer.WritePropertyName("TargetLocations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetLocationsListValue in requestObject.TargetLocations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetLocationMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetLocationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetLocationsURL())
            {
                context.Writer.WritePropertyName("TargetLocationsURL");
                context.Writer.WriteStringValue(requestObject.TargetLocationsURL);
            }

            if(requestObject.IsSetTargetMaps())
            {
                context.Writer.WritePropertyName("TargetMaps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetMapsListValue in requestObject.TargetMaps)
                {
                    context.Writer.WriteStartObject();
                    foreach (var requestObjectTargetMapsListValueKvp in requestObjectTargetMapsListValue)
                    {
                        context.Writer.WritePropertyName(requestObjectTargetMapsListValueKvp.Key);
                        var requestObjectTargetMapsListValueValue = requestObjectTargetMapsListValueKvp.Value;

                        context.Writer.WriteStartArray();
                        foreach(var requestObjectTargetMapsListValueValueListValue in requestObjectTargetMapsListValueValue)
                        {
                                context.Writer.WriteStringValue(requestObjectTargetMapsListValueValueListValue);
                        }
                        context.Writer.WriteEndArray();
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTargetParameterName())
            {
                context.Writer.WritePropertyName("TargetParameterName");
                context.Writer.WriteStringValue(requestObject.TargetParameterName);
            }

            if(requestObject.IsSetTargets())
            {
                context.Writer.WritePropertyName("Targets");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTargetsListValue in requestObject.Targets)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TargetMarshaller.Instance;
                    marshaller.Marshall(requestObjectTargetsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutomationExecutionInputsMarshaller Instance = new AutomationExecutionInputsMarshaller();

    }
}