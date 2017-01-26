/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FacetAttribute Marshaller
    /// </summary>       
    public class FacetAttributeMarshaller : IRequestMarshaller<FacetAttribute, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FacetAttribute requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAttributeDefinition())
            {
                context.Writer.WritePropertyName("AttributeDefinition");
                context.Writer.WriteObjectStart();

                var marshaller = FacetAttributeDefinitionMarshaller.Instance;
                marshaller.Marshall(requestObject.AttributeDefinition, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAttributeReference())
            {
                context.Writer.WritePropertyName("AttributeReference");
                context.Writer.WriteObjectStart();

                var marshaller = FacetAttributeReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.AttributeReference, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRequiredBehavior())
            {
                context.Writer.WritePropertyName("RequiredBehavior");
                context.Writer.Write(requestObject.RequiredBehavior);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FacetAttributeMarshaller Instance = new FacetAttributeMarshaller();

    }
}