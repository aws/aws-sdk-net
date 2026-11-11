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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Contains the state of scheduled or in-process operations on an Amazon DocumentDB global
    /// cluster. This data type is empty unless a switchover or failover operation is scheduled
    /// or is in progress on the global cluster.
    /// </summary>
    public partial class FailoverState
    {
        /// <summary>
        /// Gets and sets the property FromDbClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon DocumentDB cluster that is currently
        /// being demoted, and which is associated with this state.
        /// </para>
        /// </summary>
        public string FromDbClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the FromDbClusterArn property is set.
        /// </summary>
        internal bool IsSetFromDbClusterArn() => this.FromDbClusterArn != null;

        /// <summary>
        /// Gets and sets the property IsDataLossAllowed. 
        /// <para>
        /// Indicates whether the operation is a global switchover or a global failover. If data
        /// loss is allowed, then the operation is a global failover. Otherwise, it's a switchover.
        /// </para>
        /// </summary>
        public bool? IsDataLossAllowed { get; set; }

        /// <summary>
        /// Checks to see if the IsDataLossAllowed property is set.
        /// </summary>
        internal bool IsSetIsDataLossAllowed() => this.IsDataLossAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the global cluster. Possible values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>pending</b> – The service received a request to switch over or fail over the global
        /// cluster. The global cluster's primary cluster and the specified secondary cluster
        /// are being verified before the operation starts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>failing-over</b> – The chosen secondary cluster is being promoted to become the
        /// new primary cluster to fail over the global cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>cancelling</b> – The request to switch over or fail over the global cluster was
        /// cancelled and the primary cluster and the selected secondary cluster are returning
        /// to their previous states.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FailoverStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property ToDbClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon DocumentDB cluster that is currently
        /// being promoted, and which is associated with this state.
        /// </para>
        /// </summary>
        public string ToDbClusterArn { get; set; }

        /// <summary>
        /// Checks to see if the ToDbClusterArn property is set.
        /// </summary>
        internal bool IsSetToDbClusterArn() => this.ToDbClusterArn != null;
    }
}
