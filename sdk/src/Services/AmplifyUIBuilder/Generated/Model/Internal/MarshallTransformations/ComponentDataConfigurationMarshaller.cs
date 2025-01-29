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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComponentDataConfiguration Marshaller
    /// </summary>
    public class ComponentDataConfigurationMarshaller : IRequestMarshaller<ComponentDataConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentDataConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetIdentifiers())
            {
                context.Writer.WritePropertyName("identifiers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIdentifiersListValue in requestObject.Identifiers)
                {
                        context.Writer.WriteStringValue(requestObjectIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetModel())
            {
                context.Writer.WritePropertyName("model");
                context.Writer.WriteStringValue(requestObject.Model);
            }

            if(requestObject.IsSetPredicate())
            {
                context.Writer.WritePropertyName("predicate");
                context.Writer.WriteStartObject();

                var marshaller = PredicateMarshaller.Instance;
                marshaller.Marshall(requestObject.Predicate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSort())
            {
                context.Writer.WritePropertyName("sort");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSortListValue in requestObject.Sort)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SortPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectSortListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentDataConfigurationMarshaller Instance = new ComponentDataConfigurationMarshaller();

    }
}