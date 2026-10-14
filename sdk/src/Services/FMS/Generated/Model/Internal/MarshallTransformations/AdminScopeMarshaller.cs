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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AdminScope Marshaller
    /// </summary>
    public class AdminScopeMarshaller : IRequestMarshaller<AdminScope, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AdminScope requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetAccountScope())
            {
                context.Writer.WriteTextString("AccountScope");
                context.Writer.WriteStartMap(null);

                var marshaller = AccountScopeMarshaller.Instance;
                marshaller.Marshall(requestObject.AccountScope, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetOrganizationalUnitScope())
            {
                context.Writer.WriteTextString("OrganizationalUnitScope");
                context.Writer.WriteStartMap(null);

                var marshaller = OrganizationalUnitScopeMarshaller.Instance;
                marshaller.Marshall(requestObject.OrganizationalUnitScope, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetPolicyTypeScope())
            {
                context.Writer.WriteTextString("PolicyTypeScope");
                context.Writer.WriteStartMap(null);

                var marshaller = PolicyTypeScopeMarshaller.Instance;
                marshaller.Marshall(requestObject.PolicyTypeScope, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetRegionScope())
            {
                context.Writer.WriteTextString("RegionScope");
                context.Writer.WriteStartMap(null);

                var marshaller = RegionScopeMarshaller.Instance;
                marshaller.Marshall(requestObject.RegionScope, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AdminScopeMarshaller Instance = new AdminScopeMarshaller();

    }
}