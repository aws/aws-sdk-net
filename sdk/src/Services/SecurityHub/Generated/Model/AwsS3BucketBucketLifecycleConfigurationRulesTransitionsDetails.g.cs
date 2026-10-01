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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A rule for when objects transition to specific storage classes.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails
    {
        /// <summary>
        /// Gets and sets the property Date. 
        /// <para>
        /// A date on which to transition objects to the specified storage class. If you provide
        /// <c>Date</c>, you cannot provide <c>Days</c>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Checks to see if the Date property is set.
        /// </summary>
        internal bool IsSetDate() => this.Date != null;

        /// <summary>
        /// Gets and sets the property Days. 
        /// <para>
        /// The number of days after which to transition the object to the specified storage class.
        /// If you provide <c>Days</c>, you cannot provide <c>Date</c>.
        /// </para>
        /// </summary>
        public int? Days { get; set; }

        /// <summary>
        /// Checks to see if the Days property is set.
        /// </summary>
        internal bool IsSetDays() => this.Days.HasValue;

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// The storage class to transition the object to. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DEEP_ARCHIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GLACIER</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INTELLIGENT_TIERING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ONEZONE_IA</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD_IA</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}
