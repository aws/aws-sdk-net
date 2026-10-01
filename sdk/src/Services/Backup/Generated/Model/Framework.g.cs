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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains detailed information about a framework. Frameworks contain controls, which
    /// evaluate and report on your backup events and resources. Frameworks generate daily
    /// compliance results.
    /// </summary>
    public partial class Framework
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a framework is created, in ISO 8601 representation. The value
        /// of <c>CreationTime</c> is accurate to milliseconds. For example, 2020-07-10T15:00:00.000-08:00
        /// represents the 10th of July 2020 at 3:00 PM 8 hours behind UTC.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The deployment status of a framework. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATE_IN_PROGRESS | UPDATE_IN_PROGRESS | DELETE_IN_PROGRESS | COMPLETED | FAILED</c>
        /// 
        /// </para>
        /// </summary>
        public string DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property FrameworkArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string FrameworkArn { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkArn property is set.
        /// </summary>
        internal bool IsSetFrameworkArn() => this.FrameworkArn != null;

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// An optional description of the framework with a maximum 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FrameworkDescription { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkDescription property is set.
        /// </summary>
        internal bool IsSetFrameworkDescription() => this.FrameworkDescription != null;

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        /// The unique name of a framework. This name is between 1 and 256 characters, starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string FrameworkName { get; set; }

        /// <summary>
        /// Checks to see if the FrameworkName property is set.
        /// </summary>
        internal bool IsSetFrameworkName() => this.FrameworkName != null;

        /// <summary>
        /// Gets and sets the property NumberOfControls. 
        /// <para>
        /// The number of controls contained by the framework.
        /// </para>
        /// </summary>
        public int? NumberOfControls { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfControls property is set.
        /// </summary>
        internal bool IsSetNumberOfControls() => this.NumberOfControls.HasValue;
    }
}
