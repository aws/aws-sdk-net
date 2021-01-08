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

namespace Amazon.QLDBSession.Model
{
    /// <summary>
    /// Contains the page that was fetched.
    /// </summary>
    public partial class FetchPageResult
    {
        private IOUsage _consumedIOs;
        private Page _page;
        private TimingInformation _timingInformation;

        /// <summary>
        /// Gets and sets the property ConsumedIOs. 
        /// <para>
        /// Contains metrics about the number of I/O requests that were consumed.
        /// </para>
        /// </summary>
        public IOUsage ConsumedIOs
        {
            get { return this._consumedIOs; }
            set { this._consumedIOs = value; }
        }

        // Check to see if ConsumedIOs property is set
        internal bool IsSetConsumedIOs()
        {
            return this._consumedIOs != null;
        }

        /// <summary>
        /// Gets and sets the property Page. 
        /// <para>
        /// Contains details of the fetched page.
        /// </para>
        /// </summary>
        public Page Page
        {
            get { return this._page; }
            set { this._page = value; }
        }

        // Check to see if Page property is set
        internal bool IsSetPage()
        {
            return this._page != null;
        }

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