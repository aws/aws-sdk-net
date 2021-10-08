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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PostFulfillmentStatusSpecification Object
    /// </summary>  
    public class PostFulfillmentStatusSpecificationUnmarshaller : IUnmarshaller<PostFulfillmentStatusSpecification, XmlUnmarshallerContext>, IUnmarshaller<PostFulfillmentStatusSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PostFulfillmentStatusSpecification IUnmarshaller<PostFulfillmentStatusSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PostFulfillmentStatusSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PostFulfillmentStatusSpecification unmarshalledObject = new PostFulfillmentStatusSpecification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("failureResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.FailureResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("successResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.SuccessResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutResponse", targetDepth))
                {
                    var unmarshaller = ResponseSpecificationUnmarshaller.Instance;
                    unmarshalledObject.TimeoutResponse = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PostFulfillmentStatusSpecificationUnmarshaller _instance = new PostFulfillmentStatusSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PostFulfillmentStatusSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}