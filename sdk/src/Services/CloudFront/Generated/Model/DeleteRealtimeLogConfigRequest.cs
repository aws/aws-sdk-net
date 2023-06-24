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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRealtimeLogConfig operation.
    /// Deletes a real-time log configuration.
    /// 
    ///  
    /// <para>
    /// You cannot delete a real-time log configuration if it's attached to a cache behavior.
    /// First update your distributions to remove the real-time log configuration from all
    /// cache behaviors, then delete the real-time log configuration.
    /// </para>
    ///  
    /// <para>
    /// To delete a real-time log configuration, you can provide the configuration's name
    /// or its Amazon Resource Name (ARN). You must provide at least one. If you provide both,
    /// CloudFront uses the name to identify the real-time log configuration to delete.
    /// </para>
    /// </summary>
    public partial class DeleteRealtimeLogConfigRequest : AmazonCloudFrontRequest
    {
        private string _arn;
        private string _name;

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the real-time log configuration to delete.
        /// </para>
        /// </summary>
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the real-time log configuration to delete.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}