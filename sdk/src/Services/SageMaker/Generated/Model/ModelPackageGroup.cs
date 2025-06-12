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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A group of versioned models in the Model Registry.
    /// </summary>
    public partial class ModelPackageGroup
    {
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _modelPackageGroupArn;
        private string _modelPackageGroupDescription;
        private string _modelPackageGroupName;
        private ModelPackageGroupStatus _modelPackageGroupStatus;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the model group was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelPackageGroupArn
        {
            get { return this._modelPackageGroupArn; }
            set { this._modelPackageGroupArn = value; }
        }

        // Check to see if ModelPackageGroupArn property is set
        internal bool IsSetModelPackageGroupArn()
        {
            return this._modelPackageGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupDescription. 
        /// <para>
        /// The description for the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ModelPackageGroupDescription
        {
            get { return this._modelPackageGroupDescription; }
            set { this._modelPackageGroupDescription = value; }
        }

        // Check to see if ModelPackageGroupDescription property is set
        internal bool IsSetModelPackageGroupDescription()
        {
            return this._modelPackageGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The name of the model group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelPackageGroupName
        {
            get { return this._modelPackageGroupName; }
            set { this._modelPackageGroupName = value; }
        }

        // Check to see if ModelPackageGroupName property is set
        internal bool IsSetModelPackageGroupName()
        {
            return this._modelPackageGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupStatus. 
        /// <para>
        /// The status of the model group. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The model group is pending being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_PROGRESS</c> - The model group is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETED</c> - The model group was successfully created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The model group failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The model group is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_FAILED</c> - SageMaker failed to delete the model group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelPackageGroupStatus ModelPackageGroupStatus
        {
            get { return this._modelPackageGroupStatus; }
            set { this._modelPackageGroupStatus = value; }
        }

        // Check to see if ModelPackageGroupStatus property is set
        internal bool IsSetModelPackageGroupStatus()
        {
            return this._modelPackageGroupStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tags associated with the model group. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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