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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataLakeAutoEnableNewAccountConfiguration Marshaller
    /// </summary>
    public class DataLakeAutoEnableNewAccountConfigurationMarshaller : IRequestMarshaller<DataLakeAutoEnableNewAccountConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataLakeAutoEnableNewAccountConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRegion())
            {
                context.Writer.WritePropertyName("region");
                context.Writer.WriteStringValue(requestObject.Region);
            }

            if(requestObject.IsSetSources())
            {
                context.Writer.WritePropertyName("sources");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSourcesListValue in requestObject.Sources)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsLogSourceResourceMarshaller.Instance;
                    marshaller.Marshall(requestObjectSourcesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataLakeAutoEnableNewAccountConfigurationMarshaller Instance = new DataLakeAutoEnableNewAccountConfigurationMarshaller();

    }
}