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
 * Do not modify this file. This file is generated from the qldb-session-2019-07-11.normal.json service model.
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
namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// Contains the details of the ended session.
    /// </summary>
    public partial class EndSessionResult
    {
        private TimingInformation _timingInformation;

        /// <summary>
        /// Gets and sets the property TimingInformation. 
        /// <para>
        /// Contains server-side performance information for the command.
        /// </para>
        /// </summary>
        public TimingInformation TimingInformation
        {
            get { return this._timingInformation; }
            set { this._timingInformation = value; }
        }

        // Check to see if TimingInformation property is set
        internal bool IsSetTimingInformation()
        {
            return this._timingInformation != null;
        }

    }
}