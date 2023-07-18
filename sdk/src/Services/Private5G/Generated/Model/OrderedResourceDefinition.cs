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
 * Do not modify this file. This file is generated from the privatenetworks-2021-12-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Private5G.Model
{
    /// <summary>
    /// Details of the network resources in the order.
    /// </summary>
    public partial class OrderedResourceDefinition
    {
        private CommitmentConfiguration _commitmentConfiguration;
        private int? _count;
        private NetworkResourceDefinitionType _type;

        /// <summary>
        /// Gets and sets the property CommitmentConfiguration. 
        /// <para>
        /// The duration and renewal status of the commitment period for each radio unit in the
        /// order. Does not show details if the resource type is DEVICE_IDENTIFIER.
        /// </para>
        /// </summary>
        public CommitmentConfiguration CommitmentConfiguration
        {
            get { return this._commitmentConfiguration; }
            set { this._commitmentConfiguration = value; }
        }

        // Check to see if CommitmentConfiguration property is set
        internal bool IsSetCommitmentConfiguration()
        {
            return this._commitmentConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of network resources in the order.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of network resource in the order.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NetworkResourceDefinitionType Type
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