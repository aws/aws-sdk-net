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
    /// Container for the parameters to the UpdateSchedulingPolicy operation.
    /// Updates a scheduling policy.
    /// </summary>
    public partial class UpdateSchedulingPolicyRequest : AmazonBatchRequest
    {
        private string _arn;
        private FairsharePolicy _fairsharePolicy;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the scheduling policy to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property FairsharePolicy. 
        /// <para>
        /// The fair-share policy scheduling details.
        /// </para>
        /// </summary>
        public FairsharePolicy FairsharePolicy
        {
            get { return this._fairsharePolicy; }
            set { this._fairsharePolicy = value; }
        }

        // Check to see if FairsharePolicy property is set
        internal bool IsSetFairsharePolicy()
        {
            return this._fairsharePolicy != null;
        }

    }
}