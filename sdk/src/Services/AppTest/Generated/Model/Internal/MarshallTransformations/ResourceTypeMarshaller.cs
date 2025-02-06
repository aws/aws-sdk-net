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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppTest.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppTest.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ResourceType Marshaller
    /// </summary>
    public class ResourceTypeMarshaller : IRequestMarshaller<ResourceType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudFormation())
            {
                context.Writer.WritePropertyName("cloudFormation");
                context.Writer.WriteStartObject();

                var marshaller = CloudFormationMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudFormation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetM2ManagedApplication())
            {
                context.Writer.WritePropertyName("m2ManagedApplication");
                context.Writer.WriteStartObject();

                var marshaller = M2ManagedApplicationMarshaller.Instance;
                marshaller.Marshall(requestObject.M2ManagedApplication, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetM2NonManagedApplication())
            {
                context.Writer.WritePropertyName("m2NonManagedApplication");
                context.Writer.WriteStartObject();

                var marshaller = M2NonManagedApplicationMarshaller.Instance;
                marshaller.Marshall(requestObject.M2NonManagedApplication, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceTypeMarshaller Instance = new ResourceTypeMarshaller();

    }
}