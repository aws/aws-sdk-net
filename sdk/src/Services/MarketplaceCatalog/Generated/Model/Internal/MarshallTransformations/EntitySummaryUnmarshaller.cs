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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EntitySummary Object
    /// </summary>  
    public class EntitySummaryUnmarshaller : IUnmarshaller<EntitySummary, XmlUnmarshallerContext>, IUnmarshaller<EntitySummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        EntitySummary IUnmarshaller<EntitySummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public EntitySummary Unmarshall(JsonUnmarshallerContext context)
        {
            EntitySummary unmarshalledObject = new EntitySummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AmiProductSummary", targetDepth))
                {
                    var unmarshaller = AmiProductSummaryUnmarshaller.Instance;
                    unmarshalledObject.AmiProductSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ContainerProductSummary", targetDepth))
                {
                    var unmarshaller = ContainerProductSummaryUnmarshaller.Instance;
                    unmarshalledObject.ContainerProductSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataProductSummary", targetDepth))
                {
                    var unmarshaller = DataProductSummaryUnmarshaller.Instance;
                    unmarshalledObject.DataProductSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntityArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntityId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EntityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MachineLearningProductSummary", targetDepth))
                {
                    var unmarshaller = MachineLearningProductSummaryUnmarshaller.Instance;
                    unmarshalledObject.MachineLearningProductSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OfferSetSummary", targetDepth))
                {
                    var unmarshaller = OfferSetSummaryUnmarshaller.Instance;
                    unmarshalledObject.OfferSetSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OfferSummary", targetDepth))
                {
                    var unmarshaller = OfferSummaryUnmarshaller.Instance;
                    unmarshalledObject.OfferSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResaleAuthorizationSummary", targetDepth))
                {
                    var unmarshaller = ResaleAuthorizationSummaryUnmarshaller.Instance;
                    unmarshalledObject.ResaleAuthorizationSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SaaSProductSummary", targetDepth))
                {
                    var unmarshaller = SaaSProductSummaryUnmarshaller.Instance;
                    unmarshalledObject.SaaSProductSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Visibility", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Visibility = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EntitySummaryUnmarshaller _instance = new EntitySummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EntitySummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}