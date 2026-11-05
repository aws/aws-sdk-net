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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The configuration for a log driver volume in a daemon task definition. The volume
    /// contains the log files for each container on the container instance that uses the
    /// specified log driver in its <c>logConfiguration</c>. Containers that use a different
    /// log driver don't write log files to the volume.
    /// 
    ///  
    /// <para>
    /// For the <c>json-file</c> log driver, the volume has one directory for each container,
    /// named with the container ID. Each directory contains the container's log file, <c>&lt;container-id&gt;-json.log</c>,
    /// and any rotated log files. After a container stops and Amazon ECS removes it, Amazon
    /// ECS deletes the container's directory. Read the log files before the container is
    /// removed.
    /// </para>
    /// </summary>
    public partial class LogDriverVolumeConfiguration
    {
        /// <summary>
        /// Gets and sets the property Driver. 
        /// <para>
        /// The log driver whose log files the volume contains. The only supported value is <c>json-file</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public LogDriver Driver { get; set; }

        /// <summary>
        /// Checks to see if the Driver property is set.
        /// </summary>
        internal bool IsSetDriver() => this.Driver != null;
    }
}
