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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EntryViolation Object
    /// </summary>  
    public class EntryViolationUnmarshaller : IUnmarshaller<EntryViolation, XmlUnmarshallerContext>, IUnmarshaller<EntryViolation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EntryViolation IUnmarshaller<EntryViolation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EntryViolation Unmarshall(JsonUnmarshallerContext context)
        {
            EntryViolation unmarshalledObject = new EntryViolation();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActualEvaluationOrder", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActualEvaluationOrder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntriesWithConflicts", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EntryDescription, EntryDescriptionUnmarshaller>(EntryDescriptionUnmarshaller.Instance);
                    unmarshalledObject.EntriesWithConflicts = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntryAtExpectedEvaluationOrder", targetDepth))
                {
                    var unmarshaller = EntryDescriptionUnmarshaller.Instance;
                    unmarshalledObject.EntryAtExpectedEvaluationOrder = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntryViolationReasons", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EntryViolationReasons = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedEntry", targetDepth))
                {
                    var unmarshaller = EntryDescriptionUnmarshaller.Instance;
                    unmarshalledObject.ExpectedEntry = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedEvaluationOrder", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpectedEvaluationOrder = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EntryViolationUnmarshaller _instance = new EntryViolationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EntryViolationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}