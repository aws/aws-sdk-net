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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Smpte2110ReceiverGroupSettings Object
    /// </summary>  
    public class Smpte2110ReceiverGroupSettingsUnmarshaller : IUnmarshaller<Smpte2110ReceiverGroupSettings, XmlUnmarshallerContext>, IUnmarshaller<Smpte2110ReceiverGroupSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Smpte2110ReceiverGroupSettings IUnmarshaller<Smpte2110ReceiverGroupSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Smpte2110ReceiverGroupSettings Unmarshall(JsonUnmarshallerContext context)
        {
            Smpte2110ReceiverGroupSettings unmarshalledObject = new Smpte2110ReceiverGroupSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("smpte2110ReceiverGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Smpte2110ReceiverGroup, Smpte2110ReceiverGroupUnmarshaller>(Smpte2110ReceiverGroupUnmarshaller.Instance);
                    unmarshalledObject.Smpte2110ReceiverGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static Smpte2110ReceiverGroupSettingsUnmarshaller _instance = new Smpte2110ReceiverGroupSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static Smpte2110ReceiverGroupSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}