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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.MarketplaceDiscovery.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.MarketplaceDiscovery.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CaseStudy Object
    /// </summary>
    public partial class CaseStudyUnmarshaller : IJsonUnmarshaller<CaseStudy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CaseStudy Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new CaseStudy();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("caseStudyId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaseStudyId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("caseStudyName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CaseStudyName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("challenge", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Challenge = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("engagementDates", targetDepth, ref reader))
                {
                    var unmarshaller = EngagementDatesUnmarshaller.Instance;
                    unmarshalledObject.EngagementDates = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("implementationApproach", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImplementationApproach = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("outcome", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Outcome = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("resolution", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Resolution = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("resources", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<CaseStudyResource, CaseStudyResourceUnmarshaller>(CaseStudyResourceUnmarshaller.Instance);
                    unmarshalledObject.Resources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("shortDescription", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ShortDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static CaseStudyUnmarshaller _instance = new CaseStudyUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CaseStudyUnmarshaller Instance => _instance;
    }
}
