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
    /// The search criteria to be used to return agent statuses.
    /// </summary>
    public partial class AgentStatusSearchCriteria
    {
        /// <summary>
        /// Gets and sets the property AndConditions. 
        /// <para>
        /// A leaf node condition which can be used to specify a string condition.
        /// </para>
        ///  <note> 
        /// <para>
        /// The currently supported values for <c>FieldName</c> are <c>name</c>, <c>description</c>,
        /// <c>state</c>, <c>type</c>, <c>displayOrder</c>, and <c>resourceID</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentStatusSearchCriteria> AndConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentStatusSearchCriteria>() : null;

        /// <summary>
        /// Checks to see if the AndConditions property is set.
        /// </summary>
        internal bool IsSetAndConditions() => this.AndConditions != null && (this.AndConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property OrConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>OR</c> condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AgentStatusSearchCriteria> OrConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<AgentStatusSearchCriteria>() : null;

        /// <summary>
        /// Checks to see if the OrConditions property is set.
        /// </summary>
        internal bool IsSetOrConditions() => this.OrConditions != null && (this.OrConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a string condition.
        /// </para>
        ///  <note> 
        /// <para>
        /// The currently supported values for <c>FieldName</c> are <c>name</c>, <c>description</c>,
        /// <c>state</c>, <c>type</c>, <c>displayOrder</c>, and <c>resourceID</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public StringCondition StringCondition { get; set; }

        /// <summary>
        /// Checks to see if the StringCondition property is set.
        /// </summary>
        internal bool IsSetStringCondition() => this.StringCondition != null;
    }
}
