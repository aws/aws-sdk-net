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
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TrafficPattern Marshaller
    /// </summary>
    public class TrafficPatternMarshaller : IRequestMarshaller<TrafficPattern, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TrafficPattern requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetPhases())
            {
                context.Writer.WritePropertyName("Phases");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPhasesListValue in requestObject.Phases)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PhaseMarshaller.Instance;
                    marshaller.Marshall(requestObjectPhasesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTrafficType())
            {
                context.Writer.WritePropertyName("TrafficType");
                context.Writer.Write(requestObject.TrafficType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TrafficPatternMarshaller Instance = new TrafficPatternMarshaller();

    }
}