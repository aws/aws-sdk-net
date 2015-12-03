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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the results of a successful call to the <a>DescribeDBSnapshotAttributes</a>
    /// API.
    /// 
    ///  
    /// <para>
    /// Manual DB snapshot attributes are used to authorize other AWS accounts to copy or
    /// restore a manual DB snapshot. For more information, see the <a>ModifyDBSnapshotAttribute</a>
    /// API.
    /// </para>
    /// </summary>
    public partial class ModifyDBSnapshotAttributeResponse : AmazonWebServiceResponse
    {
        private DBSnapshotAttributesResult _response;

        /// <summary>
        /// Gets and sets the DBSnapshotAttributesResult property.
        /// </summary>
        public DBSnapshotAttributesResult DBSnapshotAttributesResult
        {
            get { return this._response; }
            set { this._response = value; }
        }
    }
}