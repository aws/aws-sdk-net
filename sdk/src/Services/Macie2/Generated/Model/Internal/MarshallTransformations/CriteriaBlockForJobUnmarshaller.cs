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
    /// Response Unmarshaller for CriteriaBlockForJob Object
    /// </summary>  
    public class CriteriaBlockForJobUnmarshaller : IJsonUnmarshaller<CriteriaBlockForJob, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CriteriaBlockForJob Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CriteriaBlockForJob unmarshalledObject = new CriteriaBlockForJob();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("and", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CriteriaForJob, CriteriaForJobUnmarshaller>(CriteriaForJobUnmarshaller.Instance);
                    unmarshalledObject.And = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CriteriaBlockForJobUnmarshaller _instance = new CriteriaBlockForJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CriteriaBlockForJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}