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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CollapseConfiguration Marshaller
    /// </summary>
    public class CollapseConfigurationMarshaller : IRequestMarshaller<CollapseConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CollapseConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDocumentAttributeKey())
            {
                context.Writer.WritePropertyName("DocumentAttributeKey");
                context.Writer.Write(requestObject.DocumentAttributeKey);
            }

            if(requestObject.IsSetExpand())
            {
                context.Writer.WritePropertyName("Expand");
                context.Writer.Write(requestObject.Expand);
            }

            if(requestObject.IsSetExpandConfiguration())
            {
                context.Writer.WritePropertyName("ExpandConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ExpandConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ExpandConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMissingAttributeKeyStrategy())
            {
                context.Writer.WritePropertyName("MissingAttributeKeyStrategy");
                context.Writer.Write(requestObject.MissingAttributeKeyStrategy);
            }

            if(requestObject.IsSetSortingConfigurations())
            {
                context.Writer.WritePropertyName("SortingConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSortingConfigurationsListValue in requestObject.SortingConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SortingConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectSortingConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CollapseConfigurationMarshaller Instance = new CollapseConfigurationMarshaller();

    }
}