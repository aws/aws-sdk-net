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
#pragma warning disable CS0612,CS0618
namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KendraConfiguration Marshaller
    /// </summary>
    public class KendraConfigurationMarshaller : IRequestMarshaller<KendraConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KendraConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetKendraIndex())
            {
                context.Writer.WritePropertyName("kendraIndex");
                context.Writer.WriteStringValue(requestObject.KendraIndex);
            }

            if(requestObject.IsSetQueryFilterString())
            {
                context.Writer.WritePropertyName("queryFilterString");
                context.Writer.WriteStringValue(requestObject.QueryFilterString);
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("role");
                context.Writer.WriteStringValue(requestObject.Role);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KendraConfigurationMarshaller Instance = new KendraConfigurationMarshaller();

    }
}