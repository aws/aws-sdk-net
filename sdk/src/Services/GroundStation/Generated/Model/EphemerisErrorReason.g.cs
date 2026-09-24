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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Detailed error information for ephemeris validation failures.
    /// 
    ///  
    /// <para>
    /// Provides an error code and descriptive message to help diagnose and resolve validation
    /// issues.
    /// </para>
    /// </summary>
    public partial class EphemerisErrorReason
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code identifying the type of validation failure.
        /// </para>
        ///  
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/ground-station/latest/ug/troubleshooting-invalid-ephemerides.html">Troubleshooting
        /// Invalid Ephemerides guide</a> for error code details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EphemerisErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable message describing the validation failure.
        /// </para>
        ///  
        /// <para>
        /// Provides specific details about what failed and may include suggestions for remediation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1000)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;
    }
}
