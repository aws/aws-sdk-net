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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// This is the response object from the CreateAlert operation.
    /// </summary>
    public partial class CreateAlertResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Alert. The alert that was created. The same `Alert` shape
        /// GetAlert returns, so a caller need not read the alert back to learn its timestamps
        /// or its minted alert id. {@code alert.state} is absent here — see the `state` member
        /// of `Alert`. Every other member is populated exactly as GetAlert populates it.
        /// </summary>
        [AWSProperty(Required = true)]
        public Alert Alert { get; set; }

        /// <summary>
        /// Checks to see if the Alert property is set.
        /// </summary>
        internal bool IsSetAlert() => this.Alert != null;

        /// <summary>
        /// Gets and sets the property AlertArn. Deprecated. Use `alert.alertArn`, which carries
        /// the same value. Kept so an existing caller keeps working while it moves to `alert`.
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AlertArn { get; set; }

        /// <summary>
        /// Checks to see if the AlertArn property is set.
        /// </summary>
        internal bool IsSetAlertArn() => this.AlertArn != null;
    }
}
