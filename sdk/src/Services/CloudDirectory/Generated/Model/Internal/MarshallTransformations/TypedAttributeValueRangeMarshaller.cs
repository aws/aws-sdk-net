/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TypedAttributeValueRange Marshaller
    /// </summary>       
    public class TypedAttributeValueRangeMarshaller : IRequestMarshaller<TypedAttributeValueRange, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TypedAttributeValueRange requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEndMode())
            {
                context.Writer.WritePropertyName("EndMode");
                context.Writer.Write(requestObject.EndMode);
            }

            if(requestObject.IsSetEndValue())
            {
                context.Writer.WritePropertyName("EndValue");
                context.Writer.WriteObjectStart();

                var marshaller = TypedAttributeValueMarshaller.Instance;
                marshaller.Marshall(requestObject.EndValue, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStartMode())
            {
                context.Writer.WritePropertyName("StartMode");
                context.Writer.Write(requestObject.StartMode);
            }

            if(requestObject.IsSetStartValue())
            {
                context.Writer.WritePropertyName("StartValue");
                context.Writer.WriteObjectStart();

                var marshaller = TypedAttributeValueMarshaller.Instance;
                marshaller.Marshall(requestObject.StartValue, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TypedAttributeValueRangeMarshaller Instance = new TypedAttributeValueRangeMarshaller();

    }
}