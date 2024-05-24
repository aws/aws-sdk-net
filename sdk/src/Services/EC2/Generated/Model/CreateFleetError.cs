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
    /// Describes the instances that could not be launched by the fleet.
    /// </summary>
    public partial class CreateFleetError
    {
        private string _errorCode;
        private string _errorMessage;
        private LaunchTemplateAndOverridesResponse _launchTemplateAndOverrides;
        private InstanceLifecycle _lifecycle;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that indicates why the instance could not be launched. For more information
        /// about error codes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/errors-overview.html">Error
        /// codes</a>.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message that describes why the instance could not be launched. For more
        /// information about error messages, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/errors-overview.html">Error
        /// codes</a>.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplateAndOverrides. 
        /// <para>
        /// The launch templates and overrides that were used for launching the instances. The
        /// values that you specify in the Overrides replace the values in the launch template.
        /// </para>
        /// </summary>
        public LaunchTemplateAndOverridesResponse LaunchTemplateAndOverrides
        {
            get { return this._launchTemplateAndOverrides; }
            set { this._launchTemplateAndOverrides = value; }
        }

        // Check to see if LaunchTemplateAndOverrides property is set
        internal bool IsSetLaunchTemplateAndOverrides()
        {
            return this._launchTemplateAndOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Indicates if the instance that could not be launched was a Spot Instance or On-Demand
        /// Instance.
        /// </para>
        /// </summary>
        public InstanceLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

    }
}