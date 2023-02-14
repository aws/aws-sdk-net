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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary counts of each Proton resource types.
    /// </summary>
    public partial class ResourceCountsSummary
    {
        private int? _behindMajor;
        private int? _behindMinor;
        private int? _failed;
        private int? _total;
        private int? _upToDate;

        /// <summary>
        /// Gets and sets the property BehindMajor. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that need
        /// a major template version update.
        /// </para>
        /// </summary>
        public int BehindMajor
        {
            get { return this._behindMajor.GetValueOrDefault(); }
            set { this._behindMajor = value; }
        }

        // Check to see if BehindMajor property is set
        internal bool IsSetBehindMajor()
        {
            return this._behindMajor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BehindMinor. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that need
        /// a minor template version update.
        /// </para>
        /// </summary>
        public int BehindMinor
        {
            get { return this._behindMinor.GetValueOrDefault(); }
            set { this._behindMinor = value; }
        }

        // Check to see if BehindMinor property is set
        internal bool IsSetBehindMinor()
        {
            return this._behindMinor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that failed
        /// to deploy.
        /// </para>
        /// </summary>
        public int Failed
        {
            get { return this._failed.GetValueOrDefault(); }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of resources of this type in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Total
        {
            get { return this._total.GetValueOrDefault(); }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpToDate. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that are up-to-date
        /// with their template.
        /// </para>
        /// </summary>
        public int UpToDate
        {
            get { return this._upToDate.GetValueOrDefault(); }
            set { this._upToDate = value; }
        }

        // Check to see if UpToDate property is set
        internal bool IsSetUpToDate()
        {
            return this._upToDate.HasValue; 
        }

    }
}