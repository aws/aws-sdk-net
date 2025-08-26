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
 * Do not modify this file. This file is generated from the arc-zonal-shift-2022-10-30.normal.json service model.
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
namespace Amazon.ARCZonalShift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateZonalAutoshiftConfiguration operation.
    /// The zonal autoshift configuration for a resource includes the practice run configuration
    /// and the status for running autoshifts, zonal autoshift status. When a resource has
    /// a practice run configuration, ARC starts weekly zonal shifts for the resource, to
    /// shift traffic away from an Availability Zone. Weekly practice runs help you to make
    /// sure that your application can continue to operate normally with the loss of one Availability
    /// Zone.
    /// 
    ///  
    /// <para>
    /// You can update the zonal autoshift status to enable or disable zonal autoshift. When
    /// zonal autoshift is <c>ENABLED</c>, you authorize Amazon Web Services to shift away
    /// resource traffic for an application from an Availability Zone during events, on your
    /// behalf, to help reduce time to recovery. Traffic is also shifted away for the required
    /// weekly practice runs.
    /// </para>
    /// </summary>
    public partial class UpdateZonalAutoshiftConfigurationRequest : AmazonARCZonalShiftRequest
    {
        private string _resourceIdentifier;
        private ZonalAutoshiftStatus _zonalAutoshiftStatus;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// The identifier for the resource that you want to update the zonal autoshift configuration
        /// for. The identifier is the Amazon Resource Name (ARN) for the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property ZonalAutoshiftStatus. 
        /// <para>
        /// The zonal autoshift status for the resource that you want to update the zonal autoshift
        /// configuration for. Choose <c>ENABLED</c> to authorize Amazon Web Services to shift
        /// away resource traffic for an application from an Availability Zone during events,
        /// on your behalf, to help reduce time to recovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ZonalAutoshiftStatus ZonalAutoshiftStatus
        {
            get { return this._zonalAutoshiftStatus; }
            set { this._zonalAutoshiftStatus = value; }
        }

        // Check to see if ZonalAutoshiftStatus property is set
        internal bool IsSetZonalAutoshiftStatus()
        {
            return this._zonalAutoshiftStatus != null;
        }

    }
}