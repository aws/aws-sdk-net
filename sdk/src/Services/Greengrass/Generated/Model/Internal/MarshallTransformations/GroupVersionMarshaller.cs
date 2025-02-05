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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Greengrass.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Greengrass.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GroupVersion Marshaller
    /// </summary>
    public class GroupVersionMarshaller : IRequestMarshaller<GroupVersion, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GroupVersion requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectorDefinitionVersionArn())
            {
                context.Writer.WritePropertyName("ConnectorDefinitionVersionArn");
                context.Writer.WriteStringValue(requestObject.ConnectorDefinitionVersionArn);
            }

            if(requestObject.IsSetCoreDefinitionVersionArn())
            {
                context.Writer.WritePropertyName("CoreDefinitionVersionArn");
                context.Writer.WriteStringValue(requestObject.CoreDefinitionVersionArn);
            }

            if(requestObject.IsSetDeviceDefinitionVersionArn())
            {
                context.Writer.WritePropertyName("DeviceDefinitionVersionArn");
                context.Writer.WriteStringValue(requestObject.DeviceDefinitionVersionArn);
            }

            if(requestObject.IsSetFunctionDefinitionVersionArn())
            {
                context.Writer.WritePropertyName("FunctionDefinitionVersionArn");
                context.Writer.WriteStringValue(requestObject.FunctionDefinitionVersionArn);
            }

            if(requestObject.IsSetLoggerDefinitionVersionArn())
            {
                context.Writer.WritePropertyName("LoggerDefinitionVersionArn");
                context.Writer.WriteStringValue(requestObject.LoggerDefinitionVersionArn);
            }

            if(requestObject.IsSetResourceDefinitionVersionArn())
            {
                context.Writer.WritePropertyName("ResourceDefinitionVersionArn");
                context.Writer.WriteStringValue(requestObject.ResourceDefinitionVersionArn);
            }

            if(requestObject.IsSetSubscriptionDefinitionVersionArn())
            {
                context.Writer.WritePropertyName("SubscriptionDefinitionVersionArn");
                context.Writer.WriteStringValue(requestObject.SubscriptionDefinitionVersionArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GroupVersionMarshaller Instance = new GroupVersionMarshaller();

    }
}