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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// This is the response object from the AssociateRepository operation.
    /// </summary>
    public partial class AssociateRepositoryResponse : AmazonWebServiceResponse
    {
        private RepositoryAssociation _repositoryAssociation;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property RepositoryAssociation. 
        /// <para>
        /// Information about the repository association.
        /// </para>
        /// </summary>
        public RepositoryAssociation RepositoryAssociation
        {
            get { return this._repositoryAssociation; }
            set { this._repositoryAssociation = value; }
        }

        // Check to see if RepositoryAssociation property is set
        internal bool IsSetRepositoryAssociation()
        {
            return this._repositoryAssociation != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  An array of key-value pairs used to tag an associated repository. A tag is a custom
        /// attribute label with two parts: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A <i>tag key</i> (for example, <code>CostCenter</code>, <code>Environment</code>,
        /// <code>Project</code>, or <code>Secret</code>). Tag keys are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An optional field known as a <i>tag value</i> (for example, <code>111122223333</code>,
        /// <code>Production</code>, or a team name). Omitting the tag value is the same as using
        /// an empty string. Like tag keys, tag values are case sensitive.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}