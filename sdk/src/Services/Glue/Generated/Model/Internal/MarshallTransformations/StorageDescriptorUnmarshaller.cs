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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StorageDescriptor Object
    /// </summary>  
    public class StorageDescriptorUnmarshaller : IJsonUnmarshaller<StorageDescriptor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public StorageDescriptor Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            StorageDescriptor unmarshalledObject = new StorageDescriptor();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AdditionalLocations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AdditionalLocations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("BucketColumns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BucketColumns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Columns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Column, ColumnUnmarshaller>(ColumnUnmarshaller.Instance);
                    unmarshalledObject.Columns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Compressed", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Compressed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InputFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Location", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NumberOfBuckets", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfBuckets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutputFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputFormat = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SchemaReference", targetDepth))
                {
                    var unmarshaller = SchemaReferenceUnmarshaller.Instance;
                    unmarshalledObject.SchemaReference = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SerdeInfo", targetDepth))
                {
                    var unmarshaller = SerDeInfoUnmarshaller.Instance;
                    unmarshalledObject.SerdeInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SkewedInfo", targetDepth))
                {
                    var unmarshaller = SkewedInfoUnmarshaller.Instance;
                    unmarshalledObject.SkewedInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SortColumns", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Order, OrderUnmarshaller>(OrderUnmarshaller.Instance);
                    unmarshalledObject.SortColumns = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StoredAsSubDirectories", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.StoredAsSubDirectories = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StorageDescriptorUnmarshaller _instance = new StorageDescriptorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StorageDescriptorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}