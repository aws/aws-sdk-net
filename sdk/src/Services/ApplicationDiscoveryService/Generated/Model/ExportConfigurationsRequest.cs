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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the ExportConfigurations operation.
    /// Exports all discovered configuration data to an Amazon S3 bucket or an application
    /// that enables you to view and evaluate the data. Data includes tags and tag associations,
    /// processes, connections, servers, and system performance. This API returns an export
    /// ID which you can query using the <i>GetExportStatus</i> API. The system imposes a
    /// limit of two configuration exports in six hours.
    /// </summary>
    public partial class ExportConfigurationsRequest : AmazonApplicationDiscoveryServiceRequest
    {

    }
}