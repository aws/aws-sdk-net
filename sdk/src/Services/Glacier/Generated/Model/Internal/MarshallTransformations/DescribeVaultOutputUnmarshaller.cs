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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeVaultOutput Object
    /// </summary>  
    public class DescribeVaultOutputUnmarshaller : IUnmarshaller<DescribeVaultOutput, XmlUnmarshallerContext>, IUnmarshaller<DescribeVaultOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DescribeVaultOutput IUnmarshaller<DescribeVaultOutput, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DescribeVaultOutput Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DescribeVaultOutput unmarshalledObject = new DescribeVaultOutput();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastInventoryDate", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Internal.Transform.DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastInventoryDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfArchives", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.NumberOfArchives = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeInBytes", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.SizeInBytes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VaultARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VaultARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VaultName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VaultName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DescribeVaultOutputUnmarshaller _instance = new DescribeVaultOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeVaultOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}