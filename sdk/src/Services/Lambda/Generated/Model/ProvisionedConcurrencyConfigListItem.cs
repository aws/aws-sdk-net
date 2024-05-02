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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Details about the provisioned concurrency configuration for a function alias or version.
    /// </summary>
    public partial class ProvisionedConcurrencyConfigListItem
    {
        private int? _allocatedProvisionedConcurrentExecutions;
        private int? _availableProvisionedConcurrentExecutions;
        private string _functionArn;
        private string _lastModified;
        private int? _requestedProvisionedConcurrentExecutions;
        private ProvisionedConcurrencyStatusEnum _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AllocatedProvisionedConcurrentExecutions. 
        /// <para>
        /// The amount of provisioned concurrency allocated. When a weighted alias is used during
        /// linear and canary deployments, this value fluctuates depending on the amount of concurrency
        /// that is provisioned for the function versions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AllocatedProvisionedConcurrentExecutions
        {
            get { return this._allocatedProvisionedConcurrentExecutions; }
            set { this._allocatedProvisionedConcurrentExecutions = value; }
        }

        // Check to see if AllocatedProvisionedConcurrentExecutions property is set
        internal bool IsSetAllocatedProvisionedConcurrentExecutions()
        {
            return this._allocatedProvisionedConcurrentExecutions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailableProvisionedConcurrentExecutions. 
        /// <para>
        /// The amount of provisioned concurrency available.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AvailableProvisionedConcurrentExecutions
        {
            get { return this._availableProvisionedConcurrentExecutions; }
            set { this._availableProvisionedConcurrentExecutions = value; }
        }

        // Check to see if AvailableProvisionedConcurrentExecutions property is set
        internal bool IsSetAvailableProvisionedConcurrentExecutions()
        {
            return this._availableProvisionedConcurrentExecutions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FunctionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alias or version.
        /// </para>
        /// </summary>
        public string FunctionArn
        {
            get { return this._functionArn; }
            set { this._functionArn = value; }
        }

        // Check to see if FunctionArn property is set
        internal bool IsSetFunctionArn()
        {
            return this._functionArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that a user last updated the configuration, in <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO
        /// 8601 format</a>.
        /// </para>
        /// </summary>
        public string LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified != null;
        }

        /// <summary>
        /// Gets and sets the property RequestedProvisionedConcurrentExecutions. 
        /// <para>
        /// The amount of provisioned concurrency requested.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? RequestedProvisionedConcurrentExecutions
        {
            get { return this._requestedProvisionedConcurrentExecutions; }
            set { this._requestedProvisionedConcurrentExecutions = value; }
        }

        // Check to see if RequestedProvisionedConcurrentExecutions property is set
        internal bool IsSetRequestedProvisionedConcurrentExecutions()
        {
            return this._requestedProvisionedConcurrentExecutions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the allocation process.
        /// </para>
        /// </summary>
        public ProvisionedConcurrencyStatusEnum Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// For failed allocations, the reason that provisioned concurrency could not be allocated.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}