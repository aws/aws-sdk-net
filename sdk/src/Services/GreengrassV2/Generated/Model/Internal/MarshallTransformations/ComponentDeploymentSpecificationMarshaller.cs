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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComponentDeploymentSpecification Marshaller
    /// </summary>
    public class ComponentDeploymentSpecificationMarshaller : IRequestMarshaller<ComponentDeploymentSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentDeploymentSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetComponentVersion())
            {
                context.Writer.WritePropertyName("componentVersion");
                context.Writer.WriteStringValue(requestObject.ComponentVersion);
            }

            if(requestObject.IsSetConfigurationUpdate())
            {
                context.Writer.WritePropertyName("configurationUpdate");
                context.Writer.WriteStartObject();

                var marshaller = ComponentConfigurationUpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfigurationUpdate, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRunWith())
            {
                context.Writer.WritePropertyName("runWith");
                context.Writer.WriteStartObject();

                var marshaller = ComponentRunWithMarshaller.Instance;
                marshaller.Marshall(requestObject.RunWith, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentDeploymentSpecificationMarshaller Instance = new ComponentDeploymentSpecificationMarshaller();

    }
}