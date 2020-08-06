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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// The reference rule that partially matches the <code>ViolationTarget</code> rule and
    /// violation reason.
    /// </summary>
    public partial class PartialMatch
    {
        private string _reference;
        private List<string> _targetViolationReasons = new List<string>();

        /// <summary>
        /// Gets and sets the property Reference. 
        /// <para>
        /// The reference rule from the master security group of the AWS Firewall Manager policy.
        /// </para>
        /// </summary>
        public string Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

        /// <summary>
        /// Gets and sets the property TargetViolationReasons. 
        /// <para>
        /// The violation reason.
        /// </para>
        /// </summary>
        public List<string> TargetViolationReasons
        {
            get { return this._targetViolationReasons; }
            set { this._targetViolationReasons = value; }
        }

        // Check to see if TargetViolationReasons property is set
        internal bool IsSetTargetViolationReasons()
        {
            return this._targetViolationReasons != null && this._targetViolationReasons.Count > 0; 
        }

    }
}