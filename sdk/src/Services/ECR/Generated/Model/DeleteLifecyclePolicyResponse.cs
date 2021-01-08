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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// This is the response object from the DeleteLifecyclePolicy operation.
    /// </summary>
    public partial class DeleteLifecyclePolicyResponse : AmazonWebServiceResponse
    {
        private DateTime? _lastEvaluatedAt;
        private string _lifecyclePolicyText;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property LastEvaluatedAt. 
        /// <para>
        /// The time stamp of the last time that the lifecycle policy was run.
        /// </para>
        /// </summary>
        public DateTime LastEvaluatedAt
        {
            get { return this._lastEvaluatedAt.GetValueOrDefault(); }
            set { this._lastEvaluatedAt = value; }
        }

        // Check to see if LastEvaluatedAt property is set
        internal bool IsSetLastEvaluatedAt()
        {
            return this._lastEvaluatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LifecyclePolicyText. 
        /// <para>
        /// The JSON lifecycle policy text.
        /// </para>
        /// </summary>
        [AWSProperty(Min=100, Max=30720)]
        public string LifecyclePolicyText
        {
            get { return this._lifecyclePolicyText; }
            set { this._lifecyclePolicyText = value; }
        }

        // Check to see if LifecyclePolicyText property is set
        internal bool IsSetLifecyclePolicyText()
        {
            return this._lifecyclePolicyText != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The registry ID associated with the request.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The repository name associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}