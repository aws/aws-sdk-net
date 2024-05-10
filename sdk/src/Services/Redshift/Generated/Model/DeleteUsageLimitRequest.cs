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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteUsageLimit operation.
    /// Deletes a usage limit from a cluster.
    /// </summary>
    public partial class DeleteUsageLimitRequest : AmazonRedshiftRequest
    {
        private string _usageLimitId;

        /// <summary>
        /// Gets and sets the property UsageLimitId. 
        /// <para>
        /// The identifier of the usage limit to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string UsageLimitId
        {
            get { return this._usageLimitId; }
            set { this._usageLimitId = value; }
        }

        // Check to see if UsageLimitId property is set
        internal bool IsSetUsageLimitId()
        {
            return this._usageLimitId != null;
        }

    }
}