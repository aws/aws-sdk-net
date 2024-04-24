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

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Mapping Marshaller
    /// </summary>
    public class MappingMarshaller : IRequestMarshaller<Mapping, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Mapping requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChildren())
            {
                context.Writer.WritePropertyName("Children");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectChildrenListValue in requestObject.Children)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = MappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectChildrenListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDropped())
            {
                context.Writer.WritePropertyName("Dropped");
                context.Writer.Write(requestObject.Dropped);
            }

            if(requestObject.IsSetFromPath())
            {
                context.Writer.WritePropertyName("FromPath");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFromPathListValue in requestObject.FromPath)
                {
                        context.Writer.Write(requestObjectFromPathListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFromType())
            {
                context.Writer.WritePropertyName("FromType");
                context.Writer.Write(requestObject.FromType);
            }

            if(requestObject.IsSetToKey())
            {
                context.Writer.WritePropertyName("ToKey");
                context.Writer.Write(requestObject.ToKey);
            }

            if(requestObject.IsSetToType())
            {
                context.Writer.WritePropertyName("ToType");
                context.Writer.Write(requestObject.ToType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MappingMarshaller Instance = new MappingMarshaller();

    }
}