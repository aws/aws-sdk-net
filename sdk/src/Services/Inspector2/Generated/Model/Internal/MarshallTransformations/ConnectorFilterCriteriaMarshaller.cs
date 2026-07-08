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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Inspector2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Inspector2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConnectorFilterCriteria Marshaller
    /// </summary>
    public class ConnectorFilterCriteriaMarshaller : IRequestMarshaller<ConnectorFilterCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectorFilterCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccounts())
            {
                context.Writer.WritePropertyName("accounts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAccountsListValue in requestObject.Accounts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = StringFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAccountsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAwsConfigConnectorArns())
            {
                context.Writer.WritePropertyName("awsConfigConnectorArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAwsConfigConnectorArnsListValue in requestObject.AwsConfigConnectorArns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsConfigConnectorArnFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectAwsConfigConnectorArnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetConnectorArns())
            {
                context.Writer.WritePropertyName("connectorArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConnectorArnsListValue in requestObject.ConnectorArns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConnectorArnFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectConnectorArnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetConnectorType())
            {
                context.Writer.WritePropertyName("connectorType");
                context.Writer.WriteStartArray();
                foreach(var requestObjectConnectorTypeListValue in requestObject.ConnectorType)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ConnectorTypeFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectConnectorTypeListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetProvider())
            {
                context.Writer.WritePropertyName("provider");
                context.Writer.WriteStartArray();
                foreach(var requestObjectProviderListValue in requestObject.Provider)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProviderFilterMarshaller.Instance;
                    marshaller.Marshall(requestObjectProviderListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectorFilterCriteriaMarshaller Instance = new ConnectorFilterCriteriaMarshaller();

    }
}