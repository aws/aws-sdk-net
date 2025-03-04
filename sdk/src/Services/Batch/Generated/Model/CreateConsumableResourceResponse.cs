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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// This is the response object from the CreateConsumableResource operation.
    /// </summary>
    public partial class CreateConsumableResourceResponse : AmazonWebServiceResponse
    {
        private string _consumableResourceArn;
        private string _consumableResourceName;

        /// <summary>
        /// Gets and sets the property ConsumableResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumableResourceArn
        {
            get { return this._consumableResourceArn; }
            set { this._consumableResourceArn = value; }
        }

        // Check to see if ConsumableResourceArn property is set
        internal bool IsSetConsumableResourceArn()
        {
            return this._consumableResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConsumableResourceName. 
        /// <para>
        /// The name of the consumable resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConsumableResourceName
        {
            get { return this._consumableResourceName; }
            set { this._consumableResourceName = value; }
        }

        // Check to see if ConsumableResourceName property is set
        internal bool IsSetConsumableResourceName()
        {
            return this._consumableResourceName != null;
        }

    }
}