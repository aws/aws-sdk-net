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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsRdsDbInstanceDetails Marshaller
    /// </summary>       
    public class AwsRdsDbInstanceDetailsMarshaller : IRequestMarshaller<AwsRdsDbInstanceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsRdsDbInstanceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAssociatedRoles())
            {
                context.Writer.WritePropertyName("AssociatedRoles");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAssociatedRolesListValue in requestObject.AssociatedRoles)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbInstanceAssociatedRoleMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociatedRolesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCACertificateIdentifier())
            {
                context.Writer.WritePropertyName("CACertificateIdentifier");
                context.Writer.Write(requestObject.CACertificateIdentifier);
            }

            if(requestObject.IsSetDBClusterIdentifier())
            {
                context.Writer.WritePropertyName("DBClusterIdentifier");
                context.Writer.Write(requestObject.DBClusterIdentifier);
            }

            if(requestObject.IsSetDBInstanceClass())
            {
                context.Writer.WritePropertyName("DBInstanceClass");
                context.Writer.Write(requestObject.DBInstanceClass);
            }

            if(requestObject.IsSetDBInstanceIdentifier())
            {
                context.Writer.WritePropertyName("DBInstanceIdentifier");
                context.Writer.Write(requestObject.DBInstanceIdentifier);
            }

            if(requestObject.IsSetDbInstancePort())
            {
                context.Writer.WritePropertyName("DbInstancePort");
                context.Writer.Write(requestObject.DbInstancePort);
            }

            if(requestObject.IsSetDbiResourceId())
            {
                context.Writer.WritePropertyName("DbiResourceId");
                context.Writer.Write(requestObject.DbiResourceId);
            }

            if(requestObject.IsSetDBName())
            {
                context.Writer.WritePropertyName("DBName");
                context.Writer.Write(requestObject.DBName);
            }

            if(requestObject.IsSetDeletionProtection())
            {
                context.Writer.WritePropertyName("DeletionProtection");
                context.Writer.Write(requestObject.DeletionProtection);
            }

            if(requestObject.IsSetEndpoint())
            {
                context.Writer.WritePropertyName("Endpoint");
                context.Writer.WriteObjectStart();

                var marshaller = AwsRdsDbInstanceEndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.Endpoint, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEngine())
            {
                context.Writer.WritePropertyName("Engine");
                context.Writer.Write(requestObject.Engine);
            }

            if(requestObject.IsSetEngineVersion())
            {
                context.Writer.WritePropertyName("EngineVersion");
                context.Writer.Write(requestObject.EngineVersion);
            }

            if(requestObject.IsSetIAMDatabaseAuthenticationEnabled())
            {
                context.Writer.WritePropertyName("IAMDatabaseAuthenticationEnabled");
                context.Writer.Write(requestObject.IAMDatabaseAuthenticationEnabled);
            }

            if(requestObject.IsSetInstanceCreateTime())
            {
                context.Writer.WritePropertyName("InstanceCreateTime");
                context.Writer.Write(requestObject.InstanceCreateTime);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.Write(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetPubliclyAccessible())
            {
                context.Writer.WritePropertyName("PubliclyAccessible");
                context.Writer.Write(requestObject.PubliclyAccessible);
            }

            if(requestObject.IsSetStorageEncrypted())
            {
                context.Writer.WritePropertyName("StorageEncrypted");
                context.Writer.Write(requestObject.StorageEncrypted);
            }

            if(requestObject.IsSetTdeCredentialArn())
            {
                context.Writer.WritePropertyName("TdeCredentialArn");
                context.Writer.Write(requestObject.TdeCredentialArn);
            }

            if(requestObject.IsSetVpcSecurityGroups())
            {
                context.Writer.WritePropertyName("VpcSecurityGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectVpcSecurityGroupsListValue in requestObject.VpcSecurityGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsRdsDbInstanceVpcSecurityGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectVpcSecurityGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsRdsDbInstanceDetailsMarshaller Instance = new AwsRdsDbInstanceDetailsMarshaller();

    }
}