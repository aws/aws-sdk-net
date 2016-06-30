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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAccountAttributes operation.
    /// Lists all of the AWS DMS attributes for a customer account. The attributes include
    /// AWS DMS quotas for the account, such as the number of replication instances allowed.
    /// The description for a quota includes the quota name, current usage toward that quota,
    /// and the quota's maximum value.
    /// 
    ///  
    /// <para>
    /// This command does not take any parameters.
    /// </para>
    /// </summary>
    public partial class DescribeAccountAttributesRequest : AmazonDatabaseMigrationServiceRequest
    {

    }
}