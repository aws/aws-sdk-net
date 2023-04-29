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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApiKeyRestrictions Marshaller
    /// </summary>
    public class ApiKeyRestrictionsMarshaller : IRequestMarshaller<ApiKeyRestrictions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ApiKeyRestrictions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllowActions())
            {
                context.Writer.WritePropertyName("AllowActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowActionsListValue in requestObject.AllowActions)
                {
                        context.Writer.Write(requestObjectAllowActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAllowReferers())
            {
                context.Writer.WritePropertyName("AllowReferers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowReferersListValue in requestObject.AllowReferers)
                {
                        context.Writer.Write(requestObjectAllowReferersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAllowResources())
            {
                context.Writer.WritePropertyName("AllowResources");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowResourcesListValue in requestObject.AllowResources)
                {
                        context.Writer.Write(requestObjectAllowResourcesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ApiKeyRestrictionsMarshaller Instance = new ApiKeyRestrictionsMarshaller();

    }
}