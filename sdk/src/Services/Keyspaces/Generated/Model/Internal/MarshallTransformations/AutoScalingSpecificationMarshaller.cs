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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoScalingSpecification Marshaller
    /// </summary>
    public class AutoScalingSpecificationMarshaller : IRequestMarshaller<AutoScalingSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoScalingSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetReadCapacityAutoScaling())
            {
                context.Writer.WritePropertyName("readCapacityAutoScaling");
                context.Writer.WriteObjectStart();

                var marshaller = AutoScalingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.ReadCapacityAutoScaling, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWriteCapacityAutoScaling())
            {
                context.Writer.WritePropertyName("writeCapacityAutoScaling");
                context.Writer.WriteObjectStart();

                var marshaller = AutoScalingSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.WriteCapacityAutoScaling, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoScalingSpecificationMarshaller Instance = new AutoScalingSpecificationMarshaller();

    }
}