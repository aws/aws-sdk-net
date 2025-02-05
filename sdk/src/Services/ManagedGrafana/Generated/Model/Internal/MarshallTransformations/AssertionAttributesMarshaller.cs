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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ManagedGrafana.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ManagedGrafana.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssertionAttributes Marshaller
    /// </summary>
    public class AssertionAttributesMarshaller : IRequestMarshaller<AssertionAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssertionAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEmail())
            {
                context.Writer.WritePropertyName("email");
                context.Writer.WriteStringValue(requestObject.Email);
            }

            if(requestObject.IsSetGroups())
            {
                context.Writer.WritePropertyName("groups");
                context.Writer.WriteStringValue(requestObject.Groups);
            }

            if(requestObject.IsSetLogin())
            {
                context.Writer.WritePropertyName("login");
                context.Writer.WriteStringValue(requestObject.Login);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOrg())
            {
                context.Writer.WritePropertyName("org");
                context.Writer.WriteStringValue(requestObject.Org);
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("role");
                context.Writer.WriteStringValue(requestObject.Role);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssertionAttributesMarshaller Instance = new AssertionAttributesMarshaller();

    }
}