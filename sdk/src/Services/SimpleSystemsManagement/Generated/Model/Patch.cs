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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Represents metadata about a patch.
    /// </summary>
    public partial class Patch
    {
        private List<string> _advisoryIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _arch;
        private List<string> _bugzillaIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _classification;
        private string _contentUrl;
        private List<string> _cveIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private int? _epoch;
        private string _id;
        private string _kbNumber;
        private string _language;
        private string _msrcNumber;
        private string _msrcSeverity;
        private string _name;
        private string _product;
        private string _productFamily;
        private string _release;
        private DateTime? _releaseDate;
        private string _repository;
        private string _severity;
        private string _title;
        private string _vendor;
        private string _version;

        /// <summary>
        /// Gets and sets the property AdvisoryIds. 
        /// <para>
        /// The Advisory ID of the patch. For example, <c>RHSA-2020:3779</c>. Applies to Linux-based
        /// managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdvisoryIds
        {
            get { return this._advisoryIds; }
            set { this._advisoryIds = value; }
        }

        // Check to see if AdvisoryIds property is set
        internal bool IsSetAdvisoryIds()
        {
            return this._advisoryIds != null && (this._advisoryIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Arch. 
        /// <para>
        /// The architecture of the patch. For example, in <c>example-pkg-0.710.10-2.7.abcd.x86_64</c>,
        /// the architecture is indicated by <c>x86_64</c>. Applies to Linux-based managed nodes
        /// only.
        /// </para>
        /// </summary>
        public string Arch
        {
            get { return this._arch; }
            set { this._arch = value; }
        }

        // Check to see if Arch property is set
        internal bool IsSetArch()
        {
            return this._arch != null;
        }

        /// <summary>
        /// Gets and sets the property BugzillaIds. 
        /// <para>
        /// The Bugzilla ID of the patch. For example, <c>1600646</c>. Applies to Linux-based
        /// managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BugzillaIds
        {
            get { return this._bugzillaIds; }
            set { this._bugzillaIds = value; }
        }

        // Check to see if BugzillaIds property is set
        internal bool IsSetBugzillaIds()
        {
            return this._bugzillaIds != null && (this._bugzillaIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the patch. For example, <c>SecurityUpdates</c>, <c>Updates</c>,
        /// or <c>CriticalUpdates</c>.
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
        /// Gets and sets the property CVEIds. 
        /// <para>
        /// The Common Vulnerabilities and Exposures (CVE) ID of the patch. For example, <c>CVE-2011-3192</c>.
        /// Applies to Linux-based managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CVEIds
        {
            get { return this._cveIds; }
            set { this._cveIds = value; }
        }

        // Check to see if CVEIds property is set
        internal bool IsSetCVEIds()
        {
            return this._cveIds != null && (this._cveIds.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property Epoch. 
        /// <para>
        /// The epoch of the patch. For example in <c>pkg-example-EE-20180914-2.2.amzn1.noarch</c>,
        /// the epoch value is <c>20180914-2</c>. Applies to Linux-based managed nodes only.
        /// </para>
        /// </summary>
        public int? Epoch
        {
            get { return this._epoch; }
            set { this._epoch = value; }
        }

        // Check to see if Epoch property is set
        internal bool IsSetEpoch()
        {
            return this._epoch.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the patch. Applies to Windows patches only.
        /// </para>
        ///  <note> 
        /// <para>
        /// This ID isn't the same as the Microsoft Knowledge Base ID.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// The Microsoft Knowledge Base ID of the patch. Applies to Windows patches only.
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
        /// The language of the patch if it's language-specific.
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
        /// The ID of the Microsoft Security Response Center (MSRC) bulletin the patch is related
        /// to. For example, <c>MS14-045</c>. Applies to Windows patches only.
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
        /// The severity of the patch, such as <c>Critical</c>, <c>Important</c>, or <c>Moderate</c>.
        /// Applies to Windows patches only.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the patch. Applies to Linux-based managed nodes only.
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
        /// Gets and sets the property Product. 
        /// <para>
        /// The specific product the patch is applicable for. For example, <c>WindowsServer2016</c>
        /// or <c>AmazonLinux2018.03</c>.
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
        /// The product family the patch is applicable for. For example, <c>Windows</c> or <c>Amazon
        /// Linux 2</c>.
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
        /// Gets and sets the property Release. 
        /// <para>
        /// The particular release of a patch. For example, in <c>pkg-example-EE-20180914-2.2.amzn1.noarch</c>,
        /// the release is <c>2.amaz1</c>. Applies to Linux-based managed nodes only.
        /// </para>
        /// </summary>
        public string Release
        {
            get { return this._release; }
            set { this._release = value; }
        }

        // Check to see if Release property is set
        internal bool IsSetRelease()
        {
            return this._release != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date the patch was released.
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The source patch repository for the operating system and version, such as <c>trusty-security</c>
        /// for Ubuntu Server 14.04 LTE and <c>focal-security</c> for Ubuntu Server 20.04 LTE.
        /// Applies to Linux-based managed nodes only.
        /// </para>
        /// </summary>
        public string Repository
        {
            get { return this._repository; }
            set { this._repository = value; }
        }

        // Check to see if Repository property is set
        internal bool IsSetRepository()
        {
            return this._repository != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of the patch. For example, <c>CRITICAL</c> or <c>MODERATE</c>.
        /// </para>
        /// </summary>
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
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

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the patch. For example, in <c>example-pkg-1.710.10-2.7.abcd.x86_64</c>,
        /// the version number is indicated by <c>-1</c>. Applies to Linux-based managed nodes
        /// only.
        /// </para>
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