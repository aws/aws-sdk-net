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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutEquipment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InferenceInputConfiguration Marshaller
    /// </summary>       
    public class InferenceInputConfigurationMarshaller : IRequestMarshaller<InferenceInputConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InferenceInputConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInferenceInputNameConfiguration())
            {
                context.Writer.WritePropertyName("InferenceInputNameConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = InferenceInputNameConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InferenceInputNameConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInputTimeZoneOffset())
            {
                context.Writer.WritePropertyName("InputTimeZoneOffset");
                context.Writer.Write(requestObject.InputTimeZoneOffset);
            }

            if(requestObject.IsSetS3InputConfiguration())
            {
                context.Writer.WritePropertyName("S3InputConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = InferenceS3InputConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3InputConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static InferenceInputConfigurationMarshaller Instance = new InferenceInputConfigurationMarshaller();

    }
}