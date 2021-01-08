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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RedshiftDataParameters Marshaller
    /// </summary>       
    public class RedshiftDataParametersMarshaller : IRequestMarshaller<RedshiftDataParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RedshiftDataParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDatabase())
            {
                context.Writer.WritePropertyName("Database");
                context.Writer.Write(requestObject.Database);
            }

            if(requestObject.IsSetDbUser())
            {
                context.Writer.WritePropertyName("DbUser");
                context.Writer.Write(requestObject.DbUser);
            }

            if(requestObject.IsSetSecretManagerArn())
            {
                context.Writer.WritePropertyName("SecretManagerArn");
                context.Writer.Write(requestObject.SecretManagerArn);
            }

            if(requestObject.IsSetSql())
            {
                context.Writer.WritePropertyName("Sql");
                context.Writer.Write(requestObject.Sql);
            }

            if(requestObject.IsSetStatementName())
            {
                context.Writer.WritePropertyName("StatementName");
                context.Writer.Write(requestObject.StatementName);
            }

            if(requestObject.IsSetWithEvent())
            {
                context.Writer.WritePropertyName("WithEvent");
                context.Writer.Write(requestObject.WithEvent);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RedshiftDataParametersMarshaller Instance = new RedshiftDataParametersMarshaller();

    }
}