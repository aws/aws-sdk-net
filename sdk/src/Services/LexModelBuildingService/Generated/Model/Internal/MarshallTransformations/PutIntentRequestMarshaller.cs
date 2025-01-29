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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutIntent Request Marshaller
    /// </summary>       
    public class PutIntentRequestMarshaller : IMarshaller<IRequest, PutIntentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutIntentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutIntentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-04-19";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetName())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/intents/{name}/versions/$LATEST";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChecksum())
            {
                context.Writer.WritePropertyName("checksum");
                context.Writer.WriteStringValue(publicRequest.Checksum);
            }

            if(publicRequest.IsSetConclusionStatement())
            {
                context.Writer.WritePropertyName("conclusionStatement");
                context.Writer.WriteStartObject();

                var marshaller = StatementMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConclusionStatement, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConfirmationPrompt())
            {
                context.Writer.WritePropertyName("confirmationPrompt");
                context.Writer.WriteStartObject();

                var marshaller = PromptMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConfirmationPrompt, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCreateVersion())
            {
                context.Writer.WritePropertyName("createVersion");
                context.Writer.WriteBooleanValue(publicRequest.CreateVersion.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDialogCodeHook())
            {
                context.Writer.WritePropertyName("dialogCodeHook");
                context.Writer.WriteStartObject();

                var marshaller = CodeHookMarshaller.Instance;
                marshaller.Marshall(publicRequest.DialogCodeHook, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFollowUpPrompt())
            {
                context.Writer.WritePropertyName("followUpPrompt");
                context.Writer.WriteStartObject();

                var marshaller = FollowUpPromptMarshaller.Instance;
                marshaller.Marshall(publicRequest.FollowUpPrompt, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetFulfillmentActivity())
            {
                context.Writer.WritePropertyName("fulfillmentActivity");
                context.Writer.WriteStartObject();

                var marshaller = FulfillmentActivityMarshaller.Instance;
                marshaller.Marshall(publicRequest.FulfillmentActivity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputContexts())
            {
                context.Writer.WritePropertyName("inputContexts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputContextsListValue in publicRequest.InputContexts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InputContextMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputContextsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetKendraConfiguration())
            {
                context.Writer.WritePropertyName("kendraConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KendraConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KendraConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputContexts())
            {
                context.Writer.WritePropertyName("outputContexts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutputContextsListValue in publicRequest.OutputContexts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = OutputContextMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputContextsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetParentIntentSignature())
            {
                context.Writer.WritePropertyName("parentIntentSignature");
                context.Writer.WriteStringValue(publicRequest.ParentIntentSignature);
            }

            if(publicRequest.IsSetRejectionStatement())
            {
                context.Writer.WritePropertyName("rejectionStatement");
                context.Writer.WriteStartObject();

                var marshaller = StatementMarshaller.Instance;
                marshaller.Marshall(publicRequest.RejectionStatement, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSampleUtterances())
            {
                context.Writer.WritePropertyName("sampleUtterances");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSampleUtterancesListValue in publicRequest.SampleUtterances)
                {
                        context.Writer.WriteStringValue(publicRequestSampleUtterancesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSlots())
            {
                context.Writer.WritePropertyName("slots");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSlotsListValue in publicRequest.Slots)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SlotMarshaller.Instance;
                    marshaller.Marshall(publicRequestSlotsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static PutIntentRequestMarshaller _instance = new PutIntentRequestMarshaller();        

        internal static PutIntentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutIntentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}