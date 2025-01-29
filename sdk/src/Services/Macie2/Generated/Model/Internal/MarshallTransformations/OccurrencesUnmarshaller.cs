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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Macie2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Macie2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Occurrences Object
    /// </summary>  
    public class OccurrencesUnmarshaller : IJsonUnmarshaller<Occurrences, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Occurrences Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Occurrences unmarshalledObject = new Occurrences();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cells", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Cell, CellUnmarshaller>(CellUnmarshaller.Instance);
                    unmarshalledObject.Cells = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lineRanges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Range, RangeUnmarshaller>(RangeUnmarshaller.Instance);
                    unmarshalledObject.LineRanges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("offsetRanges", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Range, RangeUnmarshaller>(RangeUnmarshaller.Instance);
                    unmarshalledObject.OffsetRanges = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("pages", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Page, PageUnmarshaller>(PageUnmarshaller.Instance);
                    unmarshalledObject.Pages = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("records", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Record, RecordUnmarshaller>(RecordUnmarshaller.Instance);
                    unmarshalledObject.Records = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OccurrencesUnmarshaller _instance = new OccurrencesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OccurrencesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}