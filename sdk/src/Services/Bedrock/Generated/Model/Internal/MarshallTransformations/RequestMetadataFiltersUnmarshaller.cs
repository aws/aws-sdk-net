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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RequestMetadataFilters Object
    /// </summary>  
    public class RequestMetadataFiltersUnmarshaller : IUnmarshaller<RequestMetadataFilters, XmlUnmarshallerContext>, IUnmarshaller<RequestMetadataFilters, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RequestMetadataFilters IUnmarshaller<RequestMetadataFilters, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RequestMetadataFilters Unmarshall(JsonUnmarshallerContext context)
        {
            RequestMetadataFilters unmarshalledObject = new RequestMetadataFilters();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("andAll", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RequestMetadataBaseFilters, RequestMetadataBaseFiltersUnmarshaller>(RequestMetadataBaseFiltersUnmarshaller.Instance);
                    unmarshalledObject.AndAll = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("equals", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Equals = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("notEquals", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.NotEquals = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("orAll", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RequestMetadataBaseFilters, RequestMetadataBaseFiltersUnmarshaller>(RequestMetadataBaseFiltersUnmarshaller.Instance);
                    unmarshalledObject.OrAll = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RequestMetadataFiltersUnmarshaller _instance = new RequestMetadataFiltersUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestMetadataFiltersUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}