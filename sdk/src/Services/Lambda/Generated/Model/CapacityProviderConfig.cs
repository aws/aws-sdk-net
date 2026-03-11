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
    /// Configuration for the capacity provider that manages compute resources for Lambda
    /// functions.
    /// </summary>
    public partial class CapacityProviderConfig
    {
        private LambdaManagedInstancesCapacityProviderConfig _lambdaManagedInstancesCapacityProviderConfig;

        /// <summary>
        /// Gets and sets the property LambdaManagedInstancesCapacityProviderConfig. 
        /// <para>
        /// Configuration for Lambda-managed instances used by the capacity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LambdaManagedInstancesCapacityProviderConfig LambdaManagedInstancesCapacityProviderConfig
        {
            get { return this._lambdaManagedInstancesCapacityProviderConfig; }
            set { this._lambdaManagedInstancesCapacityProviderConfig = value; }
        }

        // Check to see if LambdaManagedInstancesCapacityProviderConfig property is set
        internal bool IsSetLambdaManagedInstancesCapacityProviderConfig()
        {
            return this._lambdaManagedInstancesCapacityProviderConfig != null;
        }

    }
}