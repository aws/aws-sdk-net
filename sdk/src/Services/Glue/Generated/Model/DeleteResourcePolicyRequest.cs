/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourcePolicy operation.
    /// Deletes a specified policy.
    /// </summary>
    public partial class DeleteResourcePolicyRequest : AmazonGlueRequest
    {
        private string _policyHashCondition;

        /// <summary>
        /// Gets and sets the property PolicyHashCondition. 
        /// <para>
        /// The hash value returned when this policy was set.
        /// </para>
        /// </summary>
        public string PolicyHashCondition
        {
            get { return this._policyHashCondition; }
            set { this._policyHashCondition = value; }
        }

        // Check to see if PolicyHashCondition property is set
        internal bool IsSetPolicyHashCondition()
        {
            return this._policyHashCondition != null;
        }

    }
}