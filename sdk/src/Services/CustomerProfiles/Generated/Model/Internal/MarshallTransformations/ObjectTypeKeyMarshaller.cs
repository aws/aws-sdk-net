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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ObjectTypeKey Marshaller
    /// </summary>
    public class ObjectTypeKeyMarshaller : IRequestMarshaller<ObjectTypeKey, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ObjectTypeKey requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFieldNames())
            {
                context.Writer.WritePropertyName("FieldNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFieldNamesListValue in requestObject.FieldNames)
                {
                        context.Writer.WriteStringValue(requestObjectFieldNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStandardIdentifiers())
            {
                context.Writer.WritePropertyName("StandardIdentifiers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectStandardIdentifiersListValue in requestObject.StandardIdentifiers)
                {
                        context.Writer.WriteStringValue(requestObjectStandardIdentifiersListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ObjectTypeKeyMarshaller Instance = new ObjectTypeKeyMarshaller();

    }
}