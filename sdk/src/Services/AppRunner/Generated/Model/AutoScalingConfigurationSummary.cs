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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
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
namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Provides summary information about an App Runner automatic scaling configuration resource.
    /// 
    ///  
    /// <para>
    /// This type contains limited information about an auto scaling configuration. It includes
    /// only identification information, without configuration details. It's returned by the
    /// <a>ListAutoScalingConfigurations</a> action. Complete configuration information is
    /// returned by the <a>CreateAutoScalingConfiguration</a>, <a>DescribeAutoScalingConfiguration</a>,
    /// and <a>DeleteAutoScalingConfiguration</a> actions using the <a>AutoScalingConfiguration</a>
    /// type.
    /// </para>
    /// </summary>
    public partial class AutoScalingConfigurationSummary
    {
        private string _autoScalingConfigurationArn;
        private string _autoScalingConfigurationName;
        private int? _autoScalingConfigurationRevision;
        private DateTime? _createdAt;
        private bool? _hasAssociatedService;
        private bool? _isDefault;
        private AutoScalingConfigurationStatus _status;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this auto scaling configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string AutoScalingConfigurationArn
        {
            get { return this._autoScalingConfigurationArn; }
            set { this._autoScalingConfigurationArn = value; }
        }

        // Check to see if AutoScalingConfigurationArn property is set
        internal bool IsSetAutoScalingConfigurationArn()
        {
            return this._autoScalingConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationName. 
        /// <para>
        /// The customer-provided auto scaling configuration name. It can be used in multiple
        /// revisions of a configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=32)]
        public string AutoScalingConfigurationName
        {
            get { return this._autoScalingConfigurationName; }
            set { this._autoScalingConfigurationName = value; }
        }

        // Check to see if AutoScalingConfigurationName property is set
        internal bool IsSetAutoScalingConfigurationName()
        {
            return this._autoScalingConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationRevision. 
        /// <para>
        /// The revision of this auto scaling configuration. It's unique among all the active
        /// configurations (<c>"Status": "ACTIVE"</c>) with the same <c>AutoScalingConfigurationName</c>.
        /// </para>
        /// </summary>
        public int? AutoScalingConfigurationRevision
        {
            get { return this._autoScalingConfigurationRevision; }
            set { this._autoScalingConfigurationRevision = value; }
        }

        // Check to see if AutoScalingConfigurationRevision property is set
        internal bool IsSetAutoScalingConfigurationRevision()
        {
            return this._autoScalingConfigurationRevision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the auto scaling configuration was created. It's in Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HasAssociatedService. 
        /// <para>
        /// Indicates if this auto scaling configuration has an App Runner service associated
        /// with it. A value of <c>true</c> indicates one or more services are associated. A value
        /// of <c>false</c> indicates no services are associated.
        /// </para>
        /// </summary>
        public bool? HasAssociatedService
        {
            get { return this._hasAssociatedService; }
            set { this._hasAssociatedService = value; }
        }

        // Check to see if HasAssociatedService property is set
        internal bool IsSetHasAssociatedService()
        {
            return this._hasAssociatedService.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates if this auto scaling configuration should be used as the default for a new
        /// App Runner service that does not have an auto scaling configuration ARN specified
        /// during creation. Each account can have only one default <c>AutoScalingConfiguration</c>
        /// per region. The default <c>AutoScalingConfiguration</c> can be any revision under
        /// the same <c>AutoScalingConfigurationName</c>.
        /// </para>
        /// </summary>
        public bool? IsDefault
        {
            get { return this._isDefault; }
            set { this._isDefault = value; }
        }

        // Check to see if IsDefault property is set
        internal bool IsSetIsDefault()
        {
            return this._isDefault.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the auto scaling configuration. If the status of a configuration
        /// revision is <c>INACTIVE</c>, it was deleted and can't be used. Inactive configuration
        /// revisions are permanently removed some time after they are deleted.
        /// </para>
        /// </summary>
        public AutoScalingConfigurationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}