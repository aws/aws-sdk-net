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
    /// The connection endpoint for an Amazon Redshift cluster.
    /// </summary>
    public partial class AwsRedshiftClusterEndpoint
    {
        /// <summary>
        /// Gets and sets the property Address. 
        /// <para>
        /// The DNS address of the cluster.
        /// </para>
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Checks to see if the Address property is set.
        /// </summary>
        internal bool IsSetAddress() => this.Address != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the database engine listens on.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
