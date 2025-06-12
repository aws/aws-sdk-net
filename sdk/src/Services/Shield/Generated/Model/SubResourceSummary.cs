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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// The attack information for the specified SubResource.
    /// </summary>
    public partial class SubResourceSummary
    {
        private List<SummarizedAttackVector> _attackVectors = AWSConfigs.InitializeCollections ? new List<SummarizedAttackVector>() : null;
        private List<SummarizedCounter> _counters = AWSConfigs.InitializeCollections ? new List<SummarizedCounter>() : null;
        private string _id;
        private SubResourceType _type;

        /// <summary>
        /// Gets and sets the property AttackVectors. 
        /// <para>
        /// The list of attack types and associated counters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizedAttackVector> AttackVectors
        {
            get { return this._attackVectors; }
            set { this._attackVectors = value; }
        }

        // Check to see if AttackVectors property is set
        internal bool IsSetAttackVectors()
        {
            return this._attackVectors != null && (this._attackVectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Counters. 
        /// <para>
        /// The counters that describe the details of the attack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizedCounter> Counters
        {
            get { return this._counters; }
            set { this._counters = value; }
        }

        // Check to see if Counters property is set
        internal bool IsSetCounters()
        {
            return this._counters != null && (this._counters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier (ID) of the <c>SubResource</c>.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The <c>SubResource</c> type.
        /// </para>
        /// </summary>
        public SubResourceType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}