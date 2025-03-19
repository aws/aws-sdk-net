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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFlow operation.
    /// Updates an existing flow.
    /// </summary>
    public partial class UpdateFlowRequest : AmazonMediaConnectRequest
    {
        private string _flowArn;
        private UpdateMaintenance _maintenance;
        private NdiConfig _ndiConfig;
        private UpdateFailoverConfig _sourceFailoverConfig;
        private MonitoringConfig _sourceMonitoringConfig;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the flow that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Maintenance. 
        /// <para>
        ///  The maintenance setting of the flow. 
        /// </para>
        /// </summary>
        public UpdateMaintenance Maintenance
        {
            get { return this._maintenance; }
            set { this._maintenance = value; }
        }

        // Check to see if Maintenance property is set
        internal bool IsSetMaintenance()
        {
            return this._maintenance != null;
        }

        /// <summary>
        /// Gets and sets the property NdiConfig. 
        /// <para>
        ///  Specifies the configuration settings for NDI outputs. Required when the flow includes
        /// NDI outputs. 
        /// </para>
        /// </summary>
        public NdiConfig NdiConfig
        {
            get { return this._ndiConfig; }
            set { this._ndiConfig = value; }
        }

        // Check to see if NdiConfig property is set
        internal bool IsSetNdiConfig()
        {
            return this._ndiConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for source failover. 
        /// </para>
        /// </summary>
        public UpdateFailoverConfig SourceFailoverConfig
        {
            get { return this._sourceFailoverConfig; }
            set { this._sourceFailoverConfig = value; }
        }

        // Check to see if SourceFailoverConfig property is set
        internal bool IsSetSourceFailoverConfig()
        {
            return this._sourceFailoverConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceMonitoringConfig. 
        /// <para>
        ///  The settings for source monitoring. 
        /// </para>
        /// </summary>
        public MonitoringConfig SourceMonitoringConfig
        {
            get { return this._sourceMonitoringConfig; }
            set { this._sourceMonitoringConfig = value; }
        }

        // Check to see if SourceMonitoringConfig property is set
        internal bool IsSetSourceMonitoringConfig()
        {
            return this._sourceMonitoringConfig != null;
        }

    }
}