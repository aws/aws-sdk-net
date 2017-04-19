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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a project in AWS CodeStar with minimal structure and no resources.
    /// </summary>
    public partial class CreateProjectRequest : AmazonCodeStarRequest
    {
        private string _clientRequestToken;
        private string _description;
        private string _id;
        private string _name;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A user- or system-generated token that identifies the entity that requested project
        /// creation. This token can be used to repeat the request. It can also be used to identify
        /// which user or system made the request in DescribeProject and ListProjects.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional. The description for the project.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID for the AWS CodeStar project. Project IDs must be unique within an AWS account.
        /// Project IDs cannot exceed 15 characters and cannot contain capital letters and other
        /// restricted symbols. For more information, see <a href="http://docs.aws.amazon.com/codestar/latest/userguide/limits.html">Limits</a>
        /// in the AWS CodeStar User Guide.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The friendly name for the project. This friendly name serves as the basis for the
        /// names for resources associated with the project, such as a repository name in AWS
        /// CodeCommit. The name is limited to 100 characters and cannot contain certain restricted
        /// symbols. For more information, see <a href="http://docs.aws.amazon.com/codestar/latest/userguide/limits.html">Limits</a>
        /// in the AWS CodeStar User Guide.
        /// </para>
        /// </summary>
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

    }
}