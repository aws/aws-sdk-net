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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Specifies the weights for the share identifiers for the fair-share policy. Share identifiers
    /// that aren't included have a default weight of <c>1.0</c>.
    /// </summary>
    public partial class ShareAttributes
    {
        private string _shareIdentifier;
        private float? _weightFactor;

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// A share identifier or share identifier prefix. If the string ends with an asterisk
        /// (*), this entry specifies the weight factor to use for share identifiers that start
        /// with that prefix. The list of share identifiers in a fair-share policy can't overlap.
        /// For example, you can't have one that specifies a <c>shareIdentifier</c> of <c>UserA*</c>
        /// and another that specifies a <c>shareIdentifier</c> of <c>UserA1</c>.
        /// </para>
        ///  
        /// <para>
        /// There can be no more than 500 share identifiers active in a job queue.
        /// </para>
        ///  
        /// <para>
        /// The string is limited to 255 alphanumeric characters, and can be followed by an asterisk
        /// (*).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ShareIdentifier
        {
            get { return this._shareIdentifier; }
            set { this._shareIdentifier = value; }
        }

        // Check to see if ShareIdentifier property is set
        internal bool IsSetShareIdentifier()
        {
            return this._shareIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property WeightFactor. 
        /// <para>
        /// The weight factor for the share identifier. The default value is 1.0. A lower value
        /// has a higher priority for compute resources. For example, jobs that use a share identifier
        /// with a weight factor of 0.125 (1/8) get 8 times the compute resources of jobs that
        /// use a share identifier with a weight factor of 1.
        /// </para>
        ///  
        /// <para>
        /// The smallest supported value is 0.0001, and the largest supported value is 999.9999.
        /// </para>
        /// </summary>
        public float? WeightFactor
        {
            get { return this._weightFactor; }
            set { this._weightFactor = value; }
        }

        // Check to see if WeightFactor property is set
        internal bool IsSetWeightFactor()
        {
            return this._weightFactor.HasValue; 
        }

    }
}