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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatasetGroup operation.
    /// Creates an empty dataset group. A dataset group contains related datasets that supply
    /// data for training a model. A dataset group can contain at most three datasets, one
    /// for each type of dataset:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Interactions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Items
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Users
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To train a model (create a solution), a dataset group that contains an <code>Interactions</code>
    /// dataset is required. Call <a>CreateDataset</a> to add a dataset to the group.
    /// </para>
    ///  
    /// <para>
    /// A dataset group can be in one of the following states:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CREATE PENDING &gt; CREATE IN_PROGRESS &gt; ACTIVE -or- CREATE FAILED
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DELETE PENDING
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get the status of the dataset group, call <a>DescribeDatasetGroup</a>. If the status
    /// shows as CREATE FAILED, the response includes a <code>failureReason</code> key, which
    /// describes why the creation failed.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must wait until the <code>status</code> of the dataset group is <code>ACTIVE</code>
    /// before adding a dataset to the group.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can specify an AWS Key Management Service (KMS) key to encrypt the datasets in
    /// the group. If you specify a KMS key, you must also include an AWS Identity and Access
    /// Management (IAM) role that has permission to access the key.
    /// </para>
    ///  <p class="title"> <b>APIs that require a dataset group ARN in the request</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateDataset</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateEventTracker</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateSolution</a> 
    /// </para>
    ///  </li> </ul> <p class="title"> <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListDatasetGroups</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeDatasetGroup</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteDatasetGroup</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDatasetGroupRequest : AmazonPersonalizeRequest
    {
        private string _kmsKeyArn;
        private string _name;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a KMS key used to encrypt the datasets.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the new dataset group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that has permissions to access the KMS key. Supplying an IAM
        /// role is only valid when also specifying a KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}