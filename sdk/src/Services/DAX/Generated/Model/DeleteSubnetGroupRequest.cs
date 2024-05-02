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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
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
namespace Amazon.DAX.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteSubnetGroup operation.
    /// Deletes a subnet group.
    /// 
    ///  <note> 
    /// <para>
    /// You cannot delete a subnet group if it is associated with any DAX clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DeleteSubnetGroupRequest : AmazonDAXRequest
    {
        private string _subnetGroupName;

        /// <summary>
        /// Gets and sets the property SubnetGroupName. 
        /// <para>
        /// The name of the subnet group to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubnetGroupName
        {
            get { return this._subnetGroupName; }
            set { this._subnetGroupName = value; }
        }

        // Check to see if SubnetGroupName property is set
        internal bool IsSetSubnetGroupName()
        {
            return this._subnetGroupName != null;
        }

    }
}