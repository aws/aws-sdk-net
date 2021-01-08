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

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EntityRecognizerInputDataConfig Object
    /// </summary>  
    public class EntityRecognizerInputDataConfigUnmarshaller : IUnmarshaller<EntityRecognizerInputDataConfig, XmlUnmarshallerContext>, IUnmarshaller<EntityRecognizerInputDataConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EntityRecognizerInputDataConfig IUnmarshaller<EntityRecognizerInputDataConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public EntityRecognizerInputDataConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            EntityRecognizerInputDataConfig unmarshalledObject = new EntityRecognizerInputDataConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Annotations", targetDepth))
                {
                    var unmarshaller = EntityRecognizerAnnotationsUnmarshaller.Instance;
                    unmarshalledObject.Annotations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AugmentedManifests", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AugmentedManifestsListItem, AugmentedManifestsListItemUnmarshaller>(AugmentedManifestsListItemUnmarshaller.Instance);
                    unmarshalledObject.AugmentedManifests = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataFormat", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DataFormat = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Documents", targetDepth))
                {
                    var unmarshaller = EntityRecognizerDocumentsUnmarshaller.Instance;
                    unmarshalledObject.Documents = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntityList", targetDepth))
                {
                    var unmarshaller = EntityRecognizerEntityListUnmarshaller.Instance;
                    unmarshalledObject.EntityList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntityTypes", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EntityTypesListItem, EntityTypesListItemUnmarshaller>(EntityTypesListItemUnmarshaller.Instance);
                    unmarshalledObject.EntityTypes = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static EntityRecognizerInputDataConfigUnmarshaller _instance = new EntityRecognizerInputDataConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EntityRecognizerInputDataConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}