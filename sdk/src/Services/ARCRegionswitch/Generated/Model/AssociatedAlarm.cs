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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// An Amazon CloudWatch alarm associated with a Region switch plan. These alarms can
    /// be used to trigger automatic execution of the plan.
    /// </summary>
    public partial class AssociatedAlarm
    {
        private AlarmType _alarmType;
        private string _crossAccountRole;
        private string _externalId;
        private string _resourceIdentifier;

        /// <summary>
        /// Gets and sets the property AlarmType. 
        /// <para>
        /// The alarm type for an associated alarm. An associated CloudWatch alarm can be an application
        /// health alarm or a trigger alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlarmType AlarmType
        {
            get { return this._alarmType; }
            set { this._alarmType = value; }
        }

        // Check to see if AlarmType property is set
        internal bool IsSetAlarmType()
        {
            return this._alarmType != null;
        }

        /// <summary>
        /// Gets and sets the property CrossAccountRole. 
        /// <para>
        /// The cross account role for the configuration.
        /// </para>
        /// </summary>
        public string CrossAccountRole
        {
            get { return this._crossAccountRole; }
            set { this._crossAccountRole = value; }
        }

        // Check to see if CrossAccountRole property is set
        internal bool IsSetCrossAccountRole()
        {
            return this._crossAccountRole != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID (secret key) for the configuration.
        /// </para>
        /// </summary>
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The resource identifier for alarms that you associate with a plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}