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
    /// Container for the parameters to the DeleteProject operation.
    /// Deletes a project, including project resources. Does not delete users associated with
    /// the project, but does delete the IAM roles that allowed access to the project.
    /// </summary>
    public partial class DeleteProjectRequest : AmazonCodeStarRequest
    {
        private string _clientRequestToken;
        private bool? _deleteStack;
        private string _id;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A user- or system-generated token that identifies the entity that requested project
        /// deletion. This token can be used to repeat the request. 
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
        /// Gets and sets the property DeleteStack. 
        /// <para>
        /// Whether to send a delete request for the primary stack in AWS CloudFormation originally
        /// used to generate the project and its resources. This option will delete all AWS resources
        /// for the project (except for any buckets in Amazon S3) as well as deleting the project
        /// itself. Recommended for most use cases.
        /// </para>
        /// </summary>
        public bool DeleteStack
        {
            get { return this._deleteStack.GetValueOrDefault(); }
            set { this._deleteStack = value; }
        }

        // Check to see if DeleteStack property is set
        internal bool IsSetDeleteStack()
        {
            return this._deleteStack.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the project to be deleted in AWS CodeStar.
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

    }
}