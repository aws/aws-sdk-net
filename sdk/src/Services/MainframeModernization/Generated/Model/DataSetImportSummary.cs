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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Represents a summary of data set imports.
    /// </summary>
    public partial class DataSetImportSummary
    {
        private int? _failed;
        private int? _inProgress;
        private int? _pending;
        private int? _succeeded;
        private int? _total;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of data set imports that have failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property InProgress. 
        /// <para>
        /// The number of data set imports that are in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InProgress
        {
            get { return this._inProgress; }
            set { this._inProgress = value; }
        }

        // Check to see if InProgress property is set
        internal bool IsSetInProgress()
        {
            return this._inProgress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// The number of data set imports that are pending.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// The number of data set imports that have succeeded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Succeeded
        {
            get { return this._succeeded; }
            set { this._succeeded = value; }
        }

        // Check to see if Succeeded property is set
        internal bool IsSetSucceeded()
        {
            return this._succeeded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of data set imports.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}