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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
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
namespace Amazon.NetworkFlowMonitor.Model
{
    /// <summary>
    /// A target identifier is a pair of identifying information for a scope that is included
    /// in a target. A target identifier is made up of a target ID and a target type. Currently
    /// the target ID is always an account ID and the target type is always ACCOUNT.
    /// </summary>
    public partial class TargetIdentifier
    {
        private TargetId _targetId;
        private TargetType _targetType;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The identifier for a target, which is currently always an account ID .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetId TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of a target. A target type is currently always <c>ACCOUNT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetType TargetType
        {
            get { return this._targetType; }
            set { this._targetType = value; }
        }

        // Check to see if TargetType property is set
        internal bool IsSetTargetType()
        {
            return this._targetType != null;
        }

    }
}