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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteDBSubnetGroup operation.
    /// Deletes a DB subnet group.
    /// 
    ///  <note> 
    /// <para>
    /// The specified database subnet group must not be associated with any DB instances.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteDBSubnetGroupRequest : AmazonNeptuneRequest
    {
        private string _dbSubnetGroupName;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The name of the database subnet group to delete.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't delete the default subnet group.
        /// </para>
        ///  </note> 
        /// <para>
        /// Constraints:
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must match the name of an existing DBSubnetGroup. Must not be default.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>mySubnetgroup</code> 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

    }
}