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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Configuration settings for creating and managing pre-provisioned snapshots for a Windows
    /// fast launch enabled Windows AMI.
    /// </summary>
    public partial class FastLaunchSnapshotConfigurationResponse
    {
        private int? _targetResourceCount;

        /// <summary>
        /// Gets and sets the property TargetResourceCount. 
        /// <para>
        /// The number of pre-provisioned snapshots requested to keep on hand for a Windows fast
        /// launch enabled AMI.
        /// </para>
        /// </summary>
        public int? TargetResourceCount
        {
            get { return this._targetResourceCount; }
            set { this._targetResourceCount = value; }
        }

        // Check to see if TargetResourceCount property is set
        internal bool IsSetTargetResourceCount()
        {
            return this._targetResourceCount.HasValue; 
        }

    }
}