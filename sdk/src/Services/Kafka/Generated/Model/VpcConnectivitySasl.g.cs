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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Details for SASL client authentication for VPC connectivity.
    /// </summary>
    public partial class VpcConnectivitySasl
    {
        /// <summary>
        /// Gets and sets the property Iam. 
        /// <para>
        /// Details for SASL/IAM client authentication for VPC connectivity.
        /// </para>
        /// </summary>
        public VpcConnectivityIam Iam { get; set; }

        /// <summary>
        /// Checks to see if the Iam property is set.
        /// </summary>
        internal bool IsSetIam() => this.Iam != null;

        /// <summary>
        /// Gets and sets the property Scram. 
        /// <para>
        /// Details for SASL/SCRAM client authentication for VPC connectivity.
        /// </para>
        /// </summary>
        public VpcConnectivityScram Scram { get; set; }

        /// <summary>
        /// Checks to see if the Scram property is set.
        /// </summary>
        internal bool IsSetScram() => this.Scram != null;
    }
}
