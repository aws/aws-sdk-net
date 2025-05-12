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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RdsFieldMapping Marshaller
    /// </summary>
    public class RdsFieldMappingMarshaller : IRequestMarshaller<RdsFieldMapping, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RdsFieldMapping requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomMetadataField())
            {
                context.Writer.WritePropertyName("customMetadataField");
                context.Writer.WriteStringValue(requestObject.CustomMetadataField);
            }

            if(requestObject.IsSetMetadataField())
            {
                context.Writer.WritePropertyName("metadataField");
                context.Writer.WriteStringValue(requestObject.MetadataField);
            }

            if(requestObject.IsSetPrimaryKeyField())
            {
                context.Writer.WritePropertyName("primaryKeyField");
                context.Writer.WriteStringValue(requestObject.PrimaryKeyField);
            }

            if(requestObject.IsSetTextField())
            {
                context.Writer.WritePropertyName("textField");
                context.Writer.WriteStringValue(requestObject.TextField);
            }

            if(requestObject.IsSetVectorField())
            {
                context.Writer.WritePropertyName("vectorField");
                context.Writer.WriteStringValue(requestObject.VectorField);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RdsFieldMappingMarshaller Instance = new RdsFieldMappingMarshaller();

    }
}