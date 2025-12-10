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
    /// Response Unmarshaller for Project Object
    /// </summary>  
    public class ProjectUnmarshaller : IUnmarshaller<Project, XmlUnmarshallerContext>, IUnmarshaller<Project, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Project IUnmarshaller<Project, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Project Unmarshall(JsonUnmarshallerContext context)
        {
            Project unmarshalledObject = new Project();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AdditionalComments", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AdditionalComments = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ApnPrograms", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ApnPrograms = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsPartition", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AwsPartition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CompetitorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CompetitorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerBusinessProblem", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomerBusinessProblem = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomerUseCase", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CustomerUseCase = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeliveryModels", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.DeliveryModels = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExpectedCustomerSpend", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExpectedCustomerSpend, ExpectedCustomerSpendUnmarshaller>(ExpectedCustomerSpendUnmarshaller.Instance);
                    unmarshalledObject.ExpectedCustomerSpend = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OtherCompetitorNames", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OtherCompetitorNames = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OtherSolutionDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OtherSolutionDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RelatedOpportunityIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedOpportunityIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SalesActivities", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SalesActivities = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Title", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ProjectUnmarshaller _instance = new ProjectUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ProjectUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}