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
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfluenceSpaceConfiguration Marshaller
    /// </summary>
    public class ConfluenceSpaceConfigurationMarshaller : IRequestMarshaller<ConfluenceSpaceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConfluenceSpaceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCrawlArchivedSpaces())
            {
                context.Writer.WritePropertyName("CrawlArchivedSpaces");
                context.Writer.WriteBooleanValue(requestObject.CrawlArchivedSpaces.Value);
            }

            if(requestObject.IsSetCrawlPersonalSpaces())
            {
                context.Writer.WritePropertyName("CrawlPersonalSpaces");
                context.Writer.WriteBooleanValue(requestObject.CrawlPersonalSpaces.Value);
            }

            if(requestObject.IsSetExcludeSpaces())
            {
                context.Writer.WritePropertyName("ExcludeSpaces");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeSpacesListValue in requestObject.ExcludeSpaces)
                {
                        context.Writer.WriteStringValue(requestObjectExcludeSpacesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIncludeSpaces())
            {
                context.Writer.WritePropertyName("IncludeSpaces");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIncludeSpacesListValue in requestObject.IncludeSpaces)
                {
                        context.Writer.WriteStringValue(requestObjectIncludeSpacesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSpaceFieldMappings())
            {
                context.Writer.WritePropertyName("SpaceFieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSpaceFieldMappingsListValue in requestObject.SpaceFieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConfluenceSpaceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectSpaceFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConfluenceSpaceConfigurationMarshaller Instance = new ConfluenceSpaceConfigurationMarshaller();

    }
}