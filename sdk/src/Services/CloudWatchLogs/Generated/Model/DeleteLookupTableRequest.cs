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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteLookupTable operation.
    /// Deletes a lookup table permanently. This operation cannot be undone.
    /// 
    ///  
    /// <para>
    /// Queries that reference a deleted table will return an error. Before deleting a lookup
    /// table, review any saved queries or dashboards that may reference it.
    /// </para>
    /// </summary>
    public partial class DeleteLookupTableRequest : AmazonCloudWatchLogsRequest
    {
        private string _lookupTableArn;

        /// <summary>
        /// Gets and sets the property LookupTableArn. 
        /// <para>
        /// The ARN of the lookup table to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LookupTableArn
        {
            get { return this._lookupTableArn; }
            set { this._lookupTableArn = value; }
        }

        // Check to see if LookupTableArn property is set
        internal bool IsSetLookupTableArn()
        {
            return this._lookupTableArn != null;
        }

    }
}