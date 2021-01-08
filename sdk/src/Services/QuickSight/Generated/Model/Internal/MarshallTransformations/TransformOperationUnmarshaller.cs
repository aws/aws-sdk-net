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
using System.Net;
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
    /// Response Unmarshaller for TransformOperation Object
    /// </summary>  
    public class TransformOperationUnmarshaller : IUnmarshaller<TransformOperation, XmlUnmarshallerContext>, IUnmarshaller<TransformOperation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TransformOperation IUnmarshaller<TransformOperation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TransformOperation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            TransformOperation unmarshalledObject = new TransformOperation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CastColumnTypeOperation", targetDepth))
                {
                    var unmarshaller = CastColumnTypeOperationUnmarshaller.Instance;
                    unmarshalledObject.CastColumnTypeOperation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateColumnsOperation", targetDepth))
                {
                    var unmarshaller = CreateColumnsOperationUnmarshaller.Instance;
                    unmarshalledObject.CreateColumnsOperation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FilterOperation", targetDepth))
                {
                    var unmarshaller = FilterOperationUnmarshaller.Instance;
                    unmarshalledObject.FilterOperation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectOperation", targetDepth))
                {
                    var unmarshaller = ProjectOperationUnmarshaller.Instance;
                    unmarshalledObject.ProjectOperation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenameColumnOperation", targetDepth))
                {
                    var unmarshaller = RenameColumnOperationUnmarshaller.Instance;
                    unmarshalledObject.RenameColumnOperation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TagColumnOperation", targetDepth))
                {
                    var unmarshaller = TagColumnOperationUnmarshaller.Instance;
                    unmarshalledObject.TagColumnOperation = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static TransformOperationUnmarshaller _instance = new TransformOperationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransformOperationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}