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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SsmDocument Object
    /// </summary>  
    public class SsmDocumentUnmarshaller : IUnmarshaller<SsmDocument, XmlUnmarshallerContext>, IUnmarshaller<SsmDocument, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SsmDocument IUnmarshaller<SsmDocument, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SsmDocument Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SsmDocument unmarshalledObject = new SsmDocument();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("externalParameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, SsmExternalParameter, StringUnmarshaller, SsmExternalParameterUnmarshaller>(StringUnmarshaller.Instance, SsmExternalParameterUnmarshaller.Instance);
                    unmarshalledObject.ExternalParameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mustSucceedForCutover", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.MustSucceedForCutover = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<SsmParameterStoreParameter>, StringUnmarshaller, ListUnmarshaller<SsmParameterStoreParameter, SsmParameterStoreParameterUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<SsmParameterStoreParameter, SsmParameterStoreParameterUnmarshaller>(SsmParameterStoreParameterUnmarshaller.Instance));
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ssmDocumentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SsmDocumentName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimeoutSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SsmDocumentUnmarshaller _instance = new SsmDocumentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SsmDocumentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}