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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAllowExternalDataFiltering())
            {
                context.Writer.WritePropertyName("AllowExternalDataFiltering");
                context.Writer.Write(requestObject.AllowExternalDataFiltering);
            }

            if(requestObject.IsSetAllowFullTableExternalDataAccess())
            {
                context.Writer.WritePropertyName("AllowFullTableExternalDataAccess");
                context.Writer.Write(requestObject.AllowFullTableExternalDataAccess);
            }

            if(requestObject.IsSetAuthorizedSessionTagValueList())
            {
                context.Writer.WritePropertyName("AuthorizedSessionTagValueList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAuthorizedSessionTagValueListListValue in requestObject.AuthorizedSessionTagValueList)
                {
                        context.Writer.Write(requestObjectAuthorizedSessionTagValueListListValue);
                }
                context.Writer.WriteArrayEnd();
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

            if(requestObject.IsSetDataLakeAdmins())
            {
                context.Writer.WritePropertyName("DataLakeAdmins");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataLakeAdminsListValue in requestObject.DataLakeAdmins)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataLakeAdminsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExternalDataFilteringAllowList())
            {
                context.Writer.WritePropertyName("ExternalDataFilteringAllowList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExternalDataFilteringAllowListListValue in requestObject.ExternalDataFilteringAllowList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectExternalDataFilteringAllowListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
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

            if(requestObject.IsSetReadOnlyAdmins())
            {
                context.Writer.WritePropertyName("ReadOnlyAdmins");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectReadOnlyAdminsListValue in requestObject.ReadOnlyAdmins)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(requestObjectReadOnlyAdminsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTrustedResourceOwners())
            {
                context.Writer.WritePropertyName("TrustedResourceOwners");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTrustedResourceOwnersListValue in requestObject.TrustedResourceOwners)
                {
                        context.Writer.Write(requestObjectTrustedResourceOwnersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataLakeSettingsMarshaller Instance = new DataLakeSettingsMarshaller();

    }
}