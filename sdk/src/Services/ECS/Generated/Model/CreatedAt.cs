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
    /// The optional filter to narrow the <c>ListServiceDeployment</c> results.
    /// 
    ///  
    /// <para>
    ///  If you do not specify a value, service deployments that were created before the current
    /// time are included in the result.
    /// </para>
    /// </summary>
    public partial class CreatedAt
    {
        private DateTime? _after;
        private DateTime? _before;

        /// <summary>
        /// Gets and sets the property After. 
        /// <para>
        /// Include service deployments in the result that were created after this time. The format
        /// is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? After
        {
            get { return this._after; }
            set { this._after = value; }
        }

        // Check to see if After property is set
        internal bool IsSetAfter()
        {
            return this._after.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Before. 
        /// <para>
        /// Include service deployments in the result that were created before this time. The
        /// format is yyyy-MM-dd HH:mm:ss.SSSSSS.
        /// </para>
        /// </summary>
        public DateTime? Before
        {
            get { return this._before; }
            set { this._before = value; }
        }

        // Check to see if Before property is set
        internal bool IsSetBefore()
        {
            return this._before.HasValue; 
        }

    }
}