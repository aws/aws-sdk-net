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
    /// The search criteria to be used to return users.
    /// 
    ///  <note> 
    /// <para>
    /// The <c>name</c> and <c>description</c> fields support "contains" queries with a minimum
    /// of 2 characters and a maximum of 25 characters. Any queries with character lengths
    /// outside of this range will throw invalid results. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UserSearchCriteria
    {
        /// <summary>
        /// Gets and sets the property AndConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>AND</c> condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserSearchCriteria> AndConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<UserSearchCriteria>() : null;

        /// <summary>
        /// Checks to see if the AndConditions property is set.
        /// </summary>
        internal bool IsSetAndConditions() => this.AndConditions != null && (this.AndConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HierarchyGroupCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a hierarchy group condition.
        /// </para>
        /// </summary>
        public HierarchyGroupCondition HierarchyGroupCondition { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyGroupCondition property is set.
        /// </summary>
        internal bool IsSetHierarchyGroupCondition() => this.HierarchyGroupCondition != null;

        /// <summary>
        /// Gets and sets the property ListCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a List condition to search users
        /// with attributes included in Lists like Proficiencies.
        /// </para>
        /// </summary>
        public ListCondition ListCondition { get; set; }

        /// <summary>
        /// Checks to see if the ListCondition property is set.
        /// </summary>
        internal bool IsSetListCondition() => this.ListCondition != null;

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
        public List<UserSearchCriteria> OrConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<UserSearchCriteria>() : null;

        /// <summary>
        /// Checks to see if the OrConditions property is set.
        /// </summary>
        internal bool IsSetOrConditions() => this.OrConditions != null && (this.OrConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a string condition.
        /// </para>
        ///  
        /// <para>
        /// The currently supported values for <c>FieldName</c> are <c>Username</c>, <c>FirstName</c>,
        /// <c>LastName</c>, <c>RoutingProfileId</c>, <c>SecurityProfileId</c>, <c>resourceId</c>.
        /// </para>
        /// </summary>
        public StringCondition StringCondition { get; set; }

        /// <summary>
        /// Checks to see if the StringCondition property is set.
        /// </summary>
        internal bool IsSetStringCondition() => this.StringCondition != null;
    }
}
