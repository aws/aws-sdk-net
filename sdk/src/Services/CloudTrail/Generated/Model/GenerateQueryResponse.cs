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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the GenerateQuery operation.
    /// </summary>
    public partial class GenerateQueryResponse : AmazonWebServiceResponse
    {
        private string _eventDataStoreOwnerAccountId;
        private string _queryAlias;
        private string _queryStatement;

        /// <summary>
        /// Gets and sets the property EventDataStoreOwnerAccountId. 
        /// <para>
        ///  The account ID of the event data store owner. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=16)]
        public string EventDataStoreOwnerAccountId
        {
            get { return this._eventDataStoreOwnerAccountId; }
            set { this._eventDataStoreOwnerAccountId = value; }
        }

        // Check to see if EventDataStoreOwnerAccountId property is set
        internal bool IsSetEventDataStoreOwnerAccountId()
        {
            return this._eventDataStoreOwnerAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryAlias. 
        /// <para>
        ///  An alias that identifies the prompt. When you run the <c>StartQuery</c> operation,
        /// you can pass in either the <c>QueryAlias</c> or <c>QueryStatement</c> parameter. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string QueryAlias
        {
            get { return this._queryAlias; }
            set { this._queryAlias = value; }
        }

        // Check to see if QueryAlias property is set
        internal bool IsSetQueryAlias()
        {
            return this._queryAlias != null;
        }

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        ///  The SQL query statement generated from the prompt. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public string QueryStatement
        {
            get { return this._queryStatement; }
            set { this._queryStatement = value; }
        }

        // Check to see if QueryStatement property is set
        internal bool IsSetQueryStatement()
        {
            return this._queryStatement != null;
        }

    }
}