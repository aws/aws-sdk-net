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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Comprehend.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DatasetEntityRecognizerInputDataConfig Marshaller
    /// </summary>
    public class DatasetEntityRecognizerInputDataConfigMarshaller : IRequestMarshaller<DatasetEntityRecognizerInputDataConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DatasetEntityRecognizerInputDataConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnnotations())
            {
                context.Writer.WritePropertyName("Annotations");
                context.Writer.WriteStartObject();

                var marshaller = DatasetEntityRecognizerAnnotationsMarshaller.Instance;
                marshaller.Marshall(requestObject.Annotations, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDocuments())
            {
                context.Writer.WritePropertyName("Documents");
                context.Writer.WriteStartObject();

                var marshaller = DatasetEntityRecognizerDocumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.Documents, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEntityList())
            {
                context.Writer.WritePropertyName("EntityList");
                context.Writer.WriteStartObject();

                var marshaller = DatasetEntityRecognizerEntityListMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityList, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatasetEntityRecognizerInputDataConfigMarshaller Instance = new DatasetEntityRecognizerInputDataConfigMarshaller();

    }
}