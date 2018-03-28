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
    /// Response Unmarshaller for QualificationRequirement Object
    /// </summary>  
    public class QualificationRequirementUnmarshaller : IUnmarshaller<QualificationRequirement, XmlUnmarshallerContext>, IUnmarshaller<QualificationRequirement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        QualificationRequirement IUnmarshaller<QualificationRequirement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public QualificationRequirement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            QualificationRequirement unmarshalledObject = new QualificationRequirement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActionsGuarded", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionsGuarded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Comparator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Comparator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IntegerValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.IntegerValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocaleValues", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Locale, LocaleUnmarshaller>(LocaleUnmarshaller.Instance);
                    unmarshalledObject.LocaleValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QualificationTypeId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QualificationTypeId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RequiredToPreview", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.RequiredToPreview = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static QualificationRequirementUnmarshaller _instance = new QualificationRequirementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static QualificationRequirementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}