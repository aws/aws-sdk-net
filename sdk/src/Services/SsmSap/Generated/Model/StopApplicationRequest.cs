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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// Container for the parameters to the StopApplication operation.
    /// Request is an operation to stop an application.
    /// 
    ///  
    /// <para>
    /// Parameter <c>ApplicationId</c> is required. Parameters <c>StopConnectedEntity</c>
    /// and <c>IncludeEc2InstanceShutdown</c> are optional.
    /// </para>
    /// </summary>
    public partial class StopApplicationRequest : AmazonSsmSapRequest
    {
        private string _applicationId;
        private bool? _includeEc2InstanceShutdown;
        private ConnectedEntityType _stopConnectedEntity;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=60)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeEc2InstanceShutdown. 
        /// <para>
        /// Boolean. If included and if set to <c>True</c>, the StopApplication operation will
        /// shut down the associated Amazon EC2 instance in addition to the application.
        /// </para>
        /// </summary>
        public bool? IncludeEc2InstanceShutdown
        {
            get { return this._includeEc2InstanceShutdown; }
            set { this._includeEc2InstanceShutdown = value; }
        }

        // Check to see if IncludeEc2InstanceShutdown property is set
        internal bool IsSetIncludeEc2InstanceShutdown()
        {
            return this._includeEc2InstanceShutdown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StopConnectedEntity. 
        /// <para>
        /// Specify the <c>ConnectedEntityType</c>. Accepted type is <c>DBMS</c>.
        /// </para>
        ///  
        /// <para>
        /// If this parameter is included, the connected DBMS (Database Management System) will
        /// be stopped.
        /// </para>
        /// </summary>
        public ConnectedEntityType StopConnectedEntity
        {
            get { return this._stopConnectedEntity; }
            set { this._stopConnectedEntity = value; }
        }

        // Check to see if StopConnectedEntity property is set
        internal bool IsSetStopConnectedEntity()
        {
            return this._stopConnectedEntity != null;
        }

    }
}