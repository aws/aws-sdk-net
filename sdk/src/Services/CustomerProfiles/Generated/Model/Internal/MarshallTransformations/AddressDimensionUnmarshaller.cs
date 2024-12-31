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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CustomerProfiles.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CustomerProfiles.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AddressDimension Object
    /// </summary>  
    public class AddressDimensionUnmarshaller : IUnmarshaller<AddressDimension, XmlUnmarshallerContext>, IUnmarshaller<AddressDimension, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AddressDimension IUnmarshaller<AddressDimension, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AddressDimension Unmarshall(JsonUnmarshallerContext context)
        {
            AddressDimension unmarshalledObject = new AddressDimension();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("City", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.City = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Country", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.Country = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("County", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.County = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostalCode", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.PostalCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Province", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.Province = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = ProfileDimensionUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AddressDimensionUnmarshaller _instance = new AddressDimensionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AddressDimensionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}