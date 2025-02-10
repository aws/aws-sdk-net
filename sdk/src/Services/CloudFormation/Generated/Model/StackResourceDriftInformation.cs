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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Contains information about whether the resource's actual configuration differs, or
    /// has <i>drifted</i>, from its expected configuration.
    /// </summary>
    public partial class StackResourceDriftInformation
    {
        private DateTime? _lastCheckTimestamp;
        private StackResourceDriftStatus _stackResourceDriftStatus;

        /// <summary>
        /// Gets and sets the property LastCheckTimestamp. 
        /// <para>
        /// When CloudFormation last checked if the resource had drifted from its expected configuration.
        /// </para>
        /// </summary>
        public DateTime? LastCheckTimestamp
        {
            get { return this._lastCheckTimestamp; }
            set { this._lastCheckTimestamp = value; }
        }

        // Check to see if LastCheckTimestamp property is set
        internal bool IsSetLastCheckTimestamp()
        {
            return this._lastCheckTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StackResourceDriftStatus. 
        /// <para>
        /// Status of the resource's actual configuration compared to its expected configuration
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DELETED</c>: The resource differs from its expected configuration in that it has
        /// been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODIFIED</c>: The resource differs from its expected configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CHECKED</c>: CloudFormation has not checked if the resource differs from its
        /// expected configuration.
        /// </para>
        ///  
        /// <para>
        /// Any resources that do not currently support drift detection have a status of <c>NOT_CHECKED</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/resource-import-supported-resources.html">Resource
        /// type support for imports and drift detection</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IN_SYNC</c>: The resource's actual configuration matches its expected configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public StackResourceDriftStatus StackResourceDriftStatus
        {
            get { return this._stackResourceDriftStatus; }
            set { this._stackResourceDriftStatus = value; }
        }

        // Check to see if StackResourceDriftStatus property is set
        internal bool IsSetStackResourceDriftStatus()
        {
            return this._stackResourceDriftStatus != null;
        }

    }
}