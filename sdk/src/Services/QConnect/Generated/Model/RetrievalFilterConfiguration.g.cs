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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Configuration for filtering content during retrieval operations.
    /// </summary>
    public partial class RetrievalFilterConfiguration
    {
        /// <summary>
        /// Gets and sets the property AndAll. 
        /// <para>
        /// Filter configuration that requires all conditions to be met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2)]
        public List<RetrievalFilterConfiguration> AndAll { get; set; } = AWSConfigs.InitializeCollections ? new List<RetrievalFilterConfiguration>() : null;

        /// <summary>
        /// Checks to see if the AndAll property is set.
        /// </summary>
        internal bool IsSetAndAll() => this.AndAll != null && (this.AndAll.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        /// Filter configuration for exact equality matching.
        /// </para>
        /// </summary>
        public new FilterAttribute Equals { get; set; }

        /// <summary>
        /// Checks to see if the Equals property is set.
        /// </summary>
        internal bool IsSetEquals() => this.Equals != null;

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Filter configuration for greater than comparison.
        /// </para>
        /// </summary>
        public FilterAttribute GreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThan property is set.
        /// </summary>
        internal bool IsSetGreaterThan() => this.GreaterThan != null;

        /// <summary>
        /// Gets and sets the property GreaterThanOrEquals. 
        /// <para>
        /// Filter configuration for greater than or equal comparison.
        /// </para>
        /// </summary>
        public FilterAttribute GreaterThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThanOrEquals property is set.
        /// </summary>
        internal bool IsSetGreaterThanOrEquals() => this.GreaterThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property In. 
        /// <para>
        /// Filter configuration for membership in a set of values.
        /// </para>
        /// </summary>
        public FilterAttribute In { get; set; }

        /// <summary>
        /// Checks to see if the In property is set.
        /// </summary>
        internal bool IsSetIn() => this.In != null;

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Filter configuration for less than comparison.
        /// </para>
        /// </summary>
        public FilterAttribute LessThan { get; set; }

        /// <summary>
        /// Checks to see if the LessThan property is set.
        /// </summary>
        internal bool IsSetLessThan() => this.LessThan != null;

        /// <summary>
        /// Gets and sets the property LessThanOrEquals. 
        /// <para>
        /// Filter configuration for less than or equal comparison.
        /// </para>
        /// </summary>
        public FilterAttribute LessThanOrEquals { get; set; }

        /// <summary>
        /// Checks to see if the LessThanOrEquals property is set.
        /// </summary>
        internal bool IsSetLessThanOrEquals() => this.LessThanOrEquals != null;

        /// <summary>
        /// Gets and sets the property ListContains. 
        /// <para>
        /// Filter configuration for checking if a list contains a value.
        /// </para>
        /// </summary>
        public FilterAttribute ListContains { get; set; }

        /// <summary>
        /// Checks to see if the ListContains property is set.
        /// </summary>
        internal bool IsSetListContains() => this.ListContains != null;

        /// <summary>
        /// Gets and sets the property NotEquals. 
        /// <para>
        /// Filter configuration for inequality matching.
        /// </para>
        /// </summary>
        public FilterAttribute NotEquals { get; set; }

        /// <summary>
        /// Checks to see if the NotEquals property is set.
        /// </summary>
        internal bool IsSetNotEquals() => this.NotEquals != null;

        /// <summary>
        /// Gets and sets the property NotIn. 
        /// <para>
        /// Filter configuration for exclusion from a set of values.
        /// </para>
        /// </summary>
        public FilterAttribute NotIn { get; set; }

        /// <summary>
        /// Checks to see if the NotIn property is set.
        /// </summary>
        internal bool IsSetNotIn() => this.NotIn != null;

        /// <summary>
        /// Gets and sets the property OrAll. 
        /// <para>
        /// Filter configuration where any condition can be met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 2)]
        public List<RetrievalFilterConfiguration> OrAll { get; set; } = AWSConfigs.InitializeCollections ? new List<RetrievalFilterConfiguration>() : null;

        /// <summary>
        /// Checks to see if the OrAll property is set.
        /// </summary>
        internal bool IsSetOrAll() => this.OrAll != null && (this.OrAll.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StartsWith. 
        /// <para>
        /// Filter configuration for prefix matching.
        /// </para>
        /// </summary>
        public FilterAttribute StartsWith { get; set; }

        /// <summary>
        /// Checks to see if the StartsWith property is set.
        /// </summary>
        internal bool IsSetStartsWith() => this.StartsWith != null;

        /// <summary>
        /// Gets and sets the property StringContains. 
        /// <para>
        /// Filter configuration for substring matching.
        /// </para>
        /// </summary>
        public FilterAttribute StringContains { get; set; }

        /// <summary>
        /// Checks to see if the StringContains property is set.
        /// </summary>
        internal bool IsSetStringContains() => this.StringContains != null;
    }
}
