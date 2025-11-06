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

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TransformStep Object
    /// </summary>  
    public class TransformStepUnmarshaller : IUnmarshaller<TransformStep, XmlUnmarshallerContext>, IUnmarshaller<TransformStep, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TransformStep IUnmarshaller<TransformStep, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TransformStep Unmarshall(JsonUnmarshallerContext context)
        {
            TransformStep unmarshalledObject = new TransformStep();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AggregateStep", targetDepth))
                {
                    var unmarshaller = AggregateOperationUnmarshaller.Instance;
                    unmarshalledObject.AggregateStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AppendStep", targetDepth))
                {
                    var unmarshaller = AppendOperationUnmarshaller.Instance;
                    unmarshalledObject.AppendStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CastColumnTypesStep", targetDepth))
                {
                    var unmarshaller = CastColumnTypesOperationUnmarshaller.Instance;
                    unmarshalledObject.CastColumnTypesStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreateColumnsStep", targetDepth))
                {
                    var unmarshaller = CreateColumnsOperationUnmarshaller.Instance;
                    unmarshalledObject.CreateColumnsStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("FiltersStep", targetDepth))
                {
                    var unmarshaller = FiltersOperationUnmarshaller.Instance;
                    unmarshalledObject.FiltersStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ImportTableStep", targetDepth))
                {
                    var unmarshaller = ImportTableOperationUnmarshaller.Instance;
                    unmarshalledObject.ImportTableStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JoinStep", targetDepth))
                {
                    var unmarshaller = JoinOperationUnmarshaller.Instance;
                    unmarshalledObject.JoinStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PivotStep", targetDepth))
                {
                    var unmarshaller = PivotOperationUnmarshaller.Instance;
                    unmarshalledObject.PivotStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProjectStep", targetDepth))
                {
                    var unmarshaller = ProjectOperationUnmarshaller.Instance;
                    unmarshalledObject.ProjectStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RenameColumnsStep", targetDepth))
                {
                    var unmarshaller = RenameColumnsOperationUnmarshaller.Instance;
                    unmarshalledObject.RenameColumnsStep = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UnpivotStep", targetDepth))
                {
                    var unmarshaller = UnpivotOperationUnmarshaller.Instance;
                    unmarshalledObject.UnpivotStep = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TransformStepUnmarshaller _instance = new TransformStepUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TransformStepUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}