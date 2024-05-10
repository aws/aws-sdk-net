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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The stop CIS message progress.
    /// </summary>
    public partial class StopCisMessageProgress
    {
        private int? _errorChecks;
        private int? _failedChecks;
        private int? _informationalChecks;
        private int? _notApplicableChecks;
        private int? _notEvaluatedChecks;
        private int? _successfulChecks;
        private int? _totalChecks;
        private int? _unknownChecks;

        /// <summary>
        /// Gets and sets the property ErrorChecks. 
        /// <para>
        /// The progress' error checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? ErrorChecks
        {
            get { return this._errorChecks; }
            set { this._errorChecks = value; }
        }

        // Check to see if ErrorChecks property is set
        internal bool IsSetErrorChecks()
        {
            return this._errorChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedChecks. 
        /// <para>
        /// The progress' failed checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? FailedChecks
        {
            get { return this._failedChecks; }
            set { this._failedChecks = value; }
        }

        // Check to see if FailedChecks property is set
        internal bool IsSetFailedChecks()
        {
            return this._failedChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InformationalChecks. 
        /// <para>
        /// The progress' informational checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? InformationalChecks
        {
            get { return this._informationalChecks; }
            set { this._informationalChecks = value; }
        }

        // Check to see if InformationalChecks property is set
        internal bool IsSetInformationalChecks()
        {
            return this._informationalChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotApplicableChecks. 
        /// <para>
        /// The progress' not applicable checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? NotApplicableChecks
        {
            get { return this._notApplicableChecks; }
            set { this._notApplicableChecks = value; }
        }

        // Check to see if NotApplicableChecks property is set
        internal bool IsSetNotApplicableChecks()
        {
            return this._notApplicableChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotEvaluatedChecks. 
        /// <para>
        /// The progress' not evaluated checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? NotEvaluatedChecks
        {
            get { return this._notEvaluatedChecks; }
            set { this._notEvaluatedChecks = value; }
        }

        // Check to see if NotEvaluatedChecks property is set
        internal bool IsSetNotEvaluatedChecks()
        {
            return this._notEvaluatedChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulChecks. 
        /// <para>
        /// The progress' successful checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? SuccessfulChecks
        {
            get { return this._successfulChecks; }
            set { this._successfulChecks = value; }
        }

        // Check to see if SuccessfulChecks property is set
        internal bool IsSetSuccessfulChecks()
        {
            return this._successfulChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalChecks. 
        /// <para>
        /// The progress' total checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? TotalChecks
        {
            get { return this._totalChecks; }
            set { this._totalChecks = value; }
        }

        // Check to see if TotalChecks property is set
        internal bool IsSetTotalChecks()
        {
            return this._totalChecks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnknownChecks. 
        /// <para>
        /// The progress' unknown checks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? UnknownChecks
        {
            get { return this._unknownChecks; }
            set { this._unknownChecks = value; }
        }

        // Check to see if UnknownChecks property is set
        internal bool IsSetUnknownChecks()
        {
            return this._unknownChecks.HasValue; 
        }

    }
}