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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScopedActions Marshaller
    /// </summary>
    public class ScopedActionsMarshaller : IRequestMarshaller<ScopedActions, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScopedActions requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetActions())
            {
                context.Writer.WriteTextString("actions");
                context.Writer.WriteStartArray(requestObject.Actions.Count);
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                        context.Writer.WriteTextString(requestObjectActionsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (requestObject.IsSetContextConditions())
            {
                context.Writer.WriteTextString("contextConditions");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectContextConditionsKvp in requestObject.ContextConditions)
                {
                    context.Writer.WriteTextString(requestObjectContextConditionsKvp.Key);
                    var requestObjectContextConditionsValue = requestObjectContextConditionsKvp.Value;

                    context.Writer.WriteStartArray(requestObjectContextConditionsValue.Count);
                    foreach(var requestObjectContextConditionsValueListValue in requestObjectContextConditionsValue)
                    {
                            context.Writer.WriteTextString(requestObjectContextConditionsValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetResources())
            {
                context.Writer.WriteTextString("resources");
                context.Writer.WriteStartArray(requestObject.Resources.Count);
                foreach(var requestObjectResourcesListValue in requestObject.Resources)
                {
                    context.Writer.WriteStartMap(null);

                    var marshaller = ResourceScopeMarshaller.Instance;
                    marshaller.Marshall(requestObjectResourcesListValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndArray();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScopedActionsMarshaller Instance = new ScopedActionsMarshaller();

    }
}