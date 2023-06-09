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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SourceApiAssociation Object
    /// </summary>  
    public class SourceApiAssociationUnmarshaller : IUnmarshaller<SourceApiAssociation, XmlUnmarshallerContext>, IUnmarshaller<SourceApiAssociation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        SourceApiAssociation IUnmarshaller<SourceApiAssociation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SourceApiAssociation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            SourceApiAssociation unmarshalledObject = new SourceApiAssociation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("associationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("associationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastSuccessfulMergeDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulMergeDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mergedApiArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MergedApiArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mergedApiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MergedApiId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceApiArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceApiArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceApiAssociationConfig", targetDepth))
                {
                    var unmarshaller = SourceApiAssociationConfigUnmarshaller.Instance;
                    unmarshalledObject.SourceApiAssociationConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceApiAssociationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceApiAssociationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceApiAssociationStatusDetail", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceApiAssociationStatusDetail = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceApiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceApiId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static SourceApiAssociationUnmarshaller _instance = new SourceApiAssociationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SourceApiAssociationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}