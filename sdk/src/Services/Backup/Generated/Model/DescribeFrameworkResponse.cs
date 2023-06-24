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
    /// This is the response object from the DescribeFramework operation.
    /// </summary>
    public partial class DescribeFrameworkResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _deploymentStatus;
        private string _frameworkArn;
        private List<FrameworkControl> _frameworkControls = new List<FrameworkControl>();
        private string _frameworkDescription;
        private string _frameworkName;
        private string _frameworkStatus;
        private string _idempotencyToken;

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
        /// Gets and sets the property FrameworkControls. 
        /// <para>
        /// A list of the controls that make up the framework. Each control in the list has a
        /// name, input parameters, and scope.
        /// </para>
        /// </summary>
        public List<FrameworkControl> FrameworkControls
        {
            get { return this._frameworkControls; }
            set { this._frameworkControls = value; }
        }

        // Check to see if FrameworkControls property is set
        internal bool IsSetFrameworkControls()
        {
            return this._frameworkControls != null && this._frameworkControls.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FrameworkDescription. 
        /// <para>
        /// An optional description of the framework.
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
        /// The unique name of a framework.
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
        /// Gets and sets the property FrameworkStatus. 
        /// <para>
        /// A framework consists of one or more controls. Each control governs a resource, such
        /// as backup plans, backup selections, backup vaults, or recovery points. You can also
        /// turn Config recording on or off for each resource. The statuses are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> when recording is turned on for all resources governed by the
        /// framework.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PARTIALLY_ACTIVE</code> when recording is turned off for at least one resource
        /// governed by the framework.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INACTIVE</code> when recording is turned off for all resources governed by
        /// the framework.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UNAVAILABLE</code> when Backup is unable to validate recording status at this
        /// time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string FrameworkStatus
        {
            get { return this._frameworkStatus; }
            set { this._frameworkStatus = value; }
        }

        // Check to see if FrameworkStatus property is set
        internal bool IsSetFrameworkStatus()
        {
            return this._frameworkStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A customer-chosen string that you can use to distinguish between otherwise identical
        /// calls to <code>DescribeFrameworkOutput</code>. Retrying a successful request with
        /// the same idempotency token results in a success message with no action taken.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

    }
}