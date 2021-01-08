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
using ThirdParty.Json.LitJson;

namespace Amazon.Comprehend.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EntityRecognizerInputDataConfig Marshaller
    /// </summary>       
    public class EntityRecognizerInputDataConfigMarshaller : IRequestMarshaller<EntityRecognizerInputDataConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EntityRecognizerInputDataConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAnnotations())
            {
                context.Writer.WritePropertyName("Annotations");
                context.Writer.WriteObjectStart();

                var marshaller = EntityRecognizerAnnotationsMarshaller.Instance;
                marshaller.Marshall(requestObject.Annotations, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAugmentedManifests())
            {
                context.Writer.WritePropertyName("AugmentedManifests");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAugmentedManifestsListValue in requestObject.AugmentedManifests)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AugmentedManifestsListItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectAugmentedManifestsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDataFormat())
            {
                context.Writer.WritePropertyName("DataFormat");
                context.Writer.Write(requestObject.DataFormat);
            }

            if(requestObject.IsSetDocuments())
            {
                context.Writer.WritePropertyName("Documents");
                context.Writer.WriteObjectStart();

                var marshaller = EntityRecognizerDocumentsMarshaller.Instance;
                marshaller.Marshall(requestObject.Documents, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEntityList())
            {
                context.Writer.WritePropertyName("EntityList");
                context.Writer.WriteObjectStart();

                var marshaller = EntityRecognizerEntityListMarshaller.Instance;
                marshaller.Marshall(requestObject.EntityList, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEntityTypes())
            {
                context.Writer.WritePropertyName("EntityTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntityTypesListValue in requestObject.EntityTypes)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = EntityTypesListItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectEntityTypesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EntityRecognizerInputDataConfigMarshaller Instance = new EntityRecognizerInputDataConfigMarshaller();

    }
}