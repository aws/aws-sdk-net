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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MarketplaceCatalog.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MarketplaceCatalog.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FrameworkFilters Marshaller
    /// </summary>
    public class FrameworkFiltersMarshaller : IRequestMarshaller<FrameworkFilters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FrameworkFilters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAMISecurityFilters())
            {
                context.Writer.WritePropertyName("AMISecurityFilters");
                context.Writer.WriteStartObject();

                var marshaller = AMISecurityFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.AMISecurityFilters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainerSecurityFilters())
            {
                context.Writer.WritePropertyName("ContainerSecurityFilters");
                context.Writer.WriteStartObject();

                var marshaller = ContainerSecurityFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerSecurityFilters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FrameworkFiltersMarshaller Instance = new FrameworkFiltersMarshaller();

    }
}