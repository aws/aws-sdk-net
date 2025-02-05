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
    /// OneDriveConfiguration Marshaller
    /// </summary>
    public class OneDriveConfigurationMarshaller : IRequestMarshaller<OneDriveConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OneDriveConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDisableLocalGroups())
            {
                context.Writer.WritePropertyName("DisableLocalGroups");
                context.Writer.WriteBooleanValue(requestObject.DisableLocalGroups.Value);
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

            if(requestObject.IsSetOneDriveUsers())
            {
                context.Writer.WritePropertyName("OneDriveUsers");
                context.Writer.WriteStartObject();

                var marshaller = OneDriveUsersMarshaller.Instance;
                marshaller.Marshall(requestObject.OneDriveUsers, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.WriteStringValue(requestObject.SecretArn);
            }

            if(requestObject.IsSetTenantDomain())
            {
                context.Writer.WritePropertyName("TenantDomain");
                context.Writer.WriteStringValue(requestObject.TenantDomain);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OneDriveConfigurationMarshaller Instance = new OneDriveConfigurationMarshaller();

    }
}