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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains detailed information about a framework. Frameworks contain controls, which
    /// evaluate and report on your backup events and resources. Frameworks generate daily
    /// compliance results.
    /// </summary>
    public partial class Framework
    {
        private DateTime? _creationTime;
        private string _deploymentStatus;
        private string _frameworkArn;
        private string _frameworkDescription;
        private string _frameworkName;
        private int? _numberOfControls;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a framework is created, in ISO 8601 representation. The value
        /// of <code>CreationTime</code> is accurate to milliseconds. For example, 2020-07-10T15:00:00.000-08:00
        /// represents the 10th of July 2020 at 3:00 PM 8 hours behind UTC.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The deployment status of a framework. The statuses are:
        /// </para>
        ///  
        /// <para>
        ///  <code>CREATE_IN_PROGRESS | UPDATE_IN_PROGRESS | DELETE_IN_PROGRESS | COMPLETED |
        /// FAILED</code> 
        /// </para>
        /// </summary>
        public string DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the resource type.
        /// </para>
        /// </summary>
        public string FrameworkArn
        {
            get { return this._frameworkArn; }
            set { this._frameworkArn = value; }
        }

        // Check to see if FrameworkArn property is set
        internal bool IsSetFrameworkArn()
        {
            return this._frameworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// An optional description of the framework with a maximum 1,024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FrameworkDescription
        {
            get { return this._frameworkDescription; }
            set { this._frameworkDescription = value; }
        }

        // Check to see if FrameworkDescription property is set
        internal bool IsSetFrameworkDescription()
        {
            return this._frameworkDescription != null;
        }

        /// <summary>
        /// Gets and sets the property FrameworkName. 
        /// <para>
        /// The unique name of a framework. This name is between 1 and 256 characters, starting
        /// with a letter, and consisting of letters (a-z, A-Z), numbers (0-9), and underscores
        /// (_).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FrameworkName
        {
            get { return this._frameworkName; }
            set { this._frameworkName = value; }
        }

        // Check to see if FrameworkName property is set
        internal bool IsSetFrameworkName()
        {
            return this._frameworkName != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfControls. 
        /// <para>
        /// The number of controls contained by the framework.
        /// </para>
        /// </summary>
        public int NumberOfControls
        {
            get { return this._numberOfControls.GetValueOrDefault(); }
            set { this._numberOfControls = value; }
        }

        // Check to see if NumberOfControls property is set
        internal bool IsSetNumberOfControls()
        {
            return this._numberOfControls.HasValue; 
        }

    }
}