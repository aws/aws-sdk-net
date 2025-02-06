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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Athena.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Athena.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// QueryResultsS3AccessGrantsConfiguration Marshaller
    /// </summary>
    public class QueryResultsS3AccessGrantsConfigurationMarshaller : IRequestMarshaller<QueryResultsS3AccessGrantsConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(QueryResultsS3AccessGrantsConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuthenticationType())
            {
                context.Writer.WritePropertyName("AuthenticationType");
                context.Writer.WriteStringValue(requestObject.AuthenticationType);
            }

            if(requestObject.IsSetCreateUserLevelPrefix())
            {
                context.Writer.WritePropertyName("CreateUserLevelPrefix");
                context.Writer.WriteBooleanValue(requestObject.CreateUserLevelPrefix.Value);
            }

            if(requestObject.IsSetEnableS3AccessGrants())
            {
                context.Writer.WritePropertyName("EnableS3AccessGrants");
                context.Writer.WriteBooleanValue(requestObject.EnableS3AccessGrants.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static QueryResultsS3AccessGrantsConfigurationMarshaller Instance = new QueryResultsS3AccessGrantsConfigurationMarshaller();

    }
}