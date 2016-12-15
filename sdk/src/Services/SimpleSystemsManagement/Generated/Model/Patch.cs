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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Represents metadata about a patch.
    /// </summary>
    public partial class Patch
    {
        private string _classification;
        private string _contentUrl;
        private string _description;
        private string _id;
        private string _kbNumber;
        private string _language;
        private string _msrcNumber;
        private string _msrcSeverity;
        private string _product;
        private string _productFamily;
        private DateTime? _releaseDate;
        private string _title;
        private string _vendor;

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the patch (for example, SecurityUpdates, Updates, CriticalUpdates).
        /// </para>
        /// </summary>
        public string Classification
        {
            get { return this._classification; }
            set { this._classification = value; }
        }

        // Check to see if Classification property is set
        internal bool IsSetClassification()
        {
            return this._classification != null;
        }

        /// <summary>
        /// Gets and sets the property ContentUrl. 
        /// <para>
        /// The URL where more information can be obtained about the patch.
        /// </para>
        /// </summary>
        public string ContentUrl
        {
            get { return this._contentUrl; }
            set { this._contentUrl = value; }
        }

        // Check to see if ContentUrl property is set
        internal bool IsSetContentUrl()
        {
            return this._contentUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the patch.
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
        /// The ID of the patch (this is different than the Microsoft Knowledge Base ID).
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
        /// Gets and sets the property KbNumber. 
        /// <para>
        /// The Microsoft Knowledge Base ID of the patch.
        /// </para>
        /// </summary>
        public string KbNumber
        {
            get { return this._kbNumber; }
            set { this._kbNumber = value; }
        }

        // Check to see if KbNumber property is set
        internal bool IsSetKbNumber()
        {
            return this._kbNumber != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language of the patch if it’s language-specific.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property MsrcNumber. 
        /// <para>
        /// The ID of the MSRC bulletin the patch is related to.
        /// </para>
        /// </summary>
        public string MsrcNumber
        {
            get { return this._msrcNumber; }
            set { this._msrcNumber = value; }
        }

        // Check to see if MsrcNumber property is set
        internal bool IsSetMsrcNumber()
        {
            return this._msrcNumber != null;
        }

        /// <summary>
        /// Gets and sets the property MsrcSeverity. 
        /// <para>
        /// The severity of the patch (for example Critical, Important, Moderate).
        /// </para>
        /// </summary>
        public string MsrcSeverity
        {
            get { return this._msrcSeverity; }
            set { this._msrcSeverity = value; }
        }

        // Check to see if MsrcSeverity property is set
        internal bool IsSetMsrcSeverity()
        {
            return this._msrcSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The specific product the patch is applicable for (for example, WindowsServer2016).
        /// </para>
        /// </summary>
        public string Product
        {
            get { return this._product; }
            set { this._product = value; }
        }

        // Check to see if Product property is set
        internal bool IsSetProduct()
        {
            return this._product != null;
        }

        /// <summary>
        /// Gets and sets the property ProductFamily. 
        /// <para>
        /// The product family the patch is applicable for (for example, Windows).
        /// </para>
        /// </summary>
        public string ProductFamily
        {
            get { return this._productFamily; }
            set { this._productFamily = value; }
        }

        // Check to see if ProductFamily property is set
        internal bool IsSetProductFamily()
        {
            return this._productFamily != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date the patch was released.
        /// </para>
        /// </summary>
        public DateTime ReleaseDate
        {
            get { return this._releaseDate.GetValueOrDefault(); }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the patch.
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

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The name of the vendor providing the patch.
        /// </para>
        /// </summary>
        public string Vendor
        {
            get { return this._vendor; }
            set { this._vendor = value; }
        }

        // Check to see if Vendor property is set
        internal bool IsSetVendor()
        {
            return this._vendor != null;
        }

    }
}