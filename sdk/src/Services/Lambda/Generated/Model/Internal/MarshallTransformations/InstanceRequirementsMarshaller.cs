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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lambda.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Lambda.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceRequirements Marshaller
    /// </summary>
    public class InstanceRequirementsMarshaller : IRequestMarshaller<InstanceRequirements, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceRequirements requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedInstanceTypes())
            {
                context.Writer.WritePropertyName("AllowedInstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedInstanceTypesListValue in requestObject.AllowedInstanceTypes)
                {
                        context.Writer.Write(requestObjectAllowedInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetArchitectures())
            {
                context.Writer.WritePropertyName("Architectures");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectArchitecturesListValue in requestObject.Architectures)
                {
                        context.Writer.Write(requestObjectArchitecturesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExcludedInstanceTypes())
            {
                context.Writer.WritePropertyName("ExcludedInstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludedInstanceTypesListValue in requestObject.ExcludedInstanceTypes)
                {
                        context.Writer.Write(requestObjectExcludedInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceRequirementsMarshaller Instance = new InstanceRequirementsMarshaller();

    }
}