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
using ThirdParty.Json.LitJson;

namespace Amazon.ResilienceHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LogicalResourceId Marshaller
    /// </summary>
    public class LogicalResourceIdMarshaller : IRequestMarshaller<LogicalResourceId, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LogicalResourceId requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEksSourceName())
            {
                context.Writer.WritePropertyName("eksSourceName");
                context.Writer.Write(requestObject.EksSourceName);
            }

            if(requestObject.IsSetIdentifier())
            {
                context.Writer.WritePropertyName("identifier");
                context.Writer.Write(requestObject.Identifier);
            }

            if(requestObject.IsSetLogicalStackName())
            {
                context.Writer.WritePropertyName("logicalStackName");
                context.Writer.Write(requestObject.LogicalStackName);
            }

            if(requestObject.IsSetResourceGroupName())
            {
                context.Writer.WritePropertyName("resourceGroupName");
                context.Writer.Write(requestObject.ResourceGroupName);
            }

            if(requestObject.IsSetTerraformSourceName())
            {
                context.Writer.WritePropertyName("terraformSourceName");
                context.Writer.Write(requestObject.TerraformSourceName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LogicalResourceIdMarshaller Instance = new LogicalResourceIdMarshaller();

    }
}