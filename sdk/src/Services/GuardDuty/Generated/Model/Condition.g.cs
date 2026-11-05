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
    /// Contains information about the condition.
    /// </summary>
    public partial class Condition
    {
        /// <summary>
        /// Gets and sets the property Eq. 
        /// <para>
        /// Represents the <i>equal</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        ///  
        /// <para>
        /// Max values: 50
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated and the Equals property should be used instead.")]
        public List<string> Eq { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Eq property is set.
        /// </summary>
        internal bool IsSetEq() => this.Eq != null && (this.Eq.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        /// Represents an <i>equal</i> <b/> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        ///  
        /// <para>
        /// Max values: 50
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public new List<string> Equals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Equals property is set.
        /// </summary>
        internal bool IsSetEquals() => this.Equals != null && (this.Equals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Represents a <i>greater than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        public long? GreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThan property is set.
        /// </summary>
        internal bool IsSetGreaterThan() => this.GreaterThan.HasValue;

        /// <summary>
        /// Gets and sets the property GreaterThanOrEqual. 
        /// <para>
        /// Represents a <i>greater than or equal</i> condition to be applied to a single field
        /// when querying for findings.
        /// </para>
        /// </summary>
        public long? GreaterThanOrEqual { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThanOrEqual property is set.
        /// </summary>
        internal bool IsSetGreaterThanOrEqual() => this.GreaterThanOrEqual.HasValue;

        /// <summary>
        /// Gets and sets the property Gt. 
        /// <para>
        /// Represents a <i>greater than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the GreaterThan property should be used instead.")]
        public int? Gt { get; set; }

        /// <summary>
        /// Checks to see if the Gt property is set.
        /// </summary>
        internal bool IsSetGt() => this.Gt.HasValue;

        /// <summary>
        /// Gets and sets the property Gte. 
        /// <para>
        /// Represents a <i>greater than or equal</i> condition to be applied to a single field
        /// when querying for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the GreaterThanOrEqual property should be used instead.")]
        public int? Gte { get; set; }

        /// <summary>
        /// Checks to see if the Gte property is set.
        /// </summary>
        internal bool IsSetGte() => this.Gte.HasValue;

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Represents a <i>less than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        public long? LessThan { get; set; }

        /// <summary>
        /// Checks to see if the LessThan property is set.
        /// </summary>
        internal bool IsSetLessThan() => this.LessThan.HasValue;

        /// <summary>
        /// Gets and sets the property LessThanOrEqual. 
        /// <para>
        /// Represents a <i>less than or equal</i> condition to be applied to a single field when
        /// querying for findings.
        /// </para>
        /// </summary>
        public long? LessThanOrEqual { get; set; }

        /// <summary>
        /// Checks to see if the LessThanOrEqual property is set.
        /// </summary>
        internal bool IsSetLessThanOrEqual() => this.LessThanOrEqual.HasValue;

        /// <summary>
        /// Gets and sets the property Lt. 
        /// <para>
        /// Represents a <i>less than</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the LessThan property should be used instead.")]
        public int? Lt { get; set; }

        /// <summary>
        /// Checks to see if the Lt property is set.
        /// </summary>
        internal bool IsSetLt() => this.Lt.HasValue;

        /// <summary>
        /// Gets and sets the property Lte. 
        /// <para>
        /// Represents a <i>less than or equal</i> condition to be applied to a single field when
        /// querying for findings.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated and the LessThanOrEqual property should be used instead.")]
        public int? Lte { get; set; }

        /// <summary>
        /// Checks to see if the Lte property is set.
        /// </summary>
        internal bool IsSetLte() => this.Lte.HasValue;

        /// <summary>
        /// Gets and sets the property Matches. 
        /// <para>
        /// Represents the <i>match</i> condition to be applied to a single field when querying
        /// for findings. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  The <i>matches</i> condition is available only for create-filter and update-filter
        /// APIs. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> Matches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Matches property is set.
        /// </summary>
        internal bool IsSetMatches() => this.Matches != null && (this.Matches.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Neq. 
        /// <para>
        /// Represents the <i>not equal</i> condition to be applied to a single field when querying
        /// for findings.
        /// </para>
        ///  
        /// <para>
        /// Max values: 50
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("This property is deprecated and the NotEquals property should be used instead.")]
        public List<string> Neq { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Neq property is set.
        /// </summary>
        internal bool IsSetNeq() => this.Neq != null && (this.Neq.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        /// Represents a <i>not equal</i> <b/> condition to be applied to a single field when
        /// querying for findings.
        /// </para>
        ///  
        /// <para>
        /// Max values: 50
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> NotEquals { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotEquals property is set.
        /// </summary>
        internal bool IsSetNotEquals() => this.NotEquals != null && (this.NotEquals.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NotMatches. 
        /// <para>
        /// Represents the <i>not match</i> condition to be applied to a single field when querying
        /// for findings. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  The <i>not-matches</i> condition is available only for create-filter and update-filter
        /// APIs. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> NotMatches { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the NotMatches property is set.
        /// </summary>
        internal bool IsSetNotMatches() => this.NotMatches != null && (this.NotMatches.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
