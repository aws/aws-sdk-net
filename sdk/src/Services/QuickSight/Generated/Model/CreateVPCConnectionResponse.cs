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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the CreateVPCConnection operation.
    /// </summary>
    public partial class CreateVPCConnectionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private VPCConnectionAvailabilityStatus _availabilityStatus;
        private VPCConnectionResourceStatus _creationStatus;
        private string _requestId;
        private int? _status;
        private string _vpcConnectionId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC connection.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityStatus. 
        /// <para>
        /// The availability status of the VPC connection.
        /// </para>
        /// </summary>
        public VPCConnectionAvailabilityStatus AvailabilityStatus
        {
            get { return this._availabilityStatus; }
            set { this._availabilityStatus = value; }
        }

        // Check to see if AvailabilityStatus property is set
        internal bool IsSetAvailabilityStatus()
        {
            return this._availabilityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreationStatus. 
        /// <para>
        /// The status of the creation of the VPC connection.
        /// </para>
        /// </summary>
        public VPCConnectionResourceStatus CreationStatus
        {
            get { return this._creationStatus; }
            set { this._creationStatus = value; }
        }

        // Check to see if CreationStatus property is set
        internal bool IsSetCreationStatus()
        {
            return this._creationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VPCConnectionId. 
        /// <para>
        /// The ID for the VPC connection that you're creating. This ID is unique per Amazon Web
        /// Services Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string VPCConnectionId
        {
            get { return this._vpcConnectionId; }
            set { this._vpcConnectionId = value; }
        }

        // Check to see if VPCConnectionId property is set
        internal bool IsSetVPCConnectionId()
        {
            return this._vpcConnectionId != null;
        }

    }
}