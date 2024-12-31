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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The amount of ephemeral storage to allocate for the task. This parameter is used to
    /// expand the total amount of ephemeral storage available, beyond the default amount,
    /// for tasks hosted on Fargate. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_data_volumes.html">Using
    /// data volumes in tasks</a> in the <i>Amazon ECS Developer Guide;</i>.
    /// 
    ///  <note> 
    /// <para>
    /// For tasks using the Fargate launch type, the task requires the following platforms:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Linux platform version <c>1.4.0</c> or later.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Windows platform version <c>1.0.0</c> or later.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class EphemeralStorage
    {
        private int? _sizeInGiB;

        /// <summary>
        /// Gets and sets the property SizeInGiB. 
        /// <para>
        /// The total amount, in GiB, of ephemeral storage to set for the task. The minimum supported
        /// value is <c>21</c> GiB and the maximum supported value is <c>200</c> GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SizeInGiB
        {
            get { return this._sizeInGiB; }
            set { this._sizeInGiB = value; }
        }

        // Check to see if SizeInGiB property is set
        internal bool IsSetSizeInGiB()
        {
            return this._sizeInGiB.HasValue; 
        }

    }
}