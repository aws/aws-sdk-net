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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A summary of UltraServer resources and their current status.
    /// </summary>
    public partial class UltraServerSummary
    {
        private int? _availableSpareInstanceCount;
        private ReservedCapacityInstanceType _instanceType;
        private int? _ultraServerCount;
        private string _ultraServerType;
        private int? _unhealthyInstanceCount;

        /// <summary>
        /// Gets and sets the property AvailableSpareInstanceCount. 
        /// <para>
        /// The number of available spare instances in the UltraServers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? AvailableSpareInstanceCount
        {
            get { return this._availableSpareInstanceCount; }
            set { this._availableSpareInstanceCount = value; }
        }

        // Check to see if AvailableSpareInstanceCount property is set
        internal bool IsSetAvailableSpareInstanceCount()
        {
            return this._availableSpareInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The Amazon EC2 instance type used in the UltraServer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReservedCapacityInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property UltraServerCount. 
        /// <para>
        /// The number of UltraServers of this type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? UltraServerCount
        {
            get { return this._ultraServerCount; }
            set { this._ultraServerCount = value; }
        }

        // Check to see if UltraServerCount property is set
        internal bool IsSetUltraServerCount()
        {
            return this._ultraServerCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UltraServerType. 
        /// <para>
        /// The type of UltraServer, such as ml.u-p6e-gb200x72.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string UltraServerType
        {
            get { return this._ultraServerType; }
            set { this._ultraServerType = value; }
        }

        // Check to see if UltraServerType property is set
        internal bool IsSetUltraServerType()
        {
            return this._ultraServerType != null;
        }

        /// <summary>
        /// Gets and sets the property UnhealthyInstanceCount. 
        /// <para>
        /// The total number of instances across all UltraServers of this type that are currently
        /// in an unhealthy state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? UnhealthyInstanceCount
        {
            get { return this._unhealthyInstanceCount; }
            set { this._unhealthyInstanceCount = value; }
        }

        // Check to see if UnhealthyInstanceCount property is set
        internal bool IsSetUnhealthyInstanceCount()
        {
            return this._unhealthyInstanceCount.HasValue; 
        }

    }
}