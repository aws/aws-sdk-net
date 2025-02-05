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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HttpMatch Marshaller
    /// </summary>
    public class HttpMatchMarshaller : IRequestMarshaller<HttpMatch, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HttpMatch requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetHeaderMatches())
            {
                context.Writer.WritePropertyName("headerMatches");
                context.Writer.WriteStartArray();
                foreach(var requestObjectHeaderMatchesListValue in requestObject.HeaderMatches)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HeaderMatchMarshaller.Instance;
                    marshaller.Marshall(requestObjectHeaderMatchesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMethod())
            {
                context.Writer.WritePropertyName("method");
                context.Writer.WriteStringValue(requestObject.Method);
            }

            if(requestObject.IsSetPathMatch())
            {
                context.Writer.WritePropertyName("pathMatch");
                context.Writer.WriteStartObject();

                var marshaller = PathMatchMarshaller.Instance;
                marshaller.Marshall(requestObject.PathMatch, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HttpMatchMarshaller Instance = new HttpMatchMarshaller();

    }
}