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
    /// The association of a datashare from a producer account with a data consumer.
    /// </summary>
    public partial class DataShareAssociation
    {
        /// <summary>
        /// Gets and sets the property ConsumerAcceptedWrites. 
        /// <para>
        /// Specifies whether write operations were allowed during data share association.
        /// </para>
        /// </summary>
        public bool? ConsumerAcceptedWrites { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerAcceptedWrites property is set.
        /// </summary>
        internal bool IsSetConsumerAcceptedWrites() => this.ConsumerAcceptedWrites.HasValue;

        /// <summary>
        /// Gets and sets the property ConsumerIdentifier. 
        /// <para>
        /// The name of the consumer accounts that have an association with a producer datashare.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ConsumerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerIdentifier property is set.
        /// </summary>
        internal bool IsSetConsumerIdentifier() => this.ConsumerIdentifier != null;

        /// <summary>
        /// Gets and sets the property ConsumerRegion. 
        /// <para>
        /// The Amazon Web Services Region of the consumer accounts that have an association with
        /// a producer datashare.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ConsumerRegion { get; set; }

        /// <summary>
        /// Checks to see if the ConsumerRegion property is set.
        /// </summary>
        internal bool IsSetConsumerRegion() => this.ConsumerRegion != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The creation date of the datashare that is associated.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property ProducerAllowedWrites. 
        /// <para>
        /// Specifies whether write operations were allowed during data share authorization.
        /// </para>
        /// </summary>
        public bool? ProducerAllowedWrites { get; set; }

        /// <summary>
        /// Checks to see if the ProducerAllowedWrites property is set.
        /// </summary>
        internal bool IsSetProducerAllowedWrites() => this.ProducerAllowedWrites.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the datashare that is associated.
        /// </para>
        /// </summary>
        public DataShareStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusChangeDate. 
        /// <para>
        /// The status change data of the datashare that is associated.
        /// </para>
        /// </summary>
        public DateTime? StatusChangeDate { get; set; }

        /// <summary>
        /// Checks to see if the StatusChangeDate property is set.
        /// </summary>
        internal bool IsSetStatusChangeDate() => this.StatusChangeDate.HasValue;
    }
}
