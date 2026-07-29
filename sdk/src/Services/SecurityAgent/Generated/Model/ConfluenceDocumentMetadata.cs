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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Metadata for an integrated Confluence document.
    /// </summary>
    public partial class ConfluenceDocumentMetadata
    {
        private string _name;
        private string _pageId;
        private string _providerResourceId;
        private string _spaceKey;
        private string _spaceTitle;
        private string _title;

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PageId. 
        /// <para>
        /// The Confluence page identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PageId
        {
            get { return this._pageId; }
            set { this._pageId = value; }
        }

        // Check to see if PageId property is set
        internal bool IsSetPageId()
        {
            return this._pageId != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderResourceId.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProviderResourceId
        {
            get { return this._providerResourceId; }
            set { this._providerResourceId = value; }
        }

        // Check to see if ProviderResourceId property is set
        internal bool IsSetProviderResourceId()
        {
            return this._providerResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceKey. 
        /// <para>
        /// The Confluence space key containing the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SpaceKey
        {
            get { return this._spaceKey; }
            set { this._spaceKey = value; }
        }

        // Check to see if SpaceKey property is set
        internal bool IsSetSpaceKey()
        {
            return this._spaceKey != null;
        }

        /// <summary>
        /// Gets and sets the property SpaceTitle. 
        /// <para>
        /// The display title of the Confluence space.
        /// </para>
        /// </summary>
        public string SpaceTitle
        {
            get { return this._spaceTitle; }
            set { this._spaceTitle = value; }
        }

        // Check to see if SpaceTitle property is set
        internal bool IsSetSpaceTitle()
        {
            return this._spaceTitle != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The display title of the Confluence page.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}