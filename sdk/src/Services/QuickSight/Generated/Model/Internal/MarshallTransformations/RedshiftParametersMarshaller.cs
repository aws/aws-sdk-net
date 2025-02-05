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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftParameters Marshaller
    /// </summary>
    public class RedshiftParametersMarshaller : IRequestMarshaller<RedshiftParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetClusterId())
            {
                context.Writer.WritePropertyName("ClusterId");
                context.Writer.WriteStringValue(requestObject.ClusterId);
            }

            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.WriteStringValue(requestObject.Database);
            }

            if(requestObject.IsSetHost())
            {
                context.Writer.WritePropertyName("Host");
                context.Writer.WriteStringValue(requestObject.Host);
            }

            if(requestObject.IsSetIAMParameters())
            {
                context.Writer.WritePropertyName("IAMParameters");
                context.Writer.WriteStartObject();

                var marshaller = RedshiftIAMParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.IAMParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIdentityCenterConfiguration())
            {
                context.Writer.WritePropertyName("IdentityCenterConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = IdentityCenterConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.IdentityCenterConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftParametersMarshaller Instance = new RedshiftParametersMarshaller();

    }
}