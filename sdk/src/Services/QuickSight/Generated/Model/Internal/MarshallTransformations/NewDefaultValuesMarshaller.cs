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
    /// NewDefaultValues Marshaller
    /// </summary>
    public class NewDefaultValuesMarshaller : IRequestMarshaller<NewDefaultValues, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NewDefaultValues requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDateTimeStaticValues())
            {
                context.Writer.WritePropertyName("DateTimeStaticValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDateTimeStaticValuesListValue in requestObject.DateTimeStaticValues)
                {
                        context.Writer.Write(requestObjectDateTimeStaticValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDecimalStaticValues())
            {
                context.Writer.WritePropertyName("DecimalStaticValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDecimalStaticValuesListValue in requestObject.DecimalStaticValues)
                {
                        context.Writer.Write(requestObjectDecimalStaticValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIntegerStaticValues())
            {
                context.Writer.WritePropertyName("IntegerStaticValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIntegerStaticValuesListValue in requestObject.IntegerStaticValues)
                {
                        context.Writer.Write(requestObjectIntegerStaticValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStringStaticValues())
            {
                context.Writer.WritePropertyName("StringStaticValues");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStringStaticValuesListValue in requestObject.StringStaticValues)
                {
                        context.Writer.Write(requestObjectStringStaticValuesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NewDefaultValuesMarshaller Instance = new NewDefaultValuesMarshaller();

    }
}