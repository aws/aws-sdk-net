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

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleGroupResponse Object
    /// </summary>
    public partial class RuleGroupResponseUnmarshaller : ICborUnmarshaller<RuleGroupResponse, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RuleGroupResponse Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RuleGroupResponse();
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
                    case "AnalysisResults":
                        context.AddPathSegment("AnalysisResults");
                        unmarshalledObject.AnalysisResults = new CborListUnmarshaller<AnalysisResult, AnalysisResultUnmarshaller>(AnalysisResultUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Capacity":
                        context.AddPathSegment("Capacity");
                        unmarshalledObject.Capacity = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ConsumedCapacity":
                        context.AddPathSegment("ConsumedCapacity");
                        unmarshalledObject.ConsumedCapacity = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EncryptionConfiguration":
                        context.AddPathSegment("EncryptionConfiguration");
                        unmarshalledObject.EncryptionConfiguration = EncryptionConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LastModifiedTime":
                        context.AddPathSegment("LastModifiedTime");
                        unmarshalledObject.LastModifiedTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "NumberOfAssociations":
                        context.AddPathSegment("NumberOfAssociations");
                        unmarshalledObject.NumberOfAssociations = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RuleGroupArn":
                        context.AddPathSegment("RuleGroupArn");
                        unmarshalledObject.RuleGroupArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RuleGroupId":
                        context.AddPathSegment("RuleGroupId");
                        unmarshalledObject.RuleGroupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RuleGroupName":
                        context.AddPathSegment("RuleGroupName");
                        unmarshalledObject.RuleGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RuleGroupStatus":
                        context.AddPathSegment("RuleGroupStatus");
                        unmarshalledObject.RuleGroupStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SnsTopic":
                        context.AddPathSegment("SnsTopic");
                        unmarshalledObject.SnsTopic = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceMetadata":
                        context.AddPathSegment("SourceMetadata");
                        unmarshalledObject.SourceMetadata = SourceMetadataUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SummaryConfiguration":
                        context.AddPathSegment("SummaryConfiguration");
                        unmarshalledObject.SummaryConfiguration = SummaryConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Tags":
                        context.AddPathSegment("Tags");
                        unmarshalledObject.Tags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Type":
                        context.AddPathSegment("Type");
                        unmarshalledObject.Type = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static RuleGroupResponseUnmarshaller _instance = new RuleGroupResponseUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RuleGroupResponseUnmarshaller Instance => _instance;
    }
}
