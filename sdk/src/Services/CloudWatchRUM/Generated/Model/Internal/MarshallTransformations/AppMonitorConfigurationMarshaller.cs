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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchRUM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchRUM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AppMonitorConfiguration Marshaller
    /// </summary>
    public class AppMonitorConfigurationMarshaller : IRequestMarshaller<AppMonitorConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AppMonitorConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowCookies())
            {
                context.Writer.WritePropertyName("AllowCookies");
                context.Writer.WriteBooleanValue(requestObject.AllowCookies.Value);
            }

            if(requestObject.IsSetEnableXRay())
            {
                context.Writer.WritePropertyName("EnableXRay");
                context.Writer.WriteBooleanValue(requestObject.EnableXRay.Value);
            }

            if(requestObject.IsSetExcludedPages())
            {
                context.Writer.WritePropertyName("ExcludedPages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludedPagesListValue in requestObject.ExcludedPages)
                {
                        context.Writer.WriteStringValue(requestObjectExcludedPagesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetFavoritePages())
            {
                context.Writer.WritePropertyName("FavoritePages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectFavoritePagesListValue in requestObject.FavoritePages)
                {
                        context.Writer.WriteStringValue(requestObjectFavoritePagesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGuestRoleArn())
            {
                context.Writer.WritePropertyName("GuestRoleArn");
                context.Writer.WriteStringValue(requestObject.GuestRoleArn);
            }

            if(requestObject.IsSetIdentityPoolId())
            {
                context.Writer.WritePropertyName("IdentityPoolId");
                context.Writer.WriteStringValue(requestObject.IdentityPoolId);
            }

            if(requestObject.IsSetIncludedPages())
            {
                context.Writer.WritePropertyName("IncludedPages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIncludedPagesListValue in requestObject.IncludedPages)
                {
                        context.Writer.WriteStringValue(requestObjectIncludedPagesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSessionSampleRate())
            {
                context.Writer.WritePropertyName("SessionSampleRate");
                if(StringUtils.IsSpecialDoubleValue(requestObject.SessionSampleRate.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.SessionSampleRate.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.SessionSampleRate.Value);
                }
            }

            if(requestObject.IsSetTelemetries())
            {
                context.Writer.WritePropertyName("Telemetries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTelemetriesListValue in requestObject.Telemetries)
                {
                        context.Writer.WriteStringValue(requestObjectTelemetriesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AppMonitorConfigurationMarshaller Instance = new AppMonitorConfigurationMarshaller();

    }
}