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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OpenXJsonSerDe Marshaller
    /// </summary>       
    public class OpenXJsonSerDeMarshaller : IRequestMarshaller<OpenXJsonSerDe, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OpenXJsonSerDe requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCaseInsensitive())
            {
                context.Writer.WritePropertyName("CaseInsensitive");
                context.Writer.Write(requestObject.CaseInsensitive);
            }

            if(requestObject.IsSetColumnToJsonKeyMappings())
            {
                context.Writer.WritePropertyName("ColumnToJsonKeyMappings");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectColumnToJsonKeyMappingsKvp in requestObject.ColumnToJsonKeyMappings)
                {
                    context.Writer.WritePropertyName(requestObjectColumnToJsonKeyMappingsKvp.Key);
                    var requestObjectColumnToJsonKeyMappingsValue = requestObjectColumnToJsonKeyMappingsKvp.Value;

                        context.Writer.Write(requestObjectColumnToJsonKeyMappingsValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConvertDotsInJsonKeysToUnderscores())
            {
                context.Writer.WritePropertyName("ConvertDotsInJsonKeysToUnderscores");
                context.Writer.Write(requestObject.ConvertDotsInJsonKeysToUnderscores);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static OpenXJsonSerDeMarshaller Instance = new OpenXJsonSerDeMarshaller();

    }
}