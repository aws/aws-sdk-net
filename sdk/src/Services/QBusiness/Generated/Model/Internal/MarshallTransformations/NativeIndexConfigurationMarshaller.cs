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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NativeIndexConfiguration Marshaller
    /// </summary>
    public class NativeIndexConfigurationMarshaller : IRequestMarshaller<NativeIndexConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NativeIndexConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBoostingOverride())
            {
                context.Writer.WritePropertyName("boostingOverride");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectBoostingOverrideKvp in requestObject.BoostingOverride)
                {
                    context.Writer.WritePropertyName(requestObjectBoostingOverrideKvp.Key);
                    var requestObjectBoostingOverrideValue = requestObjectBoostingOverrideKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = DocumentAttributeBoostingConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectBoostingOverrideValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetIndexId())
            {
                context.Writer.WritePropertyName("indexId");
                context.Writer.Write(requestObject.IndexId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NativeIndexConfigurationMarshaller Instance = new NativeIndexConfigurationMarshaller();

    }
}