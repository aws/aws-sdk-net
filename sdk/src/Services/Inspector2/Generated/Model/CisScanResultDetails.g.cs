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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The CIS scan result details.
    /// </summary>
    public partial class CisScanResultDetails
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The CIS scan result details' account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CheckDescription. 
        /// <para>
        /// The account ID that's associated with the CIS scan result details.
        /// </para>
        /// </summary>
        public string CheckDescription { get; set; }

        /// <summary>
        /// Checks to see if the CheckDescription property is set.
        /// </summary>
        internal bool IsSetCheckDescription() => this.CheckDescription != null;

        /// <summary>
        /// Gets and sets the property CheckId. 
        /// <para>
        /// The CIS scan result details' check ID.
        /// </para>
        /// </summary>
        public string CheckId { get; set; }

        /// <summary>
        /// Checks to see if the CheckId property is set.
        /// </summary>
        internal bool IsSetCheckId() => this.CheckId != null;

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The CIS scan result details' finding ARN.
        /// </para>
        /// </summary>
        public string FindingArn { get; set; }

        /// <summary>
        /// Checks to see if the FindingArn property is set.
        /// </summary>
        internal bool IsSetFindingArn() => this.FindingArn != null;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The CIS scan result details' level.
        /// </para>
        /// </summary>
        public CisSecurityLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The CIS scan result details' platform.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// The CIS scan result details' remediation.
        /// </para>
        /// </summary>
        public string Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The CIS scan result details' scan ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanArn property is set.
        /// </summary>
        internal bool IsSetScanArn() => this.ScanArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The CIS scan result details' status.
        /// </para>
        /// </summary>
        public CisFindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The CIS scan result details' status reason.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TargetResourceId. 
        /// <para>
        /// The CIS scan result details' target resource ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 1024)]
        public string TargetResourceId { get; set; }

        /// <summary>
        /// Checks to see if the TargetResourceId property is set.
        /// </summary>
        internal bool IsSetTargetResourceId() => this.TargetResourceId != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The CIS scan result details' title.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
