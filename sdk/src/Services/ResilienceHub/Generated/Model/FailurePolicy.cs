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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines a failure policy.
    /// </summary>
    public partial class FailurePolicy
    {
        private int? _rpoInSecs;
        private int? _rtoInSecs;

        /// <summary>
        /// Gets and sets the property RpoInSecs. 
        /// <para>
        /// Recovery Point Objective (RPO) in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? RpoInSecs
        {
            get { return this._rpoInSecs; }
            set { this._rpoInSecs = value; }
        }

        // Check to see if RpoInSecs property is set
        internal bool IsSetRpoInSecs()
        {
            return this._rpoInSecs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RtoInSecs. 
        /// <para>
        /// Recovery Time Objective (RTO) in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? RtoInSecs
        {
            get { return this._rtoInSecs; }
            set { this._rtoInSecs = value; }
        }

        // Check to see if RtoInSecs property is set
        internal bool IsSetRtoInSecs()
        {
            return this._rtoInSecs.HasValue; 
        }

    }
}