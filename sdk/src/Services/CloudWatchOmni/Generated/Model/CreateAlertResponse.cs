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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
        private Alert _alert;
        private string _alertArn;

        /// <summary>
        /// Gets and sets the property Alert. 
        /// <para>
        /// The alert that was created. The same <c>Alert</c> shape GetAlert returns, so a caller
        /// need not read the alert back to learn its timestamps or its minted alert id.
        /// </para>
        ///  
        /// <para>
        /// {@code alert.state} is absent here — see the <c>state</c> member of <c>Alert</c>.
        /// Every other member is populated exactly as GetAlert populates it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Alert Alert
        {
            get { return this._alert; }
            set { this._alert = value; }
        }

        // Check to see if Alert property is set
        internal bool IsSetAlert()
        {
            return this._alert != null;
        }

        /// <summary>
        /// Gets and sets the property AlertArn. 
        /// <para>
        /// Deprecated. Use <c>alert.alertArn</c>, which carries the same value. Kept so an existing
        /// caller keeps working while it moves to <c>alert</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AlertArn
        {
            get { return this._alertArn; }
            set { this._alertArn = value; }
        }

        // Check to see if AlertArn property is set
        internal bool IsSetAlertArn()
        {
            return this._alertArn != null;
        }

    }
}