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

using Amazon.LexModelsV2.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.LexModelsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteSlot Request Marshaller
    /// </summary>
    public partial class DeleteSlotRequestMarshaller : IMarshaller<IRequest, DeleteSlotRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteSlotRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteSlotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelsV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-08-07";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetBotId())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotId set");
            }
            request.AddPathResource("{botId}", StringUtils.FromString(publicRequest.BotId));

            if (!publicRequest.IsSetBotVersion())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field BotVersion set");
            }
            request.AddPathResource("{botVersion}", StringUtils.FromString(publicRequest.BotVersion));

            if (!publicRequest.IsSetIntentId())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field IntentId set");
            }
            request.AddPathResource("{intentId}", StringUtils.FromString(publicRequest.IntentId));

            if (!publicRequest.IsSetLocaleId())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field LocaleId set");
            }
            request.AddPathResource("{localeId}", StringUtils.FromString(publicRequest.LocaleId));

            if (!publicRequest.IsSetSlotId())
            {
                throw new AmazonLexModelsV2Exception("Request object does not have required field SlotId set");
            }
            request.AddPathResource("{slotId}", StringUtils.FromString(publicRequest.SlotId));

            request.ResourcePath = "/bots/{botId}/botversions/{botVersion}/botlocales/{localeId}/intents/{intentId}/slots/{slotId}";

            return request;
        }

        private static readonly DeleteSlotRequestMarshaller _instance = new();

        internal static DeleteSlotRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteSlotRequestMarshaller Instance => _instance;
    }
}
