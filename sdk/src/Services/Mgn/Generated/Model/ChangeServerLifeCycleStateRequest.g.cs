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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Container for the parameters to the ChangeServerLifeCycleState operation. Allows the
    /// user to set the SourceServer.LifeCycle.state property for specific Source Server IDs
    /// to one of the following: READY_FOR_TEST or READY_FOR_CUTOVER. This command only works
    /// if the Source Server is already launchable (dataReplicationInfo.lagDuration is not
    /// null.)
    /// </summary>
    public partial class ChangeServerLifeCycleStateRequest : AmazonMgnRequest
    {
        /// <summary>
        /// Gets and sets the property AccountID. 
        /// <para>
        /// The request to change the source server migration account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string AccountID { get; set; }

        /// <summary>
        /// Checks to see if the AccountID property is set.
        /// </summary>
        internal bool IsSetAccountID() => this.AccountID != null;

        /// <summary>
        /// Gets and sets the property LifeCycle. 
        /// <para>
        /// The request to change the source server migration lifecycle state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ChangeServerLifeCycleStateSourceServerLifecycle LifeCycle { get; set; }

        /// <summary>
        /// Checks to see if the LifeCycle property is set.
        /// </summary>
        internal bool IsSetLifeCycle() => this.LifeCycle != null;

        /// <summary>
        /// Gets and sets the property SourceServerID. 
        /// <para>
        /// The request to change the source server migration lifecycle state by source server
        /// ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 19, Max = 19)]
        public string SourceServerID { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerID property is set.
        /// </summary>
        internal bool IsSetSourceServerID() => this.SourceServerID != null;
    }
}
