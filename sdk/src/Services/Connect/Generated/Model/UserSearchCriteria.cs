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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private List<UserSearchCriteria> _andConditions = AWSConfigs.InitializeCollections ? new List<UserSearchCriteria>() : null;
        private HierarchyGroupCondition _hierarchyGroupCondition;
        private ListCondition _listCondition;
        private List<UserSearchCriteria> _orConditions = AWSConfigs.InitializeCollections ? new List<UserSearchCriteria>() : null;
        private StringCondition _stringCondition;

        /// <summary>
        /// Gets and sets the property AndConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>AND</c> condition.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserSearchCriteria> AndConditions
        {
            get { return this._andConditions; }
            set { this._andConditions = value; }
        }

        // Check to see if AndConditions property is set
        internal bool IsSetAndConditions()
        {
            return this._andConditions != null && (this._andConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HierarchyGroupCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a hierarchy group condition.
        /// </para>
        /// </summary>
        public HierarchyGroupCondition HierarchyGroupCondition
        {
            get { return this._hierarchyGroupCondition; }
            set { this._hierarchyGroupCondition = value; }
        }

        // Check to see if HierarchyGroupCondition property is set
        internal bool IsSetHierarchyGroupCondition()
        {
            return this._hierarchyGroupCondition != null;
        }

        /// <summary>
        /// Gets and sets the property ListCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a List condition to search users
        /// with attributes included in Lists like Proficiencies.
        /// </para>
        /// </summary>
        public ListCondition ListCondition
        {
            get { return this._listCondition; }
            set { this._listCondition = value; }
        }

        // Check to see if ListCondition property is set
        internal bool IsSetListCondition()
        {
            return this._listCondition != null;
        }

        /// <summary>
        /// Gets and sets the property OrConditions. 
        /// <para>
        /// A list of conditions which would be applied together with an <c>OR</c> condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UserSearchCriteria> OrConditions
        {
            get { return this._orConditions; }
            set { this._orConditions = value; }
        }

        // Check to see if OrConditions property is set
        internal bool IsSetOrConditions()
        {
            return this._orConditions != null && (this._orConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringCondition. 
        /// <para>
        /// A leaf node condition which can be used to specify a string condition.
        /// </para>
        ///  
        /// <para>
        /// The currently supported values for <c>FieldName</c> are <c>Username</c>, <c>FirstName</c>,
        /// <c>LastName</c>, <c>RoutingProfileId</c>, <c>SecurityProfileId</c>, <c>ResourceId</c>.
        /// </para>
        /// </summary>
        public StringCondition StringCondition
        {
            get { return this._stringCondition; }
            set { this._stringCondition = value; }
        }

        // Check to see if StringCondition property is set
        internal bool IsSetStringCondition()
        {
            return this._stringCondition != null;
        }

    }
}