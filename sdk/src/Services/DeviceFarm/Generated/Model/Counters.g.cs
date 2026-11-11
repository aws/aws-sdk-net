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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents entity counters.
    /// </summary>
    public partial class Counters
    {
        /// <summary>
        /// Gets and sets the property Errored. 
        /// <para>
        /// The number of errored entities.
        /// </para>
        /// </summary>
        public int? Errored { get; set; }

        /// <summary>
        /// Checks to see if the Errored property is set.
        /// </summary>
        internal bool IsSetErrored() => this.Errored.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of failed entities.
        /// </para>
        /// </summary>
        public int? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property Passed. 
        /// <para>
        /// The number of passed entities.
        /// </para>
        /// </summary>
        public int? Passed { get; set; }

        /// <summary>
        /// Checks to see if the Passed property is set.
        /// </summary>
        internal bool IsSetPassed() => this.Passed.HasValue;

        /// <summary>
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The number of skipped entities.
        /// </para>
        /// </summary>
        public int? Skipped { get; set; }

        /// <summary>
        /// Checks to see if the Skipped property is set.
        /// </summary>
        internal bool IsSetSkipped() => this.Skipped.HasValue;

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The number of stopped entities.
        /// </para>
        /// </summary>
        public int? Stopped { get; set; }

        /// <summary>
        /// Checks to see if the Stopped property is set.
        /// </summary>
        internal bool IsSetStopped() => this.Stopped.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of entities.
        /// </para>
        /// </summary>
        public int? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;

        /// <summary>
        /// Gets and sets the property Warned. 
        /// <para>
        /// The number of warned entities.
        /// </para>
        /// </summary>
        public int? Warned { get; set; }

        /// <summary>
        /// Checks to see if the Warned property is set.
        /// </summary>
        internal bool IsSetWarned() => this.Warned.HasValue;
    }
}
