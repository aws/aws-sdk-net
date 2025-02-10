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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.XRay.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.XRay.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TraceSummary Object
    /// </summary>  
    public class TraceSummaryUnmarshaller : IJsonUnmarshaller<TraceSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TraceSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TraceSummary unmarshalledObject = new TraceSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Annotations", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<ValueWithServiceIds>, StringUnmarshaller, JsonListUnmarshaller<ValueWithServiceIds,ValueWithServiceIdsUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<ValueWithServiceIds, ValueWithServiceIdsUnmarshaller>(ValueWithServiceIdsUnmarshaller.Instance));
                    unmarshalledObject.Annotations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AvailabilityZones", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AvailabilityZoneDetail, AvailabilityZoneDetailUnmarshaller>(AvailabilityZoneDetailUnmarshaller.Instance);
                    unmarshalledObject.AvailabilityZones = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Duration", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EntryPoint", targetDepth))
                {
                    var unmarshaller = ServiceIdUnmarshaller.Instance;
                    unmarshalledObject.EntryPoint = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ErrorRootCauses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ErrorRootCause, ErrorRootCauseUnmarshaller>(ErrorRootCauseUnmarshaller.Instance);
                    unmarshalledObject.ErrorRootCauses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FaultRootCauses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<FaultRootCause, FaultRootCauseUnmarshaller>(FaultRootCauseUnmarshaller.Instance);
                    unmarshalledObject.FaultRootCauses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HasError", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.HasError = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HasFault", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.HasFault = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("HasThrottle", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.HasThrottle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Http", targetDepth))
                {
                    var unmarshaller = HttpUnmarshaller.Instance;
                    unmarshalledObject.Http = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InstanceIds", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InstanceIdDetail, InstanceIdDetailUnmarshaller>(InstanceIdDetailUnmarshaller.Instance);
                    unmarshalledObject.InstanceIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IsPartial", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsPartial = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MatchedEventTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.MatchedEventTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResourceARNs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceARNDetail, ResourceARNDetailUnmarshaller>(ResourceARNDetailUnmarshaller.Instance);
                    unmarshalledObject.ResourceARNs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResponseTime", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.ResponseTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ResponseTimeRootCauses", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResponseTimeRootCause, ResponseTimeRootCauseUnmarshaller>(ResponseTimeRootCauseUnmarshaller.Instance);
                    unmarshalledObject.ResponseTimeRootCauses = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Revision", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Revision = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ServiceIds", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ServiceId, ServiceIdUnmarshaller>(ServiceIdUnmarshaller.Instance);
                    unmarshalledObject.ServiceIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Users", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<TraceUser, TraceUserUnmarshaller>(TraceUserUnmarshaller.Instance);
                    unmarshalledObject.Users = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TraceSummaryUnmarshaller _instance = new TraceSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TraceSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}