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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AssetListingItem Object
    /// </summary>  
    public class AssetListingItemUnmarshaller : IUnmarshaller<AssetListingItem, XmlUnmarshallerContext>, IUnmarshaller<AssetListingItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AssetListingItem IUnmarshaller<AssetListingItem, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AssetListingItem Unmarshall(JsonUnmarshallerContext context)
        {
            AssetListingItem unmarshalledObject = new AssetListingItem();
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("additionalAttributes", targetDepth))
                {
                    var unmarshaller = AssetListingItemAdditionalAttributesUnmarshaller.Instance;
                    unmarshalledObject.AdditionalAttributes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entityId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entityRevision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityRevision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("entityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EntityType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("glossaryTerms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DetailedGlossaryTerm, DetailedGlossaryTermUnmarshaller>(DetailedGlossaryTermUnmarshaller.Instance);
                    unmarshalledObject.GlossaryTerms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listingCreatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListingCreatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listingRevision", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListingRevision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("listingUpdatedBy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ListingUpdatedBy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("owningProjectId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OwningProjectId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AssetListingItemUnmarshaller _instance = new AssetListingItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssetListingItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618