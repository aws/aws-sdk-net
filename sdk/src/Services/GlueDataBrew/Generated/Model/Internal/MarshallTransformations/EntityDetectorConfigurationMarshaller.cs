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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EntityDetectorConfiguration Marshaller
    /// </summary>
    public class EntityDetectorConfigurationMarshaller : IRequestMarshaller<EntityDetectorConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EntityDetectorConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedStatistics())
            {
                context.Writer.WritePropertyName("AllowedStatistics");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedStatisticsListValue in requestObject.AllowedStatistics)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AllowedStatisticsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAllowedStatisticsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEntityTypes())
            {
                context.Writer.WritePropertyName("EntityTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectEntityTypesListValue in requestObject.EntityTypes)
                {
                        context.Writer.WriteStringValue(requestObjectEntityTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EntityDetectorConfigurationMarshaller Instance = new EntityDetectorConfigurationMarshaller();

    }
}