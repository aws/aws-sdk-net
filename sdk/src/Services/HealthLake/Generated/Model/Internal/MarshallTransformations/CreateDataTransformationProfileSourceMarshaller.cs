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
 * Do not modify this file. This file is generated from the healthlake-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.HealthLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.HealthLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDataTransformationProfileSource Marshaller
    /// </summary>
    public class CreateDataTransformationProfileSourceMarshaller : IRequestMarshaller<CreateDataTransformationProfileSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateDataTransformationProfileSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExistingVersionedProfileId())
            {
                context.Writer.WritePropertyName("ExistingVersionedProfileId");
                context.Writer.WriteStartObject();

                var marshaller = ExistingVersionedProfileSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.ExistingVersionedProfileId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetProfileMapping())
            {
                context.Writer.WritePropertyName("ProfileMapping");
                context.Writer.WriteStartObject();

                var marshaller = ProfileMappingSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.ProfileMapping, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSampleData())
            {
                context.Writer.WritePropertyName("SampleData");
                context.Writer.WriteStartObject();

                var marshaller = SampleDataSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.SampleData, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStarterProfile())
            {
                context.Writer.WritePropertyName("StarterProfile");
                context.Writer.WriteStartObject();

                var marshaller = StarterProfileSourceMarshaller.Instance;
                marshaller.Marshall(requestObject.StarterProfile, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateDataTransformationProfileSourceMarshaller Instance = new CreateDataTransformationProfileSourceMarshaller();

    }
}