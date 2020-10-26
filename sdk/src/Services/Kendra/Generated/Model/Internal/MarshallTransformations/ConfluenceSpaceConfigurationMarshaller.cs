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
            if(requestObject.IsSetCrawlArchivedSpaces())
            {
                context.Writer.WritePropertyName("CrawlArchivedSpaces");
                context.Writer.Write(requestObject.CrawlArchivedSpaces);
            }

            if(requestObject.IsSetCrawlPersonalSpaces())
            {
                context.Writer.WritePropertyName("CrawlPersonalSpaces");
                context.Writer.Write(requestObject.CrawlPersonalSpaces);
            }

            if(requestObject.IsSetExcludeSpaces())
            {
                context.Writer.WritePropertyName("ExcludeSpaces");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludeSpacesListValue in requestObject.ExcludeSpaces)
                {
                        context.Writer.Write(requestObjectExcludeSpacesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIncludeSpaces())
            {
                context.Writer.WritePropertyName("IncludeSpaces");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIncludeSpacesListValue in requestObject.IncludeSpaces)
                {
                        context.Writer.Write(requestObjectIncludeSpacesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSpaceFieldMappings())
            {
                context.Writer.WritePropertyName("SpaceFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSpaceFieldMappingsListValue in requestObject.SpaceFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ConfluenceSpaceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectSpaceFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ConfluenceSpaceConfigurationMarshaller Instance = new ConfluenceSpaceConfigurationMarshaller();

    }
}