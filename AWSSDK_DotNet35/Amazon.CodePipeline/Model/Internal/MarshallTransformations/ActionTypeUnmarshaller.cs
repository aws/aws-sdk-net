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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ActionType Object
    /// </summary>  
    public class ActionTypeUnmarshaller : IUnmarshaller<ActionType, XmlUnmarshallerContext>, IUnmarshaller<ActionType, JsonUnmarshallerContext>
    {
        ActionType IUnmarshaller<ActionType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public ActionType Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ActionType unmarshalledObject = new ActionType();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionConfigurationProperties", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ActionConfigurationProperty, ActionConfigurationPropertyUnmarshaller>(ActionConfigurationPropertyUnmarshaller.Instance);
                    unmarshalledObject.ActionConfigurationProperties = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = ActionTypeIdUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inputArtifactDetails", targetDepth))
                {
                    var unmarshaller = ArtifactDetailsUnmarshaller.Instance;
                    unmarshalledObject.InputArtifactDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("outputArtifactDetails", targetDepth))
                {
                    var unmarshaller = ArtifactDetailsUnmarshaller.Instance;
                    unmarshalledObject.OutputArtifactDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("settings", targetDepth))
                {
                    var unmarshaller = ActionTypeSettingsUnmarshaller.Instance;
                    unmarshalledObject.Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ActionTypeUnmarshaller _instance = new ActionTypeUnmarshaller();        

        public static ActionTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}