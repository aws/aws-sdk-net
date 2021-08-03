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
        private bool? _associateEntireAccount;
        private string _consumerArn;
        private string _dataShareArn;

        /// <summary>
        /// Gets and sets the property AssociateEntireAccount. 
        /// <para>
        /// A value that specifies whether the datashare is associated with the entire account.
        /// </para>
        /// </summary>
        public bool AssociateEntireAccount
        {
            get { return this._associateEntireAccount.GetValueOrDefault(); }
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
        /// The Amazon Resource Name (ARN) of the consumer that is associated with the datashare.
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
        /// Gets and sets the property DataShareArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the datashare that the consumer is to use with the
        /// account or the namespace.
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