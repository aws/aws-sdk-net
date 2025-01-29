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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GlobalConfiguration Marshaller
    /// </summary>
    public class GlobalConfigurationMarshaller : IRequestMarshaller<GlobalConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GlobalConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInitialAudioGain())
            {
                context.Writer.WritePropertyName("initialAudioGain");
                context.Writer.WriteNumberValue(requestObject.InitialAudioGain.Value);
            }

            if(requestObject.IsSetInputEndAction())
            {
                context.Writer.WritePropertyName("inputEndAction");
                context.Writer.WriteStringValue(requestObject.InputEndAction);
            }

            if(requestObject.IsSetInputLossBehavior())
            {
                context.Writer.WritePropertyName("inputLossBehavior");
                context.Writer.WriteStartObject();

                var marshaller = InputLossBehaviorMarshaller.Instance;
                marshaller.Marshall(requestObject.InputLossBehavior, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputLockingMode())
            {
                context.Writer.WritePropertyName("outputLockingMode");
                context.Writer.WriteStringValue(requestObject.OutputLockingMode);
            }

            if(requestObject.IsSetOutputLockingSettings())
            {
                context.Writer.WritePropertyName("outputLockingSettings");
                context.Writer.WriteStartObject();

                var marshaller = OutputLockingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.OutputLockingSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOutputTimingSource())
            {
                context.Writer.WritePropertyName("outputTimingSource");
                context.Writer.WriteStringValue(requestObject.OutputTimingSource);
            }

            if(requestObject.IsSetSupportLowFramerateInputs())
            {
                context.Writer.WritePropertyName("supportLowFramerateInputs");
                context.Writer.WriteStringValue(requestObject.SupportLowFramerateInputs);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GlobalConfigurationMarshaller Instance = new GlobalConfigurationMarshaller();

    }
}