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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataPrepConfiguration Marshaller
    /// </summary>
    public class DataPrepConfigurationMarshaller : IRequestMarshaller<DataPrepConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataPrepConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationTableMap())
            {
                context.Writer.WritePropertyName("DestinationTableMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDestinationTableMapKvp in requestObject.DestinationTableMap)
                {
                    context.Writer.WritePropertyName(requestObjectDestinationTableMapKvp.Key);
                    var requestObjectDestinationTableMapValue = requestObjectDestinationTableMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = DestinationTableMarshaller.Instance;
                    marshaller.Marshall(requestObjectDestinationTableMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceTableMap())
            {
                context.Writer.WritePropertyName("SourceTableMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectSourceTableMapKvp in requestObject.SourceTableMap)
                {
                    context.Writer.WritePropertyName(requestObjectSourceTableMapKvp.Key);
                    var requestObjectSourceTableMapValue = requestObjectSourceTableMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SourceTableMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourceTableMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTransformStepMap())
            {
                context.Writer.WritePropertyName("TransformStepMap");
                context.Writer.WriteStartObject();
                foreach (var requestObjectTransformStepMapKvp in requestObject.TransformStepMap)
                {
                    context.Writer.WritePropertyName(requestObjectTransformStepMapKvp.Key);
                    var requestObjectTransformStepMapValue = requestObjectTransformStepMapKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = TransformStepMarshaller.Instance;
                    marshaller.Marshall(requestObjectTransformStepMapValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataPrepConfigurationMarshaller Instance = new DataPrepConfigurationMarshaller();

    }
}