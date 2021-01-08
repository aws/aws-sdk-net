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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RdsHttpEndpointConfig Marshaller
    /// </summary>       
    public class RdsHttpEndpointConfigMarshaller : IRequestMarshaller<RdsHttpEndpointConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RdsHttpEndpointConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAwsRegion())
            {
                context.Writer.WritePropertyName("awsRegion");
                context.Writer.Write(requestObject.AwsRegion);
            }

            if(requestObject.IsSetAwsSecretStoreArn())
            {
                context.Writer.WritePropertyName("awsSecretStoreArn");
                context.Writer.Write(requestObject.AwsSecretStoreArn);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("databaseName");
                context.Writer.Write(requestObject.DatabaseName);
            }

            if(requestObject.IsSetDbClusterIdentifier())
            {
                context.Writer.WritePropertyName("dbClusterIdentifier");
                context.Writer.Write(requestObject.DbClusterIdentifier);
            }

            if(requestObject.IsSetSchema())
            {
                context.Writer.WritePropertyName("schema");
                context.Writer.Write(requestObject.Schema);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static RdsHttpEndpointConfigMarshaller Instance = new RdsHttpEndpointConfigMarshaller();

    }
}