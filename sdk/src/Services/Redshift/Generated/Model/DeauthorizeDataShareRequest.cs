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
    /// Container for the parameters to the DeauthorizeDataShare operation.
    /// From a datashare producer account, removes authorization from the specified datashare.
    /// </summary>
    public partial class DeauthorizeDataShareRequest : AmazonRedshiftRequest
    {
        private string _consumerIdentifier;
        private string _dataShareArn;

        /// <summary>
        /// Gets and sets the property ConsumerIdentifier. 
        /// <para>
        /// The identifier of the data consumer that is to have authorization removed from the
        /// datashare. This identifier is an Amazon Web Services account ID or a keyword, such
        /// as ADX.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
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
        /// Gets and sets the property DataShareArn. 
        /// <para>
        /// The namespace Amazon Resource Name (ARN) of the datashare to remove authorization
        /// from.
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