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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the state of scheduled or in-process failover operations on an Aurora global
    /// database (<a>GlobalCluster</a>). This Data type is empty unless a failover operation
    /// is scheduled or is currently underway on the Aurora global database.
    /// </summary>
    public partial class FailoverState
    {
        private string _fromDbClusterArn;
        private FailoverStatus _status;
        private string _toDbClusterArn;

        /// <summary>
        /// Gets and sets the property FromDbClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Aurora DB cluster that is currently being demoted,
        /// and which is associated with this state. 
        /// </para>
        /// </summary>
        public string FromDbClusterArn
        {
            get { return this._fromDbClusterArn; }
            set { this._fromDbClusterArn = value; }
        }

        // Check to see if FromDbClusterArn property is set
        internal bool IsSetFromDbClusterArn()
        {
            return this._fromDbClusterArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Aurora global database (<a>GlobalCluster</a>). Possible
        /// values are as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// pending &#x96; A request to fail over the Aurora global database (<a>GlobalCluster</a>)
        /// has been received by the service. The <code>GlobalCluster</code>'s primary DB cluster
        /// and the specified secondary DB cluster are being verified before the failover process
        /// can start.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// failing-over &#x96; This status covers the range of Aurora internal operations that
        /// take place during the failover process, such as demoting the primary Aurora DB cluster,
        /// promoting the secondary Aurora DB, and synchronizing replicas. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// cancelling &#x96; The request to fail over the Aurora global database (<a>GlobalCluster</a>)
        /// was cancelled and the primary Aurora DB cluster and the selected secondary Aurora
        /// DB cluster are returning to their previous states. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FailoverStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property ToDbClusterArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Aurora DB cluster that is currently being promoted,
        /// and which is associated with this state.
        /// </para>
        /// </summary>
        public string ToDbClusterArn
        {
            get { return this._toDbClusterArn; }
            set { this._toDbClusterArn = value; }
        }

        // Check to see if ToDbClusterArn property is set
        internal bool IsSetToDbClusterArn()
        {
            return this._toDbClusterArn != null;
        }

    }
}