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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExperienceConfiguration Marshaller
    /// </summary>
    public class ExperienceConfigurationMarshaller : IRequestMarshaller<ExperienceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExperienceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetContentSourceConfiguration())
            {
                context.Writer.WritePropertyName("ContentSourceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ContentSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ContentSourceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUserIdentityConfiguration())
            {
                context.Writer.WritePropertyName("UserIdentityConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = UserIdentityConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.UserIdentityConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExperienceConfigurationMarshaller Instance = new ExperienceConfigurationMarshaller();

    }
}