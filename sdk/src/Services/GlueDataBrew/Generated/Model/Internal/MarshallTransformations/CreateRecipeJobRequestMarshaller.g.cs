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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.GlueDataBrew.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateRecipeJob Request Marshaller
    /// </summary>
    public partial class CreateRecipeJobRequestMarshaller : IMarshaller<IRequest, CreateRecipeJobRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateRecipeJobRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateRecipeJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GlueDataBrew");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/recipeJobs";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetDataCatalogOutputs())
            {
                context.Writer.WritePropertyName("DataCatalogOutputs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestDataCatalogOutputsListValue in publicRequest.DataCatalogOutputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataCatalogOutputMarshaller.Instance;
                    marshaller.Marshall(publicRequestDataCatalogOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDatabaseOutputs())
            {
                context.Writer.WritePropertyName("DatabaseOutputs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestDatabaseOutputsListValue in publicRequest.DatabaseOutputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DatabaseOutputMarshaller.Instance;
                    marshaller.Marshall(publicRequestDatabaseOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetDatasetName())
            {
                context.Writer.WritePropertyName("DatasetName");
                context.Writer.WriteStringValue(publicRequest.DatasetName);
            }
            if (publicRequest.IsSetEncryptionKeyArn())
            {
                context.Writer.WritePropertyName("EncryptionKeyArn");
                context.Writer.WriteStringValue(publicRequest.EncryptionKeyArn);
            }
            if (publicRequest.IsSetEncryptionMode())
            {
                context.Writer.WritePropertyName("EncryptionMode");
                context.Writer.WriteStringValue(publicRequest.EncryptionMode);
            }
            if (publicRequest.IsSetLogSubscription())
            {
                context.Writer.WritePropertyName("LogSubscription");
                context.Writer.WriteStringValue(publicRequest.LogSubscription);
            }
            if (publicRequest.IsSetMaxCapacity())
            {
                context.Writer.WritePropertyName("MaxCapacity");
                context.Writer.WriteNumberValue(publicRequest.MaxCapacity.Value);
            }
            if (publicRequest.IsSetMaxRetries())
            {
                context.Writer.WritePropertyName("MaxRetries");
                context.Writer.WriteNumberValue(publicRequest.MaxRetries.Value);
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetOutputs())
            {
                context.Writer.WritePropertyName("Outputs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestOutputsListValue in publicRequest.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetProjectName())
            {
                context.Writer.WritePropertyName("ProjectName");
                context.Writer.WriteStringValue(publicRequest.ProjectName);
            }
            if (publicRequest.IsSetRecipeReference())
            {
                context.Writer.WritePropertyName("RecipeReference");
                context.Writer.WriteStartObject();

                var marshaller = RecipeReferenceMarshaller.Instance;
                marshaller.Marshall(publicRequest.RecipeReference, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetRoleArn())
            {
                context.Writer.WritePropertyName("RoleArn");
                context.Writer.WriteStringValue(publicRequest.RoleArn);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTimeout())
            {
                context.Writer.WritePropertyName("Timeout");
                context.Writer.WriteNumberValue(publicRequest.Timeout.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateRecipeJobRequestMarshaller _instance = new();

        internal static CreateRecipeJobRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateRecipeJobRequestMarshaller Instance => _instance;
    }
}
