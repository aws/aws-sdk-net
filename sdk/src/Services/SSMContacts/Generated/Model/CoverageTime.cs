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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about when an on-call shift begins and ends.
    /// </summary>
    public partial class CoverageTime
    {
        private HandOffTime _end;
        private HandOffTime _start;

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// Information about when the on-call rotation shift ends.
        /// </para>
        /// </summary>
        public HandOffTime End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end != null;
        }

        /// <summary>
        /// Gets and sets the property Start. 
        /// <para>
        /// Information about when the on-call rotation shift begins.
        /// </para>
        /// </summary>
        public HandOffTime Start
        {
            get { return this._start; }
            set { this._start = value; }
        }

        // Check to see if Start property is set
        internal bool IsSetStart()
        {
            return this._start != null;
        }

    }
}