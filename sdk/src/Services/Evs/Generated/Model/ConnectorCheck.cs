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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// A check on a connector to identify connectivity health.
    /// </summary>
    public partial class ConnectorCheck
    {
        private DateTime? _impairedSince;
        private DateTime? _lastCheckAttempt;
        private CheckResult _result;
        private CheckType _type;

        /// <summary>
        /// Gets and sets the property ImpairedSince. 
        /// <para>
        /// The time when connector health began to be impaired.
        /// </para>
        /// </summary>
        public DateTime? ImpairedSince
        {
            get { return this._impairedSince; }
            set { this._impairedSince = value; }
        }

        // Check to see if ImpairedSince property is set
        internal bool IsSetImpairedSince()
        {
            return this._impairedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastCheckAttempt. 
        /// <para>
        /// The date and time of the last check attempt.
        /// </para>
        /// </summary>
        public DateTime? LastCheckAttempt
        {
            get { return this._lastCheckAttempt; }
            set { this._lastCheckAttempt = value; }
        }

        // Check to see if LastCheckAttempt property is set
        internal bool IsSetLastCheckAttempt()
        {
            return this._lastCheckAttempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The check result.
        /// </para>
        /// </summary>
        public CheckResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The check type.
        /// </para>
        /// </summary>
        public CheckType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}