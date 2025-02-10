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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EksContainerSecurityContext Marshaller
    /// </summary>
    public class EksContainerSecurityContextMarshaller : IRequestMarshaller<EksContainerSecurityContext, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EksContainerSecurityContext requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowPrivilegeEscalation())
            {
                context.Writer.WritePropertyName("allowPrivilegeEscalation");
                context.Writer.WriteBooleanValue(requestObject.AllowPrivilegeEscalation.Value);
            }

            if(requestObject.IsSetPrivileged())
            {
                context.Writer.WritePropertyName("privileged");
                context.Writer.WriteBooleanValue(requestObject.Privileged.Value);
            }

            if(requestObject.IsSetReadOnlyRootFilesystem())
            {
                context.Writer.WritePropertyName("readOnlyRootFilesystem");
                context.Writer.WriteBooleanValue(requestObject.ReadOnlyRootFilesystem.Value);
            }

            if(requestObject.IsSetRunAsGroup())
            {
                context.Writer.WritePropertyName("runAsGroup");
                context.Writer.WriteNumberValue(requestObject.RunAsGroup.Value);
            }

            if(requestObject.IsSetRunAsNonRoot())
            {
                context.Writer.WritePropertyName("runAsNonRoot");
                context.Writer.WriteBooleanValue(requestObject.RunAsNonRoot.Value);
            }

            if(requestObject.IsSetRunAsUser())
            {
                context.Writer.WritePropertyName("runAsUser");
                context.Writer.WriteNumberValue(requestObject.RunAsUser.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EksContainerSecurityContextMarshaller Instance = new EksContainerSecurityContextMarshaller();

    }
}