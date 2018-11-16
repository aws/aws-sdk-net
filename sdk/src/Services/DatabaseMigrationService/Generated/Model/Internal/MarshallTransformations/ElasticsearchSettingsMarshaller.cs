/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ElasticsearchSettings Marshaller
    /// </summary>       
    public class ElasticsearchSettingsMarshaller : IRequestMarshaller<ElasticsearchSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ElasticsearchSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetEndpointUri())
            {
                context.Writer.WritePropertyName("EndpointUri");
                context.Writer.Write(requestObject.EndpointUri);
            }

            if(requestObject.IsSetErrorRetryDuration())
            {
                context.Writer.WritePropertyName("ErrorRetryDuration");
                context.Writer.Write(requestObject.ErrorRetryDuration);
            }

            if(requestObject.IsSetFullLoadErrorPercentage())
            {
                context.Writer.WritePropertyName("FullLoadErrorPercentage");
                context.Writer.Write(requestObject.FullLoadErrorPercentage);
            }

            if(requestObject.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.Write(requestObject.ServiceAccessRoleArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ElasticsearchSettingsMarshaller Instance = new ElasticsearchSettingsMarshaller();

    }
}