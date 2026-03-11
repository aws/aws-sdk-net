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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration that specifies the permissions required for the capacity provider to
    /// manage compute resources.
    /// </summary>
    public partial class CapacityProviderPermissionsConfig
    {
        private string _capacityProviderOperatorRoleArn;

        /// <summary>
        /// Gets and sets the property CapacityProviderOperatorRoleArn. 
        /// <para>
        /// The ARN of the IAM role that the capacity provider uses to manage compute instances
        /// and other Amazon Web Services resources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CapacityProviderOperatorRoleArn
        {
            get { return this._capacityProviderOperatorRoleArn; }
            set { this._capacityProviderOperatorRoleArn = value; }
        }

        // Check to see if CapacityProviderOperatorRoleArn property is set
        internal bool IsSetCapacityProviderOperatorRoleArn()
        {
            return this._capacityProviderOperatorRoleArn != null;
        }

    }
}