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
    /// Response Unmarshaller for ActionExecution Object
    /// </summary>
    public partial class ActionExecutionUnmarshaller : ICborUnmarshaller<ActionExecution, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ActionExecution Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new ActionExecution();
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
                    case "actionExecutionId":
                        context.AddPathSegment("ActionExecutionId");
                        unmarshalledObject.ActionExecutionId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "errorDetails":
                        context.AddPathSegment("ErrorDetails");
                        unmarshalledObject.ErrorDetails = ErrorDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "externalExecutionId":
                        context.AddPathSegment("ExternalExecutionId");
                        unmarshalledObject.ExternalExecutionId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "externalExecutionUrl":
                        context.AddPathSegment("ExternalExecutionUrl");
                        unmarshalledObject.ExternalExecutionUrl = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastStatusChange":
                        context.AddPathSegment("LastStatusChange");
                        unmarshalledObject.LastStatusChange = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastUpdatedBy":
                        context.AddPathSegment("LastUpdatedBy");
                        unmarshalledObject.LastUpdatedBy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "logStreamARN":
                        context.AddPathSegment("LogStreamARN");
                        unmarshalledObject.LogStreamARN = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "percentComplete":
                        context.AddPathSegment("PercentComplete");
                        unmarshalledObject.PercentComplete = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "summary":
                        context.AddPathSegment("Summary");
                        unmarshalledObject.Summary = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "token":
                        context.AddPathSegment("Token");
                        unmarshalledObject.Token = CborStringUnmarshaller.Instance.Unmarshall(context);
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

        private static ActionExecutionUnmarshaller _instance = new ActionExecutionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ActionExecutionUnmarshaller Instance => _instance;
    }
}
