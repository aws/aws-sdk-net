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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCurrentDBClusterCapacity operation.
    /// Set the capacity of an Aurora Serverless v1 DB cluster to a specific value.
    /// 
    ///  
    /// <para>
    /// Aurora Serverless v1 scales seamlessly based on the workload on the DB cluster. In
    /// some cases, the capacity might not scale fast enough to meet a sudden change in workload,
    /// such as a large number of new transactions. Call <c>ModifyCurrentDBClusterCapacity</c>
    /// to set the capacity explicitly.
    /// </para>
    ///  
    /// <para>
    /// After this call sets the DB cluster capacity, Aurora Serverless v1 can automatically
    /// scale the DB cluster based on the cooldown period for scaling up and the cooldown
    /// period for scaling down.
    /// </para>
    ///  
    /// <para>
    /// For more information about Aurora Serverless v1, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.html">Using
    /// Amazon Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you call <c>ModifyCurrentDBClusterCapacity</c> with the default <c>TimeoutAction</c>,
    /// connections that prevent Aurora Serverless v1 from finding a scaling point might be
    /// dropped. For more information about scaling points, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/aurora-serverless.how-it-works.html#aurora-serverless.how-it-works.auto-scaling">
    /// Autoscaling for Aurora Serverless v1</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// This operation only applies to Aurora Serverless v1 DB clusters.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ModifyCurrentDBClusterCapacityRequest : AmazonRDSRequest
    {
        private int? _capacity;
        private string _dbClusterIdentifier;
        private int? _secondsBeforeTimeout;
        private string _timeoutAction;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The DB cluster capacity.
        /// </para>
        ///  
        /// <para>
        /// When you change the capacity of a paused Aurora Serverless v1 DB cluster, it automatically
        /// resumes.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Aurora MySQL, valid capacity values are <c>1</c>, <c>2</c>, <c>4</c>, <c>8</c>,
        /// <c>16</c>, <c>32</c>, <c>64</c>, <c>128</c>, and <c>256</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Aurora PostgreSQL, valid capacity values are <c>2</c>, <c>4</c>, <c>8</c>, <c>16</c>,
        /// <c>32</c>, <c>64</c>, <c>192</c>, and <c>384</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The DB cluster identifier for the cluster being modified. This parameter isn't case-sensitive.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must match the identifier of an existing DB cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DBClusterIdentifier property is set
        internal bool IsSetDBClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SecondsBeforeTimeout. 
        /// <para>
        /// The amount of time, in seconds, that Aurora Serverless v1 tries to find a scaling
        /// point to perform seamless scaling before enforcing the timeout action. The default
        /// is 300.
        /// </para>
        ///  
        /// <para>
        /// Specify a value between 10 and 600 seconds.
        /// </para>
        /// </summary>
        public int? SecondsBeforeTimeout
        {
            get { return this._secondsBeforeTimeout; }
            set { this._secondsBeforeTimeout = value; }
        }

        // Check to see if SecondsBeforeTimeout property is set
        internal bool IsSetSecondsBeforeTimeout()
        {
            return this._secondsBeforeTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutAction. 
        /// <para>
        /// The action to take when the timeout is reached, either <c>ForceApplyCapacityChange</c>
        /// or <c>RollbackCapacityChange</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ForceApplyCapacityChange</c>, the default, sets the capacity to the specified
        /// value as soon as possible.
        /// </para>
        ///  
        /// <para>
        ///  <c>RollbackCapacityChange</c> ignores the capacity change if a scaling point isn't
        /// found in the timeout period.
        /// </para>
        /// </summary>
        public string TimeoutAction
        {
            get { return this._timeoutAction; }
            set { this._timeoutAction = value; }
        }

        // Check to see if TimeoutAction property is set
        internal bool IsSetTimeoutAction()
        {
            return this._timeoutAction != null;
        }

    }
}