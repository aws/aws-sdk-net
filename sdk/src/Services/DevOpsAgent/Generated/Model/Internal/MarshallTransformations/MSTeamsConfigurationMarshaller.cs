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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MSTeamsConfiguration Marshaller
    /// </summary>
    public class MSTeamsConfigurationMarshaller : IRequestMarshaller<MSTeamsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MSTeamsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetTeamId())
            {
                context.Writer.WritePropertyName("teamId");
                context.Writer.WriteStringValue(requestObject.TeamId);
            }

            if(requestObject.IsSetTeamName())
            {
                context.Writer.WritePropertyName("teamName");
                context.Writer.WriteStringValue(requestObject.TeamName);
            }

            if(requestObject.IsSetTransmissionTarget())
            {
                context.Writer.WritePropertyName("transmissionTarget");
                context.Writer.WriteStartObject();

                var marshaller = MSTeamsTransmissionTargetMarshaller.Instance;
                marshaller.Marshall(requestObject.TransmissionTarget, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MSTeamsConfigurationMarshaller Instance = new MSTeamsConfigurationMarshaller();

    }
}