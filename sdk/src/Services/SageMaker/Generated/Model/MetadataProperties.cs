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
    /// Metadata properties of the tracking entity, trial, or trial component.
    /// </summary>
    public partial class MetadataProperties
    {
        private string _commitId;
        private string _generatedBy;
        private string _projectId;
        private string _repository;

        /// <summary>
        /// Gets and sets the property CommitId. 
        /// <para>
        /// The commit ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string CommitId
        {
            get { return this._commitId; }
            set { this._commitId = value; }
        }

        // Check to see if CommitId property is set
        internal bool IsSetCommitId()
        {
            return this._commitId != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedBy. 
        /// <para>
        /// The entity this entity was generated by.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string GeneratedBy
        {
            get { return this._generatedBy; }
            set { this._generatedBy = value; }
        }

        // Check to see if GeneratedBy property is set
        internal bool IsSetGeneratedBy()
        {
            return this._generatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The project ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The repository.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

    }
}