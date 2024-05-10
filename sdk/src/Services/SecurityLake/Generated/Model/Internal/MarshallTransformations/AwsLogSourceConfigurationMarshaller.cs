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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityLake.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsLogSourceConfiguration Marshaller
    /// </summary>
    public class AwsLogSourceConfigurationMarshaller : IRequestMarshaller<AwsLogSourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsLogSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccounts())
            {
                context.Writer.WritePropertyName("accounts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAccountsListValue in requestObject.Accounts)
                {
                        context.Writer.Write(requestObjectAccountsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRegions())
            {
                context.Writer.WritePropertyName("regions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRegionsListValue in requestObject.Regions)
                {
                        context.Writer.Write(requestObjectRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSourceName())
            {
                context.Writer.WritePropertyName("sourceName");
                context.Writer.Write(requestObject.SourceName);
            }

            if(requestObject.IsSetSourceVersion())
            {
                context.Writer.WritePropertyName("sourceVersion");
                context.Writer.Write(requestObject.SourceVersion);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsLogSourceConfigurationMarshaller Instance = new AwsLogSourceConfigurationMarshaller();

    }
}