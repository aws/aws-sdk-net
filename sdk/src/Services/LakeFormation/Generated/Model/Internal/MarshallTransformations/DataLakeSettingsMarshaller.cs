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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataLakeSettings Marshaller
    /// </summary>
    public class DataLakeSettingsMarshaller : IRequestMarshaller<DataLakeSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataLakeSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowExternalDataFiltering())
            {
                context.Writer.WritePropertyName("AllowExternalDataFiltering");
                context.Writer.WriteBooleanValue(requestObject.AllowExternalDataFiltering.Value);
            }

            if(requestObject.IsSetAllowFullTableExternalDataAccess())
            {
                context.Writer.WritePropertyName("AllowFullTableExternalDataAccess");
                context.Writer.WriteBooleanValue(requestObject.AllowFullTableExternalDataAccess.Value);
            }

            if(requestObject.IsSetAuthorizedSessionTagValueList())
            {
                context.Writer.WritePropertyName("AuthorizedSessionTagValueList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAuthorizedSessionTagValueListListValue in requestObject.AuthorizedSessionTagValueList)
                {
                        context.Writer.WriteStringValue(requestObjectAuthorizedSessionTagValueListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreateDatabaseDefaultPermissions())
            {
                context.Writer.WritePropertyName("CreateDatabaseDefaultPermissions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCreateDatabaseDefaultPermissionsListValue in requestObject.CreateDatabaseDefaultPermissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PrincipalPermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreateDatabaseDefaultPermissionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCreateTableDefaultPermissions())
            {
                context.Writer.WritePropertyName("CreateTableDefaultPermissions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCreateTableDefaultPermissionsListValue in requestObject.CreateTableDefaultPermissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PrincipalPermissionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCreateTableDefaultPermissionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDataLakeAdmins())
            {
                context.Writer.WritePropertyName("DataLakeAdmins");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDataLakeAdminsListValue in requestObject.DataLakeAdmins)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataLakeAdminsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExternalDataFilteringAllowList())
            {
                context.Writer.WritePropertyName("ExternalDataFilteringAllowList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExternalDataFilteringAllowListListValue in requestObject.ExternalDataFilteringAllowList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectExternalDataFilteringAllowListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReadOnlyAdmins())
            {
                context.Writer.WritePropertyName("ReadOnlyAdmins");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReadOnlyAdminsListValue in requestObject.ReadOnlyAdmins)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectReadOnlyAdminsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTrustedResourceOwners())
            {
                context.Writer.WritePropertyName("TrustedResourceOwners");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTrustedResourceOwnersListValue in requestObject.TrustedResourceOwners)
                {
                        context.Writer.WriteStringValue(requestObjectTrustedResourceOwnersListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataLakeSettingsMarshaller Instance = new DataLakeSettingsMarshaller();

    }
}