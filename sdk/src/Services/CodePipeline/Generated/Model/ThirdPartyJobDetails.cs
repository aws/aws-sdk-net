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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The details of a job sent in response to a <c>GetThirdPartyJobDetails</c> request.
    /// </summary>
    public partial class ThirdPartyJobDetails
    {
        private ThirdPartyJobData _data;
        private string _id;
        private string _nonce;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The data to be returned by the third party job worker.
        /// </para>
        /// </summary>
        public ThirdPartyJobData Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier used to identify the job details in CodePipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Nonce. 
        /// <para>
        /// A system-generated random number that CodePipeline uses to ensure that the job is
        /// being worked on by only one job worker. Use this number in an <a>AcknowledgeThirdPartyJob</a>
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string Nonce
        {
            get { return this._nonce; }
            set { this._nonce = value; }
        }

        // Check to see if Nonce property is set
        internal bool IsSetNonce()
        {
            return this._nonce != null;
        }

    }
}