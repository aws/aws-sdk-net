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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.B2bi.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.B2bi.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for X12OutboundEdiHeaders Object
    /// </summary>  
    public class X12OutboundEdiHeadersUnmarshaller : IUnmarshaller<X12OutboundEdiHeaders, XmlUnmarshallerContext>, IUnmarshaller<X12OutboundEdiHeaders, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        X12OutboundEdiHeaders IUnmarshaller<X12OutboundEdiHeaders, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public X12OutboundEdiHeaders Unmarshall(JsonUnmarshallerContext context)
        {
            X12OutboundEdiHeaders unmarshalledObject = new X12OutboundEdiHeaders();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("delimiters", targetDepth))
                {
                    var unmarshaller = X12DelimitersUnmarshaller.Instance;
                    unmarshalledObject.Delimiters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("functionalGroupHeaders", targetDepth))
                {
                    var unmarshaller = X12FunctionalGroupHeadersUnmarshaller.Instance;
                    unmarshalledObject.FunctionalGroupHeaders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("interchangeControlHeaders", targetDepth))
                {
                    var unmarshaller = X12InterchangeControlHeadersUnmarshaller.Instance;
                    unmarshalledObject.InterchangeControlHeaders = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("validateEdi", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ValidateEdi = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static X12OutboundEdiHeadersUnmarshaller _instance = new X12OutboundEdiHeadersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static X12OutboundEdiHeadersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}