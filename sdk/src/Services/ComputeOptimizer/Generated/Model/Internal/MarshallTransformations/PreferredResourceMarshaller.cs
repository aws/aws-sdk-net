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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PreferredResource Marshaller
    /// </summary>
    public class PreferredResourceMarshaller : IRequestMarshaller<PreferredResource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PreferredResource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExcludeList())
            {
                context.Writer.WritePropertyName("excludeList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeListListValue in requestObject.ExcludeList)
                {
                        context.Writer.WriteStringValue(requestObjectExcludeListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIncludeList())
            {
                context.Writer.WritePropertyName("includeList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIncludeListListValue in requestObject.IncludeList)
                {
                        context.Writer.WriteStringValue(requestObjectIncludeListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PreferredResourceMarshaller Instance = new PreferredResourceMarshaller();

    }
}