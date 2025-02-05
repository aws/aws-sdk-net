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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FeatureDefinition Marshaller
    /// </summary>
    public class FeatureDefinitionMarshaller : IRequestMarshaller<FeatureDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FeatureDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCollectionConfig())
            {
                context.Writer.WritePropertyName("CollectionConfig");
                context.Writer.WriteStartObject();

                var marshaller = CollectionConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CollectionConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCollectionType())
            {
                context.Writer.WritePropertyName("CollectionType");
                context.Writer.WriteStringValue(requestObject.CollectionType);
            }

            if(requestObject.IsSetFeatureName())
            {
                context.Writer.WritePropertyName("FeatureName");
                context.Writer.WriteStringValue(requestObject.FeatureName);
            }

            if(requestObject.IsSetFeatureType())
            {
                context.Writer.WritePropertyName("FeatureType");
                context.Writer.WriteStringValue(requestObject.FeatureType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FeatureDefinitionMarshaller Instance = new FeatureDefinitionMarshaller();

    }
}