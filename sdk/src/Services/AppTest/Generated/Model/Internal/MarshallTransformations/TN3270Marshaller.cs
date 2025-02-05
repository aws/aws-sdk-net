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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TN3270 Marshaller
    /// </summary>
    public class TN3270Marshaller : IRequestMarshaller<TN3270, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TN3270 requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExportDataSetNames())
            {
                context.Writer.WritePropertyName("exportDataSetNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExportDataSetNamesListValue in requestObject.ExportDataSetNames)
                {
                        context.Writer.WriteStringValue(requestObjectExportDataSetNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScript())
            {
                context.Writer.WritePropertyName("script");
                context.Writer.WriteStartObject();

                var marshaller = ScriptMarshaller.Instance;
                marshaller.Marshall(requestObject.Script, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TN3270Marshaller Instance = new TN3270Marshaller();

    }
}