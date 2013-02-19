/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Restore D B Instance To Point In Time Request Marshaller
    /// </summary>       
    public class RestoreDBInstanceToPointInTimeRequestMarshaller : IMarshaller<IRequest, RestoreDBInstanceToPointInTimeRequest>
    {
        public IRequest Marshall(RestoreDBInstanceToPointInTimeRequest restoreDBInstanceToPointInTimeRequest)
        {
            IRequest request = new DefaultRequest(restoreDBInstanceToPointInTimeRequest, "AmazonRDS");
            request.Parameters.Add("Action", "RestoreDBInstanceToPointInTime");
            request.Parameters.Add("Version", "2013-01-10");
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetSourceDBInstanceIdentifier())
            {
                request.Parameters.Add("SourceDBInstanceIdentifier", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.SourceDBInstanceIdentifier));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetTargetDBInstanceIdentifier())
            {
                request.Parameters.Add("TargetDBInstanceIdentifier", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.TargetDBInstanceIdentifier));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetRestoreTime())
            {
                request.Parameters.Add("RestoreTime", StringUtils.FromDateTime(restoreDBInstanceToPointInTimeRequest.RestoreTime));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetUseLatestRestorableTime())
            {
                request.Parameters.Add("UseLatestRestorableTime", StringUtils.FromBool(restoreDBInstanceToPointInTimeRequest.UseLatestRestorableTime));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetDBInstanceClass())
            {
                request.Parameters.Add("DBInstanceClass", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.DBInstanceClass));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetPort())
            {
                request.Parameters.Add("Port", StringUtils.FromInt(restoreDBInstanceToPointInTimeRequest.Port));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetAvailabilityZone())
            {
                request.Parameters.Add("AvailabilityZone", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.AvailabilityZone));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetDBSubnetGroupName())
            {
                request.Parameters.Add("DBSubnetGroupName", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.DBSubnetGroupName));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetMultiAZ())
            {
                request.Parameters.Add("MultiAZ", StringUtils.FromBool(restoreDBInstanceToPointInTimeRequest.MultiAZ));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetPubliclyAccessible())
            {
                request.Parameters.Add("PubliclyAccessible", StringUtils.FromBool(restoreDBInstanceToPointInTimeRequest.PubliclyAccessible));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetAutoMinorVersionUpgrade())
            {
                request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(restoreDBInstanceToPointInTimeRequest.AutoMinorVersionUpgrade));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetLicenseModel())
            {
                request.Parameters.Add("LicenseModel", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.LicenseModel));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetDBName())
            {
                request.Parameters.Add("DBName", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.DBName));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetEngine())
            {
                request.Parameters.Add("Engine", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.Engine));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetIops())
            {
                request.Parameters.Add("Iops", StringUtils.FromInt(restoreDBInstanceToPointInTimeRequest.Iops));
            }
            if (restoreDBInstanceToPointInTimeRequest != null && restoreDBInstanceToPointInTimeRequest.IsSetOptionGroupName())
            {
                request.Parameters.Add("OptionGroupName", StringUtils.FromString(restoreDBInstanceToPointInTimeRequest.OptionGroupName));
            }

            return request;
        }
    }
}
