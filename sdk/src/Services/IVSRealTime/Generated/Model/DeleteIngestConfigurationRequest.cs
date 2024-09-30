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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
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
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteIngestConfiguration operation.
    /// Deletes a specified IngestConfiguration, so it can no longer be used to broadcast.
    /// An IngestConfiguration cannot be deleted if the publisher is actively streaming to
    /// a stage, unless <c>force</c> is set to <c>true</c>.
    /// </summary>
    public partial class DeleteIngestConfigurationRequest : AmazonIVSRealTimeRequest
    {
        private string _arn;
        private bool? _force;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the IngestConfiguration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Force. 
        /// <para>
        /// Optional field to force deletion of the IngestConfiguration. If this is set to <c>true</c>
        /// when a participant is actively publishing, the participant is disconnected from the
        /// stage, followed by deletion of the IngestConfiguration. Default: <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

    }
}