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
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DatabaseInput Marshaller
    /// </summary>
    public class DatabaseInputMarshaller : IRequestMarshaller<DatabaseInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DatabaseInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCreateTableDefaultPermissions())
            {
                context.Writer.WritePropertyName("CreateTableDefaultPermissions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCreateTableDefaultPermissionsListValue in requestObject.CreateTableDefaultPermissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PrincipalPermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreateTableDefaultPermissionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFederatedDatabase())
            {
                context.Writer.WritePropertyName("FederatedDatabase");
                context.Writer.WriteStartObject();

                var marshaller = FederatedDatabaseMarshaller.Instance;
                marshaller.Marshall(requestObject.FederatedDatabase, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLocationUri())
            {
                context.Writer.WritePropertyName("LocationUri");
                context.Writer.WriteStringValue(requestObject.LocationUri);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTargetDatabase())
            {
                context.Writer.WritePropertyName("TargetDatabase");
                context.Writer.WriteStartObject();

                var marshaller = DatabaseIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetDatabase, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatabaseInputMarshaller Instance = new DatabaseInputMarshaller();

    }
}