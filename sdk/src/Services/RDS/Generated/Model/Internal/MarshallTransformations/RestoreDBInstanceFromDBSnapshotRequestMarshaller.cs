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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreDBInstanceFromDBSnapshot Request Marshaller
    /// </summary>       
    public class RestoreDBInstanceFromDBSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreDBInstanceFromDBSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreDBInstanceFromDBSnapshotRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreDBInstanceFromDBSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "RestoreDBInstanceFromDBSnapshot");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAllocatedStorage())
                {
                    request.Parameters.Add("AllocatedStorage", StringUtils.FromInt(publicRequest.AllocatedStorage));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetBackupTarget())
                {
                    request.Parameters.Add("BackupTarget", StringUtils.FromString(publicRequest.BackupTarget));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCACertificateIdentifier())
                {
                    request.Parameters.Add("CACertificateIdentifier", StringUtils.FromString(publicRequest.CACertificateIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCopyTagsToSnapshot())
                {
                    request.Parameters.Add("CopyTagsToSnapshot", StringUtils.FromBool(publicRequest.CopyTagsToSnapshot));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCustomIamInstanceProfile())
                {
                    request.Parameters.Add("CustomIamInstanceProfile", StringUtils.FromString(publicRequest.CustomIamInstanceProfile));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBClusterSnapshotIdentifier())
                {
                    request.Parameters.Add("DBClusterSnapshotIdentifier", StringUtils.FromString(publicRequest.DBClusterSnapshotIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBInstanceClass())
                {
                    request.Parameters.Add("DBInstanceClass", StringUtils.FromString(publicRequest.DBInstanceClass));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBInstanceIdentifier())
                {
                    request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBName())
                {
                    request.Parameters.Add("DBName", StringUtils.FromString(publicRequest.DBName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBParameterGroupName())
                {
                    request.Parameters.Add("DBParameterGroupName", StringUtils.FromString(publicRequest.DBParameterGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBSnapshotIdentifier())
                {
                    request.Parameters.Add("DBSnapshotIdentifier", StringUtils.FromString(publicRequest.DBSnapshotIdentifier));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDBSubnetGroupName())
                {
                    request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(publicRequest.DBSubnetGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDedicatedLogVolume())
                {
                    request.Parameters.Add("DedicatedLogVolume", StringUtils.FromBool(publicRequest.DedicatedLogVolume));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDeletionProtection())
                {
                    request.Parameters.Add("DeletionProtection", StringUtils.FromBool(publicRequest.DeletionProtection));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomain())
                {
                    request.Parameters.Add("Domain", StringUtils.FromString(publicRequest.Domain));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainAuthSecretArn())
                {
                    request.Parameters.Add("DomainAuthSecretArn", StringUtils.FromString(publicRequest.DomainAuthSecretArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainDnsIps())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.DomainDnsIps)
                    {
                        request.Parameters.Add("DomainDnsIps" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainFqdn())
                {
                    request.Parameters.Add("DomainFqdn", StringUtils.FromString(publicRequest.DomainFqdn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainIAMRoleName())
                {
                    request.Parameters.Add("DomainIAMRoleName", StringUtils.FromString(publicRequest.DomainIAMRoleName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetDomainOu())
                {
                    request.Parameters.Add("DomainOu", StringUtils.FromString(publicRequest.DomainOu));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableCloudwatchLogsExports())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.EnableCloudwatchLogsExports)
                    {
                        request.Parameters.Add("EnableCloudwatchLogsExports" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableCustomerOwnedIp())
                {
                    request.Parameters.Add("EnableCustomerOwnedIp", StringUtils.FromBool(publicRequest.EnableCustomerOwnedIp));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnableIAMDatabaseAuthentication())
                {
                    request.Parameters.Add("EnableIAMDatabaseAuthentication", StringUtils.FromBool(publicRequest.EnableIAMDatabaseAuthentication));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetIops())
                {
                    request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLicenseModel())
                {
                    request.Parameters.Add("LicenseModel", StringUtils.FromString(publicRequest.LicenseModel));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMultiAZ())
                {
                    request.Parameters.Add("MultiAZ", StringUtils.FromBool(publicRequest.MultiAZ));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetNetworkType())
                {
                    request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOptionGroupName())
                {
                    request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetProcessorFeatures())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ProcessorFeatures)
                    {
                        if(publicRequestlistValue.IsSetName())
                        {
                            request.Parameters.Add("ProcessorFeatures" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestlistValue.Name));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("ProcessorFeatures" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPubliclyAccessible())
                {
                    request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStorageThroughput())
                {
                    request.Parameters.Add("StorageThroughput", StringUtils.FromInt(publicRequest.StorageThroughput));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStorageType())
                {
                    request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTdeCredentialArn())
                {
                    request.Parameters.Add("TdeCredentialArn", StringUtils.FromString(publicRequest.TdeCredentialArn));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTdeCredentialPassword())
                {
                    request.Parameters.Add("TdeCredentialPassword", StringUtils.FromString(publicRequest.TdeCredentialPassword));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetUseDefaultProcessorFeatures())
                {
                    request.Parameters.Add("UseDefaultProcessorFeatures", StringUtils.FromBool(publicRequest.UseDefaultProcessorFeatures));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetVpcSecurityGroupIds())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.VpcSecurityGroupIds)
                    {
                        request.Parameters.Add("VpcSecurityGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static RestoreDBInstanceFromDBSnapshotRequestMarshaller _instance = new RestoreDBInstanceFromDBSnapshotRequestMarshaller();        

        internal static RestoreDBInstanceFromDBSnapshotRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreDBInstanceFromDBSnapshotRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}