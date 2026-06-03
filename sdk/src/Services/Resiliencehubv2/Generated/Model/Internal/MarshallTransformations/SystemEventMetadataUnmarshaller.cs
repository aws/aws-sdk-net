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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Resiliencehubv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Resiliencehubv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SystemEventMetadata Object
    /// </summary>  
    public class SystemEventMetadataUnmarshaller : IJsonUnmarshaller<SystemEventMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SystemEventMetadata Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SystemEventMetadata unmarshalledObject = new SystemEventMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("systemCreated", targetDepth))
                {
                    var unmarshaller = SystemCreatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemCreated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemDeleted", targetDepth))
                {
                    var unmarshaller = SystemDeletedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemDeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemPolicyAssociated", targetDepth))
                {
                    var unmarshaller = SystemPolicyAssociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemPolicyAssociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemPolicyDisassociated", targetDepth))
                {
                    var unmarshaller = SystemPolicyDisassociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemPolicyDisassociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemServiceAssociated", targetDepth))
                {
                    var unmarshaller = SystemServiceAssociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemServiceAssociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemServiceDisassociated", targetDepth))
                {
                    var unmarshaller = SystemServiceDisassociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemServiceDisassociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemUserJourneyCreated", targetDepth))
                {
                    var unmarshaller = SystemUserJourneyCreatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemUserJourneyCreated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemUserJourneyDeleted", targetDepth))
                {
                    var unmarshaller = SystemUserJourneyDeletedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemUserJourneyDeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("systemUserJourneyUpdated", targetDepth))
                {
                    var unmarshaller = SystemUserJourneyUpdatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.SystemUserJourneyUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SystemEventMetadataUnmarshaller _instance = new SystemEventMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SystemEventMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}