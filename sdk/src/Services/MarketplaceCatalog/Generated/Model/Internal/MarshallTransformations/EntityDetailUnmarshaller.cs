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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EntityDetail Object
    /// </summary>  
    public class EntityDetailUnmarshaller : IJsonUnmarshaller<EntityDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EntityDetail Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EntityDetail unmarshalledObject = new EntityDetail();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DetailsDocument", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.DetailsDocument = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EntityArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EntityIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityIdentifier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EntityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EntityDetailUnmarshaller _instance = new EntityDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EntityDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}