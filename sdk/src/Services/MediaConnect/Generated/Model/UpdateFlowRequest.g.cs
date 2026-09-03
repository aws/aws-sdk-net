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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateFlow operation. Updates an existing flow.
    /// <note> <para> Because <c>UpdateFlowSources</c> and <c>UpdateFlow</c> are separate
    /// operations, you can't change both the source type AND the flow size in a single request.
    /// </para> <ul> <li> <para> If you have a <c>MEDIUM</c> flow and you want to change the
    /// flow source to NDI®: </para> <ul> <li> <para> First, use the <c>UpdateFlow</c> operation
    /// to upgrade the flow size to <c>LARGE</c>. </para> </li> <li> <para> After that, you
    /// can then use the <c>UpdateFlowSource</c> operation to configure the NDI source. </para>
    /// </li> </ul> </li> <li> <para> If you're switching from an NDI source to a transport
    /// stream (TS) source and want to downgrade the flow size: </para> <ul> <li> <para> First,
    /// use the <c>UpdateFlowSource</c> operation to change the flow source type. </para>
    /// </li> <li> <para> After that, you can then use the <c>UpdateFlow</c> operation to
    /// downgrade the flow size to <c>MEDIUM</c>. </para> </li> </ul> </li> </ul> </note>
    /// </summary>
    public partial class UpdateFlowRequest : AmazonMediaConnectRequest
    {
        /// <summary>
        /// Gets and sets the property EncodingConfig.
        /// </summary>
        public EncodingConfig EncodingConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncodingConfig property is set.
        /// </summary>
        internal bool IsSetEncodingConfig() => this.EncodingConfig != null;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the flow that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FlowArn { get; set; }

        /// <summary>
        /// Checks to see if the FlowArn property is set.
        /// </summary>
        internal bool IsSetFlowArn() => this.FlowArn != null;

        /// <summary>
        /// Gets and sets the property FlowSize. 
        /// <para>
        ///  Determines the processing capacity and feature set of the flow. 
        /// </para>
        /// </summary>
        public FlowSize FlowSize { get; set; }

        /// <summary>
        /// Checks to see if the FlowSize property is set.
        /// </summary>
        internal bool IsSetFlowSize() => this.FlowSize != null;

        /// <summary>
        /// Gets and sets the property Maintenance. 
        /// <para>
        ///  The maintenance setting of the flow. 
        /// </para>
        /// </summary>
        public UpdateMaintenance Maintenance { get; set; }

        /// <summary>
        /// Checks to see if the Maintenance property is set.
        /// </summary>
        internal bool IsSetMaintenance() => this.Maintenance != null;

        /// <summary>
        /// Gets and sets the property NdiConfig. 
        /// <para>
        ///  Specifies the configuration settings for a flow's NDI source or output. Required
        /// when the flow includes an NDI source or output. 
        /// </para>
        /// </summary>
        public NdiConfig NdiConfig { get; set; }

        /// <summary>
        /// Checks to see if the NdiConfig property is set.
        /// </summary>
        internal bool IsSetNdiConfig() => this.NdiConfig != null;

        /// <summary>
        /// Gets and sets the property SourceFailoverConfig. 
        /// <para>
        ///  The settings for source failover. 
        /// </para>
        /// </summary>
        public UpdateFailoverConfig SourceFailoverConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceFailoverConfig property is set.
        /// </summary>
        internal bool IsSetSourceFailoverConfig() => this.SourceFailoverConfig != null;

        /// <summary>
        /// Gets and sets the property SourceMonitoringConfig. 
        /// <para>
        ///  The settings for source monitoring. 
        /// </para>
        /// </summary>
        public MonitoringConfig SourceMonitoringConfig { get; set; }

        /// <summary>
        /// Checks to see if the SourceMonitoringConfig property is set.
        /// </summary>
        internal bool IsSetSourceMonitoringConfig() => this.SourceMonitoringConfig != null;
    }
}
