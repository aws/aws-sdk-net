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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.TaxSettings.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.TaxSettings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaxExemption Object
    /// </summary>  
    public class TaxExemptionUnmarshaller : IUnmarshaller<TaxExemption, XmlUnmarshallerContext>, IUnmarshaller<TaxExemption, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        TaxExemption IUnmarshaller<TaxExemption, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public TaxExemption Unmarshall(JsonUnmarshallerContext context)
        {
            TaxExemption unmarshalledObject = new TaxExemption();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("authority", targetDepth))
                {
                    var unmarshaller = AuthorityUnmarshaller.Instance;
                    unmarshalledObject.Authority = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("effectiveDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EffectiveDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("expirationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExpirationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("systemEffectiveDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.SystemEffectiveDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taxExemptionType", targetDepth))
                {
                    var unmarshaller = TaxExemptionTypeUnmarshaller.Instance;
                    unmarshalledObject.TaxExemptionType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TaxExemptionUnmarshaller _instance = new TaxExemptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TaxExemptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}