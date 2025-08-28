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
 * Do not modify this file. This file is generated from the ssm-sap-2018-05-10.normal.json service model.
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
namespace Amazon.SsmSap.Model
{
    /// <summary>
    /// A summary of rule results, providing counts for each status type.
    /// </summary>
    public partial class RuleStatusCounts
    {
        private int? _failed;
        private int? _info;
        private int? _passed;
        private int? _unknown;
        private int? _warning;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of rules that failed.
        /// </para>
        /// </summary>
        public int? Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Info. 
        /// <para>
        /// The number of rules that returned informational results.
        /// </para>
        /// </summary>
        public int? Info
        {
            get { return this._info; }
            set { this._info = value; }
        }

        // Check to see if Info property is set
        internal bool IsSetInfo()
        {
            return this._info.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Passed. 
        /// <para>
        /// The number of rules that passed.
        /// </para>
        /// </summary>
        public int? Passed
        {
            get { return this._passed; }
            set { this._passed = value; }
        }

        // Check to see if Passed property is set
        internal bool IsSetPassed()
        {
            return this._passed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Unknown. 
        /// <para>
        /// The number of rules with unknown status.
        /// </para>
        /// </summary>
        public int? Unknown
        {
            get { return this._unknown; }
            set { this._unknown = value; }
        }

        // Check to see if Unknown property is set
        internal bool IsSetUnknown()
        {
            return this._unknown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Warning. 
        /// <para>
        /// The number of rules that returned warnings.
        /// </para>
        /// </summary>
        public int? Warning
        {
            get { return this._warning; }
            set { this._warning = value; }
        }

        // Check to see if Warning property is set
        internal bool IsSetWarning()
        {
            return this._warning.HasValue; 
        }

    }
}