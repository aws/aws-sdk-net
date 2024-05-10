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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the CancelLoaderJob operation.
    /// Cancels a specified load job. This is an HTTP <c>DELETE</c> request. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/load-api-reference-status.htm">Neptune
    /// Loader Get-Status API</a> for more information.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#cancelloaderjob">neptune-db:CancelLoaderJob</a>
    /// IAM action in that cluster..
    /// </para>
    /// </summary>
    public partial class CancelLoaderJobRequest : AmazonNeptunedataRequest
    {
        private string _loadId;

        /// <summary>
        /// Gets and sets the property LoadId. 
        /// <para>
        /// The ID of the load job to be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LoadId
        {
            get { return this._loadId; }
            set { this._loadId = value; }
        }

        // Check to see if LoadId property is set
        internal bool IsSetLoadId()
        {
            return this._loadId != null;
        }

    }
}