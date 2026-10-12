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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Provides summary information about an App Runner connection resource.
    /// </summary>
    public partial class ConnectionSummary
    {
        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string ConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionArn property is set.
        /// </summary>
        internal bool IsSetConnectionArn() => this.ConnectionArn != null;

        /// <summary>
        /// Gets and sets the property ConnectionName. 
        /// <para>
        /// The customer-provided connection name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 32)]
        public string ConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionName property is set.
        /// </summary>
        internal bool IsSetConnectionName() => this.ConnectionName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The App Runner connection creation time, expressed as a Unix time stamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ProviderType. 
        /// <para>
        /// The source repository provider.
        /// </para>
        /// </summary>
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderType property is set.
        /// </summary>
        internal bool IsSetProviderType() => this.ProviderType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the App Runner connection. When the state is <c>AVAILABLE</c>,
        /// you can use the connection to create an App Runner service.
        /// </para>
        /// </summary>
        public ConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
