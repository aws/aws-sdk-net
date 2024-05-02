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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the published asset for which the subscription grant is created.
    /// </summary>
    public partial class SubscribedListing
    {
        private string _description;
        private string _id;
        private SubscribedListingItem _item;
        private string _name;
        private string _ownerProjectId;
        private string _ownerProjectName;
        private string _revision;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=2048)]
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
        /// The identifier of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Item. 
        /// <para>
        /// The published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscribedListingItem Item
        {
            get { return this._item; }
            set { this._item = value; }
        }

        // Check to see if Item property is set
        internal bool IsSetItem()
        {
            return this._item != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the published asset for which the subscription grant is created.
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
        /// Gets and sets the property OwnerProjectId. 
        /// <para>
        /// The identifier of the project of the published asset for which the subscription grant
        /// is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwnerProjectId
        {
            get { return this._ownerProjectId; }
            set { this._ownerProjectId = value; }
        }

        // Check to see if OwnerProjectId property is set
        internal bool IsSetOwnerProjectId()
        {
            return this._ownerProjectId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerProjectName. 
        /// <para>
        /// The name of the project that owns the published asset for which the subscription grant
        /// is created.
        /// </para>
        /// </summary>
        public string OwnerProjectName
        {
            get { return this._ownerProjectName; }
            set { this._ownerProjectName = value; }
        }

        // Check to see if OwnerProjectName property is set
        internal bool IsSetOwnerProjectName()
        {
            return this._ownerProjectName != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the published asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}