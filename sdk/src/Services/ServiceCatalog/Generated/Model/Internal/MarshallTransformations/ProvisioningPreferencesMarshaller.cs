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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ServiceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ProvisioningPreferences Marshaller
    /// </summary>       
    public class ProvisioningPreferencesMarshaller : IRequestMarshaller<ProvisioningPreferences, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ProvisioningPreferences requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetStackSetAccounts())
            {
                context.Writer.WritePropertyName("StackSetAccounts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStackSetAccountsListValue in requestObject.StackSetAccounts)
                {
                        context.Writer.Write(requestObjectStackSetAccountsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStackSetFailureToleranceCount())
            {
                context.Writer.WritePropertyName("StackSetFailureToleranceCount");
                context.Writer.Write(requestObject.StackSetFailureToleranceCount);
            }

            if(requestObject.IsSetStackSetFailureTolerancePercentage())
            {
                context.Writer.WritePropertyName("StackSetFailureTolerancePercentage");
                context.Writer.Write(requestObject.StackSetFailureTolerancePercentage);
            }

            if(requestObject.IsSetStackSetMaxConcurrencyCount())
            {
                context.Writer.WritePropertyName("StackSetMaxConcurrencyCount");
                context.Writer.Write(requestObject.StackSetMaxConcurrencyCount);
            }

            if(requestObject.IsSetStackSetMaxConcurrencyPercentage())
            {
                context.Writer.WritePropertyName("StackSetMaxConcurrencyPercentage");
                context.Writer.Write(requestObject.StackSetMaxConcurrencyPercentage);
            }

            if(requestObject.IsSetStackSetRegions())
            {
                context.Writer.WritePropertyName("StackSetRegions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectStackSetRegionsListValue in requestObject.StackSetRegions)
                {
                        context.Writer.Write(requestObjectStackSetRegionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ProvisioningPreferencesMarshaller Instance = new ProvisioningPreferencesMarshaller();

    }
}