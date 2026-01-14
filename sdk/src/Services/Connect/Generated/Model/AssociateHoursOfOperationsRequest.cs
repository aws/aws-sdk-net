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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateHoursOfOperations operation.
    /// Associates a set of hours of operations with another hours of operation. Refer to
    /// Administrator Guide <a href="https://docs.aws.amazon.com/connect/latest/adminguide/hours-of-operation-overrides.html">
    /// here </a> for more information on inheriting overrides from parent hours of operation(s).
    /// </summary>
    public partial class AssociateHoursOfOperationsRequest : AmazonConnectRequest
    {
        private string _hoursOfOperationId;
        private string _instanceId;
        private List<ParentHoursOfOperationConfig> _parentHoursOfOperationConfigs = AWSConfigs.InitializeCollections ? new List<ParentHoursOfOperationConfig>() : null;

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier of the child hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HoursOfOperationId
        {
            get { return this._hoursOfOperationId; }
            set { this._hoursOfOperationId = value; }
        }

        // Check to see if HoursOfOperationId property is set
        internal bool IsSetHoursOfOperationId()
        {
            return this._hoursOfOperationId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ParentHoursOfOperationConfigs. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the parent hours of operation resources to associate
        /// with the child hours of operation resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=3)]
        public List<ParentHoursOfOperationConfig> ParentHoursOfOperationConfigs
        {
            get { return this._parentHoursOfOperationConfigs; }
            set { this._parentHoursOfOperationConfigs = value; }
        }

        // Check to see if ParentHoursOfOperationConfigs property is set
        internal bool IsSetParentHoursOfOperationConfigs()
        {
            return this._parentHoursOfOperationConfigs != null && (this._parentHoursOfOperationConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}