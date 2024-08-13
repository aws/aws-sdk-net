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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The asset statistics from the data source run.
    /// </summary>
    public partial class RunStatisticsForAssets
    {
        private int? _added;
        private int? _failed;
        private int? _skipped;
        private int? _unchanged;
        private int? _updated;

        /// <summary>
        /// Gets and sets the property Added. 
        /// <para>
        /// The <c>added</c> statistic for the data source run.
        /// </para>
        /// </summary>
        public int? Added
        {
            get { return this._added; }
            set { this._added = value; }
        }

        // Check to see if Added property is set
        internal bool IsSetAdded()
        {
            return this._added.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The <c>failed</c> statistic for the data source run.
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
        /// Gets and sets the property Skipped. 
        /// <para>
        /// The <c>skipped</c> statistic for the data source run.
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
        /// Gets and sets the property Unchanged. 
        /// <para>
        /// The <c>unchanged</c> statistic for the data source run.
        /// </para>
        /// </summary>
        public int? Unchanged
        {
            get { return this._unchanged; }
            set { this._unchanged = value; }
        }

        // Check to see if Unchanged property is set
        internal bool IsSetUnchanged()
        {
            return this._unchanged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Updated. 
        /// <para>
        /// The <c>updated</c> statistic for the data source run.
        /// </para>
        /// </summary>
        public int? Updated
        {
            get { return this._updated; }
            set { this._updated = value; }
        }

        // Check to see if Updated property is set
        internal bool IsSetUpdated()
        {
            return this._updated.HasValue; 
        }

    }
}