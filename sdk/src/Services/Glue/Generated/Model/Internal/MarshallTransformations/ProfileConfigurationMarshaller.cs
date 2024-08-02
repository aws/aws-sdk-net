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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProfileConfiguration Marshaller
    /// </summary>
    public class ProfileConfigurationMarshaller : IRequestMarshaller<ProfileConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProfileConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetJobConfiguration())
            {
                context.Writer.WritePropertyName("JobConfiguration");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectJobConfigurationKvp in requestObject.JobConfiguration)
                {
                    context.Writer.WritePropertyName(requestObjectJobConfigurationKvp.Key);
                    var requestObjectJobConfigurationValue = requestObjectJobConfigurationKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationObjectMarshaller.Instance;
                    marshaller.Marshall(requestObjectJobConfigurationValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSessionConfiguration())
            {
                context.Writer.WritePropertyName("SessionConfiguration");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSessionConfigurationKvp in requestObject.SessionConfiguration)
                {
                    context.Writer.WritePropertyName(requestObjectSessionConfigurationKvp.Key);
                    var requestObjectSessionConfigurationValue = requestObjectSessionConfigurationKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ConfigurationObjectMarshaller.Instance;
                    marshaller.Marshall(requestObjectSessionConfigurationValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ProfileConfigurationMarshaller Instance = new ProfileConfigurationMarshaller();

    }
}