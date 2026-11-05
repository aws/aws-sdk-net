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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The parameters for disassociating the local replica from a global table using Version
    /// 2019.11.21 with multi-Region eventual consistency (MREC).
    /// 
    ///  
    /// <para>
    /// After disassociation completes, the replica remains a standalone regional table that
    /// keeps its data, indexes, and table settings.
    /// </para>
    ///  
    /// <para>
    /// For request requirements, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/APIReference/API_UpdateTable.html">UpdateTable</a>.
    /// For prerequisites, the protection update, and completion checks, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables-disassociate.html">Disassociating
    /// a global table replica</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class DisassociateReplicationGroupMemberAction
    {
        /// <summary>
        /// Gets and sets the property DisassociationMode. 
        /// <para>
        /// The mode for handling pending replication before disassociation completes. You must
        /// specify <c>WAIT_FOR_REPLICATION</c>. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables-disassociate.html">Disassociating
        /// a global table replica</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DisassociationMode DisassociationMode { get; set; }

        /// <summary>
        /// Checks to see if the DisassociationMode property is set.
        /// </summary>
        internal bool IsSetDisassociationMode() => this.DisassociationMode != null;

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Region of the replica to disassociate. Set this value to the Region where you
        /// send the <c>UpdateTable</c> request. You must use credentials for the account that
        /// owns the replica.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegionName { get; set; }

        /// <summary>
        /// Checks to see if the RegionName property is set.
        /// </summary>
        internal bool IsSetRegionName() => this.RegionName != null;
    }
}
