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
    /// A leaf node condition which can be used to specify a List condition to search users
    /// with attributes included in Lists like Proficiencies.
    /// </summary>
    public partial class ListCondition
    {
        private List<Condition> _conditions = AWSConfigs.InitializeCollections ? new List<Condition>() : null;
        private TargetListType _targetListType;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// A list of Condition objects which would be applied together with an AND condition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Condition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetListType. 
        /// <para>
        /// The type of target list that will be used to filter the users.
        /// </para>
        /// </summary>
        public TargetListType TargetListType
        {
            get { return this._targetListType; }
            set { this._targetListType = value; }
        }

        // Check to see if TargetListType property is set
        internal bool IsSetTargetListType()
        {
            return this._targetListType != null;
        }

    }
}