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
    /// Response Unmarshaller for ListingAttributeResults Object
    /// </summary>
    public partial class ListingAttributeResultsUnmarshaller : IJsonUnmarshaller<ListingAttributeResults, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ListingAttributeResults Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ListingAttributeResults();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("caseStudy", targetDepth, ref reader))
                {
                    var unmarshaller = CaseStudyUnmarshaller.Instance;
                    unmarshalledObject.CaseStudy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("specializationDetail", targetDepth, ref reader))
                {
                    var unmarshaller = SpecializationDetailUnmarshaller.Instance;
                    unmarshalledObject.SpecializationDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trustCenterCertification", targetDepth, ref reader))
                {
                    var unmarshaller = TrustCenterCertificationAttributeUnmarshaller.Instance;
                    unmarshalledObject.TrustCenterCertification = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trustCenterControl", targetDepth, ref reader))
                {
                    var unmarshaller = TrustCenterControlUnmarshaller.Instance;
                    unmarshalledObject.TrustCenterControl = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trustCenterDocument", targetDepth, ref reader))
                {
                    var unmarshaller = TrustCenterDocumentAttributeUnmarshaller.Instance;
                    unmarshalledObject.TrustCenterDocument = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trustCenterFaq", targetDepth, ref reader))
                {
                    var unmarshaller = TrustCenterFaqAttributeUnmarshaller.Instance;
                    unmarshalledObject.TrustCenterFaq = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trustCenterSource", targetDepth, ref reader))
                {
                    var unmarshaller = TrustCenterSourceUnmarshaller.Instance;
                    unmarshalledObject.TrustCenterSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("trustCenterUpdate", targetDepth, ref reader))
                {
                    var unmarshaller = TrustCenterUpdateAttributeUnmarshaller.Instance;
                    unmarshalledObject.TrustCenterUpdate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ListingAttributeResultsUnmarshaller _instance = new ListingAttributeResultsUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListingAttributeResultsUnmarshaller Instance => _instance;
    }
}
