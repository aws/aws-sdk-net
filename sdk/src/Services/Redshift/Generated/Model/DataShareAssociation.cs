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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private bool? _consumerAcceptedWrites;
        private string _consumerIdentifier;
        private string _consumerRegion;
        private DateTime? _createdDate;
        private bool? _producerAllowedWrites;
        private DataShareStatus _status;
        private DateTime? _statusChangeDate;

        /// <summary>
        /// Gets and sets the property ConsumerAcceptedWrites. 
        /// <para>
        /// Specifies whether write operations were allowed during data share association.
        /// </para>
        /// </summary>
        public bool? ConsumerAcceptedWrites
        {
            get { return this._consumerAcceptedWrites; }
            set { this._consumerAcceptedWrites = value; }
        }

        // Check to see if ConsumerAcceptedWrites property is set
        internal bool IsSetConsumerAcceptedWrites()
        {
            return this._consumerAcceptedWrites.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumerIdentifier. 
        /// <para>
        /// The name of the consumer accounts that have an association with a producer datashare.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ConsumerIdentifier
        {
            get { return this._consumerIdentifier; }
            set { this._consumerIdentifier = value; }
        }

        // Check to see if ConsumerIdentifier property is set
        internal bool IsSetConsumerIdentifier()
        {
            return this._consumerIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumerRegion. 
        /// <para>
        /// The Amazon Web Services Region of the consumer accounts that have an association with
        /// a producer datashare.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ConsumerRegion
        {
            get { return this._consumerRegion; }
            set { this._consumerRegion = value; }
        }

        // Check to see if ConsumerRegion property is set
        internal bool IsSetConsumerRegion()
        {
            return this._consumerRegion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The creation date of the datashare that is associated.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProducerAllowedWrites. 
        /// <para>
        /// Specifies whether write operations were allowed during data share authorization.
        /// </para>
        /// </summary>
        public bool? ProducerAllowedWrites
        {
            get { return this._producerAllowedWrites; }
            set { this._producerAllowedWrites = value; }
        }

        // Check to see if ProducerAllowedWrites property is set
        internal bool IsSetProducerAllowedWrites()
        {
            return this._producerAllowedWrites.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the datashare that is associated.
        /// </para>
        /// </summary>
        public DataShareStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusChangeDate. 
        /// <para>
        /// The status change data of the datashare that is associated.
        /// </para>
        /// </summary>
        public DateTime? StatusChangeDate
        {
            get { return this._statusChangeDate; }
            set { this._statusChangeDate = value; }
        }

        // Check to see if StatusChangeDate property is set
        internal bool IsSetStatusChangeDate()
        {
            return this._statusChangeDate.HasValue; 
        }

    }
}