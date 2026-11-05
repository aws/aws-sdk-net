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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AdvisoryIds. 
        /// <para>
        /// The Advisory ID of the patch. For example, <c>RHSA-2020:3779</c>. Applies to Linux-based
        /// managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AdvisoryIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AdvisoryIds property is set.
        /// </summary>
        internal bool IsSetAdvisoryIds() => this.AdvisoryIds != null && (this.AdvisoryIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Arch. 
        /// <para>
        /// The architecture of the patch. For example, in <c>example-pkg-0.710.10-2.7.abcd.x86_64</c>,
        /// the architecture is indicated by <c>x86_64</c>. Applies to Linux-based managed nodes
        /// only.
        /// </para>
        /// </summary>
        public string Arch { get; set; }

        /// <summary>
        /// Checks to see if the Arch property is set.
        /// </summary>
        internal bool IsSetArch() => this.Arch != null;

        /// <summary>
        /// Gets and sets the property BugzillaIds. 
        /// <para>
        /// The Bugzilla ID of the patch. For example, <c>1600646</c>. Applies to Linux-based
        /// managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BugzillaIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BugzillaIds property is set.
        /// </summary>
        internal bool IsSetBugzillaIds() => this.BugzillaIds != null && (this.BugzillaIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CVEIds. 
        /// <para>
        /// The Common Vulnerabilities and Exposures (CVE) ID of the patch. For example, <c>CVE-2011-3192</c>.
        /// Applies to Linux-based managed nodes only.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CVEIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CVEIds property is set.
        /// </summary>
        internal bool IsSetCVEIds() => this.CVEIds != null && (this.CVEIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Classification. 
        /// <para>
        /// The classification of the patch. For example, <c>SecurityUpdates</c>, <c>Updates</c>,
        /// or <c>CriticalUpdates</c>.
        /// </para>
        /// </summary>
        public string Classification { get; set; }

        /// <summary>
        /// Checks to see if the Classification property is set.
        /// </summary>
        internal bool IsSetClassification() => this.Classification != null;

        /// <summary>
        /// Gets and sets the property ContentUrl. 
        /// <para>
        /// The URL where more information can be obtained about the patch.
        /// </para>
        /// </summary>
        public string ContentUrl { get; set; }

        /// <summary>
        /// Checks to see if the ContentUrl property is set.
        /// </summary>
        internal bool IsSetContentUrl() => this.ContentUrl != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the patch.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Epoch. 
        /// <para>
        /// The epoch of the patch. For example in <c>pkg-example-EE-20180914-2.2.amzn1.noarch</c>,
        /// the epoch value is <c>20180914-2</c>. Applies to Linux-based managed nodes only.
        /// </para>
        /// </summary>
        public int? Epoch { get; set; }

        /// <summary>
        /// Checks to see if the Epoch property is set.
        /// </summary>
        internal bool IsSetEpoch() => this.Epoch.HasValue;

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
        [AWSProperty(Min = 1, Max = 100)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property KbNumber. 
        /// <para>
        /// The Microsoft Knowledge Base ID of the patch. Applies to Windows patches only.
        /// </para>
        /// </summary>
        public string KbNumber { get; set; }

        /// <summary>
        /// Checks to see if the KbNumber property is set.
        /// </summary>
        internal bool IsSetKbNumber() => this.KbNumber != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language of the patch if it's language-specific.
        /// </para>
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property MsrcNumber. 
        /// <para>
        /// The ID of the Microsoft Security Response Center (MSRC) bulletin the patch is related
        /// to. For example, <c>MS14-045</c>. Applies to Windows patches only.
        /// </para>
        /// </summary>
        public string MsrcNumber { get; set; }

        /// <summary>
        /// Checks to see if the MsrcNumber property is set.
        /// </summary>
        internal bool IsSetMsrcNumber() => this.MsrcNumber != null;

        /// <summary>
        /// Gets and sets the property MsrcSeverity. 
        /// <para>
        /// The severity of the patch, such as <c>Critical</c>, <c>Important</c>, or <c>Moderate</c>.
        /// Applies to Windows patches only.
        /// </para>
        /// </summary>
        public string MsrcSeverity { get; set; }

        /// <summary>
        /// Checks to see if the MsrcSeverity property is set.
        /// </summary>
        internal bool IsSetMsrcSeverity() => this.MsrcSeverity != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the patch. Applies to Linux-based managed nodes only.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Product. 
        /// <para>
        /// The specific product the patch is applicable for. For example, <c>WindowsServer2016</c>
        /// or <c>AmazonLinux2018.03</c>.
        /// </para>
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        /// Checks to see if the Product property is set.
        /// </summary>
        internal bool IsSetProduct() => this.Product != null;

        /// <summary>
        /// Gets and sets the property ProductFamily. 
        /// <para>
        /// The product family the patch is applicable for. For example, <c>Windows</c> or <c>Amazon
        /// Linux 2</c>.
        /// </para>
        /// </summary>
        public string ProductFamily { get; set; }

        /// <summary>
        /// Checks to see if the ProductFamily property is set.
        /// </summary>
        internal bool IsSetProductFamily() => this.ProductFamily != null;

        /// <summary>
        /// Gets and sets the property Release. 
        /// <para>
        /// The particular release of a patch. For example, in <c>pkg-example-EE-20180914-2.2.amzn1.noarch</c>,
        /// the release is <c>2.amaz1</c>. Applies to Linux-based managed nodes only.
        /// </para>
        /// </summary>
        public string Release { get; set; }

        /// <summary>
        /// Checks to see if the Release property is set.
        /// </summary>
        internal bool IsSetRelease() => this.Release != null;

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date the patch was released.
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseDate property is set.
        /// </summary>
        internal bool IsSetReleaseDate() => this.ReleaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The source patch repository for the operating system and version, such as <c>trusty-security</c>
        /// for Ubuntu Server 14.04 LTE and <c>focal-security</c> for Ubuntu Server 20.04 LTE.
        /// Applies to Linux-based managed nodes only.
        /// </para>
        /// </summary>
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of the patch. For example, <c>CRITICAL</c> or <c>MODERATE</c>.
        /// </para>
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the patch.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Vendor. 
        /// <para>
        /// The name of the vendor providing the patch.
        /// </para>
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// Checks to see if the Vendor property is set.
        /// </summary>
        internal bool IsSetVendor() => this.Vendor != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number of the patch. For example, in <c>example-pkg-1.710.10-2.7.abcd.x86_64</c>,
        /// the version number is indicated by <c>-1</c>. Applies to Linux-based managed nodes
        /// only.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
