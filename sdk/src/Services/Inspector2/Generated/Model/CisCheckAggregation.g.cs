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
    /// A CIS check.
    /// </summary>
    public partial class CisCheckAggregation
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for the CIS check.
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
        /// The description for the CIS check.
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
        /// The check ID for the CIS check.
        /// </para>
        /// </summary>
        public string CheckId { get; set; }

        /// <summary>
        /// Checks to see if the CheckId property is set.
        /// </summary>
        internal bool IsSetCheckId() => this.CheckId != null;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// The CIS check level.
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
        /// The CIS check platform.
        /// </para>
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// Checks to see if the Platform property is set.
        /// </summary>
        internal bool IsSetPlatform() => this.Platform != null;

        /// <summary>
        /// Gets and sets the property ScanArn. 
        /// <para>
        /// The scan ARN for the CIS check scan ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanArn property is set.
        /// </summary>
        internal bool IsSetScanArn() => this.ScanArn != null;

        /// <summary>
        /// Gets and sets the property StatusCounts. 
        /// <para>
        /// The CIS check status counts.
        /// </para>
        /// </summary>
        public StatusCounts StatusCounts { get; set; }

        /// <summary>
        /// Checks to see if the StatusCounts property is set.
        /// </summary>
        internal bool IsSetStatusCounts() => this.StatusCounts != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The CIS check title.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
