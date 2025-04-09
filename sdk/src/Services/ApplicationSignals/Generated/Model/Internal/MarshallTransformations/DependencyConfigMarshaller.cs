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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationSignals.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationSignals.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DependencyConfig Marshaller
    /// </summary>
    public class DependencyConfigMarshaller : IRequestMarshaller<DependencyConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DependencyConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDependencyKeyAttributes())
            {
                context.Writer.WritePropertyName("DependencyKeyAttributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectDependencyKeyAttributesKvp in requestObject.DependencyKeyAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectDependencyKeyAttributesKvp.Key);
                    var requestObjectDependencyKeyAttributesValue = requestObjectDependencyKeyAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectDependencyKeyAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDependencyOperationName())
            {
                context.Writer.WritePropertyName("DependencyOperationName");
                context.Writer.WriteStringValue(requestObject.DependencyOperationName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DependencyConfigMarshaller Instance = new DependencyConfigMarshaller();

    }
}