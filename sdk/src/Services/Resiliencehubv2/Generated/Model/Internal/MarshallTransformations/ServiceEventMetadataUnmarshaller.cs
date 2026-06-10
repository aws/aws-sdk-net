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
    /// Response Unmarshaller for ServiceEventMetadata Object
    /// </summary>  
    public class ServiceEventMetadataUnmarshaller : IJsonUnmarshaller<ServiceEventMetadata, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceEventMetadata Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ServiceEventMetadata unmarshalledObject = new ServiceEventMetadata();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("assertionCreated", targetDepth, ref reader))
                {
                    var unmarshaller = AssertionCreatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.AssertionCreated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assertionDeleted", targetDepth, ref reader))
                {
                    var unmarshaller = AssertionDeletedMetadataUnmarshaller.Instance;
                    unmarshalledObject.AssertionDeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("assertionUpdated", targetDepth, ref reader))
                {
                    var unmarshaller = AssertionUpdatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.AssertionUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceAchievabilityUpdated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceAchievabilityUpdatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceAchievabilityUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceCreated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceCreatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceCreated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceDeleted", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceDeletedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceDeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceFunctionCreated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceFunctionCreatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceFunctionCreated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceFunctionDeleted", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceFunctionDeletedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceFunctionDeleted = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceFunctionResourcesAdded", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceFunctionResourcesAddedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceFunctionResourcesAdded = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceFunctionResourcesRemoved", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceFunctionResourcesRemovedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceFunctionResourcesRemoved = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceFunctionUpdated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceFunctionUpdatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceFunctionUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceInputSourcesUpdated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceInputSourcesUpdatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceInputSourcesUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("servicePolicyAssociated", targetDepth, ref reader))
                {
                    var unmarshaller = ServicePolicyAssociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServicePolicyAssociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("servicePolicyDisassociated", targetDepth, ref reader))
                {
                    var unmarshaller = ServicePolicyDisassociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServicePolicyDisassociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceResourcesAssociated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceResourcesAssociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceResourcesAssociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceResourcesDisassociated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceResourcesDisassociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceResourcesDisassociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceSystemAssociated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceSystemAssociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceSystemAssociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceSystemDisassociated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceSystemDisassociatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceSystemDisassociated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceWorkflowUpdated", targetDepth, ref reader))
                {
                    var unmarshaller = ServiceWorkflowUpdatedMetadataUnmarshaller.Instance;
                    unmarshalledObject.ServiceWorkflowUpdated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ServiceEventMetadataUnmarshaller _instance = new ServiceEventMetadataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceEventMetadataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}