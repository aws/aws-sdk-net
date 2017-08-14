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
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StorageDescriptor Object
    /// </summary>  
    public class StorageDescriptorUnmarshaller : IUnmarshaller<StorageDescriptor, XmlUnmarshallerContext>, IUnmarshaller<StorageDescriptor, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StorageDescriptor IUnmarshaller<StorageDescriptor, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StorageDescriptor Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StorageDescriptor unmarshalledObject = new StorageDescriptor();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BucketColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BucketColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Columns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Column, ColumnUnmarshaller>(ColumnUnmarshaller.Instance);
                    unmarshalledObject.Columns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Compressed", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Compressed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InputFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InputFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Location", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Location = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfBuckets", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfBuckets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutputFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SerdeInfo", targetDepth))
                {
                    var unmarshaller = SerDeInfoUnmarshaller.Instance;
                    unmarshalledObject.SerdeInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SkewedInfo", targetDepth))
                {
                    var unmarshaller = SkewedInfoUnmarshaller.Instance;
                    unmarshalledObject.SkewedInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SortColumns", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Order, OrderUnmarshaller>(OrderUnmarshaller.Instance);
                    unmarshalledObject.SortColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StoredAsSubDirectories", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.StoredAsSubDirectories = unmarshaller.Unmarshall(context);
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