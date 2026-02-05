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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OffsetConfiguration Object
    /// </summary>  
    public class OffsetConfigurationUnmarshaller : IUnmarshaller<OffsetConfiguration, XmlUnmarshallerContext>, IUnmarshaller<OffsetConfiguration, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OffsetConfiguration IUnmarshaller<OffsetConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OffsetConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            OffsetConfiguration unmarshalledObject = new OffsetConfiguration();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("LimitParameter", targetDepth))
                {
                    var unmarshaller = ExtractedParameterUnmarshaller.Instance;
                    unmarshalledObject.LimitParameter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OffsetParameter", targetDepth))
                {
                    var unmarshaller = ExtractedParameterUnmarshaller.Instance;
                    unmarshalledObject.OffsetParameter = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OffsetConfigurationUnmarshaller _instance = new OffsetConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OffsetConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}