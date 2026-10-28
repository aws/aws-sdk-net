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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the GetStorageInfo operation. Retrieves storage information
    /// for the Neptune database instance, including approximate total storage used and per-category
    /// size and entry counts. Storage categories include: <ul> <li> <para> <i>Quad indexes</i>
    /// - the indexes that store graph data, for both RDF (SPARQL) and Property Graph (Gremlin/openCypher)
    /// models. </para> </li> <li> <para> <i>Dictionaries</i> - the term dictionaries, including
    /// total dictionary storage and the portion used by blob (large value) entries. </para>
    /// </li> <li> <para> <i>Undo logs</i> - the undo logs, reported as a total size and the
    /// number of entries in the undo log list. </para> </li> <li> <para> <i>Streams</i> -
    /// the change-log streams. </para> </li> <li> <para> <i>Schema</i> - the schema. </para>
    /// </li> <li> <para> <i>DFE statistics</i> - the DFE engine statistics. </para> </li>
    /// <li> <para> <i>System metadata</i> - internal system metadata. </para> </li> </ul>
    /// <para> When invoking this operation in a Neptune cluster that has IAM authentication
    /// enabled, the IAM user or role making the request must have a policy attached that
    /// allows the <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#getstorageinfo">neptune-db:GetStorageInfo</a>
    /// IAM action in that cluster. </para>
    /// </summary>
    public partial class GetStorageInfoRequest : AmazonNeptunedataRequest
    {
    }
}
