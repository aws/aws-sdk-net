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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBParameterGroup operation.
    /// Deletes a specified DB parameter group. The DB parameter group to be deleted can't
    /// be associated with any DB instances.
    /// </summary>
    public partial class DeleteDBParameterGroupRequest : AmazonRDSRequest
    {
        private string _dbParameterGroupName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDBParameterGroupRequest() { }

        /// <summary>
        /// Instantiates DeleteDBParameterGroupRequest with the parameterized properties
        /// </summary>
        /// <param name="dbParameterGroupName">The name of the DB parameter group. Constraints: <ul> <li> Must be the name of an existing DB parameter group </li> <li> You can't delete a default DB parameter group </li> <li> Can't be associated with any DB instances </li> </ul></param>
        public DeleteDBParameterGroupRequest(string dbParameterGroupName)
        {
            _dbParameterGroupName = dbParameterGroupName;
        }

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be the name of an existing DB parameter group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can't delete a default DB parameter group
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Can't be associated with any DB instances
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBParameterGroupName
        {
            get { return this._dbParameterGroupName; }
            set { this._dbParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dbParameterGroupName != null;
        }

    }
}