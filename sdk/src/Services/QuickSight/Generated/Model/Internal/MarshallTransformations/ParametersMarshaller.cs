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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Parameters Marshaller
    /// </summary>
    public class ParametersMarshaller : IRequestMarshaller<Parameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Parameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDateTimeParameters())
            {
                context.Writer.WritePropertyName("DateTimeParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDateTimeParametersListValue in requestObject.DateTimeParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DateTimeParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectDateTimeParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDecimalParameters())
            {
                context.Writer.WritePropertyName("DecimalParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDecimalParametersListValue in requestObject.DecimalParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DecimalParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectDecimalParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIntegerParameters())
            {
                context.Writer.WritePropertyName("IntegerParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIntegerParametersListValue in requestObject.IntegerParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = IntegerParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectIntegerParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringParameters())
            {
                context.Writer.WritePropertyName("StringParameters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringParametersListValue in requestObject.StringParameters)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = StringParameterMarshaller.Instance;
                    marshaller.Marshall(requestObjectStringParametersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ParametersMarshaller Instance = new ParametersMarshaller();

    }
}