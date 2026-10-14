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

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary counts of each Proton resource types.
    /// </summary>
    public partial class ResourceCountsSummary
    {
        /// <summary>
        /// Gets and sets the property BehindMajor. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that need
        /// a major template version update.
        /// </para>
        /// </summary>
        public int? BehindMajor { get; set; }

        /// <summary>
        /// Checks to see if the BehindMajor property is set.
        /// </summary>
        internal bool IsSetBehindMajor() => this.BehindMajor.HasValue;

        /// <summary>
        /// Gets and sets the property BehindMinor. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that need
        /// a minor template version update.
        /// </para>
        /// </summary>
        public int? BehindMinor { get; set; }

        /// <summary>
        /// Checks to see if the BehindMinor property is set.
        /// </summary>
        internal bool IsSetBehindMinor() => this.BehindMinor.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that failed
        /// to deploy.
        /// </para>
        /// </summary>
        public int? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total number of resources of this type in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Total { get; set; }

        /// <summary>
        /// Checks to see if the Total property is set.
        /// </summary>
        internal bool IsSetTotal() => this.Total.HasValue;

        /// <summary>
        /// Gets and sets the property UpToDate. 
        /// <para>
        /// The number of resources of this type in the Amazon Web Services account that are up-to-date
        /// with their template.
        /// </para>
        /// </summary>
        public int? UpToDate { get; set; }

        /// <summary>
        /// Checks to see if the UpToDate property is set.
        /// </summary>
        internal bool IsSetUpToDate() => this.UpToDate.HasValue;
    }
}
