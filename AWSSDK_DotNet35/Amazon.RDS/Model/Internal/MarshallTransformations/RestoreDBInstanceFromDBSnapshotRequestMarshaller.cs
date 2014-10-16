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
 * Do not modify this file. This file is generated from the rds-2014-09-01.normal.json service model.
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
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreDBInstanceFromDBSnapshot Request Marshaller
    /// </summary>       
    public class RestoreDBInstanceFromDBSnapshotRequestMarshaller : IMarshaller<IRequest, RestoreDBInstanceFromDBSnapshotRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreDBInstanceFromDBSnapshotRequest)input);
        }
    
        public IRequest Marshall(RestoreDBInstanceFromDBSnapshotRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RDS");
            request.Parameters.Add("Action", "RestoreDBInstanceFromDBSnapshot");
            request.Parameters.Add("Version", "2014-09-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
                if(publicRequest.IsSetAvailabilityZone())
                {
                    request.Parameters.Add("AvailabilityZone", StringUtils.FromString(publicRequest.AvailabilityZone));
                }
                if(publicRequest.IsSetDBInstanceClass())
                {
                    request.Parameters.Add("DBInstanceClass", StringUtils.FromString(publicRequest.DBInstanceClass));
                }
                if(publicRequest.IsSetDBInstanceIdentifier())
                {
                    request.Parameters.Add("DBInstanceIdentifier", StringUtils.FromString(publicRequest.DBInstanceIdentifier));
                }
                if(publicRequest.IsSetDBName())
                {
                    request.Parameters.Add("DBName", StringUtils.FromString(publicRequest.DBName));
                }
                if(publicRequest.IsSetDBSnapshotIdentifier())
                {
                    request.Parameters.Add("DBSnapshotIdentifier", StringUtils.FromString(publicRequest.DBSnapshotIdentifier));
                }
                if(publicRequest.IsSetDBSubnetGroupName())
                {
                    request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(publicRequest.DBSubnetGroupName));
                }
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
                if(publicRequest.IsSetIops())
                {
                    request.Parameters.Add("Iops", StringUtils.FromInt(publicRequest.Iops));
                }
                if(publicRequest.IsSetLicenseModel())
                {
                    request.Parameters.Add("LicenseModel", StringUtils.FromString(publicRequest.LicenseModel));
                }
                if(publicRequest.IsSetMultiAZ())
                {
                    request.Parameters.Add("MultiAZ", StringUtils.FromBool(publicRequest.MultiAZ));
                }
                if(publicRequest.IsSetOptionGroupName())
                {
                    request.Parameters.Add("OptionGroupName", StringUtils.FromString(publicRequest.OptionGroupName));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetPubliclyAccessible())
                {
                    request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(publicRequest.PubliclyAccessible));
                }
                if(publicRequest.IsSetStorageType())
                {
                    request.Parameters.Add("StorageType", StringUtils.FromString(publicRequest.StorageType));
                }
                if(publicRequest.IsSetTags())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Tags)
                    {
                        if(publicRequestlistValue.IsSetKey())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                        }
                        if(publicRequestlistValue.IsSetValue())
                        {
                            request.Parameters.Add("Tags" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetTdeCredentialArn())
                {
                    request.Parameters.Add("TdeCredentialArn", StringUtils.FromString(publicRequest.TdeCredentialArn));
                }
                if(publicRequest.IsSetTdeCredentialPassword())
                {
                    request.Parameters.Add("TdeCredentialPassword", StringUtils.FromString(publicRequest.TdeCredentialPassword));
                }
            }
            return request;
        }
    }
}