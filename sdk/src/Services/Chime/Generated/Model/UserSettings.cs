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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// Settings associated with an Amazon Chime user, including inbound and outbound calling
    /// and text messaging.
    /// </summary>
    public partial class UserSettings
    {
        private TelephonySettings _telephony;

        /// <summary>
        /// Gets and sets the property Telephony. 
        /// <para>
        /// The telephony settings associated with the user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TelephonySettings Telephony
        {
            get { return this._telephony; }
            set { this._telephony = value; }
        }

        // Check to see if Telephony property is set
        internal bool IsSetTelephony()
        {
            return this._telephony != null;
        }

    }
}