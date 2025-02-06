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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CaptionDescription Marshaller
    /// </summary>
    public class CaptionDescriptionMarshaller : IRequestMarshaller<CaptionDescription, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CaptionDescription requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessibility())
            {
                context.Writer.WritePropertyName("accessibility");
                context.Writer.WriteStringValue(requestObject.Accessibility);
            }

            if(requestObject.IsSetCaptionDashRoles())
            {
                context.Writer.WritePropertyName("captionDashRoles");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCaptionDashRolesListValue in requestObject.CaptionDashRoles)
                {
                        context.Writer.WriteStringValue(requestObjectCaptionDashRolesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCaptionSelectorName())
            {
                context.Writer.WritePropertyName("captionSelectorName");
                context.Writer.WriteStringValue(requestObject.CaptionSelectorName);
            }

            if(requestObject.IsSetDestinationSettings())
            {
                context.Writer.WritePropertyName("destinationSettings");
                context.Writer.WriteStartObject();

                var marshaller = CaptionDestinationSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDvbDashAccessibility())
            {
                context.Writer.WritePropertyName("dvbDashAccessibility");
                context.Writer.WriteStringValue(requestObject.DvbDashAccessibility);
            }

            if(requestObject.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("languageCode");
                context.Writer.WriteStringValue(requestObject.LanguageCode);
            }

            if(requestObject.IsSetLanguageDescription())
            {
                context.Writer.WritePropertyName("languageDescription");
                context.Writer.WriteStringValue(requestObject.LanguageDescription);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CaptionDescriptionMarshaller Instance = new CaptionDescriptionMarshaller();

    }
}