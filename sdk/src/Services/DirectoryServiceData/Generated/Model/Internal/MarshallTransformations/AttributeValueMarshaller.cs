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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryServiceData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DirectoryServiceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AttributeValue Marshaller
    /// </summary>
    public class AttributeValueMarshaller : IRequestMarshaller<AttributeValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AttributeValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBOOL())
            {
                context.Writer.WritePropertyName("BOOL");
                context.Writer.WriteBooleanValue(requestObject.BOOL.Value);
            }

            if(requestObject.IsSetN())
            {
                context.Writer.WritePropertyName("N");
                context.Writer.WriteNumberValue(requestObject.N.Value);
            }

            if(requestObject.IsSetS())
            {
                context.Writer.WritePropertyName("S");
                context.Writer.WriteStringValue(requestObject.S);
            }

            if(requestObject.IsSetSS())
            {
                context.Writer.WritePropertyName("SS");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSSListValue in requestObject.SS)
                {
                        context.Writer.WriteStringValue(requestObjectSSListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeValueMarshaller Instance = new AttributeValueMarshaller();

    }
}