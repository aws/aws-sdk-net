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

using Amazon.Synthetics.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Synthetics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CanaryCodeInput Marshaller
    /// </summary>
    public partial class CanaryCodeInputMarshaller : IRequestMarshaller<CanaryCodeInput, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CanaryCodeInput requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBlueprintTypes())
            {
                context.Writer.WritePropertyName("BlueprintTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectBlueprintTypesListValue in requestObject.BlueprintTypes)
                {
                    context.Writer.WriteStringValue(requestObjectBlueprintTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetDependencies())
            {
                context.Writer.WritePropertyName("Dependencies");
                context.Writer.WriteStartArray();
                foreach (var requestObjectDependenciesListValue in requestObject.Dependencies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependenciesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetHandler())
            {
                context.Writer.WritePropertyName("Handler");
                context.Writer.WriteStringValue(requestObject.Handler);
            }

            if (requestObject.IsSetS3Bucket())
            {
                context.Writer.WritePropertyName("S3Bucket");
                context.Writer.WriteStringValue(requestObject.S3Bucket);
            }

            if (requestObject.IsSetS3Key())
            {
                context.Writer.WritePropertyName("S3Key");
                context.Writer.WriteStringValue(requestObject.S3Key);
            }

            if (requestObject.IsSetS3Version())
            {
                context.Writer.WritePropertyName("S3Version");
                context.Writer.WriteStringValue(requestObject.S3Version);
            }

            if (requestObject.IsSetZipFile())
            {
                context.Writer.WritePropertyName("ZipFile");
                StringUtils.WriteBase64StringValue(context.Writer, requestObject.ZipFile);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CanaryCodeInputMarshaller Instance = new CanaryCodeInputMarshaller();
    }
}
