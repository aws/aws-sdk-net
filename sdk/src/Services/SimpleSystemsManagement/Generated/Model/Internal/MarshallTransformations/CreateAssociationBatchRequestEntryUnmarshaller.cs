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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateAssociationBatchRequestEntry Object
    /// </summary>  
    public class CreateAssociationBatchRequestEntryUnmarshaller : IUnmarshaller<CreateAssociationBatchRequestEntry, XmlUnmarshallerContext>, IUnmarshaller<CreateAssociationBatchRequestEntry, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CreateAssociationBatchRequestEntry IUnmarshaller<CreateAssociationBatchRequestEntry, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CreateAssociationBatchRequestEntry Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CreateAssociationBatchRequestEntry unmarshalledObject = new CreateAssociationBatchRequestEntry();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplyOnlyAtCronInterval", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ApplyOnlyAtCronInterval = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AssociationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AssociationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutomationTargetParameterName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AutomationTargetParameterName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComplianceSeverity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComplianceSeverity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DocumentVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DocumentVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxConcurrency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxConcurrency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxErrors", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxErrors = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OutputLocation", targetDepth))
                {
                    var unmarshaller = InstanceAssociationOutputLocationUnmarshaller.Instance;
                    unmarshalledObject.OutputLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Parameters", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<string>, StringUnmarshaller, ListUnmarshaller<string, StringUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance));
                    unmarshalledObject.Parameters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduleExpression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScheduleExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SyncCompliance", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SyncCompliance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetLocations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TargetLocation, TargetLocationUnmarshaller>(TargetLocationUnmarshaller.Instance);
                    unmarshalledObject.TargetLocations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Targets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Target, TargetUnmarshaller>(TargetUnmarshaller.Instance);
                    unmarshalledObject.Targets = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CreateAssociationBatchRequestEntryUnmarshaller _instance = new CreateAssociationBatchRequestEntryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAssociationBatchRequestEntryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}