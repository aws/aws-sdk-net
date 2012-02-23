/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Deprecate Activity Type Request Marshaller
    /// </summary>       
    internal class DeprecateActivityTypeRequestMarshaller : IMarshaller<IRequest<DeprecateActivityTypeRequest>, DeprecateActivityTypeRequest> 
    {
        public IRequest<DeprecateActivityTypeRequest> Marshall(DeprecateActivityTypeRequest deprecateActivityTypeRequest) 
        {

            IRequest<DeprecateActivityTypeRequest> request = new DefaultRequest<DeprecateActivityTypeRequest>(deprecateActivityTypeRequest, "AmazonSimpleWorkflow");
            string target = "SimpleWorkflowService.DeprecateActivityType";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (deprecateActivityTypeRequest != null && deprecateActivityTypeRequest.IsSetDomain()) 
                {
                    writer.WritePropertyName("domain");
                    writer.Write(deprecateActivityTypeRequest.Domain);
                }

                if (deprecateActivityTypeRequest != null) 
                {
                    ActivityType activityType = deprecateActivityTypeRequest.ActivityType;
                    if (activityType != null)
                    {
                        writer.WritePropertyName("activityType");
                        writer.WriteObjectStart();
                        if (activityType != null && activityType.IsSetName()) 
                        {
                            writer.WritePropertyName("name");
                            writer.Write(activityType.Name);
                        }
                        if (activityType != null && activityType.IsSetVersion()) 
                        {
                            writer.WritePropertyName("version");
                            writer.Write(activityType.Version);
                        }
                        writer.WriteObjectEnd();
                    }
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
