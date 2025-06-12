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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatasetGroup operation.
    /// Creates an empty dataset group. A dataset group is a container for Amazon Personalize
    /// resources. A dataset group can contain at most three datasets, one for each type of
    /// dataset:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Item interactions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Items
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Users
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Actions
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Action interactions
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  A dataset group can be a Domain dataset group, where you specify a domain and use
    /// pre-configured resources like recommenders, or a Custom dataset group, where you use
    /// custom resources, such as a solution with a solution version, that you deploy with
    /// a campaign. If you start with a Domain dataset group, you can still add custom resources
    /// such as solutions and solution versions trained with recipes for custom use cases
    /// and deployed with campaigns. 
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
    /// To get the status of the dataset group, call <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>.
    /// If the status shows as CREATE FAILED, the response includes a <c>failureReason</c>
    /// key, which describes why the creation failed.
    /// </para>
    ///  <note> 
    /// <para>
    /// You must wait until the <c>status</c> of the dataset group is <c>ACTIVE</c> before
    /// adding a dataset to the group.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can specify an Key Management Service (KMS) key to encrypt the datasets in the
    /// group. If you specify a KMS key, you must also include an Identity and Access Management
    /// (IAM) role that has permission to access the key.
    /// </para>
    ///  
    /// <para>
    ///  <b>APIs that require a dataset group ARN in the request</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateDataset.html">CreateDataset</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateSolution.html">CreateSolution</a>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Related APIs</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_ListDatasetGroups.html">ListDatasetGroups</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DescribeDatasetGroup.html">DescribeDatasetGroup</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_DeleteDatasetGroup.html">DeleteDatasetGroup</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDatasetGroupRequest : AmazonPersonalizeRequest
    {
        private Domain _domain;
        private string _kmsKeyArn;
        private string _name;
        private string _roleArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain of the dataset group. Specify a domain to create a Domain dataset group.
        /// The domain you specify determines the default schemas for datasets and the use cases
        /// available for recommenders. If you don't specify a domain, you create a Custom dataset
        /// group with solution versions that you deploy with a campaign. 
        /// </para>
        /// </summary>
        public Domain Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Key Management Service (KMS) key used to encrypt
        /// the datasets.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// The ARN of the Identity and Access Management (IAM) role that has permissions to access
        /// the Key Management Service (KMS) key. Supplying an IAM role is only valid when also
        /// specifying a KMS key.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of <a href="https://docs.aws.amazon.com/personalize/latest/dg/tagging-resources.html">tags</a>
        /// to apply to the dataset group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}