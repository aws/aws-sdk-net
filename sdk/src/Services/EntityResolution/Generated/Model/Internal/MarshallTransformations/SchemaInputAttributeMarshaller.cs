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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SchemaInputAttribute Marshaller
    /// </summary>
    public class SchemaInputAttributeMarshaller : IRequestMarshaller<SchemaInputAttribute, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SchemaInputAttribute requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFieldName())
            {
                context.Writer.WritePropertyName("fieldName");
                context.Writer.WriteStringValue(requestObject.FieldName);
            }

            if(requestObject.IsSetGroupName())
            {
                context.Writer.WritePropertyName("groupName");
                context.Writer.WriteStringValue(requestObject.GroupName);
            }

            if(requestObject.IsSetHashed())
            {
                context.Writer.WritePropertyName("hashed");
                context.Writer.WriteBooleanValue(requestObject.Hashed.Value);
            }

            if(requestObject.IsSetMatchKey())
            {
                context.Writer.WritePropertyName("matchKey");
                context.Writer.WriteStringValue(requestObject.MatchKey);
            }

            if(requestObject.IsSetSubType())
            {
                context.Writer.WritePropertyName("subType");
                context.Writer.WriteStringValue(requestObject.SubType);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SchemaInputAttributeMarshaller Instance = new SchemaInputAttributeMarshaller();

    }
}