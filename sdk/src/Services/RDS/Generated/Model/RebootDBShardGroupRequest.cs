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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RebootDBShardGroup operation.
    /// You might need to reboot your DB shard group, usually for maintenance reasons. For
    /// example, if you make certain modifications, reboot the DB shard group for the changes
    /// to take effect.
    /// 
    ///  
    /// <para>
    /// This operation applies only to Aurora Limitless Database DBb shard groups.
    /// </para>
    /// </summary>
    public partial class RebootDBShardGroupRequest : AmazonRDSRequest
    {
        private string _dbShardGroupIdentifier;

        /// <summary>
        /// Gets and sets the property DBShardGroupIdentifier. 
        /// <para>
        /// The name of the DB shard group to reboot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DBShardGroupIdentifier
        {
            get { return this._dbShardGroupIdentifier; }
            set { this._dbShardGroupIdentifier = value; }
        }

        // Check to see if DBShardGroupIdentifier property is set
        internal bool IsSetDBShardGroupIdentifier()
        {
            return this._dbShardGroupIdentifier != null;
        }

    }
}