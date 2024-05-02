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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a target for a pull request.
    /// </summary>
    public partial class Target
    {
        private string _destinationReference;
        private string _repositoryName;
        private string _sourceReference;

        /// <summary>
        /// Gets and sets the property DestinationReference. 
        /// <para>
        /// The branch of the repository where the pull request changes are merged. Also known
        /// as the destination branch.
        /// </para>
        /// </summary>
        public string DestinationReference
        {
            get { return this._destinationReference; }
            set { this._destinationReference = value; }
        }

        // Check to see if DestinationReference property is set
        internal bool IsSetDestinationReference()
        {
            return this._destinationReference != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that contains the pull request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

        /// <summary>
        /// Gets and sets the property SourceReference. 
        /// <para>
        /// The branch of the repository that contains the changes for the pull request. Also
        /// known as the source branch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceReference
        {
            get { return this._sourceReference; }
            set { this._sourceReference = value; }
        }

        // Check to see if SourceReference property is set
        internal bool IsSetSourceReference()
        {
            return this._sourceReference != null;
        }

    }
}