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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelConversionTask operation.
    /// Cancels an active conversion task. The task can be the import of an instance or volume.
    /// The action removes all artifacts of the conversion, including a partially uploaded
    /// volume or instance. If the conversion is complete or is in the process of transferring
    /// the final disk image, the command fails and returns an exception.
    /// </summary>
    public partial class CancelConversionTaskRequest : AmazonEC2Request
    {
        private string _conversionTaskId;
        private bool? _dryRun;
        private string _reasonMessage;

        /// <summary>
        /// Gets and sets the property ConversionTaskId. 
        /// <para>
        /// The ID of the conversion task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConversionTaskId
        {
            get { return this._conversionTaskId; }
            set { this._conversionTaskId = value; }
        }

        // Check to see if ConversionTaskId property is set
        internal bool IsSetConversionTaskId()
        {
            return this._conversionTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReasonMessage. 
        /// <para>
        /// The reason for canceling the conversion task.
        /// </para>
        /// </summary>
        public string ReasonMessage
        {
            get { return this._reasonMessage; }
            set { this._reasonMessage = value; }
        }

        // Check to see if ReasonMessage property is set
        internal bool IsSetReasonMessage()
        {
            return this._reasonMessage != null;
        }

    }
}