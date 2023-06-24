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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the PutRetentionPolicy operation.
    /// Puts a retention policy to the specified organization.
    /// </summary>
    public partial class PutRetentionPolicyRequest : AmazonWorkMailRequest
    {
        private string _description;
        private List<FolderConfiguration> _folderConfigurations = new List<FolderConfiguration>();
        private string _id;
        private string _name;
        private string _organizationId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The retention policy description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=256)]
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
        /// Gets and sets the property FolderConfigurations. 
        /// <para>
        /// The retention policy folder configurations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FolderConfiguration> FolderConfigurations
        {
            get { return this._folderConfigurations; }
            set { this._folderConfigurations = value; }
        }

        // Check to see if FolderConfigurations property is set
        internal bool IsSetFolderConfigurations()
        {
            return this._folderConfigurations != null && this._folderConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The retention policy ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// The retention policy name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The organization ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

    }
}