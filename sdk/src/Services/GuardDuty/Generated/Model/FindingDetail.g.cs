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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about a GuardDuty finding.
    /// </summary>
    public partial class FindingDetail
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account in which the finding was generated.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property ActivityWindow. 
        /// <para>
        /// The time range of the activity that the finding describes.
        /// </para>
        /// </summary>
        public ActivityWindow ActivityWindow { get; set; }

        /// <summary>
        /// Checks to see if the ActivityWindow property is set.
        /// </summary>
        internal bool IsSetActivityWindow() => this.ActivityWindow != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The ID of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The type of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region in which the finding was generated.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;
    }
}
