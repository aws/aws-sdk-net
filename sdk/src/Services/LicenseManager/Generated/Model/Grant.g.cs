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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes a grant.
    /// </summary>
    public partial class Grant
    {
        /// <summary>
        /// Gets and sets the property GrantArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string GrantArn { get; set; }

        /// <summary>
        /// Checks to see if the GrantArn property is set.
        /// </summary>
        internal bool IsSetGrantArn() => this.GrantArn != null;

        /// <summary>
        /// Gets and sets the property GrantName. 
        /// <para>
        /// Grant name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GrantName { get; set; }

        /// <summary>
        /// Checks to see if the GrantName property is set.
        /// </summary>
        internal bool IsSetGrantName() => this.GrantName != null;

        /// <summary>
        /// Gets and sets the property GrantStatus. 
        /// <para>
        /// Grant status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public GrantStatus GrantStatus { get; set; }

        /// <summary>
        /// Checks to see if the GrantStatus property is set.
        /// </summary>
        internal bool IsSetGrantStatus() => this.GrantStatus != null;

        /// <summary>
        /// Gets and sets the property GrantedOperations. 
        /// <para>
        /// Granted operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8)]
        public List<string> GrantedOperations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GrantedOperations property is set.
        /// </summary>
        internal bool IsSetGrantedOperations() => this.GrantedOperations != null && (this.GrantedOperations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GranteePrincipalArn. 
        /// <para>
        /// The grantee principal ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string GranteePrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the GranteePrincipalArn property is set.
        /// </summary>
        internal bool IsSetGranteePrincipalArn() => this.GranteePrincipalArn != null;

        /// <summary>
        /// Gets and sets the property HomeRegion. 
        /// <para>
        /// Home Region of the grant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string HomeRegion { get; set; }

        /// <summary>
        /// Checks to see if the HomeRegion property is set.
        /// </summary>
        internal bool IsSetHomeRegion() => this.HomeRegion != null;

        /// <summary>
        /// Gets and sets the property LicenseArn. 
        /// <para>
        /// License ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LicenseArn { get; set; }

        /// <summary>
        /// Checks to see if the LicenseArn property is set.
        /// </summary>
        internal bool IsSetLicenseArn() => this.LicenseArn != null;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options specified for the grant.
        /// </para>
        /// </summary>
        public Options Options { get; set; }

        /// <summary>
        /// Checks to see if the Options property is set.
        /// </summary>
        internal bool IsSetOptions() => this.Options != null;

        /// <summary>
        /// Gets and sets the property ParentArn. 
        /// <para>
        /// Parent ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string ParentArn { get; set; }

        /// <summary>
        /// Checks to see if the ParentArn property is set.
        /// </summary>
        internal bool IsSetParentArn() => this.ParentArn != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Grant status reason.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 400)]
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Grant version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
