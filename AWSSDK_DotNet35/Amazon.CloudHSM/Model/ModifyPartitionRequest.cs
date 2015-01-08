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
    /// Container for the parameters to the ModifyPartition operation.
    /// Modifies a partition's attributes
    /// </summary>
    public partial class ModifyPartitionRequest : AmazonCloudHSMRequest
    {
        private string _partitionArn;
        private string _partitionLabel;

        /// <summary>
        /// Gets and sets the property PartitionArn.
        /// </summary>
        public string PartitionArn
        {
            get { return this._partitionArn; }
            set { this._partitionArn = value; }
        }

        // Check to see if PartitionArn property is set
        internal bool IsSetPartitionArn()
        {
            return this._partitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionLabel.
        /// </summary>
        public string PartitionLabel
        {
            get { return this._partitionLabel; }
            set { this._partitionLabel = value; }
        }

        // Check to see if PartitionLabel property is set
        internal bool IsSetPartitionLabel()
        {
            return this._partitionLabel != null;
        }

    }
}