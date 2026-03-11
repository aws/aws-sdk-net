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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Defines filtering criteria for WorkSpace Instance type searches. Combines multiple
    /// filter conditions including billing mode, platform type, and tenancy to help customers
    /// find instance types that meet their specific requirements.
    /// </summary>
    public partial class InstanceConfigurationFilter
    {
        private BillingMode _billingMode;
        private PlatformTypeEnum _platformType;
        private InstanceConfigurationTenancyEnum _tenancy;

        /// <summary>
        /// Gets and sets the property BillingMode. 
        /// <para>
        /// Filters WorkSpace Instance types based on supported billing modes. Allows customers
        /// to search for instance types that support their preferred billing model, such as HOURLY
        /// or MONTHLY billing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BillingMode BillingMode
        {
            get { return this._billingMode; }
            set { this._billingMode = value; }
        }

        // Check to see if BillingMode property is set
        internal bool IsSetBillingMode()
        {
            return this._billingMode != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformType. 
        /// <para>
        /// Filters WorkSpace Instance types by operating system platform. Allows customers to
        /// find instances that support their desired OS, such as Windows, Linux/UNIX, Ubuntu
        /// Pro, RHEL, or SUSE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PlatformTypeEnum PlatformType
        {
            get { return this._platformType; }
            set { this._platformType = value; }
        }

        // Check to see if PlatformType property is set
        internal bool IsSetPlatformType()
        {
            return this._platformType != null;
        }

        /// <summary>
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Filters WorkSpace Instance types by tenancy model. Allows customers to find instances
        /// that match their tenancy requirements, such as SHARED or DEDICATED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceConfigurationTenancyEnum Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

    }
}