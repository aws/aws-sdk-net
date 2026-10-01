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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about the threat intelligence related to a finding.
    /// </summary>
    public partial class ThreatIntelIndicator
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category of a threat intelligence indicator.
        /// </para>
        /// </summary>
        public ThreatIntelIndicatorCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// Indicates when the most recent instance of a threat intelligence indicator was observed.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LastObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastObservedAt property is set.
        /// </summary>
        internal bool IsSetLastObservedAt() => this.LastObservedAt != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the threat intelligence indicator.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1 length. Maximum of 64 length.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceUrl. 
        /// <para>
        /// The URL to the page or site where you can get more information about the threat intelligence
        /// indicator.
        /// </para>
        /// </summary>
        public string SourceUrl { get; set; }

        /// <summary>
        /// Checks to see if the SourceUrl property is set.
        /// </summary>
        internal bool IsSetSourceUrl() => this.SourceUrl != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of threat intelligence indicator.
        /// </para>
        /// </summary>
        public ThreatIntelIndicatorType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of a threat intelligence indicator.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1 length. Maximum of 512 length.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
