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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
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
namespace Amazon.IVS.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRecordingConfiguration operation.
    /// Deletes the recording configuration for the specified ARN.
    /// 
    ///  
    /// <para>
    /// If you try to delete a recording configuration that is associated with a channel,
    /// you will get an error (409 ConflictException). To avoid this, for all channels that
    /// reference the recording configuration, first use <a>UpdateChannel</a> to set the <c>recordingConfigurationArn</c>
    /// field to an empty string, then use DeleteRecordingConfiguration.
    /// </para>
    /// </summary>
    public partial class DeleteRecordingConfigurationRequest : AmazonIVSRequest
    {
        private string _arn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// ARN of the recording configuration to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=128)]
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

    }
}