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
    /// The properties of an experiment as returned by the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
    /// API. For information about experiments, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateExperiment.html">CreateExperiment</a>
    /// API.
    /// </summary>
    public partial class Experiment
    {
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _description;
        private string _displayName;
        private string _experimentArn;
        private string _experimentName;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private ExperimentSource _source;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created the experiment.
        /// </para>
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
        /// When the experiment was created.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3072)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the experiment as displayed. If <c>DisplayName</c> isn't specified, <c>ExperimentName</c>
        /// is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ExperimentArn
        {
            get { return this._experimentArn; }
            set { this._experimentArn = value; }
        }

        // Check to see if ExperimentArn property is set
        internal bool IsSetExperimentArn()
        {
            return this._experimentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExperimentName. 
        /// <para>
        /// The name of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=120)]
        public string ExperimentName
        {
            get { return this._experimentName; }
            set { this._experimentName = value; }
        }

        // Check to see if ExperimentName property is set
        internal bool IsSetExperimentName()
        {
            return this._experimentName != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the experiment was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source.
        /// </summary>
        public ExperimentSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags that are associated with the experiment. You can use <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html">Search</a>
        /// API to search on the tags.
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