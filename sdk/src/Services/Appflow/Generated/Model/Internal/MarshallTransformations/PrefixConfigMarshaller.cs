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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Appflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Appflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PrefixConfig Marshaller
    /// </summary>
    public class PrefixConfigMarshaller : IRequestMarshaller<PrefixConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PrefixConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPathPrefixHierarchy())
            {
                context.Writer.WritePropertyName("pathPrefixHierarchy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPathPrefixHierarchyListValue in requestObject.PathPrefixHierarchy)
                {
                        context.Writer.WriteStringValue(requestObjectPathPrefixHierarchyListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPrefixFormat())
            {
                context.Writer.WritePropertyName("prefixFormat");
                context.Writer.WriteStringValue(requestObject.PrefixFormat);
            }

            if(requestObject.IsSetPrefixType())
            {
                context.Writer.WritePropertyName("prefixType");
                context.Writer.WriteStringValue(requestObject.PrefixType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PrefixConfigMarshaller Instance = new PrefixConfigMarshaller();

    }
}