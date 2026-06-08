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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AiAgentSearchCriteria Marshaller
    /// </summary>
    public class AiAgentSearchCriteriaMarshaller : IRequestMarshaller<AiAgentSearchCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AiAgentSearchCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAiAgentEscalated())
            {
                context.Writer.WritePropertyName("AiAgentEscalated");
                context.Writer.WriteBooleanValue(requestObject.AiAgentEscalated.Value);
            }

            if(requestObject.IsSetAiUseCase())
            {
                context.Writer.WritePropertyName("AiUseCase");
                context.Writer.WriteStringValue(requestObject.AiUseCase);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetVersionNumber())
            {
                context.Writer.WritePropertyName("VersionNumber");
                context.Writer.WriteNumberValue(requestObject.VersionNumber.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AiAgentSearchCriteriaMarshaller Instance = new AiAgentSearchCriteriaMarshaller();

    }
}