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
    /// Container for the parameters to the AssociateDataShareConsumer operation.
    /// From a datashare consumer account, associates a datashare with the account (AssociateEntireAccount)
    /// or the specified namespace (ConsumerArn). If you make this association, the consumer
    /// can consume the datashare.
    /// </summary>
    public partial class AssociateDataShareConsumerRequest : AmazonRedshiftRequest
    {
        private bool? _allowWrites;
        private bool? _associateEntireAccount;
        private string _consumerArn;
        private string _consumerRegion;
        private string _dataShareArn;

        /// <summary>
        /// Gets and sets the property AllowWrites. 
        /// <para>
        /// If set to true, allows write operations for a datashare.
        /// </para>
        /// </summary>
        public bool? AllowWrites
        {
            get { return this._allowWrites; }
            set { this._allowWrites = value; }
        }

        // Check to see if AllowWrites property is set
        internal bool IsSetAllowWrites()
        {
            return this._allowWrites.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssociateEntireAccount. 
        /// <para>
        /// A value that specifies whether the datashare is associated with the entire account.
        /// </para>
        /// </summary>
        public bool? AssociateEntireAccount
        {
            get { return this._associateEntireAccount; }
            set { this._associateEntireAccount = value; }
        }

        // Check to see if AssociateEntireAccount property is set
        internal bool IsSetAssociateEntireAccount()
        {
            return this._associateEntireAccount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConsumerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consumer namespace associated with the datashare.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ConsumerArn
        {
            get { return this._consumerArn; }
            set { this._consumerArn = value; }
        }

        // Check to see if ConsumerArn property is set
        internal bool IsSetConsumerArn()
        {
            return this._consumerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumerRegion. 
        /// <para>
        /// From a datashare consumer account, associates a datashare with all existing and future
        /// namespaces in the specified Amazon Web Services Region.
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
        /// Gets and sets the property DataShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the datashare that the consumer is to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string DataShareArn
        {
            get { return this._dataShareArn; }
            set { this._dataShareArn = value; }
        }

        // Check to see if DataShareArn property is set
        internal bool IsSetDataShareArn()
        {
            return this._dataShareArn != null;
        }

    }
}