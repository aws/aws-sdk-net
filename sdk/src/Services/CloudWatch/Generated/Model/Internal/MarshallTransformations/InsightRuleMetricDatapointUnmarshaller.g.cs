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

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InsightRuleMetricDatapoint Object
    /// </summary>
    public partial class InsightRuleMetricDatapointUnmarshaller : ICborUnmarshaller<InsightRuleMetricDatapoint, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public InsightRuleMetricDatapoint Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new InsightRuleMetricDatapoint();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "Average":
                        context.AddPathSegment("Average");
                        unmarshalledObject.Average = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MaxContributorValue":
                        context.AddPathSegment("MaxContributorValue");
                        unmarshalledObject.MaxContributorValue = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Maximum":
                        context.AddPathSegment("Maximum");
                        unmarshalledObject.Maximum = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Minimum":
                        context.AddPathSegment("Minimum");
                        unmarshalledObject.Minimum = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SampleCount":
                        context.AddPathSegment("SampleCount");
                        unmarshalledObject.SampleCount = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Sum":
                        context.AddPathSegment("Sum");
                        unmarshalledObject.Sum = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Timestamp":
                        context.AddPathSegment("Timestamp");
                        unmarshalledObject.Timestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "UniqueContributors":
                        context.AddPathSegment("UniqueContributors");
                        unmarshalledObject.UniqueContributors = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static InsightRuleMetricDatapointUnmarshaller _instance = new InsightRuleMetricDatapointUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InsightRuleMetricDatapointUnmarshaller Instance => _instance;
    }
}
