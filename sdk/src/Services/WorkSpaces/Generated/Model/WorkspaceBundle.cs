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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a WorkSpace bundle.
    /// </summary>
    public partial class WorkspaceBundle
    {
        private string _bundleId;
        private ComputeType _computeType;
        private string _description;
        private string _name;
        private string _owner;
        private RootStorage _rootStorage;
        private UserStorage _userStorage;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle identifier.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// The compute type. For more information, see <a href="http://aws.amazon.com/workspaces/details/#Amazon_WorkSpaces_Bundles">Amazon
        /// WorkSpaces Bundles</a>.
        /// </para>
        /// </summary>
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bundle.
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

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the bundle. This is the account identifier of the owner, or <code>AMAZON</code>
        /// if the bundle is provided by AWS.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property RootStorage. 
        /// <para>
        /// The size of the root volume.
        /// </para>
        /// </summary>
        public RootStorage RootStorage
        {
            get { return this._rootStorage; }
            set { this._rootStorage = value; }
        }

        // Check to see if RootStorage property is set
        internal bool IsSetRootStorage()
        {
            return this._rootStorage != null;
        }

        /// <summary>
        /// Gets and sets the property UserStorage. 
        /// <para>
        /// The size of the user storage.
        /// </para>
        /// </summary>
        public UserStorage UserStorage
        {
            get { return this._userStorage; }
            set { this._userStorage = value; }
        }

        // Check to see if UserStorage property is set
        internal bool IsSetUserStorage()
        {
            return this._userStorage != null;
        }

    }
}