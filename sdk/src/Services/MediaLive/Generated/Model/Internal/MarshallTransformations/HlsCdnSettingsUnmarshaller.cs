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

namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HlsCdnSettings Object
    /// </summary>  
    public class HlsCdnSettingsUnmarshaller : IUnmarshaller<HlsCdnSettings, XmlUnmarshallerContext>, IUnmarshaller<HlsCdnSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HlsCdnSettings IUnmarshaller<HlsCdnSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HlsCdnSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HlsCdnSettings unmarshalledObject = new HlsCdnSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("hlsAkamaiSettings", targetDepth))
                {
                    var unmarshaller = HlsAkamaiSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsAkamaiSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hlsBasicPutSettings", targetDepth))
                {
                    var unmarshaller = HlsBasicPutSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsBasicPutSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hlsMediaStoreSettings", targetDepth))
                {
                    var unmarshaller = HlsMediaStoreSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsMediaStoreSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hlsWebdavSettings", targetDepth))
                {
                    var unmarshaller = HlsWebdavSettingsUnmarshaller.Instance;
                    unmarshalledObject.HlsWebdavSettings = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HlsCdnSettingsUnmarshaller _instance = new HlsCdnSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HlsCdnSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}