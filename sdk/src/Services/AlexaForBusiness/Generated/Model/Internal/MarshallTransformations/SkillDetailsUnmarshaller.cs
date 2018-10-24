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
    /// Response Unmarshaller for SkillDetails Object
    /// </summary>  
    public class SkillDetailsUnmarshaller : IUnmarshaller<SkillDetails, XmlUnmarshallerContext>, IUnmarshaller<SkillDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SkillDetails IUnmarshaller<SkillDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SkillDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SkillDetails unmarshalledObject = new SkillDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BulletPoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.BulletPoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeveloperInfo", targetDepth))
                {
                    var unmarshaller = DeveloperInfoUnmarshaller.Instance;
                    unmarshalledObject.DeveloperInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndUserLicenseAgreement", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EndUserLicenseAgreement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GenericKeywords", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.GenericKeywords = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InvocationPhrase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvocationPhrase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NewInThisVersionBulletPoints", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NewInThisVersionBulletPoints = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ProductDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProductDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ReleaseDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReleaseDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Reviews", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Reviews = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SkillTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SkillTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SkillDetailsUnmarshaller _instance = new SkillDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SkillDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}