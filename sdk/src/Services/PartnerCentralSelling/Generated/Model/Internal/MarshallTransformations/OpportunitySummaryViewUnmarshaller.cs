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
    /// Response Unmarshaller for OpportunitySummaryView Object
    /// </summary>  
    public class OpportunitySummaryViewUnmarshaller : IUnmarshaller<OpportunitySummaryView, XmlUnmarshallerContext>, IUnmarshaller<OpportunitySummaryView, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OpportunitySummaryView IUnmarshaller<OpportunitySummaryView, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OpportunitySummaryView Unmarshall(JsonUnmarshallerContext context)
        {
            OpportunitySummaryView unmarshalledObject = new OpportunitySummaryView();
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
                    var unmarshaller = CustomerUnmarshaller.Instance;
                    unmarshalledObject.Customer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Lifecycle", targetDepth))
                {
                    var unmarshaller = LifeCycleForViewUnmarshaller.Instance;
                    unmarshalledObject.Lifecycle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpportunityTeam", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Contact, ContactUnmarshaller>(ContactUnmarshaller.Instance);
                    unmarshalledObject.OpportunityTeam = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OpportunityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OpportunityType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrimaryNeedsFromAws", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PrimaryNeedsFromAws = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Project", targetDepth))
                {
                    var unmarshaller = ProjectViewUnmarshaller.Instance;
                    unmarshalledObject.Project = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedEntityIdentifiers", targetDepth))
                {
                    var unmarshaller = RelatedEntityIdentifiersUnmarshaller.Instance;
                    unmarshalledObject.RelatedEntityIdentifiers = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OpportunitySummaryViewUnmarshaller _instance = new OpportunitySummaryViewUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpportunitySummaryViewUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}