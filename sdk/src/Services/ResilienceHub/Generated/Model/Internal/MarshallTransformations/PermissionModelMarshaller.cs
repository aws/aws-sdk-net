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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResilienceHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PermissionModel Marshaller
    /// </summary>
    public class PermissionModelMarshaller : IRequestMarshaller<PermissionModel, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PermissionModel requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCrossAccountRoleArns())
            {
                context.Writer.WritePropertyName("crossAccountRoleArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCrossAccountRoleArnsListValue in requestObject.CrossAccountRoleArns)
                {
                        context.Writer.WriteStringValue(requestObjectCrossAccountRoleArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInvokerRoleName())
            {
                context.Writer.WritePropertyName("invokerRoleName");
                context.Writer.WriteStringValue(requestObject.InvokerRoleName);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PermissionModelMarshaller Instance = new PermissionModelMarshaller();

    }
}