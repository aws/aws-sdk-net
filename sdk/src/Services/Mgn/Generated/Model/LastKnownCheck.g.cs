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

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Last known check performed on a launched instance.
    /// </summary>
    public partial class LastKnownCheck
    {
        /// <summary>
        /// Gets and sets the property CheckedAt. 
        /// <para>
        /// Last known check timestamp.
        /// </para>
        /// </summary>
        public DateTime? CheckedAt { get; set; }

        /// <summary>
        /// Checks to see if the CheckedAt property is set.
        /// </summary>
        internal bool IsSetCheckedAt() => this.CheckedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Last known check error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Last known check name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Last known check status.
        /// </para>
        /// </summary>
        public LastKnownCheckStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Last known check type.
        /// </para>
        /// </summary>
        public LastKnownCheckType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
