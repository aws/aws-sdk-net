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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBClusterParameterGroup operation. Deletes
    /// a specified DB cluster parameter group. The DB cluster parameter group to be deleted
    /// can't be associated with any DB clusters.
    /// </summary>
    public partial class DeleteDBClusterParameterGroupRequest : AmazonNeptuneRequest
    {
        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the name of an existing DB cluster parameter group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't delete a default DB cluster parameter group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be associated with any DB clusters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBClusterParameterGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterParameterGroupName property is set.
        /// </summary>
        internal bool IsSetDBClusterParameterGroupName() => this.DBClusterParameterGroupName != null;
    }
}
