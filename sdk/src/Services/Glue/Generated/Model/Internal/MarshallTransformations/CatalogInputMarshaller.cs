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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CatalogInput Marshaller
    /// </summary>
    public class CatalogInputMarshaller : IRequestMarshaller<CatalogInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CatalogInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowFullTableExternalDataAccess())
            {
                context.Writer.WritePropertyName("AllowFullTableExternalDataAccess");
                context.Writer.Write(requestObject.AllowFullTableExternalDataAccess);
            }

            if(requestObject.IsSetCatalogProperties())
            {
                context.Writer.WritePropertyName("CatalogProperties");
                context.Writer.WriteObjectStart();

                var marshaller = CatalogPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.CatalogProperties, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateDatabaseDefaultPermissions())
            {
                context.Writer.WritePropertyName("CreateDatabaseDefaultPermissions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCreateDatabaseDefaultPermissionsListValue in requestObject.CreateDatabaseDefaultPermissions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PrincipalPermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreateDatabaseDefaultPermissionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCreateTableDefaultPermissions())
            {
                context.Writer.WritePropertyName("CreateTableDefaultPermissions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCreateTableDefaultPermissionsListValue in requestObject.CreateTableDefaultPermissions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = PrincipalPermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreateTableDefaultPermissionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetFederatedCatalog())
            {
                context.Writer.WritePropertyName("FederatedCatalog");
                context.Writer.WriteObjectStart();

                var marshaller = FederatedCatalogMarshaller.Instance;
                marshaller.Marshall(requestObject.FederatedCatalog, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.Write(requestObjectParametersValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTargetRedshiftCatalog())
            {
                context.Writer.WritePropertyName("TargetRedshiftCatalog");
                context.Writer.WriteObjectStart();

                var marshaller = TargetRedshiftCatalogMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetRedshiftCatalog, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CatalogInputMarshaller Instance = new CatalogInputMarshaller();

    }
}