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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MTurk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Qualification Object
    /// </summary>  
    public class QualificationUnmarshaller : IUnmarshaller<Qualification, XmlUnmarshallerContext>, IUnmarshaller<Qualification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Qualification IUnmarshaller<Qualification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Qualification Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Qualification unmarshalledObject = new Qualification();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("GrantTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.GrantTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IntegerValue", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.IntegerValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocaleValue", targetDepth))
                {
                    var unmarshaller = LocaleUnmarshaller.Instance;
                    unmarshalledObject.LocaleValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QualificationTypeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QualificationTypeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkerId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static QualificationUnmarshaller _instance = new QualificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QualificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}