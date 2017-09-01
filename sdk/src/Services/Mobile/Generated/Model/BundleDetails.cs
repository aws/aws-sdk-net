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
 * Do not modify this file. This file is generated from the mobile-2017-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mobile.Model
{
    /// <summary>
    /// The details of the bundle.
    /// </summary>
    public partial class BundleDetails
    {
        private List<string> _availablePlatforms = new List<string>();
        private string _bundleId;
        private string _description;
        private string _iconUrl;
        private string _title;
        private string _version;

        /// <summary>
        /// Gets and sets the property AvailablePlatforms.
        /// </summary>
        public List<string> AvailablePlatforms
        {
            get { return this._availablePlatforms; }
            set { this._availablePlatforms = value; }
        }

        // Check to see if AvailablePlatforms property is set
        internal bool IsSetAvailablePlatforms()
        {
            return this._availablePlatforms != null && this._availablePlatforms.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property BundleId.
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
        /// Gets and sets the property Description.
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
        /// Gets and sets the property IconUrl.
        /// </summary>
        public string IconUrl
        {
            get { return this._iconUrl; }
            set { this._iconUrl = value; }
        }

        // Check to see if IconUrl property is set
        internal bool IsSetIconUrl()
        {
            return this._iconUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Title.
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

        /// <summary>
        /// Gets and sets the property Version.
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}