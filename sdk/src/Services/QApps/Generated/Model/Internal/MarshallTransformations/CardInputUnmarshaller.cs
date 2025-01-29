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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QApps.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.QApps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CardInput Object
    /// </summary>  
    public class CardInputUnmarshaller : IJsonUnmarshaller<CardInput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CardInput Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CardInput unmarshalledObject = new CardInput();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("fileUpload", targetDepth))
                {
                    var unmarshaller = FileUploadCardInputUnmarshaller.Instance;
                    unmarshalledObject.FileUpload = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("formInput", targetDepth))
                {
                    var unmarshaller = FormInputCardInputUnmarshaller.Instance;
                    unmarshalledObject.FormInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("qPlugin", targetDepth))
                {
                    var unmarshaller = QPluginCardInputUnmarshaller.Instance;
                    unmarshalledObject.QPlugin = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("qQuery", targetDepth))
                {
                    var unmarshaller = QQueryCardInputUnmarshaller.Instance;
                    unmarshalledObject.QQuery = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("textInput", targetDepth))
                {
                    var unmarshaller = TextInputCardInputUnmarshaller.Instance;
                    unmarshalledObject.TextInput = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CardInputUnmarshaller _instance = new CardInputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CardInputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}