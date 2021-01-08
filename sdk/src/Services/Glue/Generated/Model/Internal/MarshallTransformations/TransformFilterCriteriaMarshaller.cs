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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TransformFilterCriteria Marshaller
    /// </summary>       
    public class TransformFilterCriteriaMarshaller : IRequestMarshaller<TransformFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TransformFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCreatedAfter())
            {
                context.Writer.WritePropertyName("CreatedAfter");
                context.Writer.Write(requestObject.CreatedAfter);
            }

            if(requestObject.IsSetCreatedBefore())
            {
                context.Writer.WritePropertyName("CreatedBefore");
                context.Writer.Write(requestObject.CreatedBefore);
            }

            if(requestObject.IsSetGlueVersion())
            {
                context.Writer.WritePropertyName("GlueVersion");
                context.Writer.Write(requestObject.GlueVersion);
            }

            if(requestObject.IsSetLastModifiedAfter())
            {
                context.Writer.WritePropertyName("LastModifiedAfter");
                context.Writer.Write(requestObject.LastModifiedAfter);
            }

            if(requestObject.IsSetLastModifiedBefore())
            {
                context.Writer.WritePropertyName("LastModifiedBefore");
                context.Writer.Write(requestObject.LastModifiedBefore);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetSchema())
            {
                context.Writer.WritePropertyName("Schema");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSchemaListValue in requestObject.Schema)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SchemaColumnMarshaller.Instance;
                    marshaller.Marshall(requestObjectSchemaListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetTransformType())
            {
                context.Writer.WritePropertyName("TransformType");
                context.Writer.Write(requestObject.TransformType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static TransformFilterCriteriaMarshaller Instance = new TransformFilterCriteriaMarshaller();

    }
}