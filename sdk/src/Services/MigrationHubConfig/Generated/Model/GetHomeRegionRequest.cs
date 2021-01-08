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
 * Do not modify this file. This file is generated from the migrationhub-config-2019-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubConfig.Model
{
    /// <summary>
    /// Container for the parameters to the GetHomeRegion operation.
    /// Returns the calling account’s home region, if configured. This API is used by other
    /// AWS services to determine the regional endpoint for calling AWS Application Discovery
    /// Service and Migration Hub. You must call <code>GetHomeRegion</code> at least once
    /// before you call any other AWS Application Discovery Service and AWS Migration Hub
    /// APIs, to obtain the account's Migration Hub home region.
    /// </summary>
    public partial class GetHomeRegionRequest : AmazonMigrationHubConfigRequest
    {

    }
}