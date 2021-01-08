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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AliasRoutingConfiguration Marshaller
    /// </summary>       
    public class AliasRoutingConfigurationMarshaller : IRequestMarshaller<AliasRoutingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AliasRoutingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAdditionalVersionWeights())
            {
                context.Writer.WritePropertyName("AdditionalVersionWeights");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAdditionalVersionWeightsKvp in requestObject.AdditionalVersionWeights)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalVersionWeightsKvp.Key);
                    var requestObjectAdditionalVersionWeightsValue = requestObjectAdditionalVersionWeightsKvp.Value;

                        context.Writer.Write(requestObjectAdditionalVersionWeightsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AliasRoutingConfigurationMarshaller Instance = new AliasRoutingConfigurationMarshaller();

    }
}