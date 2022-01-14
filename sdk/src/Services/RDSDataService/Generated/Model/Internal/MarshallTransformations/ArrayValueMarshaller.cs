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
 * Do not modify this file. This file is generated from the rds-data-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDSDataService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.RDSDataService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ArrayValue Marshaller
    /// </summary>
    public class ArrayValueMarshaller : IRequestMarshaller<ArrayValue, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ArrayValue requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetArrayValues())
            {
                context.Writer.WritePropertyName("arrayValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectArrayValuesListValue in requestObject.ArrayValues)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ArrayValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectArrayValuesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBooleanValues())
            {
                context.Writer.WritePropertyName("booleanValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBooleanValuesListValue in requestObject.BooleanValues)
                {
                        context.Writer.Write(requestObjectBooleanValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDoubleValues())
            {
                context.Writer.WritePropertyName("doubleValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDoubleValuesListValue in requestObject.DoubleValues)
                {
                        context.Writer.Write(requestObjectDoubleValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLongValues())
            {
                context.Writer.WritePropertyName("longValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLongValuesListValue in requestObject.LongValues)
                {
                        context.Writer.Write(requestObjectLongValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringValues())
            {
                context.Writer.WritePropertyName("stringValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringValuesListValue in requestObject.StringValues)
                {
                        context.Writer.Write(requestObjectStringValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ArrayValueMarshaller Instance = new ArrayValueMarshaller();

    }
}