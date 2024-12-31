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

#pragma warning disable CS0612,CS0618
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GlueConnectionInput Marshaller
    /// </summary>
    public class GlueConnectionInputMarshaller : IRequestMarshaller<GlueConnectionInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GlueConnectionInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAthenaProperties())
            {
                context.Writer.WritePropertyName("athenaProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAthenaPropertiesKvp in requestObject.AthenaProperties)
                {
                    context.Writer.WritePropertyName(requestObjectAthenaPropertiesKvp.Key);
                    var requestObjectAthenaPropertiesValue = requestObjectAthenaPropertiesKvp.Value;

                        context.Writer.Write(requestObjectAthenaPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAuthenticationConfiguration())
            {
                context.Writer.WritePropertyName("authenticationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AuthenticationConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthenticationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnectionProperties())
            {
                context.Writer.WritePropertyName("connectionProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectConnectionPropertiesKvp in requestObject.ConnectionProperties)
                {
                    context.Writer.WritePropertyName(requestObjectConnectionPropertiesKvp.Key);
                    var requestObjectConnectionPropertiesValue = requestObjectConnectionPropertiesKvp.Value;

                        context.Writer.Write(requestObjectConnectionPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnectionType())
            {
                context.Writer.WritePropertyName("connectionType");
                context.Writer.Write(requestObject.ConnectionType);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetMatchCriteria())
            {
                context.Writer.WritePropertyName("matchCriteria");
                context.Writer.Write(requestObject.MatchCriteria);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPhysicalConnectionRequirements())
            {
                context.Writer.WritePropertyName("physicalConnectionRequirements");
                context.Writer.WriteObjectStart();

                var marshaller = PhysicalConnectionRequirementsMarshaller.Instance;
                marshaller.Marshall(requestObject.PhysicalConnectionRequirements, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPythonProperties())
            {
                context.Writer.WritePropertyName("pythonProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPythonPropertiesKvp in requestObject.PythonProperties)
                {
                    context.Writer.WritePropertyName(requestObjectPythonPropertiesKvp.Key);
                    var requestObjectPythonPropertiesValue = requestObjectPythonPropertiesKvp.Value;

                        context.Writer.Write(requestObjectPythonPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkProperties())
            {
                context.Writer.WritePropertyName("sparkProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSparkPropertiesKvp in requestObject.SparkProperties)
                {
                    context.Writer.WritePropertyName(requestObjectSparkPropertiesKvp.Key);
                    var requestObjectSparkPropertiesValue = requestObjectSparkPropertiesKvp.Value;

                        context.Writer.Write(requestObjectSparkPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetValidateCredentials())
            {
                context.Writer.WritePropertyName("validateCredentials");
                context.Writer.Write(requestObject.ValidateCredentials);
            }

            if(requestObject.IsSetValidateForComputeEnvironments())
            {
                context.Writer.WritePropertyName("validateForComputeEnvironments");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectValidateForComputeEnvironmentsListValue in requestObject.ValidateForComputeEnvironments)
                {
                        context.Writer.Write(requestObjectValidateForComputeEnvironmentsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GlueConnectionInputMarshaller Instance = new GlueConnectionInputMarshaller();

    }
}