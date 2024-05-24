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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ToxicLabels Object
    /// </summary>  
    public class ToxicLabelsUnmarshaller : IUnmarshaller<ToxicLabels, XmlUnmarshallerContext>, IUnmarshaller<ToxicLabels, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ToxicLabels IUnmarshaller<ToxicLabels, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ToxicLabels Unmarshall(JsonUnmarshallerContext context)
        {
            ToxicLabels unmarshalledObject = new ToxicLabels();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Labels", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ToxicContent, ToxicContentUnmarshaller>(ToxicContentUnmarshaller.Instance);
                    unmarshalledObject.Labels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Toxicity", targetDepth))
                {
                    var unmarshaller = FloatUnmarshaller.Instance;
                    unmarshalledObject.Toxicity = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ToxicLabelsUnmarshaller _instance = new ToxicLabelsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ToxicLabelsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}