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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTTwinMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTTwinMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataType Marshaller
    /// </summary>
    public class DataTypeMarshaller : IRequestMarshaller<DataType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataType requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowedValues())
            {
                context.Writer.WritePropertyName("allowedValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedValuesListValue in requestObject.AllowedValues)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectAllowedValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNestedType())
            {
                context.Writer.WritePropertyName("nestedType");
                context.Writer.WriteObjectStart();

                var marshaller = DataTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.NestedType, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRelationship())
            {
                context.Writer.WritePropertyName("relationship");
                context.Writer.WriteObjectStart();

                var marshaller = RelationshipMarshaller.Instance;
                marshaller.Marshall(requestObject.Relationship, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.Write(requestObject.Type);
            }

            if(requestObject.IsSetUnitOfMeasure())
            {
                context.Writer.WritePropertyName("unitOfMeasure");
                context.Writer.Write(requestObject.UnitOfMeasure);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataTypeMarshaller Instance = new DataTypeMarshaller();

    }
}