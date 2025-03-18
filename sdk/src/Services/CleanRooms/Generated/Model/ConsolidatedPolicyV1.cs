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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Controls on the analysis specifications that can be run on a configured table.
    /// </summary>
    public partial class ConsolidatedPolicyV1
    {
        private ConsolidatedPolicyAggregation _aggregation;
        private ConsolidatedPolicyCustom _custom;
        private ConsolidatedPolicyList _list;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        ///  The aggregation setting for the consolidated policy.
        /// </para>
        /// </summary>
        public ConsolidatedPolicyAggregation Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null;
        }

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        ///  Custom policy
        /// </para>
        /// </summary>
        public ConsolidatedPolicyCustom Custom
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if Custom property is set
        internal bool IsSetCustom()
        {
            return this._custom != null;
        }

        /// <summary>
        /// Gets and sets the property List. 
        /// <para>
        ///  The list of consolidated policies.
        /// </para>
        /// </summary>
        public ConsolidatedPolicyList List
        {
            get { return this._list; }
            set { this._list = value; }
        }

        // Check to see if List property is set
        internal bool IsSetList()
        {
            return this._list != null;
        }

    }
}