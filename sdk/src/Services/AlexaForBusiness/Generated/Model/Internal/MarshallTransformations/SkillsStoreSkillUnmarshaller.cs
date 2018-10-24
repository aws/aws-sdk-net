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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AlexaForBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AlexaForBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SkillsStoreSkill Object
    /// </summary>  
    public class SkillsStoreSkillUnmarshaller : IUnmarshaller<SkillsStoreSkill, XmlUnmarshallerContext>, IUnmarshaller<SkillsStoreSkill, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SkillsStoreSkill IUnmarshaller<SkillsStoreSkill, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SkillsStoreSkill Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SkillsStoreSkill unmarshalledObject = new SkillsStoreSkill();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("IconUrl", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IconUrl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SampleUtterances", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SampleUtterances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShortDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShortDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SkillDetails", targetDepth))
                {
                    var unmarshaller = SkillDetailsUnmarshaller.Instance;
                    unmarshalledObject.SkillDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SkillId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SkillId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SkillName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SkillName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportsLinking", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SupportsLinking = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SkillsStoreSkillUnmarshaller _instance = new SkillsStoreSkillUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SkillsStoreSkillUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}