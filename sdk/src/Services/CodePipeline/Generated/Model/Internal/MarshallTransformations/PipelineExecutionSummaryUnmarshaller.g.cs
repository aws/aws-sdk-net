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

using Amazon.CodePipeline.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PipelineExecutionSummary Object
    /// </summary>
    public partial class PipelineExecutionSummaryUnmarshaller : ICborUnmarshaller<PipelineExecutionSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public PipelineExecutionSummary Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new PipelineExecutionSummary();
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
                    case "executionMode":
                        context.AddPathSegment("ExecutionMode");
                        unmarshalledObject.ExecutionMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "executionType":
                        context.AddPathSegment("ExecutionType");
                        unmarshalledObject.ExecutionType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastUpdateTime":
                        context.AddPathSegment("LastUpdateTime");
                        unmarshalledObject.LastUpdateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "pipelineExecutionId":
                        context.AddPathSegment("PipelineExecutionId");
                        unmarshalledObject.PipelineExecutionId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "rollbackMetadata":
                        context.AddPathSegment("RollbackMetadata");
                        unmarshalledObject.RollbackMetadata = PipelineRollbackMetadataUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "sourceRevisions":
                        context.AddPathSegment("SourceRevisions");
                        unmarshalledObject.SourceRevisions = new CborListUnmarshaller<SourceRevision, SourceRevisionUnmarshaller>(SourceRevisionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "startTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "statusSummary":
                        context.AddPathSegment("StatusSummary");
                        unmarshalledObject.StatusSummary = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "stopTrigger":
                        context.AddPathSegment("StopTrigger");
                        unmarshalledObject.StopTrigger = StopExecutionTriggerUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "trigger":
                        context.AddPathSegment("Trigger");
                        unmarshalledObject.Trigger = ExecutionTriggerUnmarshaller.Instance.Unmarshall(context);
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

        private static PipelineExecutionSummaryUnmarshaller _instance = new PipelineExecutionSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PipelineExecutionSummaryUnmarshaller Instance => _instance;
    }
}
