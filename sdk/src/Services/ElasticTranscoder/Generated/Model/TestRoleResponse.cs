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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// The <c>TestRoleResponse</c> structure.
    /// </summary>
    [Obsolete("This type is deprecated")]
    public partial class TestRoleResponse : AmazonWebServiceResponse
    {
        private List<string> _messages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _success;

        /// <summary>
        /// Gets and sets the property Messages. 
        /// <para>
        /// If the <c>Success</c> element contains <c>false</c>, this value is an array of one
        /// or more error messages that were generated during the test process.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Messages
        {
            get { return this._messages; }
            set { this._messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this._messages != null && (this._messages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Success. 
        /// <para>
        /// If the operation is successful, this value is <c>true</c>; otherwise, the value is
        /// <c>false</c>.
        /// </para>
        /// </summary>
        public string Success
        {
            get { return this._success; }
            set { this._success = value; }
        }

        // Check to see if Success property is set
        internal bool IsSetSuccess()
        {
            return this._success != null;
        }

    }
}