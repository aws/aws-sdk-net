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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisFirehose.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisFirehose.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MSKSourceConfiguration Marshaller
    /// </summary>
    public class MSKSourceConfigurationMarshaller : IRequestMarshaller<MSKSourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MSKSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationConfiguration())
            {
                context.Writer.WritePropertyName("AuthenticationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AuthenticationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthenticationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMSKClusterARN())
            {
                context.Writer.WritePropertyName("MSKClusterARN");
                context.Writer.Write(requestObject.MSKClusterARN);
            }

            if(requestObject.IsSetReadFromTimestamp())
            {
                context.Writer.WritePropertyName("ReadFromTimestamp");
                context.Writer.Write(requestObject.ReadFromTimestamp);
            }

            if(requestObject.IsSetTopicName())
            {
                context.Writer.WritePropertyName("TopicName");
                context.Writer.Write(requestObject.TopicName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MSKSourceConfigurationMarshaller Instance = new MSKSourceConfigurationMarshaller();

    }
}