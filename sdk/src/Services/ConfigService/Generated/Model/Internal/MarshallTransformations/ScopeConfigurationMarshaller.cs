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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConfigService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ConfigService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ScopeConfiguration Marshaller
    /// </summary>
    public class ScopeConfigurationMarshaller : IRequestMarshaller<ScopeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ScopeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllRegions())
            {
                context.Writer.WritePropertyName("allRegions");
                context.Writer.WriteBooleanValue(requestObject.AllRegions.Value);
            }

            if(requestObject.IsSetIncludedRegions())
            {
                context.Writer.WritePropertyName("includedRegions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectIncludedRegionsListValue in requestObject.IncludedRegions)
                {
                        context.Writer.WriteStringValue(requestObjectIncludedRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetScopeType())
            {
                context.Writer.WritePropertyName("scopeType");
                context.Writer.WriteStringValue(requestObject.ScopeType);
            }

            if(requestObject.IsSetScopeValues())
            {
                context.Writer.WritePropertyName("scopeValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectScopeValuesListValue in requestObject.ScopeValues)
                {
                        context.Writer.WriteStringValue(requestObjectScopeValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ScopeConfigurationMarshaller Instance = new ScopeConfigurationMarshaller();

    }
}