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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// This operation creates a job.
    /// </summary>
    public partial class CreateJobRequest : AmazonDataExchangeRequest
    {
        private RequestDetails _details;
        private Type _type;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// The details for the CreateJob request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequestDetails Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of job to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
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