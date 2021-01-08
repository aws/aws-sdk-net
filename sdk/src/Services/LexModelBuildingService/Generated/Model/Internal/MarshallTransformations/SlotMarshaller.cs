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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Slot Marshaller
    /// </summary>       
    public class SlotMarshaller : IRequestMarshaller<Slot, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Slot requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDefaultValueSpec())
            {
                context.Writer.WritePropertyName("defaultValueSpec");
                context.Writer.WriteObjectStart();

                var marshaller = SlotDefaultValueSpecMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultValueSpec, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetObfuscationSetting())
            {
                context.Writer.WritePropertyName("obfuscationSetting");
                context.Writer.Write(requestObject.ObfuscationSetting);
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("priority");
                context.Writer.Write(requestObject.Priority);
            }

            if(requestObject.IsSetResponseCard())
            {
                context.Writer.WritePropertyName("responseCard");
                context.Writer.Write(requestObject.ResponseCard);
            }

            if(requestObject.IsSetSampleUtterances())
            {
                context.Writer.WritePropertyName("sampleUtterances");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSampleUtterancesListValue in requestObject.SampleUtterances)
                {
                        context.Writer.Write(requestObjectSampleUtterancesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSlotConstraint())
            {
                context.Writer.WritePropertyName("slotConstraint");
                context.Writer.Write(requestObject.SlotConstraint);
            }

            if(requestObject.IsSetSlotType())
            {
                context.Writer.WritePropertyName("slotType");
                context.Writer.Write(requestObject.SlotType);
            }

            if(requestObject.IsSetSlotTypeVersion())
            {
                context.Writer.WritePropertyName("slotTypeVersion");
                context.Writer.Write(requestObject.SlotTypeVersion);
            }

            if(requestObject.IsSetValueElicitationPrompt())
            {
                context.Writer.WritePropertyName("valueElicitationPrompt");
                context.Writer.WriteObjectStart();

                var marshaller = PromptMarshaller.Instance;
                marshaller.Marshall(requestObject.ValueElicitationPrompt, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static SlotMarshaller Instance = new SlotMarshaller();

    }
}