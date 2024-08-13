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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
        private int? _errored;
        private int? _failed;
        private int? _passed;
        private int? _skipped;
        private int? _stopped;
        private int? _total;
        private int? _warned;

        /// <summary>
        /// Gets and sets the property Errored. 
        /// <para>
        /// The number of errored entities.
        /// </para>
        /// </summary>
        public int? Errored
        {
            get { return this._errored; }
            set { this._errored = value; }
        }

        // Check to see if Errored property is set
        internal bool IsSetErrored()
        {
            return this._errored.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of failed entities.
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
        /// Gets and sets the property Passed. 
        /// <para>
        /// The number of passed entities.
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
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The number of skipped entities.
        /// </para>
        /// </summary>
        public int? Skipped
        {
            get { return this._skipped; }
            set { this._skipped = value; }
        }

        // Check to see if Skipped property is set
        internal bool IsSetSkipped()
        {
            return this._skipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The number of stopped entities.
        /// </para>
        /// </summary>
        public int? Stopped
        {
            get { return this._stopped; }
            set { this._stopped = value; }
        }

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this._stopped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of entities.
        /// </para>
        /// </summary>
        public int? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Warned. 
        /// <para>
        /// The number of warned entities.
        /// </para>
        /// </summary>
        public int? Warned
        {
            get { return this._warned; }
            set { this._warned = value; }
        }

        // Check to see if Warned property is set
        internal bool IsSetWarned()
        {
            return this._warned.HasValue; 
        }

    }
}