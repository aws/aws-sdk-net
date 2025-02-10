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
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DatabaseConfiguration Marshaller
    /// </summary>
    public class DatabaseConfigurationMarshaller : IRequestMarshaller<DatabaseConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DatabaseConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAclConfiguration())
            {
                context.Writer.WritePropertyName("AclConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AclConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AclConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetColumnConfiguration())
            {
                context.Writer.WritePropertyName("ColumnConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ColumnConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ColumnConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnectionConfiguration())
            {
                context.Writer.WritePropertyName("ConnectionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ConnectionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectionConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabaseEngineType())
            {
                context.Writer.WritePropertyName("DatabaseEngineType");
                context.Writer.WriteStringValue(requestObject.DatabaseEngineType);
            }

            if(requestObject.IsSetSqlConfiguration())
            {
                context.Writer.WritePropertyName("SqlConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SqlConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SqlConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DatabaseConfigurationMarshaller Instance = new DatabaseConfigurationMarshaller();

    }
}