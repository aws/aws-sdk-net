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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyHapg operation.
    /// Modifies an existing high-availability partition group.
    /// </summary>
    public partial class ModifyHapgRequest : AmazonCloudHSMRequest
    {
        private string _hapgArn;
        private string _label;
        private List<string> _partitionSerialList = new List<string>();

        /// <summary>
        /// Gets and sets the property HapgArn. 
        /// <para>
        /// The ARN of the high-availability partition group to modify.
        /// </para>
        /// </summary>
        public string HapgArn
        {
            get { return this._hapgArn; }
            set { this._hapgArn = value; }
        }

        // Check to see if HapgArn property is set
        internal bool IsSetHapgArn()
        {
            return this._hapgArn != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The new label for the high-availability partition group.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionSerialList. 
        /// <para>
        /// The list of partition serial numbers to make members of the high-availability partition
        /// group.
        /// </para>
        /// </summary>
        public List<string> PartitionSerialList
        {
            get { return this._partitionSerialList; }
            set { this._partitionSerialList = value; }
        }

        // Check to see if PartitionSerialList property is set
        internal bool IsSetPartitionSerialList()
        {
            return this._partitionSerialList != null && this._partitionSerialList.Count > 0; 
        }

    }
}