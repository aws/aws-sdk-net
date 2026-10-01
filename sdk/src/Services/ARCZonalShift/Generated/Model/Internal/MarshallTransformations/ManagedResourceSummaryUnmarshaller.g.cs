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

using Amazon.ARCZonalShift.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.ARCZonalShift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManagedResourceSummary Object
    /// </summary>
    public partial class ManagedResourceSummaryUnmarshaller : IJsonUnmarshaller<ManagedResourceSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ManagedResourceSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ManagedResourceSummary();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("appliedWeights", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, float, StringUnmarshaller, FloatUnmarshaller>(StringUnmarshaller.Instance, FloatUnmarshaller.Instance);
                    unmarshalledObject.AppliedWeights = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("arn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("autoshifts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AutoshiftInResource, AutoshiftInResourceUnmarshaller>(AutoshiftInResourceUnmarshaller.Instance);
                    unmarshalledObject.Autoshifts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("availabilityZones", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("name", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("practiceRunStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PracticeRunStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("zonalAutoshiftStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ZonalAutoshiftStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("zonalShifts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ZonalShiftInResource, ZonalShiftInResourceUnmarshaller>(ZonalShiftInResourceUnmarshaller.Instance);
                    unmarshalledObject.ZonalShifts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ManagedResourceSummaryUnmarshaller _instance = new ManagedResourceSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ManagedResourceSummaryUnmarshaller Instance => _instance;
    }
}
