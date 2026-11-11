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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BlockPublicAccessConfiguration Marshaller
    /// </summary>
    public partial class BlockPublicAccessConfigurationMarshaller : IRequestMarshaller<BlockPublicAccessConfiguration, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(BlockPublicAccessConfiguration requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBlockPublicSecurityGroupRules())
            {
                context.Writer.WritePropertyName("BlockPublicSecurityGroupRules");
                context.Writer.WriteBooleanValue(requestObject.BlockPublicSecurityGroupRules.Value);
            }

            if (requestObject.IsSetClassification())
            {
                context.Writer.WritePropertyName("Classification");
                context.Writer.WriteStringValue(requestObject.Classification);
            }

            if (requestObject.IsSetConfigurations())
            {
                context.Writer.WritePropertyName("Configurations");
                context.Writer.WriteStartArray();
                foreach (var requestObjectConfigurationsListValue in requestObject.Configurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetPermittedPublicSecurityGroupRuleRanges())
            {
                context.Writer.WritePropertyName("PermittedPublicSecurityGroupRuleRanges");
                context.Writer.WriteStartArray();
                foreach (var requestObjectPermittedPublicSecurityGroupRuleRangesListValue in requestObject.PermittedPublicSecurityGroupRuleRanges)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PortRangeMarshaller.Instance;
                    marshaller.Marshall(requestObjectPermittedPublicSecurityGroupRuleRangesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("Properties");
                context.Writer.WriteStartObject();
                foreach (var requestObjectPropertiesKvp in requestObject.Properties)
                {
                    context.Writer.WritePropertyName(requestObjectPropertiesKvp.Key);
                    var requestObjectPropertiesValue = requestObjectPropertiesKvp.Value;
                    context.Writer.WriteStringValue(requestObjectPropertiesValue);
                }
                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static BlockPublicAccessConfigurationMarshaller Instance = new BlockPublicAccessConfigurationMarshaller();
    }
}
