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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftRunConfigurationInput Marshaller
    /// </summary>
    public class RedshiftRunConfigurationInputMarshaller : IRequestMarshaller<RedshiftRunConfigurationInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftRunConfigurationInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataAccessRole())
            {
                context.Writer.WritePropertyName("dataAccessRole");
                context.Writer.Write(requestObject.DataAccessRole);
            }

            if(requestObject.IsSetRedshiftCredentialConfiguration())
            {
                context.Writer.WritePropertyName("redshiftCredentialConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftCredentialConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftCredentialConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRedshiftStorage())
            {
                context.Writer.WritePropertyName("redshiftStorage");
                context.Writer.WriteObjectStart();

                var marshaller = RedshiftStorageMarshaller.Instance;
                marshaller.Marshall(requestObject.RedshiftStorage, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRelationalFilterConfigurations())
            {
                context.Writer.WritePropertyName("relationalFilterConfigurations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRelationalFilterConfigurationsListValue in requestObject.RelationalFilterConfigurations)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = RelationalFilterConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectRelationalFilterConfigurationsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RedshiftRunConfigurationInputMarshaller Instance = new RedshiftRunConfigurationInputMarshaller();

    }
}