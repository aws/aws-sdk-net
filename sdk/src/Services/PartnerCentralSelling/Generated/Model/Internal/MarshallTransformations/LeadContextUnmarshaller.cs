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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LeadContext Object
    /// </summary>  
    public class LeadContextUnmarshaller : IUnmarshaller<LeadContext, XmlUnmarshallerContext>, IUnmarshaller<LeadContext, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        LeadContext IUnmarshaller<LeadContext, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LeadContext Unmarshall(JsonUnmarshallerContext context)
        {
            LeadContext unmarshalledObject = new LeadContext();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Customer", targetDepth))
                {
                    var unmarshaller = LeadCustomerUnmarshaller.Instance;
                    unmarshalledObject.Customer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Interactions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<LeadInteraction, LeadInteractionUnmarshaller>(LeadInteractionUnmarshaller.Instance);
                    unmarshalledObject.Interactions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("QualificationStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.QualificationStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static LeadContextUnmarshaller _instance = new LeadContextUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LeadContextUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}