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
    /// GoogleDriveConfiguration Marshaller
    /// </summary>
    public class GoogleDriveConfigurationMarshaller : IRequestMarshaller<GoogleDriveConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GoogleDriveConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExcludeMimeTypes())
            {
                context.Writer.WritePropertyName("ExcludeMimeTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeMimeTypesListValue in requestObject.ExcludeMimeTypes)
                {
                        context.Writer.WriteStringValue(requestObjectExcludeMimeTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExcludeSharedDrives())
            {
                context.Writer.WritePropertyName("ExcludeSharedDrives");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeSharedDrivesListValue in requestObject.ExcludeSharedDrives)
                {
                        context.Writer.WriteStringValue(requestObjectExcludeSharedDrivesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExcludeUserAccounts())
            {
                context.Writer.WritePropertyName("ExcludeUserAccounts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludeUserAccountsListValue in requestObject.ExcludeUserAccounts)
                {
                        context.Writer.WriteStringValue(requestObjectExcludeUserAccountsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExclusionPatterns())
            {
                context.Writer.WritePropertyName("ExclusionPatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExclusionPatternsListValue in requestObject.ExclusionPatterns)
                {
                        context.Writer.WriteStringValue(requestObjectExclusionPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFieldMappings())
            {
                context.Writer.WritePropertyName("FieldMappings");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFieldMappingsListValue in requestObject.FieldMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectFieldMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInclusionPatterns())
            {
                context.Writer.WritePropertyName("InclusionPatterns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInclusionPatternsListValue in requestObject.InclusionPatterns)
                {
                        context.Writer.WriteStringValue(requestObjectInclusionPatternsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GoogleDriveConfigurationMarshaller Instance = new GoogleDriveConfigurationMarshaller();

    }
}