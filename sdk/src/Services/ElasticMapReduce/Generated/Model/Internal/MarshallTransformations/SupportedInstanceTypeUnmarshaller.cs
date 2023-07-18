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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SupportedInstanceType Object
    /// </summary>  
    public class SupportedInstanceTypeUnmarshaller : IUnmarshaller<SupportedInstanceType, XmlUnmarshallerContext>, IUnmarshaller<SupportedInstanceType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SupportedInstanceType IUnmarshaller<SupportedInstanceType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SupportedInstanceType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SupportedInstanceType unmarshalledObject = new SupportedInstanceType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Architecture", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Architecture = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsOptimizedAvailable", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EbsOptimizedAvailable = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsOptimizedByDefault", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EbsOptimizedByDefault = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsStorageOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.EbsStorageOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceFamilyId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceFamilyId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Is64BitsOnly", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.Is64BitsOnly = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MemoryGB", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.MemoryGB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfDisks", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfDisks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StorageGB", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.StorageGB = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VCPU", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.VCPU = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SupportedInstanceTypeUnmarshaller _instance = new SupportedInstanceTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SupportedInstanceTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}