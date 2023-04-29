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
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OrganizationalUnitScope Marshaller
    /// </summary>
    public class OrganizationalUnitScopeMarshaller : IRequestMarshaller<OrganizationalUnitScope, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(OrganizationalUnitScope requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAllOrganizationalUnitsEnabled())
            {
                context.Writer.WritePropertyName("AllOrganizationalUnitsEnabled");
                context.Writer.Write(requestObject.AllOrganizationalUnitsEnabled);
            }

            if(requestObject.IsSetExcludeSpecifiedOrganizationalUnits())
            {
                context.Writer.WritePropertyName("ExcludeSpecifiedOrganizationalUnits");
                context.Writer.Write(requestObject.ExcludeSpecifiedOrganizationalUnits);
            }

            if(requestObject.IsSetOrganizationalUnits())
            {
                context.Writer.WritePropertyName("OrganizationalUnits");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOrganizationalUnitsListValue in requestObject.OrganizationalUnits)
                {
                        context.Writer.Write(requestObjectOrganizationalUnitsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static OrganizationalUnitScopeMarshaller Instance = new OrganizationalUnitScopeMarshaller();

    }
}