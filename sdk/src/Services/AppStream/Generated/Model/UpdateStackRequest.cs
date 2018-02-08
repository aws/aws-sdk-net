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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStack operation.
    /// Updates the specified stack.
    /// </summary>
    public partial class UpdateStackRequest : AmazonAppStreamRequest
    {
        private List<string> _attributesToDelete = new List<string>();
        private bool? _deleteStorageConnectors;
        private string _description;
        private string _displayName;
        private string _name;
        private string _redirectURL;
        private List<StorageConnector> _storageConnectors = new List<StorageConnector>();

        /// <summary>
        /// Gets and sets the property AttributesToDelete. 
        /// <para>
        /// The stack attributes to delete.
        /// </para>
        /// </summary>
        public List<string> AttributesToDelete
        {
            get { return this._attributesToDelete; }
            set { this._attributesToDelete = value; }
        }

        // Check to see if AttributesToDelete property is set
        internal bool IsSetAttributesToDelete()
        {
            return this._attributesToDelete != null && this._attributesToDelete.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeleteStorageConnectors. 
        /// <para>
        /// Deletes the storage connectors currently enabled for the stack.
        /// </para>
        /// </summary>
        public bool DeleteStorageConnectors
        {
            get { return this._deleteStorageConnectors.GetValueOrDefault(); }
            set { this._deleteStorageConnectors = value; }
        }

        // Check to see if DeleteStorageConnectors property is set
        internal bool IsSetDeleteStorageConnectors()
        {
            return this._deleteStorageConnectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for display.
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
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The stack name for display.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the stack.
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
        /// Gets and sets the property RedirectURL. 
        /// <para>
        /// The URL the user is redirected to after the streaming session ends.
        /// </para>
        /// </summary>
        public string RedirectURL
        {
            get { return this._redirectURL; }
            set { this._redirectURL = value; }
        }

        // Check to see if RedirectURL property is set
        internal bool IsSetRedirectURL()
        {
            return this._redirectURL != null;
        }

        /// <summary>
        /// Gets and sets the property StorageConnectors. 
        /// <para>
        /// The storage connectors to enable.
        /// </para>
        /// </summary>
        public List<StorageConnector> StorageConnectors
        {
            get { return this._storageConnectors; }
            set { this._storageConnectors = value; }
        }

        // Check to see if StorageConnectors property is set
        internal bool IsSetStorageConnectors()
        {
            return this._storageConnectors != null && this._storageConnectors.Count > 0; 
        }

    }
}