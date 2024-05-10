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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The API of the connector application that Amazon AppFlow uses to transfer your data.
    /// </summary>
    public partial class DataTransferApi
    {
        private string _name;
        private DataTransferApiType _type;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the connector application API.
        /// </para>
        /// </summary>
        [AWSProperty(Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// You can specify one of the following types:
        /// </para>
        ///  <dl> <dt>AUTOMATIC</dt> <dd> 
        /// <para>
        /// The default. Optimizes a flow for datasets that fluctuate in size from small to large.
        /// For each flow run, Amazon AppFlow chooses to use the SYNC or ASYNC API type based
        /// on the amount of data that the run transfers.
        /// </para>
        ///  </dd> <dt>SYNC</dt> <dd> 
        /// <para>
        /// A synchronous API. This type of API optimizes a flow for small to medium-sized datasets.
        /// </para>
        ///  </dd> <dt>ASYNC</dt> <dd> 
        /// <para>
        /// An asynchronous API. This type of API optimizes a flow for large datasets.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public DataTransferApiType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}