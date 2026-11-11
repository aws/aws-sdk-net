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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about a reference when the <c>referenceType</c> is <c>CONTACT_ANALYSIS</c>.
    /// Otherwise, null.
    /// </summary>
    public partial class ContactAnalysisReference
    {
        /// <summary>
        /// Gets and sets the property AnalyticsMode. 
        /// <para>
        /// The analytics mode of the contact analysis.
        /// </para>
        /// </summary>
        public AnalyticsMode AnalyticsMode { get; set; }

        /// <summary>
        /// Checks to see if the AnalyticsMode property is set.
        /// </summary>
        internal bool IsSetAnalyticsMode() => this.AnalyticsMode != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the contact analysis reference.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property IsRedacted. 
        /// <para>
        /// Indicates whether sensitive data has been redacted from the contact analysis.
        /// </para>
        /// </summary>
        public bool? IsRedacted { get; set; }

        /// <summary>
        /// Checks to see if the IsRedacted property is set.
        /// </summary>
        internal bool IsSetIsRedacted() => this.IsRedacted.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Identifier of the contact analysis reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the contact analysis reference type.
        /// </para>
        /// </summary>
        public ReferenceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The location path of the contact analysis reference.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
