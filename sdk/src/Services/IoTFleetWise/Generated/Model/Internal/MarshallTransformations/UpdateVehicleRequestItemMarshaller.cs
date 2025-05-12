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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateVehicleRequestItem Marshaller
    /// </summary>
    public class UpdateVehicleRequestItemMarshaller : IRequestMarshaller<UpdateVehicleRequestItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateVehicleRequestItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAttributeUpdateMode())
            {
                context.Writer.WritePropertyName("attributeUpdateMode");
                context.Writer.WriteStringValue(requestObject.AttributeUpdateMode);
            }

            if(requestObject.IsSetDecoderManifestArn())
            {
                context.Writer.WritePropertyName("decoderManifestArn");
                context.Writer.WriteStringValue(requestObject.DecoderManifestArn);
            }

            if(requestObject.IsSetModelManifestArn())
            {
                context.Writer.WritePropertyName("modelManifestArn");
                context.Writer.WriteStringValue(requestObject.ModelManifestArn);
            }

            if(requestObject.IsSetStateTemplatesToAdd())
            {
                context.Writer.WritePropertyName("stateTemplatesToAdd");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStateTemplatesToAddListValue in requestObject.StateTemplatesToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StateTemplateAssociationMarshaller.Instance;
                    marshaller.Marshall(requestObjectStateTemplatesToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStateTemplatesToRemove())
            {
                context.Writer.WritePropertyName("stateTemplatesToRemove");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStateTemplatesToRemoveListValue in requestObject.StateTemplatesToRemove)
                {
                        context.Writer.WriteStringValue(requestObjectStateTemplatesToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStateTemplatesToUpdate())
            {
                context.Writer.WritePropertyName("stateTemplatesToUpdate");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStateTemplatesToUpdateListValue in requestObject.StateTemplatesToUpdate)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StateTemplateAssociationMarshaller.Instance;
                    marshaller.Marshall(requestObjectStateTemplatesToUpdateListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetVehicleName())
            {
                context.Writer.WritePropertyName("vehicleName");
                context.Writer.WriteStringValue(requestObject.VehicleName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateVehicleRequestItemMarshaller Instance = new UpdateVehicleRequestItemMarshaller();

    }
}