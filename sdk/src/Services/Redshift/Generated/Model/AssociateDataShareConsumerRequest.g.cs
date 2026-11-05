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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateDataShareConsumer operation. From a datashare
    /// consumer account, associates a datashare with the account (AssociateEntireAccount)
    /// or the specified namespace (ConsumerArn). If you make this association, the consumer
    /// can consume the datashare.
    /// </summary>
    public partial class AssociateDataShareConsumerRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property AllowWrites. 
        /// <para>
        /// If set to true, allows write operations for a datashare.
        /// </para>
        /// </summary>
        public bool? AllowWrites { get; set; }

        /// <summary>
        /// Checks to see if the AllowWrites property is set.
        /// </summary>
        internal bool IsSetAllowWrites() => this.AllowWrites.HasValue;

        /// <summary>
        /// Gets and sets the property AssociateEntireAccount. 
        /// <para>
        /// A value that specifies whether the datashare is associated with the entire account.
        /// </para>
        /// </summary>
        public bool? AssociateEntireAccount { get; set; }

        /// <summary>
        /// Checks to see if the AssociateEntireAccount property is set.
        /// </summary>
        internal bool IsSetAssociateEntireAccount() => this.AssociateEntireAccount.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consumer namespace associated with the datashare.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ConsumerArn { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerArn property is set.
        /// </summary>
        internal bool IsSetConsumerArn() => this.ConsumerArn != null;

        /// <summary>
        /// Gets and sets the property ConsumerRegion. 
        /// <para>
        /// From a datashare consumer account, associates a datashare with all existing and future
        /// namespaces in the specified Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ConsumerRegion { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerRegion property is set.
        /// </summary>
        internal bool IsSetConsumerRegion() => this.ConsumerRegion != null;

        /// <summary>
        /// Gets and sets the property DataShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the datashare that the consumer is to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string DataShareArn { get; set; }

        /// <summary>
        /// Checks to see if the DataShareArn property is set.
        /// </summary>
        internal bool IsSetDataShareArn() => this.DataShareArn != null;
    }
}
