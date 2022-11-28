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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The <code>ulimit</code> settings to pass to the container.
    /// 
    ///  
    /// <para>
    /// Amazon ECS tasks hosted on Fargate use the default resource limit values set by the
    /// operating system with the exception of the <code>nofile</code> resource limit parameter
    /// which Fargate overrides. The <code>nofile</code> resource limit sets a restriction
    /// on the number of open files that a container can use. The default <code>nofile</code>
    /// soft limit is <code>1024</code> and hard limit is <code>4096</code>.
    /// </para>
    /// </summary>
    public partial class Ulimit
    {
        private int? _hardLimit;
        private UlimitName _name;
        private int? _softLimit;

        /// <summary>
        /// Gets and sets the property HardLimit. 
        /// <para>
        /// The hard limit for the <code>ulimit</code> type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int HardLimit
        {
            get { return this._hardLimit.GetValueOrDefault(); }
            set { this._hardLimit = value; }
        }

        // Check to see if HardLimit property is set
        internal bool IsSetHardLimit()
        {
            return this._hardLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The <code>type</code> of the <code>ulimit</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UlimitName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SoftLimit. 
        /// <para>
        /// The soft limit for the <code>ulimit</code> type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int SoftLimit
        {
            get { return this._softLimit.GetValueOrDefault(); }
            set { this._softLimit = value; }
        }

        // Check to see if SoftLimit property is set
        internal bool IsSetSoftLimit()
        {
            return this._softLimit.HasValue; 
        }

    }
}