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
    /// ResourceAction Marshaller
    /// </summary>
    public class ResourceActionMarshaller : IRequestMarshaller<ResourceAction, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ResourceAction requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudFormationAction())
            {
                context.Writer.WritePropertyName("cloudFormationAction");
                context.Writer.WriteStartObject();

                var marshaller = CloudFormationActionMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudFormationAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetM2ManagedApplicationAction())
            {
                context.Writer.WritePropertyName("m2ManagedApplicationAction");
                context.Writer.WriteStartObject();

                var marshaller = M2ManagedApplicationActionMarshaller.Instance;
                marshaller.Marshall(requestObject.M2ManagedApplicationAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetM2NonManagedApplicationAction())
            {
                context.Writer.WritePropertyName("m2NonManagedApplicationAction");
                context.Writer.WriteStartObject();

                var marshaller = M2NonManagedApplicationActionMarshaller.Instance;
                marshaller.Marshall(requestObject.M2NonManagedApplicationAction, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ResourceActionMarshaller Instance = new ResourceActionMarshaller();

    }
}