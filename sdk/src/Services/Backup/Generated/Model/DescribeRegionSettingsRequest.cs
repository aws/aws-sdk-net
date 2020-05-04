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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRegionSettings operation.
    /// Returns the current service opt-in settings for the region. If the service has a value
    /// set to true, AWS Backup will attempt to protect that service's resources in this region,
    /// when included in an on-demand backup or scheduled backup plan. If the value is set
    /// to false for a service, AWS Backup will not attempt to protect that service's resources
    /// in this region.
    /// </summary>
    public partial class DescribeRegionSettingsRequest : AmazonBackupRequest
    {

    }
}